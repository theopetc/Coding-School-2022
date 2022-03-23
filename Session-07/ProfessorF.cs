using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class formProfessor : Form
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public enum Rank { Full, Associate, Assistant }//TODO: enum
        //public string[] courses { get; set; }

        public formProfessor()
        {
            InitializeComponent();
        }

        private void formProfessor_Load(object sender, EventArgs e)
        {
            Session_03.Professor p = new Session_03.Professor();
            p.Name = textEdit1.Text;

            textEdit1.Text = Name;
            textEdit2.Text = Age.ToString();
            //comboBoxEdit1.Text = 
        }
    }
}
