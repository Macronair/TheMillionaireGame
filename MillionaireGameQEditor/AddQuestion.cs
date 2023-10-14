using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmQuestionAdd : Form
    {

        private readonly QEditor _qe;
        int fff_answer = 0;

        public frmQuestionAdd(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string levelType;
            SqlCommand cmd;
            if(radRegularQuestion.Checked)
            {
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level1 (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
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
            }    
            else if (radFastestFinger.Checked)
            {
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level0 (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", lblAnswer.Text);
                cmd.Parameters.AddWithValue("@Level", 0);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else
            {
                Console.WriteLine("[{0}] Error while completing operation: Question type is invalid.", DateTime.Now);
                MessageBox.Show("Question type is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _qe.UpdateDB();
            this.Close();
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
        }

        private void frmQuestionAdd_Load(object sender, EventArgs e)
        {

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
    }
}
