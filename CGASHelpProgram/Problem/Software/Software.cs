using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGASHelpProgram.Problem.Software
{
    public partial class Software : Form
    {
        
        public Software()
        {
            InitializeComponent();
            timer1.Start();
            
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)

        {
            Time_label.Text = DateTime.Now.ToString("HH:mm:ss");
            Date_label.Text = DateTime.Now.ToShortDateString();
            


        }  // Date et heure

        private void Software_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Si un processus et en cours","ATTENTION !",MessageBoxButtons.YesNo);
            switch (window)
            {
                case DialogResult.No:
                    break; 
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
            
        }  //Contre les fermetures accidentelles en peine procédure

        
    }
}
