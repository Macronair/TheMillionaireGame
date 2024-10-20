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
                cmd.Parameters.AddWithValue("@Level", 0);
                cmd.Parameters.AddWithValue("@Used", chkQuestionUsed.Checked);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            else if (level >= 1)
            {
                cmd = new SqlCommand("UPDATE questions SET Question = @Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Difficulty_Type = @DType,Level = @Level,LevelRange = @LevelRange,Used = @Used,Note = @Note WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                if (radDiffRange.Checked)
                {
                    cmd.Parameters.AddWithValue("@Level", "");
                    cmd.Parameters.AddWithValue("@DType", "Range");
                    switch (cmbQuestionRange.SelectedIndex)
                    {
                        case 0:
                            cmd.Parameters.AddWithValue("@LevelRange", "Lvl1");
                            break;
                        case 1:
                            cmd.Parameters.AddWithValue("@LevelRange", "Lvl2");
                            break;
                        case 2:
                            cmd.Parameters.AddWithValue("@LevelRange", "Lvl3");
                            break;
                        case 3:
                            cmd.Parameters.AddWithValue("@LevelRange", "Lvl4");
                            break;
                        default:
                            cmd.Parameters.AddWithValue("@LevelRange", "Lvl1");
                            break;
                    }
                }
                else if (radDiffSpecific.Checked)
                {
                    cmd.Parameters.AddWithValue("@Level", trkQuestionLevel.Value);
                    cmd.Parameters.AddWithValue("@DType", "Specific");
                    cmd.Parameters.AddWithValue("@LevelRange", "");
                }
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
            if (Convert.ToInt16(txtLevel.Text) > 0)
            {
                txtCorrect.Visible = true;
                pnlFFFAnswer.Visible = false;
                btnReset.Enabled = false;

                grpDifficulty.Visible = true;

                lblQuestionLevel.Text = trkQuestionLevel.Value.ToString();
            }
            else
            {
                txtCorrect.Visible = false;
                pnlFFFAnswer.Visible = true;
                btnReset.Enabled = true;

                grpDifficulty.Visible = false;
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

        private void radDiffSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiffSpecific.Checked)
            {
                trkQuestionLevel.Enabled = true;
                lblQuestionLevelText.Visible = true;
                lblQuestionLevel.Visible = true;

                cmbQuestionRange.Enabled = false;

                if (cmbQuestionRange.SelectedIndex == 0)
                {
                    if (!(trkQuestionLevel.Value >= 1 && trkQuestionLevel.Value <= 5))
                    {
                        trkQuestionLevel.Value = 1;
                        lblQuestionLevel.Text = "1";
                    }
                }
                else if (cmbQuestionRange.SelectedIndex == 1)
                {
                    if (!(trkQuestionLevel.Value >= 6 && trkQuestionLevel.Value <= 10))
                    {
                        trkQuestionLevel.Value = 6;
                        lblQuestionLevel.Text = "6";
                    }
                }
                else if (cmbQuestionRange.SelectedIndex == 2)
                {
                    if (!(trkQuestionLevel.Value >= 11 && trkQuestionLevel.Value <= 14))
                    {
                        trkQuestionLevel.Value = 11;
                        lblQuestionLevel.Text = "11";
                    }
                }
                else if (cmbQuestionRange.SelectedIndex == 3)
                {
                    if (trkQuestionLevel.Value != 15)
                    {
                        trkQuestionLevel.Value = 15;
                        lblQuestionLevel.Text = "15";
                    }
                }
            }
        }

        private void radDiffRange_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiffRange.Checked)
            {
                trkQuestionLevel.Enabled = false;
                lblQuestionLevelText.Visible = false;
                lblQuestionLevel.Visible = false;

                cmbQuestionRange.Enabled = true;

                if (trkQuestionLevel.Value >= 1 && trkQuestionLevel.Value <= 5)
                {
                    cmbQuestionRange.SelectedIndex = 0;
                }
                else if (trkQuestionLevel.Value >= 6 && trkQuestionLevel.Value <= 10)
                {
                    cmbQuestionRange.SelectedIndex = 1;
                }
                else if (trkQuestionLevel.Value >= 11 && trkQuestionLevel.Value <= 14)
                {
                    cmbQuestionRange.SelectedIndex = 2;
                }
                else if (trkQuestionLevel.Value == 15)
                {
                    cmbQuestionRange.SelectedIndex = 3;
                }
            }
        }

        private void trkQuestionLevel_Scroll(object sender, EventArgs e)
        {
            lblQuestionLevel.Text = trkQuestionLevel.Value.ToString();
        }
    }
}
