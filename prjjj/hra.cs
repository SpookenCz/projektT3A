using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjjj
{
    public partial class hra : Form
    {
        private Form1 mainForm;

        public hra(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void hra_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Opravdu se chceš vrátit do hlavního menu?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vysledek == DialogResult.Yes)
            {
                mainForm.Show();
                this.Close();
            }
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            napoveda help = new napoveda();
            help.ShowDialog(); 
        }
    }
}
