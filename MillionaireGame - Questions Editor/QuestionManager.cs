using Millionaire.Windows.Question_Editor;
using MillionaireGame.QEdit;
using MillionaireGame.QEdit.Managers;
using MillionaireGame.QEdit.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class QEditor : Form
    {
        public static SqlConnection c;
        public static SQLSettings sqlsettings = new SQLSettings();

        private readonly Dictionary<string, Color> _colorCache = new Dictionary<string, Color>();

        public QEditor()
        {
            InitializeComponent();
        }

        public void UpdateDB()
        {
            int firstRow1 = dtLevel1.FirstDisplayedScrollingRowIndex >= 0 ? dtLevel1.FirstDisplayedScrollingRowIndex : 0;
            int firstRow0 = dtLevel0.FirstDisplayedScrollingRowIndex >= 0 ? dtLevel0.FirstDisplayedScrollingRowIndex : 0;

            DataGridViewColumn sortedCol1 = dtLevel1.SortedColumn;
            ListSortDirection? sortDir1 = null;
            if (sortedCol1 != null)
                sortDir1 = dtLevel1.SortOrder == System.Windows.Forms.SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending;

            DataGridViewColumn sortedCol0 = dtLevel0.SortedColumn;
            ListSortDirection? sortDir0 = null;
            if (sortedCol0 != null)
                sortDir0 = dtLevel0.SortOrder == System.Windows.Forms.SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending;


            var select1 = @"SELECT 
    q.Id,
    q.QuestionCategory,
    c.CategoryName,
    c.CategoryColor,
    q.Question,
    q.A,
    q.B,
    q.C,
    q.D,
    q.CorrectAnswer,
    q.Difficulty_Type,
    q.Level,
    q.LevelRange,
    q.Note,
    q.Used
FROM questions q
LEFT JOIN settings_QuestionCategories c ON q.QuestionCategory = c.CategoryId";
            var dataAdapter1 = new SqlDataAdapter(select1, c);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dtLevel1.ReadOnly = true;
            dtLevel1.DataSource = ds1.Tables[0];
            dtLevel1.Columns["QuestionCategory"].Visible = false;
            dtLevel1.Columns["CategoryColor"].Visible = false;

            var select0 = "SELECT Id,Question,A,B,C,D,CorrectAnswer,Level,Note,Used FROM fff_questions";
            var dataAdapter0 = new SqlDataAdapter(select0, c);
            var commandBuilder0 = new SqlCommandBuilder(dataAdapter0);
            var ds0 = new DataSet();
            dataAdapter0.Fill(ds0);
            dtLevel0.ReadOnly = true;
            dtLevel0.DataSource = ds0.Tables[0];
            dtLevel0.Columns["Level"].Visible = false;

            bool used;

            foreach (DataGridViewRow row in dtLevel0.Rows)
            {
                used = Convert.ToBoolean(row.Cells[9].Value);

                if (used)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            // Restore the sorting state of the DataGridViews
            if (sortedCol1 != null && dtLevel1.Columns.Contains(sortedCol1.Name) && sortDir1.HasValue)
                dtLevel1.Sort(dtLevel1.Columns[sortedCol1.Name], sortDir1.Value);
            if (sortedCol0 != null && dtLevel0.Columns.Contains(sortedCol0.Name) && sortDir0.HasValue)
                dtLevel0.Sort(dtLevel0.Columns[sortedCol0.Name], sortDir0.Value);

            // Restore the first displayed scrolling row index
            if (dtLevel1.RowCount > 0 && firstRow1 < dtLevel1.RowCount)
                dtLevel1.FirstDisplayedScrollingRowIndex = firstRow1;
            if (dtLevel0.RowCount > 0 && firstRow0 < dtLevel0.RowCount)
                dtLevel0.FirstDisplayedScrollingRowIndex = firstRow0;
        }

        public void EditDB()
        {
            frmEditQuestion edit = new frmEditQuestion(this);

            // Regular Question
            if (Convert.ToInt16(stLevel.Text) == 1)
            {
                if (Convert.ToInt32(dtLevel1.CurrentRow.Cells[0].Value) == 0)
                {
                    MessageBox.Show("You must select a question first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    edit.txtId.Text = this.dtLevel1.CurrentRow.Cells[0].Value.ToString();
                    edit.txtQuestion.Text = this.dtLevel1.CurrentRow.Cells["Question"].Value.ToString();
                    edit.txtA.Text = this.dtLevel1.CurrentRow.Cells["A"].Value.ToString();
                    edit.txtB.Text = this.dtLevel1.CurrentRow.Cells["B"].Value.ToString();
                    edit.txtC.Text = this.dtLevel1.CurrentRow.Cells["C"].Value.ToString();
                    edit.txtD.Text = this.dtLevel1.CurrentRow.Cells["D"].Value.ToString();
                    edit.txtCorrect.Text = this.dtLevel1.CurrentRow.Cells["CorrectAnswer"].Value.ToString();
                    edit.txtLevel.Text = this.dtLevel1.CurrentRow.Cells["Level"].Value.ToString();

                    string sqlcmd = "SELECT CategoryName FROM settings_QuestionCategories WHERE CategoryId = @CategoryId";
                    SqlCommand cmd = new SqlCommand(sqlcmd, c);
                    cmd.Parameters.AddWithValue("@CategoryId", this.dtLevel1.CurrentRow.Cells["QuestionCategory"].Value);
                    c.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        edit.cmbCategory.Text = reader["CategoryName"].ToString();
                    }
                    else
                    {
                        edit.cmbCategory.Text = "";
                    }
                    reader.Close(); // Ensure this reader is closed

                    if (this.dtLevel1.CurrentRow.Cells["Difficulty_Type"].Value.ToString() == "Range")
                    {
                        edit.trkQuestionLevel.Value = 1;
                        edit.lblQuestionLevel.Text = "1";
                        edit.txtLevel.Text = "1";

                        edit.radDiffRange.Checked = true;
                        edit.radDiffSpecific.Checked = false;

                        edit.trkQuestionLevel.Enabled = false;
                        edit.lblQuestionLevelText.Visible = false;
                        edit.lblQuestionLevel.Visible = false;
                        if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl1")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 0;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl2")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 1;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl3")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 2;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl4")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 3;
                        }
                    }
                    else if (this.dtLevel1.CurrentRow.Cells["Difficulty_Type"].Value.ToString() == "Specific")
                    {
                        edit.trkQuestionLevel.Value = Convert.ToInt16(this.dtLevel1.CurrentRow.Cells["Level"].Value);
                        edit.lblQuestionLevel.Text = Convert.ToString(this.dtLevel1.CurrentRow.Cells["Level"].Value);

                        edit.cmbQuestionRange.Text = "";
                        edit.radDiffRange.Checked = false;
                        edit.radDiffSpecific.Checked = true;

                        edit.trkQuestionLevel.Enabled = true;
                        edit.lblQuestionLevelText.Visible = true;
                        edit.lblQuestionLevel.Visible = true;
                        if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl1")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 0;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl2")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 1;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl3")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 2;
                        }
                        else if (this.dtLevel1.CurrentRow.Cells["LevelRange"].Value.ToString() == "Lvl4")
                        {
                            edit.cmbQuestionRange.SelectedIndex = 3;
                        }
                        else
                        {
                            edit.cmbQuestionRange.SelectedIndex = 0;
                        }
                    }
                    edit.lblQuestionLevel.Text = this.dtLevel1.CurrentRow.Cells["Level"].Value.ToString();
                    edit.chkQuestionUsed.Checked = Convert.ToBoolean(this.dtLevel1.CurrentRow.Cells["Used"].Value);
                    edit.txtNote.Text = this.dtLevel1.CurrentRow.Cells["Note"].Value.ToString();

                    edit.lblQuestion.Text = this.dtLevel1.CurrentRow.Cells["Question"].Value.ToString();
                    edit.lblA.Text = "A: " + this.dtLevel1.CurrentRow.Cells["A"].Value.ToString();
                    edit.lblB.Text = "B: " + this.dtLevel1.CurrentRow.Cells["B"].Value.ToString();
                    edit.lblC.Text = "C: " + this.dtLevel1.CurrentRow.Cells["C"].Value.ToString();
                    edit.lblD.Text = "D: " + this.dtLevel1.CurrentRow.Cells["D"].Value.ToString();

                    // FIll the category combobox
                    edit.cmbCategory.Items.Clear();
                    string query = "SELECT CategoryId, CategoryName FROM settings_QuestionCategories ORDER BY CategoryName";
                    using (SqlCommand cmdCat = new SqlCommand(query, QEditor.c))
                    using (SqlDataReader readerCat = cmdCat.ExecuteReader())
                    {
                        var categories = new List<KeyValuePair<int, string>>();
                        categories.Add(new KeyValuePair<int, string>(0, "")); // Add default option
                        while (readerCat.Read())
                        {
                            int id = readerCat.GetInt32(0);
                            string name = readerCat.GetString(1);
                            categories.Add(new KeyValuePair<int, string>(id, name));
                        }
                        edit.cmbCategory.DataSource = categories;
                        edit.cmbCategory.DisplayMember = "Value"; // CategoryName
                        edit.cmbCategory.ValueMember = "Key";     // CategoryId
                        readerCat.Close();
                    }
                    c.Close();
                }
                edit.ShowDialog();
            }
            else if (Convert.ToInt16(stLevel.Text) == 0)
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
                    edit.chkQuestionUsed.Checked = Convert.ToBoolean(this.dtLevel0.CurrentRow.Cells[9].Value);
                    edit.txtNote.Text = this.dtLevel0.CurrentRow.Cells[8].Value.ToString();

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
            sqlsettings.LoadSettings();

            if (SQLSettings.SQLInfo.UseRemoteServer == true)
            {
                c = new SqlConnection
                    (String.Format("Server={0},{1};Database={2};User Id={3};Password={4}",
                    SQLSettings.SQLInfo.rSQL_Server, SQLSettings.SQLInfo.rSQL_Port, SQLSettings.SQLInfo.rSQL_Database,
                    SQLSettings.SQLInfo.rSQL_Login, SQLSettings.SQLInfo.rSQL_Password));
            }
            else
            {
                if (SQLSettings.SQLInfo.UseLocalDB)
                {
                    c = new SqlConnection(String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", Application.StartupPath, "dbMillionaire"));
                }
                else
                {
                    c = new SqlConnection(String.Format(@"Server=localhost\SQLEXPRESS;Database={0};Trusted_Connection=true", "dbMillionaire"));
                }

            }

            UpdateDB();

            // Sorting the DataGridViews
            if (dtLevel1.Columns.Count > 0)
                dtLevel1.Sort(dtLevel1.Columns[0], ListSortDirection.Ascending);
            if (dtLevel0.Columns.Count > 0)
                dtLevel0.Sort(dtLevel0.Columns[0], ListSortDirection.Ascending);

            #region Autosize columns
            dtLevel1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // ID
            dtLevel1.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // CategoryName
            dtLevel1.Columns["Question"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Question
            dtLevel1.Columns["A"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // A
            dtLevel1.Columns["B"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // B
            dtLevel1.Columns["C"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // C
            dtLevel1.Columns["D"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // D
            dtLevel1.Columns["CorrectAnswer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // CorrectAnswer
            dtLevel1.Columns["Difficulty_Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Difficulty_Type
            dtLevel1.Columns["Level"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Level
            dtLevel1.Columns["LevelRange"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // LevelRange
            dtLevel1.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Note
            dtLevel1.Columns["Used"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Used


            dtLevel0.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // ID
            dtLevel0.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Question
            dtLevel0.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // A
            dtLevel0.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // B
            dtLevel0.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // C
            dtLevel0.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // D
            dtLevel0.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // CorrectAnswer
            dtLevel0.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Level
            dtLevel0.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Note
            dtLevel0.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; // Used
            #endregion
            dtLevel1.CellFormatting += dtLevel1_CellFormatting;
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
                stLevel.Text = "1";
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
                stLevel.Text = "1";
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
                stLevel.Text = "0";
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
                stLevel.Text = "0";
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

        private void toCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuestionsExportCSV frmQuestionsExportCSV = new frmQuestionsExportCSV();
            frmQuestionsExportCSV.Show();
        }

        private void fromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuestionsImportCSV frmQuestionsImportCSV = new frmQuestionsImportCSV();
            frmQuestionsImportCSV.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryManager cat = new frmCategoryManager();
            cat.Show();
        }

        private void dtLevel1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dtLevel1.Rows[e.RowIndex];

            // CategoryName kleur
            if (dtLevel1.Columns[e.ColumnIndex].Name == "CategoryName")
            {
                var colorValue = row.Cells["CategoryColor"].Value?.ToString();
                if (!string.IsNullOrEmpty(colorValue) && colorValue.StartsWith("#"))
                {
                    try
                    {
                        Color color;
                        if (!_colorCache.TryGetValue(colorValue, out color))
                        {
                            color = ColorTranslator.FromHtml(colorValue);
                            _colorCache[colorValue] = color;
                        }
                        e.CellStyle.BackColor = color;
                        double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
                        e.CellStyle.ForeColor = luminance < 0.5 ? Color.White : Color.Black;
                    }
                    catch { }
                }
            }

            // At used questions: gray background at rows
            bool used = false;
            if (row.Cells["Used"].Value != null && bool.TryParse(row.Cells["Used"].Value.ToString(), out used) && used)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            // Difficulty_Type & Level/LevelRange colors
            string difficulty = row.Cells["Difficulty_Type"].Value?.ToString();
            if (dtLevel1.Columns[e.ColumnIndex].Name == "Difficulty_Type")
            {
                if (difficulty == "Range")
                    e.CellStyle.BackColor = Color.Plum;
                else if (difficulty == "Specific")
                    e.CellStyle.BackColor = Color.Aquamarine;
            }
            if (dtLevel1.Columns[e.ColumnIndex].Name == "Level")
            {
                if (difficulty == "Range")
                    e.CellStyle.ForeColor = Color.LightGray;
                else if (difficulty == "Specific")
                {
                    int l = 0;
                    int.TryParse(row.Cells["Level"].Value?.ToString(), out l);
                    if (l >= 1 && l <= 5) e.CellStyle.BackColor = Color.PaleGreen;
                    else if (l >= 6 && l <= 10) e.CellStyle.BackColor = Color.LightSkyBlue;
                    else if (l >= 11 && l <= 14) e.CellStyle.BackColor = Color.Gold;
                    else if (l == 15) e.CellStyle.BackColor = Color.LightCoral;
                }
            }
            if (dtLevel1.Columns[e.ColumnIndex].Name == "LevelRange")
            {
                if (difficulty == "Range")
                {
                    string range = row.Cells["LevelRange"].Value?.ToString();
                    if (range == "Lvl1") e.CellStyle.BackColor = Color.PaleGreen;
                    else if (range == "Lvl2") e.CellStyle.BackColor = Color.LightSkyBlue;
                    else if (range == "Lvl3") e.CellStyle.BackColor = Color.Gold;
                    else if (range == "Lvl4") e.CellStyle.BackColor = Color.LightCoral;
                }
                else if (difficulty == "Specific")
                {
                    e.CellStyle.ForeColor = Color.LightGray;
                }
            }

            // Overwrite selection colors for custom colored cells
            bool isCustomColoredCell =
                (dtLevel1.Columns[e.ColumnIndex].Name == "CategoryName") ||
                (dtLevel1.Columns[e.ColumnIndex].Name == "Difficulty_Type") ||
                (dtLevel1.Columns[e.ColumnIndex].Name == "Level") ||
                (dtLevel1.Columns[e.ColumnIndex].Name == "LevelRange");

            if (dtLevel1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected && isCustomColoredCell)
            {
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }
        }
    }
}
