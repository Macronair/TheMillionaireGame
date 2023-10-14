using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmQuestionImport : Form
    {

        private readonly QEditor _qe;
        int fff_answer = 0;

        public static SqlConnection olddb = new SqlConnection
                   (String.Format
                   (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", Application.StartupPath, @"old\dbMillionaire"));

        public static SqlConnection newdb = new SqlConnection
                   (String.Format
                   (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", Application.StartupPath, "dbMillionaire"));

        public frmQuestionImport(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        private void UpdateViews()
        {
            var old_select1 = "SELECT * FROM questions_level1";
            var dataAdapter1 = new SqlDataAdapter(old_select1, olddb);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);

            var old_select2 = "SELECT * FROM questions_level2";
            var dataAdapter2 = new SqlDataAdapter(old_select2, olddb);
            var commandBuilder2 = new SqlCommandBuilder(dataAdapter2);

            var old_select3 = "SELECT * FROM questions_level3";
            var dataAdapter3 = new SqlDataAdapter(old_select3, olddb);
            var commandBuilder3 = new SqlCommandBuilder(dataAdapter3);

            var old_select4 = "SELECT * FROM questions_level4";
            var dataAdapter4 = new SqlDataAdapter(old_select4, olddb);
            var commandBuilder4 = new SqlCommandBuilder(dataAdapter4);

            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dataAdapter2.Fill(ds1);
            dataAdapter3.Fill(ds1);
            dataAdapter4.Fill(ds1);
            dataOldDatabase.ReadOnly = true;
            dataOldDatabase.DataSource = ds1.Tables[0];

            var new_select = "SELECT * FROM questions";
            var dataAdapter0 = new SqlDataAdapter(new_select, newdb);
            var commandBuilder0 = new SqlCommandBuilder(dataAdapter0);
            var ds0 = new DataSet();
            dataAdapter0.Fill(ds0);
            dataNewDatabase.ReadOnly = true;
            dataNewDatabase.DataSource = ds0.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            QEditor.c.Open();
            string str = String.Format(@"INSERT INTO questions (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
            cmd = new SqlCommand(str, QEditor.c);
            cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@A", txtA.Text);
            cmd.Parameters.AddWithValue("@B", txtB.Text);
            cmd.Parameters.AddWithValue("@C", txtC.Text);
            cmd.Parameters.AddWithValue("@D", txtD.Text);
            cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
            cmd.Parameters.AddWithValue("@Level", lblQuestionLevel.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
            cmd.ExecuteNonQuery();
            QEditor.c.Close();

            olddb.Open();
            if(lblLevel.Text == "Lvl1")
            {
                str = String.Format(@"UPDATE questions_Level1 SET Used = True WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl2")
            {
                str = String.Format(@"UPDATE questions_Level2 SET Used = True WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl3")
            {
                str = String.Format(@"UPDATE questions_Level3 SET Used = True WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if(lblLevel.Text == "Lvl4")
            {
                str = String.Format(@"UPDATE questions_Level4 SET Used = True WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            olddb.Close();
            btnClear.PerformClick();
            UpdateViews();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtCorrect.Text = "";
            trkQuestionLevel.Value = 1;
            lblQuestionLevel.Text = "1";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _qe.UpdateDB();
        }

        private void frmQuestionAdd_Load(object sender, EventArgs e)
        {
            UpdateViews();
        }

        private void btnFFFA_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "A";
            btnFFFA.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFB_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "B";
            btnFFFB.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFC_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "C";
            btnFFFC.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFD_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "D";
            btnFFFD.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "*";
            btnFFFA.Enabled = true;
            btnFFFB.Enabled = true;
            btnFFFC.Enabled = true;
            btnFFFD.Enabled = true;
            fff_answer = 0;
            btnReset.Enabled = false;
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            lblQuestion.Text = txtQuestion.Text;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            lblA.Text = "A: " + txtA.Text;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            lblB.Text = "B: " + txtB.Text;
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            lblC.Text = "C: " + txtC.Text;
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            lblD.Text = "D: " + txtD.Text;
        }

        private void trkQuestionLevel_Scroll(object sender, EventArgs e)
        {
            lblQuestionLevel.Text = trkQuestionLevel.Value.ToString();
        }

        private void radFastestFinger_CheckedChanged(object sender, EventArgs e)
        {
            if(radFastestFinger.Checked)
            {
                txtCorrect.Visible = false;
                pnlFFFAnswer.Visible = true;

                trkQuestionLevel.Visible = false;
                lblQuestionLevel.Visible = false;
                lblQuestionLevelText.Visible = false;
            }
        }

        private void radRegularQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if(radRegularQuestion.Checked)
            {
                txtCorrect.Visible = true;
                pnlFFFAnswer.Visible = false;

                trkQuestionLevel.Visible = true;
                lblQuestionLevel.Visible = true;
                lblQuestionLevelText.Visible = true;
            }
        }

        private void dataOldDatabase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = this.dataOldDatabase.CurrentRow.Cells[0].Value.ToString();
            txtQuestion.Text = this.dataOldDatabase.CurrentRow.Cells[1].Value.ToString();
            txtA.Text = this.dataOldDatabase.CurrentRow.Cells[2].Value.ToString();
            txtB.Text = this.dataOldDatabase.CurrentRow.Cells[3].Value.ToString();
            txtC.Text = this.dataOldDatabase.CurrentRow.Cells[4].Value.ToString();
            txtD.Text = this.dataOldDatabase.CurrentRow.Cells[5].Value.ToString();
            txtCorrect.Text = this.dataOldDatabase.CurrentRow.Cells[6].Value.ToString();
            txtNote.Text = this.dataOldDatabase.CurrentRow.Cells[9].Value.ToString();
            lblLevel.Text = this.dataOldDatabase.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            QEditor.c.Open();
            string str = String.Format(@"INSERT INTO questions (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
            cmd = new SqlCommand(str, QEditor.c);
            cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@A", txtA.Text);
            cmd.Parameters.AddWithValue("@B", txtB.Text);
            cmd.Parameters.AddWithValue("@C", txtC.Text);
            cmd.Parameters.AddWithValue("@D", txtD.Text);
            cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
            cmd.Parameters.AddWithValue("@Level", lblQuestionLevel.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
            cmd.ExecuteNonQuery();
            QEditor.c.Close();

            olddb.Open();
            if (lblLevel.Text == "Lvl1")
            {
                str = String.Format(@"UPDATE questions_Level1 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl2")
            {
                str = String.Format(@"UPDATE questions_Level2 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl3")
            {
                str = String.Format(@"UPDATE questions_Level3 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl4")
            {
                str = String.Format(@"UPDATE questions_Level4 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            olddb.Close();
            btnClear.PerformClick();
            UpdateViews();

            Random rand = new Random();

            string randomtable = "questions_Level1";
            switch(rand.Next(1, 5))
            {
                case 1:
                    randomtable = "questions_Level1";
                    break;
                case 2:
                    randomtable = "questions_Level2";
                    break;
                case 3:
                    randomtable = "questions_Level3";
                    break;
                case 4:
                    randomtable = "questions_Level4";
                    break;
            }

            DataSet ds = new DataSet();
            SqlCommand sql = new SqlCommand($"SELECT TOP 1 * FROM {randomtable} WHERE Used = 'False' ORDER BY NEWID()", olddb);

            olddb.Open();
            SqlDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    txtQuestion.Text = reader.GetString(1);
                    txtA.Text = reader.GetString(2);
                    txtB.Text = reader.GetString(3);
                    txtC.Text = reader.GetString(4);
                    txtD.Text = reader.GetString(5);
                    txtCorrect.Text = reader.GetString(6);
                    lblID.Text = Convert.ToString(reader.GetInt32(0));
                    lblLevel.Text = reader.GetString(7);
                    try { txtNote.Text = reader.GetString(9); } catch { txtNote.Text = ""; }
                }
                reader.Close();
            }
            olddb.Close();
    }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string str;

            olddb.Open();
            if (lblLevel.Text == "Lvl1")
            {
                str = String.Format(@"UPDATE questions_Level1 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl2")
            {
                str = String.Format(@"UPDATE questions_Level2 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl3")
            {
                str = String.Format(@"UPDATE questions_Level3 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl4")
            {
                str = String.Format(@"UPDATE questions_Level4 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            olddb.Close();
            btnClear.PerformClick();
            UpdateViews();
        }

        private void btnSkipAndNext_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string str;

            olddb.Open();
            if (lblLevel.Text == "Lvl1")
            {
                str = String.Format(@"UPDATE questions_Level1 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl2")
            {
                str = String.Format(@"UPDATE questions_Level2 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl3")
            {
                str = String.Format(@"UPDATE questions_Level3 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            else if (lblLevel.Text == "Lvl4")
            {
                str = String.Format(@"UPDATE questions_Level4 SET Used = 'True' WHERE Id = @Id");
                cmd = new SqlCommand(str, olddb);
                cmd.Parameters.AddWithValue("@Id", lblID.Text);
                cmd.ExecuteNonQuery();
            }
            olddb.Close();
            btnClear.PerformClick();
            UpdateViews();

            Random rand = new Random();

            string randomtable = "questions_Level1";
            switch (rand.Next(1, 5))
            {
                case 1:
                    randomtable = "questions_Level1";
                    break;
                case 2:
                    randomtable = "questions_Level2";
                    break;
                case 3:
                    randomtable = "questions_Level3";
                    break;
                case 4:
                    randomtable = "questions_Level4";
                    break;
            }

            DataSet ds = new DataSet();
            SqlCommand sql = new SqlCommand($"SELECT TOP 1 * FROM {randomtable} WHERE Used = 'False' ORDER BY NEWID()", olddb);

            olddb.Open();
            SqlDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtQuestion.Text = reader.GetString(1);
                    txtA.Text = reader.GetString(2);
                    txtB.Text = reader.GetString(3);
                    txtC.Text = reader.GetString(4);
                    txtD.Text = reader.GetString(5);
                    txtCorrect.Text = reader.GetString(6);
                    lblID.Text = Convert.ToString(reader.GetInt32(0));
                    lblLevel.Text = reader.GetString(7);
                    try { txtNote.Text = reader.GetString(9); } catch { txtNote.Text = ""; }
                }
                reader.Close();
            }
            olddb.Close();
        }
    }
}
