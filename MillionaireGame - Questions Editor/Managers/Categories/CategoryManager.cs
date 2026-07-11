using Millionaire;
using MillionaireGame.QEdit.Managers.Categories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MillionaireGame.QEdit.Managers
{
    public partial class frmCategoryManager : Form
    {
        public int selectedId = 0;

        public frmCategoryManager()
        {
            InitializeComponent();
            dtCategories.CellFormatting += dtCategories_CellFormatting;
        }

        private void frmCategoryManager_Load(object sender, EventArgs e)
        {
            UpdateDB();
        }

        public void UpdateDB()
        {
            var select1 = "SELECT * FROM settings_QuestionCategories";
            var dataAdapter1 = new SqlDataAdapter(select1, QEditor.c);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dtCategories.ReadOnly = true;
            dtCategories.DataSource = ds1.Tables[0];
            dtCategories.ClearSelection();
            selectedId = 0;
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAddEdit addCategoryForm = new frmCategoryAddEdit(this);
            addCategoryForm.ShowDialog();
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select the question you want to remove.", "Remove question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult remDiag = MessageBox.Show("Are you sure that you want to delete the selected category?", "Remove category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (remDiag == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM settings_QuestionCategories WHERE CategoryId='" + selectedId + "'", QEditor.c);
                    QEditor.c.Open();
                    cmd.ExecuteNonQuery();
                    QEditor.c.Close();
                }
                else if (remDiag == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            frmCategoryAddEdit edit = new frmCategoryAddEdit(this);
            if (Convert.ToInt32(dtCategories.CurrentRow.Cells[0].Value) == 0)
            {
                MessageBox.Show("You must select a category first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                edit.EditingId = Convert.ToInt16(this.dtCategories.CurrentRow.Cells[0].Value);
                edit.txtCategoryName.Text = this.dtCategories.CurrentRow.Cells[1].Value.ToString();
                edit.txtCategoryDescription.Text = this.dtCategories.CurrentRow.Cells[3].Value.ToString();
                edit.lblCategoryColor.Text = this.dtCategories.CurrentRow.Cells[2].Value.ToString();
                edit.pnlCategoryColor.BackColor = ColorTranslator.FromHtml(edit.lblCategoryColor.Text);
            }
            edit.ShowDialog();
        }

        private void dtCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtCategories.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtCategories.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtCategories.Rows[selectedrowindex];
                selectedId = Convert.ToInt16(selectedRow.Cells["CategoryId"].Value);
            }
        }

        private void dtCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsEdit.PerformClick();
        }

        private void dtCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtCategories.Columns[e.ColumnIndex].Name == "CategoryColor" && e.Value != null)
            {
                try
                {
                    string hex = e.Value.ToString();
                    Color color = ColorTranslator.FromHtml(hex);
                    var cell = dtCategories.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Normal background color
                    cell.Style.BackColor = color;
                    cell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    // Luminance calculation for text color
                    double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
                    Color textColor = luminance < 0.5 ? Color.White : Color.Black;
                    cell.Style.ForeColor = textColor;

                    // Override selection colors
                    cell.Style.SelectionBackColor = color;
                    cell.Style.SelectionForeColor = textColor;
                }
                catch
                {
                    // Invalid color format, do nothing
                }
            }
        }
    }
}
