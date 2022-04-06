using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace WhatsappMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DatabaseGet()
        {
            SqlConnection myConn = new SqlConnection();
            SqlCommand command = new SqlCommand();

            myConn.ConnectionString = "Data Source=U220\\SQLEXPRESS;Initial Catalog=WhatsAppDB;Integrated Security=True";
            myConn.Open();
            command.Connection = myConn;
            command.CommandText = ("SELECT Numara, Adi FROM BilgiTable");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNumara.DataSource = dt;
            myConn.Close();

            dgvNumara.Columns[0].Width = 150;
            dgvNumara.Columns[1].Width = 150;
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

        private void sendWhatsApp()
        {
            try
            {
                #region Extra Kod
                //foreach (var process in Process.GetProcessesByName("chrome"))
                //{
                //    process.Kill();
                //}
                //SendKeys.Send("{ENTER}");
                //SendKeys.Send("%{F4}");
                //SendKeys.Send("^{W}");
                #endregion

                foreach (DataGridViewRow draw in dgvNumara.SelectedRows)
                {
                    string no = draw.Cells[0].Value.ToString();
                    string message = textBoxIcerik.Text;
                    Process.Start("whatsapp://send?phone=" + no + "&text=" + message);
                    System.Threading.Thread.Sleep(1500);
                    SendKeys.Send("{ENTER}");
                    SendKeys.Send("%{TAB}");
                }

                MessageBox.Show("Mesajlarınız gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.ToString());
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            if(textBoxIcerik.Text=="")
            {
                MessageBox.Show("Gönderilecek mesajı yazınız.");
            }
            else if(dgvNumara.SelectedRows.Count==0)
            {
                MessageBox.Show("Gönderilecek kişi veya kişileri seçiniz.");
            }
            else
            {
                sendWhatsApp();
                textBoxIcerik.Text = "";
                dgvNumara.ClearSelection();
            }
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
                Process.Start("whatsapp://");
                DatabaseGet();
                dgvNumara.ClearSelection();
            }
            else
            {
                DatabaseGet();

                foreach (var file in allFiles)
                {
                    FileInfo fi = new FileInfo(file);
                    fi.CopyTo(KaydedilecekDosyaYolu, true);
                }

                CMDCalistir("WhatsAppSetup.exe", userDesktop, null, ProcessWindowStyle.Normal);
                MessageBox.Show("Whatsapp yüklü değil kurulumu tamamlayınız.");
            }
            this.TopMost = true;
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("WhatsApp"))
            {
                process.Kill();
            }
            this.Close();
        }
    }
}
