using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmEditQuestion : Form
    {

        int fff_answer = 0;

        private readonly QEditor _qe;

        public frmEditQuestion(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            QEditor.c.Open();
            if (txtLevel.Text == "Lvl1")
            {
                cmd = new SqlCommand("UPDATE questions_Level1 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl2")
            {
                cmd = new SqlCommand("UPDATE questions_Level2 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl3")
            {
                cmd = new SqlCommand("UPDATE questions_Level3 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl4")
            {
                cmd = new SqlCommand("UPDATE questions_Level4 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl0")
            {
                cmd = new SqlCommand("UPDATE questions_Level0 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", lblAnswer.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            QEditor.c.Close();
            this._qe.UpdateDB();
            this.Close();
            Console.WriteLine("[{0}] Database EDIT operation completed succesfully!", DateTime.Now);
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {
            if (txtLevel.Text == "Lvl0")
            {
                txtCorrect.Visible = false;
                pnlFFFAnswer.Visible = true;
            }
            else
            {
                txtCorrect.Visible = true;
                pnlFFFAnswer.Visible = false;
            }
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
    }
}
