using Ionic.Zip;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace installer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public WebClient Client = new WebClient();
        public string path = Application.StartupPath + "\\PointBlank.zip";
        public string PathAdd;
        public bool stts;
        public Form1()
        {
            InitializeComponent();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(install_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(Install_zip_DownloadProgressCompleted);
        }

        private void Install_zip_DownloadProgressCompleted(object sender, AsyncCompletedEventArgs e)
        {
            PathAdd = PathInstall();
            if (PathAdd != string.Empty)
                unzip(PathAdd, path);
            else
                MessageBox.Show("o caminho especificado não pode ser vazio.", "Menu - Download", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void install_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lbl_Aguardando.Text = "Aguarde o jogo está sendo baixado...";
            BarTransfer(e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage);
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            #region Animation
            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(2);
                    ClientSize = new Size(493, 212); //134
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }).Start();
            #endregion
            stts = false;
            Client.DownloadFileAsync(new Uri("http://127.0.0.1/arquivos/clientes/PointBlank.zip"), path);
            Application.DoEvents();
        }
        public string PathInstall()
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog
            {
                Description = "Selecione um diretório especifico: ",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };
            if (fbd1.ShowDialog() == DialogResult.OK)
                return fbd1.SelectedPath;
            return "";
        }
        private void btn_unistall_Click(object sender, EventArgs e)
        {
            #region Animation
            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(2);
                    ClientSize = new Size(493, 212); //134
                    lbl_Aguardando.Text = "Tentando desinstalar arquivos.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }).Start();
            #endregion
            StreamReader streamReader = null;
            try
            {
                 streamReader = new StreamReader(@"C:\Temp\directory.txt");
                if (streamReader != null)
                {
                    string path = streamReader.ReadLine();
                    Directory.Delete(path);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Dispose();
                    streamReader.Close();
                }
            }

            Application.DoEvents();
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            #region Animation
            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(2);
                    ClientSize = new Size(493, 212); //134
                    lbl_Aguardando.Text = "Tentando reparar arquivos.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }).Start();
            #endregion
            Application.DoEvents();
        }
        public void BarTransfer(long received, long maximum, long Porcentagem)
        {
            lbl_transfer.Text = string.Concat(Porcentagem + " %");
            progressBar1.Width = (int)(received * 438 / maximum);
        }
        public void unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                stts = true;
                ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                try
                {
                    zipFile.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(unzip_ExtractProgressChanged);
                    foreach (ZipEntry zipEntry1 in zipFile)
                    {
                        string fileName = zipEntry1.FileName;
                        if (fileName.Contains("/"))
                        {
                            int num2 = fileName.LastIndexOf("/");
                            fileName = fileName.Substring(num2 + 1);
                        }
                        zipEntry1.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                finally
                {
                    if (zipFile != null)
                    {
                        zipFile.Dispose();
                    }
                    lbl_Aguardando.Text = "Instalação concluida!";
                    InstallerTemp();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public void InstallerTemp()
        {
            StreamWriter streamwrite = null;
            try
            {
                streamwrite = new StreamWriter(new FileStream(@"C:\Temp\directory.txt", FileMode.Create));
                streamwrite.WriteLine(PathAdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(streamwrite != null)
                {
                    streamwrite.Dispose();
                    streamwrite.Close();
                }
            }
        }
        private void unzip_ExtractProgressChanged(object sender, ExtractProgressEventArgs e)
        {
            Application.DoEvents();
            if (e.TotalBytesToTransfer > 0)
            {
                lbl_Aguardando.Text = e.ArchiveName;
                lbl_transfer.Text = string.Concat(Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer) + " %");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/wesley.vale.3192");
            MessageBox.Show("Aplicação desenvolvida para uso publico, todos os creditos ao desenvolvedor.", "Wesley Vale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
