using Millionaire;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace MillionaireGameQEditor.Windows
{
    public partial class frmQuestionsImportCSV : Form
    {
        public frmQuestionsImportCSV()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var r_linenumber = 0;
            var fff_linenumber = 0;
            var errorcount = 0;

            var tres_regular = -1;
            var tres_fff = -1;

            QEditor.c.Open();

            if (chkRegularQuestions.Checked)
            {
                if(chkRegularSkipFirstLine.Checked)
                {
                    tres_regular = 0;
                }
                try
                {
                    using (StreamReader readRegularQ = new StreamReader(txtRegularQuestionsFileLoc.Text))
                    {
                        while (!readRegularQ.EndOfStream)
                        {
                            var line = readRegularQ.ReadLine();
                            if (r_linenumber != tres_regular)
                            {
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    if (values[i] != null)
                                    {
                                        // Vervang line breaks met een placeholder (bijv. [NEWLINE])
                                        values[i] = values[i].ToString()
                                                            .Replace("%[NL]%", Environment.NewLine);
                                    }
                                }

                                string str = String.Format(@"INSERT INTO questions (Question, A, B, C, D, CorrectAnswer, Level, Note, Difficulty_Type, LevelRange) 
VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note, @Difficulty_Type, @LevelRange)");
                                SqlCommand cmd = new SqlCommand(str, QEditor.c);
                                cmd.Parameters.AddWithValue("@Question", values[0]);
                                cmd.Parameters.AddWithValue("@A", values[1]);
                                cmd.Parameters.AddWithValue("@B", values[2]);
                                cmd.Parameters.AddWithValue("@C", values[3]);
                                cmd.Parameters.AddWithValue("@D", values[4]);
                                cmd.Parameters.AddWithValue("@Correct", values[5]);
                                if (values[7] != "0")
                                {
                                    cmd.Parameters.AddWithValue("@Level", values[7]);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@Level", 1);
                                }
                                cmd.Parameters.AddWithValue("@Note", values[9]);

                                cmd.Parameters.AddWithValue("@Difficulty_Type", values[6]);
                                //switch(values[6])
                                //{
                                //    case "1":
                                //        cmd.Parameters.AddWithValue("@Difficulty_Type", "Specific");
                                //        break;
                                //    case "2":
                                //        cmd.Parameters.AddWithValue("@Difficulty_Type", "Range");
                                //        break;
                                //    case "Specific":
                                //        cmd.Parameters.AddWithValue("@Difficulty_Type", "Specific");
                                //        break;
                                //    case "Range":
                                //        cmd.Parameters.AddWithValue("@Difficulty_Type", "Range");
                                //        break;
                                //    default:
                                //        cmd.Parameters.AddWithValue("@Difficulty_Type", "Specific");
                                //        break;
                                //}

                                cmd.Parameters.AddWithValue("@LevelRange", values[8]);
                                //switch(values[8])
                                //{
                                //    case "1":
                                //        cmd.Parameters.AddWithValue("@LevelRange", "Lvl1");
                                //        break;
                                //    case "2":
                                //        cmd.Parameters.AddWithValue("@LevelRange", "Lvl2");
                                //        break;
                                //    case "3":
                                //        cmd.Parameters.AddWithValue("@LevelRange", "Lvl3");
                                //        break;
                                //    case "4":
                                //        cmd.Parameters.AddWithValue("@LevelRange", "Lvl4");
                                //        break;
                                //    default:
                                //        cmd.Parameters.AddWithValue("@LevelRange", "");
                                //        break;
                                //}

                                cmd.ExecuteNonQuery();
                            }
                            r_linenumber++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorcount++;
                    MessageBox.Show("Something went wrong when importing the regular questions:" + Environment.NewLine + ex.Message, "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkFFFQuestions.Checked)
            {
                if (chkFFFSkipFirstLine.Checked)
                {
                    tres_fff = 0;
                }
                try
                {
                    using (StreamReader readFFFQ = new StreamReader(txtFFFQuestionsFileLoc.Text))
                    {
                        while (!readFFFQ.EndOfStream)
                        {
                            var line = readFFFQ.ReadLine();
                            if (fff_linenumber != tres_fff)
                            {
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    if (values[i] != null)
                                    {
                                        // Vervang line breaks met een placeholder (bijv. [NEWLINE])
                                        values[i] = values[i].ToString()
                                                            .Replace("%[NL]%", Environment.NewLine);
                                    }
                                }

                                string str = String.Format(@"INSERT INTO fff_questions (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
                                SqlCommand cmd = new SqlCommand(str, QEditor.c);
                                cmd.Parameters.AddWithValue("@Question", values[0]);
                                cmd.Parameters.AddWithValue("@A", values[1]);
                                cmd.Parameters.AddWithValue("@B", values[2]);
                                cmd.Parameters.AddWithValue("@C", values[3]);
                                cmd.Parameters.AddWithValue("@D", values[4]);
                                cmd.Parameters.AddWithValue("@Correct", values[5]);
                                cmd.Parameters.AddWithValue("@Level", "0");
                                cmd.Parameters.AddWithValue("@Note", values[6]);
                                cmd.ExecuteNonQuery();
                            }
                            fff_linenumber++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorcount++;
                    MessageBox.Show("Something went wrong when importing the FFF questions:" + Environment.NewLine + ex.Message, "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            QEditor.c.Close();

            if (r_linenumber > 1)
            {
                r_linenumber = r_linenumber - 1;
            }
            if (fff_linenumber > 1)
            {
                fff_linenumber = fff_linenumber - 1;
            }

            if(errorcount == 0)
            {
                MessageBox.Show(r_linenumber + " regular questions & " + fff_linenumber + " fastest finger questions succesfully imported.", "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QEditor q = new QEditor();
                q.UpdateDB();
                errorcount = 0;
                this.Close();
            }
            else
            {
                errorcount = 0;
                // Keep window open.
            }
        }

        private void frmQuestionsImportCSV_Load(object sender, EventArgs e)
        {
            txtFFFQuestionsFileLoc.Text = Application.StartupPath + @"\questions_export_fff.csv";
            txtRegularQuestionsFileLoc.Text = Application.StartupPath + @"\questions_export.csv";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegularQuestionsBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "CSV|*.csv";
                dlg.Title = "Choose directory and file name";
                DialogResult result = dlg.ShowDialog();
                {
                    if (result == DialogResult.OK)
                    {
                        txtRegularQuestionsFileLoc.Text = dlg.FileName;
                    }
                    else
                    {
                        // Nothing
                    }
                }
            }
        }

        private void btnFFFQuestionsBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "CSV|*.csv";
                dlg.Title = "Choose directory and file name";
                DialogResult result = dlg.ShowDialog();
                {
                    if (result == DialogResult.OK)
                    {
                        txtFFFQuestionsFileLoc.Text = dlg.FileName;
                    }
                    else
                    {
                        // Nothing
                    }
                }
            }
        }

        private void chkRegularQuestions_CheckedChanged(object sender, EventArgs e)
        {
            grpRegularQuestions.Enabled = chkRegularQuestions.Checked;
        }

        private void chkFFFQuestions_CheckedChanged(object sender, EventArgs e)
        {
            grpFFFQuestions.Enabled = chkFFFQuestions.Checked;
        }
    }
}
