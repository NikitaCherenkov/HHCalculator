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
using System.Net;
using System.Diagnostics;

namespace HHCalculator
{
    public partial class Form1 : Form
    {
        private static WebClient FirstWebClient = new WebClient();

        Form SettingsWindow = new Form2();
        public Form1(string[] args)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "hh калькулятор";
            btnSelect.Enabled = false;
            listBox1.Items.AddRange(ClassData.Forms.Keys.ToArray());
            if (!Directory.Exists(ClassData.ApplicationPath)) Directory.CreateDirectory(ClassData.ApplicationPath);
            if (!File.Exists(ClassData.FilePath)) ClassFunctions.CreateNewFile(ClassData.FilePath);
            ClassFunctions.ReadFile(ClassData.FilePath);
            ClassFunctions.CreateConvertVariables();
            UpdateCheck();
            //if (args.Length > 0)
            //{
            //    if (args[0] == "-firstrun") ;
            //}
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            string selectedItem = listBox1.SelectedItem.ToString();
            if (ClassData.Forms.ContainsKey(selectedItem))
            {
                Form c = ClassData.Forms[selectedItem];
                if (!c.Visible & c != null)
                {
                    c.Show();
                    c.Left = this.Left;
                    c.Top = this.Top;
                }
            }
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listBox1.SelectedIndex);
            if (index == -1)
                btnSelect.Enabled = false;
            else
                btnSelect.Enabled = true;
        }

        private void UpdateCheck()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                Stream FirstStream = FirstWebClient.OpenRead(ClassData.UpdateInfoLink);
                StreamReader FirstSR = new StreamReader(FirstStream);
                string[] InfoLines = new string[0];
                string TempLine = string.Empty;
                string NewVersion = string.Empty;
                while ((TempLine = FirstSR.ReadLine()) != null)
                {
                    Array.Resize(ref InfoLines, InfoLines.Length + 1);
                    InfoLines[InfoLines.Length - 1] = TempLine;
                    if (InfoLines[InfoLines.Length - 1].Contains("Version"))
                    {
                        FirstStream.Close();
                        NewVersion = InfoLines[InfoLines.Length - 1].Split('=')[1];
                        break;
                    }
                }
                FirstStream.Close();
                if (NewVersion == string.Empty) CouldntUpdate("Отсутствует упоминание версии");
                string[] LocalVersionArray = ClassData.Version.Split('.').ToArray();
                string[] NewVersionArray = NewVersion.Split('.').ToArray();
                bool NeedToUpdate = false;
                for (int i = 0; i < LocalVersionArray.Length; i++)
                {
                    if (Int32.Parse(LocalVersionArray[i]) < Int32.Parse(NewVersionArray[i]))
                    {
                        NeedToUpdate = true;
                        break;
                    }
                }
                if (NeedToUpdate)
                {
                    if (!File.Exists(ClassData.ApplicationPath + "\\" + "Updater.exe")) FirstWebClient.DownloadFile(ClassData.UpdaterLink, ClassData.ApplicationPath + "\\" + "Updater.exe");
                    ProcessStartInfo StartInfo = new ProcessStartInfo(ClassData.ApplicationPath + "\\" + "Updater.exe");
                    StartInfo.Arguments = ClassData.UpdateDownloadLink + " " + ClassData.UpdateInfoLink + " " + Application.ExecutablePath;
                    Process Updater = new Process();
                    Updater.StartInfo = StartInfo;
                    Updater.Start();
                    Environment.Exit(0);
                }
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.Message, "Не удалось произвести обновление");
                Environment.Exit(0);
            }
        }

        private static void CouldntUpdate(string msg)
        {
            MessageBox.Show(msg, "Не удалось произвести обновление");
            Environment.Exit(0);
        }
    }
}
