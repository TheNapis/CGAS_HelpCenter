using CGASHelpProgram.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CGASHelpProgram.PowerOptions
{
    public partial class PowerOptionMenu : UserControl
    {
        public PowerOptionMenu()
        {
            InitializeComponent();
        }

        private void ShutD_Button_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }// Shutdown the computer

        private void Reboot_Button_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");  // Restart the computer
        }// Restart the computer

        private void AdvOptions_Button_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /o /f /t 0");
        }// Go on WinRE

        private void SignOff_Button_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/l");
        }// Disconnect the actual
    }
}
