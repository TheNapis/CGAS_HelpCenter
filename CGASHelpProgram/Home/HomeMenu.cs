using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGASHelpProgram.Home
{
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
            powerOptionMenu1.Visible = false;
            softwareMenu1.Visible = false;
        }

        
        

        private void PowerOptions_Button_Click(object sender, EventArgs e)
        {
            ProbHardware_Button.Visible = false;
            ProbOther_Button.Visible = false;
            ProbSoftware_Button.Visible = false;
            ProbSystem_Button.Visible = false;
            label1.Visible = false;
            CGASDocs_Button.Visible = false;
            PowerOptions_Button.Visible = false;
            powerOptionMenu1.Visible = true;
        }

        private void CGASDocs_Button_Click(object sender, EventArgs e)
        {
            // La documentation n'a pas encore été crée
            MessageBox.Show("La documentation n'est accesible.");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ProbHardware_Button.Visible = true;
            ProbOther_Button.Visible = true;
            ProbSoftware_Button.Visible = true;
            ProbSystem_Button.Visible = true;
            label1.Visible = true;
            CGASDocs_Button.Visible = true;
            PowerOptions_Button.Visible = true;
            powerOptionMenu1.Visible = false;
            softwareMenu1.Visible = false;


        } // Cache le menu d'alimentation et affiche les éléments du menu principal 

        private void ProbSoftware_Button_Click(object sender, EventArgs e)
        {
            ProbHardware_Button.Visible = false;
            ProbOther_Button.Visible = false;
            ProbSoftware_Button.Visible = false;
            ProbSystem_Button.Visible = false;
            label1.Visible = false;
            CGASDocs_Button.Visible = false;
            PowerOptions_Button.Visible = false;
            softwareMenu1.Visible = true;
        }
    }

        
    }
