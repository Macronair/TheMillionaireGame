using Millionaire;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MillionaireGame.QEdit.Managers.Categories
{
    public partial class frmCategoryAddEdit : Form
    {
        private readonly frmCategoryManager _cm;
        public int EditingId;

        public frmCategoryAddEdit(frmCategoryManager c)
        {
            InitializeComponent();
            this._cm = c;
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    string hexColor = $"#{selectedColor.R:X2}{selectedColor.G:X2}{selectedColor.B:X2}"; // example "#FF0000"

                    lblCategoryColor.Text = hexColor;
                    pnlCategoryColor.BackColor = selectedColor;
                }
            }
        }

        private void btnClearColor_Click(object sender, EventArgs e)
        {
            lblCategoryColor.Text = "No Color";
            pnlCategoryColor.BackColor = Color.Transparent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please enter a name for the category.", "Add/Edit category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            QEditor.c.Open();

            string str;

            if (EditingId != 0)
            {
                // If EditingId is set, we are editing an existing category
                str = String.Format(@"UPDATE settings_QuestionCategories SET CategoryName = @CategoryName,CategoryColor = @CategoryColor, Description = @Description WHERE CategoryId = @CategoryId");
                SqlCommand cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@CategoryId", EditingId);
                cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                cmd.Parameters.AddWithValue("@CategoryColor", lblCategoryColor.Text);
                cmd.Parameters.AddWithValue("@Description", txtCategoryDescription.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when updating category in the database: " + Environment.NewLine + ex.Message, "Edit category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    QEditor.c.Close();
                }
            }
            else
            {
                // If EditingId is not set, we are adding a new category
                bool uniqueId = false;
                Random rnd = new Random();
                int id = 0000;

                while (uniqueId == false)
                {
                    // Generate a random ID between 1000 and 9999
                    // This is a simple way to ensure the ID is unique, but in a real application, you might want to use a more robust method
                    // such as checking against existing IDs in the database.
                    id = rnd.Next(1000, 10000);

                    // Check if the ID already exists in the database
                    str = String.Format($"SELECT * FROM settings_QuestionCategories WHERE CategoryId = {id}");

                    using (SqlCommand sqlCmd = new SqlCommand(str, QEditor.c))
                    {
                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                reader.Close();
                                uniqueId = true; // If no rows are returned, the ID is unique
                            }
                            else
                            {
                                // If the ID already exists, restart the loop and generate a new one.
                                reader.Close();
                            }
                        }
                    }
                }

                str = String.Format(@"INSERT INTO settings_QuestionCategories (CategoryId, CategoryName, CategoryColor, Description) 
VALUES(@CategoryId, @CategoryName, @CategoryColor, @Description)");
                SqlCommand cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@CategoryId", id);
                cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                cmd.Parameters.AddWithValue("@CategoryColor", lblCategoryColor.Text);
                cmd.Parameters.AddWithValue("@Description", txtCategoryDescription.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when adding category to the database: " + Environment.NewLine + ex.Message, "Add new category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    QEditor.c.Close();
                }
            }

            _cm.UpdateDB();
            this.Close();
        }

        private void frmCategoryAddEdit_Load(object sender, EventArgs e)
        {
            if (EditingId != 0)
            {
                lblCategoryId.Visible = true;
                lblCategoryId.Text = "Category ID: " + EditingId.ToString();
            }
        }
    }
}
