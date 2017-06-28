using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadByDaylight144hz
{
    public partial class Form1 : Form
    {
        static string userName = System.Environment.UserName;
        public string pathValue = @"C:\Users\" + userName + @"\AppData\Local\DeadByDaylight\Saved\Config\WindowsNoEditor\Engine.ini";
        Boolean pathSet = false;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(pathValue))
            {
                pathSet = true;
                pathDisplayBox.Text = "" + pathValue + " (Auto-detected)";
            }
            else
                pathDisplayBox.Text = "No path set";
        }

        private void changePathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (pathValue.Contains("Engine.ini"))
            {
                pathValue = openFileDialog1.FileName;
                pathDisplayBox.Text = pathValue;
                pathSet = true;
            }
            else
                pathDisplayBox.Text = "Wrong File Selected (Are you sure you picked Engine.ini?)";
        }

        private Boolean containsString(string @str)
        {
            if (File.ReadLines(pathValue).Any(line => line.Contains(@str)))
                return true;
            else
                return false;
        }

        private void writeLine(String @str)
        {
            using (StreamWriter w = File.AppendText(pathValue))
            {
                w.WriteLine(@str);
                w.Close();
            }
        }

        private void editFileButton1_Click(object sender, EventArgs e)
        {
            if (pathSet)
            {
                if (!containsString(@"[/script/engine.engine]"))
                {
                    writeLine("");
                    writeLine("");
                    writeLine(@"[/script/engine.engine]");
                }
                if (!containsString(@"bSmoothFrameRate=false")) 
                    writeLine(@"bSmoothFrameRate=false");       
                if (!containsString(@"MinSmoothedFrameRate=5"))                
                    writeLine(@"MinSmoothedFrameRate=5");
                if (!containsString(@"MaxSmoothedFrameRate=144"))               
                    writeLine(@"MaxSmoothedFrameRate=144");                
                if (!containsString(@"bUseVSync=false"))
                    writeLine(@"bUseVSync=false");
                System.Windows.Forms.MessageBox.Show("VSync has been disabled and 144hz has been applied.");
            }
            else
                MessageBox.Show("The path has not been set to an Engine.ini file.");
        }
    }
}
