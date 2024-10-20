using Millionaire;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MillionaireGameQEditor.Windows
{
    public partial class frmQuestionsExportCSV : Form
    {
        public frmQuestionsExportCSV()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            QEditor.c.Open();

            SqlCommand sqlRegularQ = new SqlCommand("SELECT * FROM questions", QEditor.c);
            SqlCommand sqlFFFQ = new SqlCommand("SELECT * FROM fff_questions", QEditor.c);

            if (chkRegularQuestions.Checked)
            {
                SqlDataReader readRegularQ = sqlRegularQ.ExecuteReader();
                StreamWriter writeRegularQ = new StreamWriter(txtRegularQuestionsFileLoc.Text);

                object[] outputRegularQ = new object[readRegularQ.FieldCount];

                for (int i = 0; i < readRegularQ.FieldCount; i++)
                    outputRegularQ[i] = readRegularQ.GetName(i);

                writeRegularQ.WriteLine(string.Join(";", outputRegularQ));

                while (readRegularQ.Read())
                {
                    readRegularQ.GetValues(outputRegularQ);

                    for (int i = 0; i < outputRegularQ.Length; i++)
                    {
                        if (outputRegularQ[i] != null)
                        {
                            // Vervang line breaks met een placeholder (bijv. [NEWLINE])
                            outputRegularQ[i] = outputRegularQ[i].ToString()
                                                .Replace("\r\n", "%[NL]%")
                                                .Replace("\n", "%[NL]%")
                                                .Replace("\r", "%[NL]%");
                        }
                    }

                    // Schrijf de aangepaste waarden naar het bestand
                    writeRegularQ.WriteLine(string.Join(";", outputRegularQ));
                }

                readRegularQ.Close();
                writeRegularQ.Close();
            }

            if (chkFFFQuestions.Checked)
            {
                SqlDataReader readFFFQ = sqlFFFQ.ExecuteReader();
                StreamWriter writeFFFQ = new StreamWriter(txtFFFQuestionsFileLoc.Text);

                object[] outputFFFQ = new object[readFFFQ.FieldCount];

                for (int i = 0; i < readFFFQ.FieldCount; i++)
                    outputFFFQ[i] = readFFFQ.GetName(i);

                writeFFFQ.WriteLine(string.Join(";", outputFFFQ));

                while (readFFFQ.Read())
                {
                    readFFFQ.GetValues(outputFFFQ);

                    for (int i = 0; i < outputFFFQ.Length; i++)
                    {
                        if (outputFFFQ[i] != null)
                        {
                            // Vervang line breaks met een placeholder (bijv. [NEWLINE])
                            outputFFFQ[i] = outputFFFQ[i].ToString()
                                                .Replace("\r\n", "%[NL]%")
                                                .Replace("\n", "%[NL]%")
                                                .Replace("\r", "%[NL]%");
                        }
                    }

                    // Schrijf de aangepaste waarden naar het bestand
                    writeFFFQ.WriteLine(string.Join(";", outputFFFQ));
                }

                readFFFQ.Close();
                writeFFFQ.Close();
            }

            QEditor.c.Close();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportQuestionsCSV_Load(object sender, EventArgs e)
        {
            txtFFFQuestionsFileLoc.Text = Application.StartupPath + @"\questions_export_fff.csv";
            txtRegularQuestionsFileLoc.Text = Application.StartupPath + @"\questions_export.csv";
        }

        private void btnRegularQuestionsBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
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
            using (SaveFileDialog dlg = new SaveFileDialog())
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
