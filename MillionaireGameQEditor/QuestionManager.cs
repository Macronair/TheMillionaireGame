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
            var select1 = "SELECT * FROM questions_Level1";
            var dataAdapter1 = new SqlDataAdapter(select1, c);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dtLevel1.ReadOnly = true;
            dtLevel1.DataSource = ds1.Tables[0];

            var select2 = "SELECT * FROM questions_Level2";
            var dataAdapter2 = new SqlDataAdapter(select2, c);
            var commandBuilder2 = new SqlCommandBuilder(dataAdapter2);
            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            dtLevel2.ReadOnly = true;
            dtLevel2.DataSource = ds2.Tables[0];

            var select3 = "SELECT * FROM questions_Level3";
            var dataAdapter3 = new SqlDataAdapter(select3, c);
            var commandBuilder3 = new SqlCommandBuilder(dataAdapter3);
            var ds3 = new DataSet();
            dataAdapter3.Fill(ds3);
            dtLevel3.ReadOnly = true;
            dtLevel3.DataSource = ds3.Tables[0];

            var select4 = "SELECT * FROM questions_Level4";
            var dataAdapter4 = new SqlDataAdapter(select4, c);
            var commandBuilder4 = new SqlCommandBuilder(dataAdapter4);
            var ds4 = new DataSet();
            dataAdapter4.Fill(ds4);
            dtLevel4.ReadOnly = true;
            dtLevel4.DataSource = ds4.Tables[0];

            var select0 = "SELECT * FROM questions_Level0";
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

            if (stLevel.Text == "Lvl1")
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
                    edit.txtNote.Text = this.dtLevel1.CurrentRow.Cells[9].Value.ToString();
                }
            }
            else if (stLevel.Text == "Lvl2")
            {
                if (Convert.ToInt32(dtLevel2.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel2.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel2.CurrentRow.Cells[1].Value.ToString();
                    edit.txtA.Text = this.dtLevel2.CurrentRow.Cells[2].Value.ToString();
                    edit.txtB.Text = this.dtLevel2.CurrentRow.Cells[3].Value.ToString();
                    edit.txtC.Text = this.dtLevel2.CurrentRow.Cells[4].Value.ToString();
                    edit.txtD.Text = this.dtLevel2.CurrentRow.Cells[5].Value.ToString();
                    edit.txtCorrect.Text = this.dtLevel2.CurrentRow.Cells[6].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel2.CurrentRow.Cells[7].Value.ToString();
                    edit.txtNote.Text = this.dtLevel2.CurrentRow.Cells[9].Value.ToString();
                }

            }
            else if (stLevel.Text == "Lvl3")
            {
                if (Convert.ToInt32(dtLevel3.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel3.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel3.CurrentRow.Cells[1].Value.ToString();
                    edit.txtA.Text = this.dtLevel3.CurrentRow.Cells[2].Value.ToString();
                    edit.txtB.Text = this.dtLevel3.CurrentRow.Cells[3].Value.ToString();
                    edit.txtC.Text = this.dtLevel3.CurrentRow.Cells[4].Value.ToString();
                    edit.txtD.Text = this.dtLevel3.CurrentRow.Cells[5].Value.ToString();
                    edit.txtCorrect.Text = this.dtLevel3.CurrentRow.Cells[6].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel3.CurrentRow.Cells[7].Value.ToString();
                    edit.txtNote.Text = this.dtLevel3.CurrentRow.Cells[9].Value.ToString();
                }

            }
            else if (stLevel.Text == "Lvl4")
            {
                if (Convert.ToInt32(dtLevel4.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel4.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel4.CurrentRow.Cells[1].Value.ToString();
                    edit.txtA.Text = this.dtLevel4.CurrentRow.Cells[2].Value.ToString();
                    edit.txtB.Text = this.dtLevel4.CurrentRow.Cells[3].Value.ToString();
                    edit.txtC.Text = this.dtLevel4.CurrentRow.Cells[4].Value.ToString();
                    edit.txtD.Text = this.dtLevel4.CurrentRow.Cells[5].Value.ToString();
                    edit.txtCorrect.Text = this.dtLevel4.CurrentRow.Cells[6].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel4.CurrentRow.Cells[7].Value.ToString();
                    edit.txtNote.Text = this.dtLevel4.CurrentRow.Cells[9].Value.ToString();
                }
            }
            else if (stLevel.Text == "Lvl0")
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
                    edit.txtNote.Text = this.dtLevel0.CurrentRow.Cells[9].Value.ToString();
                }
            }
            edit.ShowDialog();
        }

        public void DeleteDB()
        {
            if(stLevel.Text == "Not selected")
            {
                MessageBox.Show("Please select the question you want to remove.", "Remove question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult remDiag = MessageBox.Show("Are you sure that you want to delete the selected question?", "Remove question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (remDiag == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(stlblId.Text);
                    if (stLevel.Text == "Lvl1")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions_Level1 WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (stLevel.Text == "Lvl2")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions_Level2 WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (stLevel.Text == "Lvl3")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions_Level3 WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (stLevel.Text == "Lvl4")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions_Level4 WHERE Id='" + id + "'", c);
                        c.Open();
                        cmd.ExecuteNonQuery();
                        c.Close();
                    }
                    else if (stLevel.Text == "Lvl0")
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM questions_Level0 WHERE Id='" + id + "'", c);
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

        public void ChangeLevelDB()
        {
            frmChangeLevel change = new frmChangeLevel(this);
            if (stLevel.Text == "Lvl1")
            {
                if (Convert.ToInt32(dtLevel1.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    change.lblOldLevel.Text = "Level 1";
                    change.cmbNewLevel.Text = "Level 1";
                    change.QuestionID = Convert.ToInt32(this.dtLevel1.CurrentRow.Cells[0].Value);
                    change.question = this.dtLevel1.CurrentRow.Cells[1].Value.ToString();
                    change.A = this.dtLevel1.CurrentRow.Cells[2].Value.ToString();
                    change.B = this.dtLevel1.CurrentRow.Cells[3].Value.ToString();
                    change.C = this.dtLevel1.CurrentRow.Cells[4].Value.ToString();
                    change.D = this.dtLevel1.CurrentRow.Cells[5].Value.ToString();
                    change.Correct = this.dtLevel1.CurrentRow.Cells[6].Value.ToString();
                    change.Note = this.dtLevel1.CurrentRow.Cells[9].Value.ToString();
                    change.ShowDialog();
                }
            }
            else if (stLevel.Text == "Lvl2")
            {
                if (Convert.ToInt32(dtLevel2.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    change.lblOldLevel.Text = "Level 2";
                    change.cmbNewLevel.Text = "Level 2";
                    change.QuestionID = Convert.ToInt32(this.dtLevel2.CurrentRow.Cells[0].Value);
                    change.question = this.dtLevel2.CurrentRow.Cells[1].Value.ToString();
                    change.A = this.dtLevel2.CurrentRow.Cells[2].Value.ToString();
                    change.B = this.dtLevel2.CurrentRow.Cells[3].Value.ToString();
                    change.C = this.dtLevel2.CurrentRow.Cells[4].Value.ToString();
                    change.D = this.dtLevel2.CurrentRow.Cells[5].Value.ToString();
                    change.Correct = this.dtLevel2.CurrentRow.Cells[6].Value.ToString();
                    change.Note = this.dtLevel2.CurrentRow.Cells[9].Value.ToString();
                    change.ShowDialog();
                }
            }
            else if (stLevel.Text == "Lvl3")
            {
                if (Convert.ToInt32(dtLevel3.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    change.lblOldLevel.Text = "Level 3";
                    change.cmbNewLevel.Text = "Level 3";
                    change.QuestionID = Convert.ToInt32(this.dtLevel3.CurrentRow.Cells[0].Value);
                    change.question = this.dtLevel3.CurrentRow.Cells[1].Value.ToString();
                    change.A = this.dtLevel3.CurrentRow.Cells[2].Value.ToString();
                    change.B = this.dtLevel3.CurrentRow.Cells[3].Value.ToString();
                    change.C = this.dtLevel3.CurrentRow.Cells[4].Value.ToString();
                    change.D = this.dtLevel3.CurrentRow.Cells[5].Value.ToString();
                    change.Correct = this.dtLevel3.CurrentRow.Cells[6].Value.ToString();
                    change.Note = this.dtLevel3.CurrentRow.Cells[9].Value.ToString();
                    change.ShowDialog();
                }

            }
            else if (stLevel.Text == "Lvl4")
            {
                if (Convert.ToInt32(dtLevel4.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    change.lblOldLevel.Text = "Level 4";
                    change.cmbNewLevel.Text = "Level 4";
                    change.QuestionID = Convert.ToInt32(this.dtLevel4.CurrentRow.Cells[0].Value);
                    change.question = this.dtLevel4.CurrentRow.Cells[1].Value.ToString();
                    change.A = this.dtLevel4.CurrentRow.Cells[2].Value.ToString();
                    change.B = this.dtLevel4.CurrentRow.Cells[3].Value.ToString();
                    change.C = this.dtLevel4.CurrentRow.Cells[4].Value.ToString();
                    change.D = this.dtLevel4.CurrentRow.Cells[5].Value.ToString();
                    change.Correct = this.dtLevel4.CurrentRow.Cells[6].Value.ToString();
                    change.Note = this.dtLevel4.CurrentRow.Cells[9].Value.ToString();
                    change.ShowDialog();
                }
            }
            else if (stLevel.Text == "Lvl0")
            {
                MessageBox.Show("You cannot change the question level for a Fastest Finger question.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            dtLevel2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtLevel2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel2.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtLevel3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtLevel3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel3.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtLevel4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtLevel4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtLevel4.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void dtLevel2_SelectionChanged(object sender, EventArgs e)
        {
            if (dtLevel2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel2.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel2.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void dtLevel2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLevel2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel2.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel2.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dtLevel3_SelectionChanged(object sender, EventArgs e)
        {
            if (dtLevel3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel3.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel3.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void dtLevel3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLevel3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel3.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel3.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dtLevel4_SelectionChanged(object sender, EventArgs e)
        {
            if (dtLevel4.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel4.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel4.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void dtLevel4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLevel4.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtLevel4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtLevel4.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                stlblId.Text = Convert.ToString(a);
                stLevel.Text = this.dtLevel4.CurrentRow.Cells[7].Value.ToString();
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
            SqlCommand cmd0 = new SqlCommand("UPDATE questions_Level0 SET Used='False'", c);
            SqlCommand cmd1 = new SqlCommand("UPDATE questions_Level1 SET Used='False'", c);
            SqlCommand cmd2 = new SqlCommand("UPDATE questions_Level2 SET Used='False'", c);
            SqlCommand cmd3 = new SqlCommand("UPDATE questions_Level3 SET Used='False'", c);
            SqlCommand cmd4 = new SqlCommand("UPDATE questions_Level4 SET Used='False'", c);
            try
            {
                c.Open();
                cmd0.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
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

        private void resetLevel1UsedQuestionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("UPDATE questions_Level1 SET Used='False'", c);
            try
            {
                c.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("All Level 1 questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void resetLevel2UsedQuestionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("UPDATE questions_Level2 SET Used='False'", c);
            try
            {
                c.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("All Level 2 questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void resetLevel3UsedQuestionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE questions_Level3 SET Used='False'", c);
            try
            {
                c.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("All Level 3 questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void resetLevel4UsedQuestionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("UPDATE questions_Level4 SET Used='False'", c);
            try
            {
                c.Open();
                cmd4.ExecuteNonQuery();
                MessageBox.Show("All Level 4 questions succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlCommand cmd0 = new SqlCommand("UPDATE questions_Level0 SET Used='False'", c);
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

        private void dtLevel2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDB();
        }

        private void dtLevel3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDB();
        }

        private void dtLevel4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDB();
        }

        #endregion

        private void tsChangeLevel_Click(object sender, EventArgs e)
        {
            ChangeLevelDB();
        }

        private void changeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLevelDB();
        }

        private void tbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            stLevel.Text = "Not selected";
            stlblId.Text = "0";
            dtLevel0.ClearSelection();
            dtLevel1.ClearSelection();
            dtLevel2.ClearSelection();
            dtLevel3.ClearSelection();
            dtLevel4.ClearSelection();
        }
    }
}
