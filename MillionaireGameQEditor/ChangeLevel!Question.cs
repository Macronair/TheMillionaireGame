using Millionaire;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MillionaireGameQEditor
{

    public partial class frmResetQuestions : Form
    {

        private readonly QEditor _qe;

        public frmResetQuestions(QEditor q)
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Close();
        }
    }
}
 