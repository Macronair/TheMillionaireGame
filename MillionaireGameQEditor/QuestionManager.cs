using Millionaire.Windows.Question_Editor;
using MillionaireGameQEditor;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class QEditor : Form
    {

        public static SqlConnection c = new SqlConnection
                    (String.Format
                    (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", Application.StartupPath, "dbMillionaire"));

        public QEditor()
        {
            InitializeComponent();
        }

        public void UpdateDB()
        {
            var select1 = "SELECT * FROM questions";
            var dataAdapter1 = new SqlDataAdapter(select1, c);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dtLevel1.ReadOnly = true;
            dtLevel1.DataSource = ds1.Tables[0];

            var select0 = "SELECT * FROM fff_questions";
            var dataAdapter0 = new SqlDataAdapter(select0, c);
            var commandBuilder0 = new SqlCommandBuilder(dataAdapter0);
            var ds0 = new DataSet();
            dataAdapter0.Fill(ds0);
            dtLevel0.ReadOnly = true;
            dtLevel0.DataSource = ds0.Tables[0];
        }

        public void EditDB()
        {
            frmEditQuestion edit = new frmEditQuestion(this);

            if (Convert.ToInt16(stLevel.Text) >= 1 & Convert.ToInt16(stLevel.Text) <= 15)
            {
                if (Convert.ToInt32(dtLevel1.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel1.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel1.CurrentRow.Cells[1].Value.ToString();
                    edit.txtA.Text = this.dtLevel1.CurrentRow.Cells[2].Value.ToString();
                    edit.txtB.Text = this.dtLevel1.CurrentRow.Cells[3].Value.ToString();
                    edit.txtC.Text = this.dtLevel1.CurrentRow.Cells[4].Value.ToString();
                    edit.txtD.Text = this.dtLevel1.CurrentRow.Cells[5].Value.ToString();
                    edit.txtCorrect.Text = this.dtLevel1.CurrentRow.Cells[6].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel1.CurrentRow.Cells[7].Value.ToString();
                    edit.trkQuestionLevel.Value = Convert.ToInt16(this.dtLevel1.CurrentRow.Cells[7].Value);
                    edit.lblQuestionLevel.Text = this.dtLevel1.CurrentRow.Cells[7].Value.ToString();
                    edit.chkQuestionUsed.Checked = Convert.ToBoolean(this.dtLevel1.CurrentRow.Cells[8].Value);
                    edit.txtNote.Text = this.dtLevel1.CurrentRow.Cells[9].Value.ToString();

                    edit.lblQuestion.Text = this.dtLevel1.CurrentRow.Cells[1].Value.ToString();
                    edit.lblA.Text = "A: " + this.dtLevel1.CurrentRow.Cells[2].Value.ToString();
                    edit.lblB.Text = "B: " + this.dtLevel1.CurrentRow.Cells[3].Value.ToString();
                    edit.lblC.Text = "C: " + this.dtLevel1.CurrentRow.Cells[4].Value.ToString();
                    edit.lblD.Text = "D: " + this.dtLevel1.CurrentRow.Cells[5].Value.ToString();
                }
                edit.ShowDialog();
            }
            else if (stLevel.Text == "0")
            {
                if (Convert.ToInt32(dtLevel0.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel0.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel0.CurrentRow.Cells[1].Value.ToString();
                    edit.txtA.Text = this.dtLevel0.CurrentRow.Cells[2].Value.ToString();
                    edit.txtB.Text = this.dtLevel0.CurrentRow.Cells[3].Value.ToString();
                    edit.txtC.Text = this.dtLevel0.CurrentRow.Cells[4].Value.ToString();
                    edit.txtD.Text = this.dtLevel0.CurrentRow.Cells[5].Value.ToString();
                    edit.lblAnswer.Text = this.dtLevel0.CurrentRow.Cells[6].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel0.CurrentRow.Cells[7].Value.ToString();
                    edit.lblQuestionLevel.Text = this.dtLevel0.CurrentRow.Cells[7].Value.ToString();
                    edit.chkQuestionUsed.Checked = Convert.ToBoolean(this.dtLevel0.CurrentRow.Cells[8].Value);
                    edit.txtNote.Text = this.dtLevel0.CurrentRow.Cells[9].Value.ToString();

                    edit.lblQuestion.Text = this.dtLevel0.CurrentRow.Cells[1].Value.ToString();
                    edit.lblA.Text = "A: " + this.dtLevel0.CurrentRow.Cells[2].Value.ToString();
                    edit.lblB.Text = "B: " + this.dtLevel0.CurrentRow.Cells[3].Value.ToString();
                    edit.lblC.Text = "C: " + this.dtLevel0.CurrentRow.Cells[4].Value.ToString();
                    edit.lblD.Text = "D: " + this.dtLevel0.CurrentRow.Cells[5].Value.ToString();
                }
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DeleteDB()
        {
            if (stLevel.Text == "Not selected")
            {
                MessageBox.Show("Please select the question you want to remove.", "Remove question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult remDiag = MessageBox.Show("Are you sure that you want to delete the selected question?", "Remove question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (remDiag == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(stlblId.Text);
                    if ((Convert.ToInt16(stLevel.Text) >= 1 & Convert.ToInt16(stLevel.Text) <= 15))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (stLevel.Text == "0")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM fff_questions WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                }
                else if (remDiag == DialogResult.No)
                {
                    return;
                }
                UpdateDB();
            }
        }

        private void QEditor_Load(object sender, EventArgs e)
        {
            UpdateDB();
            #region Autosize columns
            dtLevel0.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtLevel0.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel0.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtLevel1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtLevel1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            frmQuestionAdd add = new frmQuestionAdd(this);
            add.ShowDialog();
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            DeleteDB();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            if (stLevel.Text == "Not selected")
            {
                MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EditDB();
            }

        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        #region Selection Changed
        private void dtLevel1_SelectionChanged(object sender, EventArgs e)
        {
            if (dtLevel1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel1.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void dtLevel1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLevel1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel1.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dtLevel0_SelectionChanged(object sender, EventArgs e)
        {
            if (dtLevel0.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel0.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel0.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel0.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void dtLevel0_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLevel0.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel0.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel0.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel0.CurrentRow.Cells[7].Value.ToString();
            }
        }
        #endregion

        #region Questions Reset functions
        private void tsmenuActionsResetAllQuestions_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd0 = new SqlCommand("UPDATE questions SET Used='False'", c);
            try
            {
                c.Open();
                cmd0.ExecuteNonQuery();
                MessageBox.Show("All questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }
                UpdateDB();
            }
        }

        private void resetFastestFingerUsedQuestionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd0 = new SqlCommand("UPDATE fff_questions SET Used='False'", c);
            try
            {
                c.Open();
                cmd0.ExecuteNonQuery();
                MessageBox.Show("All Fastest Finger questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (c.State == ConnectionState.Open)
                {
                    c.Close();
                }
                UpdateDB();
            }
        }
        #endregion

        #region Double Clicks
        private void dtLevel1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDB();
        }

        private void dtLevel0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDB();
        }
        #endregion

        private void tbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            stLevel.Text = "Not selected";
            stlblId.Text = "Not selected";
            dtLevel0.ClearSelection();
            dtLevel1.ClearSelection();
        }

        private void fromOldDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuestionImport questionImport = new frmQuestionImport(this);
            questionImport.Show();
        }

        private void atLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var reset = new frmResetQuestions(this))
            {
                var result = reset.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd0 = new SqlCommand($"UPDATE questions SET Used='False' WHERE Level={reset.nmrLevel.Value}", c);
                    try
                    {
                        c.Open();
                        cmd0.ExecuteNonQuery();
                        MessageBox.Show($"Questions from level {reset.nmrLevel.Value} has been reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (c.State == ConnectionState.Open)
                        {
                            c.Close();
                        }
                        UpdateDB();
                    }
                }
            }
        }

        private void tsmenuQuestionCreate_Click(object sender, EventArgs e)
        {
            frmQuestionAdd add = new frmQuestionAdd(this);
            add.ShowDialog();
        }

        private void tsmenuQuestionEdit_Click(object sender, EventArgs e)
        {
            if (stLevel.Text == "Not selected")
            {
                MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EditDB();
            }
        }

        private void tsmenuQuestionRemove_Click(object sender, EventArgs e)
        {
            DeleteDB();
        }
    }
}
