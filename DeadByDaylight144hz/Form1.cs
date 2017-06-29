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
        public string gamePathValue = null;
        Boolean pathSet = false;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(pathValue))
            {
                pathSet = true;
                gamePathValue = pathValue.Substring(0, pathValue.Length - 10) + "GameUserSettings.ini";
                pathDisplayBox.Text = "" + pathValue + " (Auto-detected)";

                File.SetAttributes(pathValue, File.GetAttributes(pathValue) & ~FileAttributes.ReadOnly); // Get Attributes, set read only off on Engine.ini
                File.SetAttributes(gamePathValue, File.GetAttributes(gamePathValue) & ~FileAttributes.ReadOnly); // Get Attributes, set read only off on GameUserSettings.ini
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
                gamePathValue = pathValue.Substring(0, pathValue.Length - 10) + "GameUserSettings.ini";
                pathDisplayBox.Text = pathValue;
                pathSet = true;

                File.SetAttributes(pathValue, File.GetAttributes(pathValue) & ~FileAttributes.ReadOnly); // Get Attributes, set read only off on Engine.ini
                File.SetAttributes(gamePathValue, File.GetAttributes(gamePathValue) & ~FileAttributes.ReadOnly); // Get Attributes, set read only off on GameUserSettings.ini
            }
            else
                pathDisplayBox.Text = "Wrong File Selected (Are you sure you picked Engine.ini?)";
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            if (arrLine[line_to_edit - 1].ToLower().Contains("vsync"))
                 arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
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
                lineChanger("bUseVSync=false", gamePathValue, 30); // Changes Vsync setting in Game User Settings

                var first8Lines = File.ReadLines(pathValue).Take(8).ToList(); // Grabs first 8 lines (require lines) in engine.ini, saves
                File.WriteAllText(pathValue, String.Empty); // Clears text file

                foreach(string curLine in first8Lines) // loops through and prints the require first 8 lines.    
                    writeLine(curLine);

                writeLine(""); // Blank Space
               
                writeLine(@"[/script/engine.engine]"); // Necessary script for changing hz.
                writeLine(@"bSmoothFrameRate=false");
                writeLine(@"SmoothedFrameRateRange=(LowerBound=(Type=Inclusive,Value=5.000000),UpperBound=(Type=Exclusive,Value=144.000000))");
                writeLine(@"bUseVSync=false");

                File.SetAttributes(pathValue, File.GetAttributes(pathValue) | FileAttributes.ReadOnly); // set Engine.ini to read-only again
                File.SetAttributes(gamePathValue, File.GetAttributes(gamePathValue) | FileAttributes.ReadOnly); // set GameUserSettings.ini to read-only again

                System.Windows.Forms.MessageBox.Show("VSync has been disabled and 144hz has been applied.");
            }
            else
                MessageBox.Show("The path has not been set to an Engine.ini file.");
        }
    }
}
