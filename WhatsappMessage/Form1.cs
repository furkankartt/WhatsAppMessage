using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WhatsappMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void CMDCalistir(string fileName, string workingDirectory, string arguments, ProcessWindowStyle style)
        {
            var p2 = new Process
            {
                StartInfo =
                 {
                     FileName = fileName,
                     WorkingDirectory = workingDirectory,
                     Arguments = arguments,
                     WindowStyle = style
                 }
            }.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("%{TAB}");
            SendKeys.Send("{ENTER}");
        }

        private void sendWhatsApp(string number, string message)
        {
            try
            {
                if(number == "")
                {
                    MessageBox.Show("Numara giriniz..");
                    textBoxNo.Focus();
                }
                else if(number.Length <= 10)
                {
                    List<string> no = new List<string>();
                    number = "+90" + number;
                    number = number.Replace(" ", "");
                    no.Add(number);
                    no.Add("+905384452384");
                    no.Add("+905345448169");
                    no.Add("+905384452384");
                    no.Add("+905345448169");
                    no.Add("+905384452384");
                    no.Add("+905345448169");
                    for (int i = 0; i < no.Count; i++)
                    {
                        webBrowser1.Url = new Uri("https://api.whatsapp.com/send?phone=" + no[i] + "&text=" + message);
                        timer1.Start();
                        MessageBox.Show(no[i] + " numaralı kişiye mesajınız gönderildi.", "BİLGİ");
                        SendKeys.Send("%{TAB}");
                        SendKeys.Send("{ENTER}");
                        timer1.Stop();
                        #region SendKey

                        //foreach (var process in Process.GetProcessesByName("chrome"))
                        //{
                        //    process.Kill();
                        //}
                        //SendKeys.Send("{ENTER}");
                        //System.Threading.Thread.Sleep(5000);
                        //SendKeys.Send("%{F4}");
                        //System.Threading.Thread.Sleep(2000);
                        //SendKeys.Send("^{W}");
                        //System.Threading.Thread.Sleep(2000);
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.ToString());
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            sendWhatsApp(textBoxNo.Text, textBoxIcerik.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Değişkenler
            string userDesktop = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string userLocal = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            bool Kontrol = Directory.Exists(userLocal + "\\WhatsApp");
            string KopyalanacakDosyaYolu = @"\\192.168.100.17\Ses_Dosyalari";
            string KaydedilecekDosyaYolu = @userDesktop + "\\WhatsAppSetup.exe";
            string[] allFiles = Directory.GetFiles(KopyalanacakDosyaYolu, "WhatsAppSetup.exe", SearchOption.AllDirectories);
            #endregion

            if (Kontrol)
            {
                Process.Start(userLocal + "/WhatsApp/WhatsApp.exe");
            }
            else
            {
                foreach (var file in allFiles)
                {
                    FileInfo fi = new FileInfo(file);
                    fi.CopyTo(KaydedilecekDosyaYolu, true);
                }

                CMDCalistir("WhatsAppSetup.exe", userDesktop, null, ProcessWindowStyle.Normal);
                MessageBox.Show("Whatsapp yüklü değil kurulumu tamamlayınız.");
            }
            this.TopMost = true;
            webBrowser1.Hide();
        }

    }
}
