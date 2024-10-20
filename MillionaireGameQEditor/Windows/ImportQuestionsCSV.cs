using Millionaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            QEditor.c.Open();

            if(chkRegularQuestions.Checked)
            {
                using (StreamReader readRegularQ = new StreamReader(txtRegularQuestionsFileLoc.Text))
                {
                    while (!readRegularQ.EndOfStream)
                    {
                        var line = readRegularQ.ReadLine();
                        if (r_linenumber != 0)
                        {
                            var values = line.Split(';');

                            values[1] = values[1].ToString()
                                .Replace("%[NL]%", Environment.NewLine);

                            string str = String.Format(@"INSERT INTO questions (Question, A, B, C, D, CorrectAnswer, Level, Note, Difficulty_Type, LevelRange) 
VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note, @Difficulty_Type, @LevelRange)");
                            SqlCommand cmd = new SqlCommand(str, QEditor.c);
                            cmd.Parameters.AddWithValue("@Question", values[1]);
                            cmd.Parameters.AddWithValue("@A", values[2]);
                            cmd.Parameters.AddWithValue("@B", values[3]);
                            cmd.Parameters.AddWithValue("@C", values[4]);
                            cmd.Parameters.AddWithValue("@D", values[5]);
                            cmd.Parameters.AddWithValue("@Correct", values[6]);
                            cmd.Parameters.AddWithValue("@Level", values[7]);
                            cmd.Parameters.AddWithValue("@Note", values[8]);
                            cmd.Parameters.AddWithValue("@Difficulty_Type", values[9]);
                            cmd.Parameters.AddWithValue("@LevelRange", values[10]);
                            cmd.ExecuteNonQuery();
                        }
                        r_linenumber++;
                    }
                }
            }
            if(chkFFFQuestions.Checked)
            {
                using (StreamReader readFFFQ = new StreamReader(txtRegularQuestionsFileLoc.Text))
                {
                    while (!readFFFQ.EndOfStream)
                    {
                        var line = readFFFQ.ReadLine();
                        if (fff_linenumber != 0)
                        {
                            var values = line.Split(';');

                            values[1] = values[1].ToString()
                                .Replace("%[NL]%", Environment.NewLine);

                            string str = String.Format(@"INSERT INTO fff_questions (Question, A, B, C, D, CorrectAnswer, Level, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Level, @Note)");
                            SqlCommand cmd = new SqlCommand(str, QEditor.c);
                            cmd.Parameters.AddWithValue("@Question", values[1]);
                            cmd.Parameters.AddWithValue("@A", values[2]);
                            cmd.Parameters.AddWithValue("@B", values[3]);
                            cmd.Parameters.AddWithValue("@C", values[4]);
                            cmd.Parameters.AddWithValue("@D", values[5]);
                            cmd.Parameters.AddWithValue("@Correct", values[6]);
                            cmd.Parameters.AddWithValue("@Level", values[7]);
                            cmd.Parameters.AddWithValue("@Note", values[8]);
                            cmd.ExecuteNonQuery();
                        }
                        fff_linenumber++;
                    }
                }
            }

            QEditor.c.Close();
            MessageBox.Show(r_linenumber - 1 + " regular questions & " + fff_linenumber + " fastest finger questions succesfully imported.", "Import from CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
