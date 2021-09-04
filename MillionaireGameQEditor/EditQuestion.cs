using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmEditQuestion : Form
    {

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
                cmd = new SqlCommand("UPDATE questions_Level1 SET Question='" + txtQuestion.Text + "',A='" + txtA.Text + "',B='" + txtB.Text + "',C='" + txtC.Text + "',D='" + txtD.Text + "',CorrectAnswer='" + txtCorrect.Text + "',Type='" + txtLevel.Text + "' WHERE Id = '" + txtId.Text + "'", QEditor.c);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl2")
            {
                cmd = new SqlCommand("UPDATE questions_Level2 SET Question='" + txtQuestion.Text + "',A='" + txtA.Text + "',B='" + txtB.Text + "',C='" + txtC.Text + "',D='" + txtD.Text + "',CorrectAnswer='" + txtCorrect.Text + "',Type='" + txtLevel.Text + "' WHERE Id = '" + txtId.Text + "'", QEditor.c);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl3")
            {
                cmd = new SqlCommand("UPDATE questions_Level3 SET Question='" + txtQuestion.Text + "',A='" + txtA.Text + "',B='" + txtB.Text + "',C='" + txtC.Text + "',D='" + txtD.Text + "',CorrectAnswer='" + txtCorrect.Text + "',Type='" + txtLevel.Text + "' WHERE Id = '" + txtId.Text + "'", QEditor.c);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl4")
            {
                cmd = new SqlCommand("UPDATE questions_Level4 SET Question='" + txtQuestion.Text + "',A='" + txtA.Text + "',B='" + txtB.Text + "',C='" + txtC.Text + "',D='" + txtD.Text + "',CorrectAnswer='" + txtCorrect.Text + "',Type='" + txtLevel.Text + "' WHERE Id = '" + txtId.Text + "'", QEditor.c);
                cmd.ExecuteNonQuery();
            }
            QEditor.c.Close();
            this._qe.UpdateDB();
            this.Close();
            Console.WriteLine("[{0}] Database EDIT operation completed succesfully!", DateTime.Now);
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
