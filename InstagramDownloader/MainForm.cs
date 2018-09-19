using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net;
using System.Windows.Forms;

namespace InstagramDownloader
{
    public partial class MainForm : Form
    {
        private IWebDriver driver;

        public MainForm()
        {
            InitializeComponent();

            textURL.Text = "https://www.instagram.com/chacarolina/";
            textFolder.Text = @"C:\Users\Juldhais Hengkyawan\Downloads\ig";
        }   

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (textURL.Text == "")
                    throw new Exception("URL belum dimasukkan.");
                if (textFolder.Text == "")
                    throw new Exception("Pilih folder terlebih dahulu.");

                textURL.Enabled = false;
                textFolder.Enabled = false;
                buttonPilihFolder.Enabled = false;
                buttonDownload.Enabled = false;
                Text = "Sedang mendownload foto...";

                driver = new ChromeDriver(new ChromeOptions { LeaveBrowserRunning = false });
                driver.Url = textURL.Text;

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate();

                var listDiv = driver.FindElements(By.ClassName("KL4Bh"));
                int counter = 1;

                var webClient = new WebClient();
                
                foreach (var item in listDiv)
                {
                    var img = item.FindElement(By.TagName("img"));
                    var src = img.GetAttribute("src");
                    if (string.IsNullOrWhiteSpace(src)) continue;
                    
                    await webClient.DownloadFileTaskAsync(src, $"{textFolder.Text}\\{counter}.jpg");
                    counter++;
                    
                }

                this.Activate();
                MessageBox.Show("Foto berhasil didownload.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                driver.Close();
                driver.Dispose();

                textURL.Enabled = true;
                textFolder.Enabled = true;
                buttonPilihFolder.Enabled = true;
                buttonDownload.Enabled = true;
                buttonDownload.Text = "Download";
                Text = "Instagram Downloader";
            }
            
        }

        private void buttonPilihFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
                textFolder.Text = folderDialog.SelectedPath;
        }
    }
}
