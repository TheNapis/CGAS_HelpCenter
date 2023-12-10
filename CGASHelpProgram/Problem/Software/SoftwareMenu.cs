using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGASHelpProgram.Problem.Software;
using CGASHelpProgram.Properties;

namespace CGASHelpProgram.Problem.Software
{
    public partial class SoftwareMenu : UserControl
    {
        string option = null;
        public SoftwareMenu()
        {
            
            InitializeComponent();
        }

        private void Unlogiciel_Button_Click(object sender, EventArgs e)
        {
            option = "un";
            choix();
        }
        private void Pluslogiciel_Button_Click(object sender, EventArgs e)
        {
            option = "all";
            choix();
        }

        public string choix()
        {
            switch (option)
            {
                case "un":
                    return "un";
                    
                case "all":
                     return "all";
                    
                default:
                    return null;   
            }
            
        }


    }
}
