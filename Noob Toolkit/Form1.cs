using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Noob_Toolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "APK|*.apk";
            openfile.Title = "Selecione seu apk ...";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                apkTextbox.Text = openfile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " install \"" + apkTextbox.Text + "\"";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog backupfolder = new FolderBrowserDialog();
            backupfolder.Description = "Choose backup location";
            if (backupfolder.ShowDialog() == DialogResult.OK)
            {
                backupTextbox.Text = backupfolder.SelectedPath + "\\backup.ab";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " backup -all -f \"" + apkTextbox.Text + "\"";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "ZIP files|*.zip";
            openfile.Title = "Open a file..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                sideloadTextbox.Text = openfile.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " sideload \"" + sideloadTextbox.Text + "\"";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " reboot";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " reboot recovery";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "tool//adb.exe";
            startInfo.Arguments = " reboot bootloader";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }
    }
}
