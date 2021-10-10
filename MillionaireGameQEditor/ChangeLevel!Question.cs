using Millionaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionaireGameQEditor
{

    public partial class frmChangeLevel : Form
    {

        private readonly QEditor _qe;

        public frmChangeLevel(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        // Stored question variables for moving question to the new level.
        public int QuestionID = 0;
        public string question = null;
        public string A = null;
        public string B = null;
        public string C = null;
        public string D = null;
        public string Correct = null;
        public string Note = null;

        private void frmChangeLevel_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string levelType;
            SqlCommand cmd;
            SqlCommand cmdRemove;

            if (cmbNewLevel.Text == "Level 1")
            {
                levelType = "Lvl1";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level1 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@A", A);
                cmd.Parameters.AddWithValue("@B", B);
                cmd.Parameters.AddWithValue("@C", B);
                cmd.Parameters.AddWithValue("@D", C);
                cmd.Parameters.AddWithValue("@Correct", Correct);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", Note);
                cmd.ExecuteNonQuery();
            }
            else if (cmbNewLevel.Text == "Level 2")
            {
                levelType = "Lvl2";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level2 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@A", A);
                cmd.Parameters.AddWithValue("@B", B);
                cmd.Parameters.AddWithValue("@C", B);
                cmd.Parameters.AddWithValue("@D", C);
                cmd.Parameters.AddWithValue("@Correct", Correct);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", Note);
                cmd.ExecuteNonQuery();
            }
            else if (cmbNewLevel.Text == "Level 3")
            {
                levelType = "Lvl3";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level3 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@A", A);
                cmd.Parameters.AddWithValue("@B", B);
                cmd.Parameters.AddWithValue("@C", B);
                cmd.Parameters.AddWithValue("@D", C);
                cmd.Parameters.AddWithValue("@Correct", Correct);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", Note);
                cmd.ExecuteNonQuery();
            }
            else if (cmbNewLevel.Text == "Level 4")
            {
                levelType = "Lvl4";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level4 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@A", A);
                cmd.Parameters.AddWithValue("@B", B);
                cmd.Parameters.AddWithValue("@C", B);
                cmd.Parameters.AddWithValue("@D", C);
                cmd.Parameters.AddWithValue("@Correct", Correct);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", Note);
                cmd.ExecuteNonQuery();
            }

            if(lblOldLevel.Text == "Level 1")
            {
                string strR = "DELETE FROM questions_Level1 WHERE Id = @Id";
                cmdRemove = new SqlCommand(strR, QEditor.c);
                cmdRemove.Parameters.AddWithValue("@Id", QuestionID);
                cmdRemove.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if(lblOldLevel.Text == "Level 2")
            {
                string strR = "DELETE FROM questions_Level2 WHERE Id = @Id";
                cmdRemove = new SqlCommand(strR, QEditor.c);
                cmdRemove.Parameters.AddWithValue("@Id", QuestionID);
                cmdRemove.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (lblOldLevel.Text == "Level 3")
            {
                string strR = "DELETE FROM questions_Level3 WHERE Id = @Id";
                cmdRemove = new SqlCommand(strR, QEditor.c);
                cmdRemove.Parameters.AddWithValue("@Id", QuestionID);
                cmdRemove.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (lblOldLevel.Text == "Level 4")
            {
                string strR = "DELETE FROM questions_Level4 WHERE Id = @Id";
                cmdRemove = new SqlCommand(strR, QEditor.c);
                cmdRemove.Parameters.AddWithValue("@Id", QuestionID);
                cmdRemove.ExecuteNonQuery();
                QEditor.c.Close();
            }

            _qe.UpdateDB();
            this.Close();
        }
    }
}
