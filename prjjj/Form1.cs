using System.Windows.Forms;
namespace prjjj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spouštím hru!");

            hra game = new hra(); 
            game.Show();

            this.Hide();
        }
    }
}
