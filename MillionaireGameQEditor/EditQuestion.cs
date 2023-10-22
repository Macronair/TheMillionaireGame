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
            int level = Convert.ToInt16(txtLevel.Text);

            SqlCommand cmd;
            QEditor.c.Open();
            if (level == 0)
            {
                cmd = new SqlCommand("UPDATE fff_questions SET Question = @Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Level = @Level,Used = @Used,Note = @Note WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", lblAnswer.Text);
                cmd.Parameters.AddWithValue("@Level", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Used", chkQuestionUsed.Checked);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (level >= 1)
            {
                cmd = new SqlCommand("UPDATE questions SET Question = @Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Level = @Level,Used = @Used,Note = @Note WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Level", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Used", chkQuestionUsed.Checked);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
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
            if (txtLevel.Text == "0")
            {
                txtCorrect.Visible = false;
                pnlFFFAnswer.Visible = true;
                btnReset.Enabled = true;

                trkQuestionLevel.Visible = false;
                lblQuestionLevel.Visible = false;
                lblQuestionLevelText.Visible = false;
            }
            else
            {
                txtCorrect.Visible = true;
                pnlFFFAnswer.Visible = false;

                trkQuestionLevel.Visible = true;
                lblQuestionLevel.Visible = true;
                lblQuestionLevelText.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "*";
            fff_answer = 0;
            btnFFFA.Enabled = true;
            btnFFFB.Enabled = true;
            btnFFFC.Enabled = true;
            btnFFFD.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFFFA_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "A";
            btnFFFA.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFB_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "B";
            btnFFFB.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFC_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "C";
            btnFFFC.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFD_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "D";
            btnFFFD.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
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
    }
}
