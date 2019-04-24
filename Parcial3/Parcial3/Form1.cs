using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Utec") && (textBox2.Text == "Programacion1"))
            {
                for (int i = 0; i <= 24; i++)
                {
                    progressBar1.PerformStep();
                }
               
                    MDIParent1 mdi = new MDIParent1();
                    mdi.Show();
                    this.Show();
                    
                 
                
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
        }
    }
}
