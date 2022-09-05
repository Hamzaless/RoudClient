using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.IO;
using System.Net;
using System.Threading;
using MCServerStatus;
using MCServerStatus.Models;

namespace RoudClient
{
    public partial class RoudClient : Form
    {
        public RoudClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public string serverStats;


        console con = new console();
        

        public static string onay;
        public static string baslik = "Roud Client | 1.0.0";
        MSession session;
        public static string versiyon;

        private void path()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
              con.listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };


            foreach (var item in launcher.GetAllVersions())
            {
             //   vercombo.Items.Add(item.Name);
            }

        }

        private void Launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            launcher.FileChanged += (e) =>
            {
               
              con.listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };
            launcher.ProgressChanged += (s, e) =>
            {
                bar2.Value = e.ProgressPercentage;
            };

            var launchOption = new MLaunchOption
            {
                MaximumRamMb = guna2TrackBar1.Value,
                Session = MSession.GetOfflineSession(namebox.Text),
                ScreenWidth = Convert.ToInt32(x.Text),
                ScreenHeight = Convert.ToInt32(y.Text),

            };
            versiyon = vercombo.SelectedItem.ToString();
            var process = launcher.CreateProcess(versiyon, launchOption);

            process.Start();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game_Panel.Show();
            RPC();
            onay = "true";
            rambox.Text = "Ram: "+localSaves.Default.ram;
            ramvalue.Text = localSaves.Default.ram;
            guna2TrackBar1.Value = Convert.ToInt32(localSaves.Default.ram);
            /* Launcer By Hamzaless */
            if (localSaves.Default.username != "")
            {
                namebox.Text = localSaves.Default.username;
                btn_Login.PerformClick();
            }
            else
            {
                login_Panel.Show();
            }
            path();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            con.Show();
            ayarlarlabel.Enabled = false;
            settingsPanel.Visible = false;
            bar2.Visible = true;
            label4.Text = "Açılıyor...";
            btn_play.Enabled = false;
            Thread thread = new Thread(() => Launch());
            thread.IsBackground = true;
            thread.Start();

        }

        public void RoudLogOut()
        {
            settingsPanel.Hide();
            shadow.Hide();
            ayarlarlabel.Hide();
            
            localSaves.Default.username = "";
            localSaves.Default.Save();
            namebox.Clear();
            gameStart.Visible = false;
            login_Panel.Show(); 
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        void RPC()
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("926149800641040424", ref this.handlers, true, null);
            this.presence.details = "Launcher'da bekliyor";
            this.presence.state = "Syroex Craft";
            this.presence.largeImageKey = "syroex_pp";
            this.presence.largeImageText = "syroex_pp";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
              e.KeyChar == '€' || e.KeyChar == '₺' ||
              e.KeyChar == '¨' || e.KeyChar == 'æ' ||
              e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
               namebox.Text = namebox.Text.Replace("ö", "o");
                namebox.Text =  namebox.Text.Replace("ğ", "g");
                namebox.Text = namebox.Text.Replace("ü", "u");
                namebox.Text =  namebox.Text.Replace("ş", "s");
                namebox.Text =  namebox.Text.Replace("ç", "c");
                namebox.Text =   namebox.Text.Replace("İ", "I");
                namebox.Text =   namebox.Text.Replace("ı", "i");
            }
            catch
            {

            }
            if (namebox.Text != "")
            {
                game_Panel.Show();
                shadow.Show();
                ayarlarlabel.Show();
          
                localSaves.Default.username = namebox.Text;
                localSaves.Default.Save();
                userlabel.Text = namebox.Text;
                gameStart.Visible = true;
                login_Panel.Hide();
                try
                {
                    var request = WebRequest.Create("https://cravatar.eu/helmavatar/" + namebox.Text + "/190.png");

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pp.Image = Bitmap.FromStream(stream);
                    }
                }
                catch
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı minecraft isim kuralarına uygun değil veya intarnete bağlı değilsiniz lütfen konrol ediniz Hata Kodu: Cx1002 (Profil Fotorafı Yüklenemedi)", baslik);
                    pp.Image = null;
                }
            }
            else
            {
                string Hata = "Kullanıcı Adını boş bırakamazsın!";
                MessageBox.Show(Hata,baslik);
            } 
        }

        public void cikisyap()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            settingsPanel.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            settingsPanel.Hide();
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2TrackBar1_ValueChanged(object sender, EventArgs e)
        {
           rambox.Text = "Ram: "+guna2TrackBar1.Value.ToString();
            ramvalue.Text = guna2TrackBar1.Value.ToString();
            localSaves.Default.ram = ramvalue.Text;
           localSaves.Default.Save();
        }

        private void rambox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            RoudLogOut();
        }

        private void y_TextChanged(object sender, EventArgs e)
        {

        }
        public async Task server()
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            if (webclient.DownloadString("https://spanel.syroex.com/kontrol.txt").Contains("1"))
            {
                timer1.Stop();
                TopMost = true;
                MessageBox.Show("LAUNCHER HAMZALESS TARAFINDAN KULLANIM DIŞI EDİLMİŞTİR | Developer: Hamzaless#8267", "Devre Dışı! | Developer: Hamzaless#8267");
                Application.Exit();
            }
        }

        private void ayarlarlabel_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible == false)
            {
                settingsPanel.Show();
            }
            else
            {
                settingsPanel.Hide();
            }
        }
    }
}

// hamza ablasını(sevval) cok seviyor.