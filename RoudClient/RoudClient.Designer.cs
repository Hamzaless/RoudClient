namespace RoudClient
{
    partial class RoudClient
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoudClient));
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.bar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.game_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ayarlarlabel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label_RoudClient = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gameStart = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.userlabel = new System.Windows.Forms.Label();
            this.pp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ramvalue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.namebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.login_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.rambox = new System.Windows.Forms.Label();
            this.Kanal = new System.Windows.Forms.Label();
            this.vercombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.y = new Guna.UI2.WinForms.Guna2TextBox();
            this.x = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.game_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayarlarlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gameStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).BeginInit();
            this.shadow.SuspendLayout();
            this.login_Panel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BorderColor = System.Drawing.Color.Transparent;
            this.btn_play.BorderRadius = 8;
            this.btn_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(900, 14);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.PressedColor = System.Drawing.Color.Green;
            this.btn_play.Size = new System.Drawing.Size(180, 33);
            this.btn_play.TabIndex = 5;
            this.btn_play.Text = "Oyna!";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // bar2
            // 
            this.bar2.BorderRadius = 8;
            this.bar2.Location = new System.Drawing.Point(685, 16);
            this.bar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar2.Name = "bar2";
            this.bar2.ProgressColor = System.Drawing.Color.Aqua;
            this.bar2.ProgressColor2 = System.Drawing.Color.Aqua;
            this.bar2.Size = new System.Drawing.Size(207, 31);
            this.bar2.TabIndex = 6;
            this.bar2.Text = "guna2ProgressBar1";
            this.bar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.bar2.Visible = false;
            // 
            // game_Panel
            // 
            this.game_Panel.BorderRadius = 20;
            this.game_Panel.Controls.Add(this.ayarlarlabel);
            this.game_Panel.Controls.Add(this.guna2PictureBox1);
            this.game_Panel.Controls.Add(this.guna2ControlBox2);
            this.game_Panel.Controls.Add(this.guna2ControlBox1);
            this.game_Panel.Controls.Add(this.label_RoudClient);
            this.game_Panel.Location = new System.Drawing.Point(14, 14);
            this.game_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_Panel.Name = "game_Panel";
            this.game_Panel.Size = new System.Drawing.Size(1064, 70);
            this.game_Panel.TabIndex = 10;
            this.game_Panel.Visible = false;
            // 
            // ayarlarlabel
            // 
            this.ayarlarlabel.Image = global::RoudClient.Properties.Resources.settingslogo;
            this.ayarlarlabel.ImageRotate = 0F;
            this.ayarlarlabel.Location = new System.Drawing.Point(907, 15);
            this.ayarlarlabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ayarlarlabel.Name = "ayarlarlabel";
            this.ayarlarlabel.Size = new System.Drawing.Size(40, 40);
            this.ayarlarlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayarlarlabel.TabIndex = 20;
            this.ayarlarlabel.TabStop = false;
            this.ayarlarlabel.Click += new System.EventHandler(this.ayarlarlabel_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 8);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 8;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(958, 22);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.Size = new System.Drawing.Size(40, 27);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 8;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1006, 21);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 27);
            this.guna2ControlBox1.TabIndex = 17;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label_RoudClient
            // 
            this.label_RoudClient.AutoSize = true;
            this.label_RoudClient.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_RoudClient.ForeColor = System.Drawing.Color.White;
            this.label_RoudClient.Location = new System.Drawing.Point(75, 17);
            this.label_RoudClient.Name = "label_RoudClient";
            this.label_RoudClient.Size = new System.Drawing.Size(322, 37);
            this.label_RoudClient.TabIndex = 12;
            this.label_RoudClient.Text = "Sunucu İsmi Launcher";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this.gameStart;
            // 
            // gameStart
            // 
            this.gameStart.BorderRadius = 20;
            this.gameStart.Controls.Add(this.userlabel);
            this.gameStart.Controls.Add(this.btn_play);
            this.gameStart.Controls.Add(this.bar2);
            this.gameStart.Controls.Add(this.pp);
            this.gameStart.Location = new System.Drawing.Point(-5, 495);
            this.gameStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(1102, 62);
            this.gameStart.TabIndex = 16;
            this.gameStart.Visible = false;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12.2F, System.Drawing.FontStyle.Bold);
            this.userlabel.ForeColor = System.Drawing.Color.White;
            this.userlabel.Location = new System.Drawing.Point(72, 16);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(144, 28);
            this.userlabel.TabIndex = 12;
            this.userlabel.Text = "Kullanıcı Adı";
            // 
            // pp
            // 
            this.pp.Image = ((System.Drawing.Image)(resources.GetObject("pp.Image")));
            this.pp.ImageRotate = 0F;
            this.pp.Location = new System.Drawing.Point(15, 5);
            this.pp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(45, 45);
            this.pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pp.TabIndex = 11;
            this.pp.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1101, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sürüm: Less Client 1.8.9";
            this.label4.Visible = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 50;
            this.guna2Elipse2.TargetControl = this.game_Panel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 50;
            this.guna2Elipse3.TargetControl = this.login_Panel;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.game_Panel;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 650;
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 12;
            this.guna2Elipse4.TargetControl = this.pp;
            // 
            // shadow
            // 
            this.shadow.BackColor = System.Drawing.Color.Transparent;
            this.shadow.Controls.Add(this.label6);
            this.shadow.EdgeWidth = 100;
            this.shadow.FillColor = System.Drawing.Color.White;
            this.shadow.Location = new System.Drawing.Point(-5, 450);
            this.shadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shadow.Name = "shadow";
            this.shadow.ShadowColor = System.Drawing.Color.Black;
            this.shadow.ShadowDepth = 120;
            this.shadow.ShadowShift = 1;
            this.shadow.Size = new System.Drawing.Size(1102, 46);
            this.shadow.TabIndex = 18;
            this.shadow.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(453, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sunucu Tanıtım Yazısı";
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 50;
            this.guna2Elipse5.TargetControl = this.settingsPanel;
            // 
            // ramvalue
            // 
            this.ramvalue.AutoSize = true;
            this.ramvalue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.ramvalue.ForeColor = System.Drawing.Color.White;
            this.ramvalue.Location = new System.Drawing.Point(849, 45);
            this.ramvalue.Name = "ramvalue";
            this.ramvalue.Size = new System.Drawing.Size(64, 27);
            this.ramvalue.TabIndex = 22;
            this.ramvalue.Text = "Ram:";
            this.ramvalue.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Roud Client - Giriş";
            // 
            // namebox
            // 
            this.namebox.BorderRadius = 8;
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.DefaultText = "";
            this.namebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.namebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.namebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.namebox.ForeColor = System.Drawing.Color.Black;
            this.namebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namebox.Location = new System.Drawing.Point(37, 124);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.namebox.PlaceholderText = "Kullanıcı Adı";
            this.namebox.SelectedText = "";
            this.namebox.Size = new System.Drawing.Size(284, 34);
            this.namebox.TabIndex = 20;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.namebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namebox_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderRadius = 8;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Login.Location = new System.Drawing.Point(85, 162);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PressedColor = System.Drawing.Color.Green;
            this.btn_Login.Size = new System.Drawing.Size(180, 46);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Giriş Yap";
            this.btn_Login.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // login_Panel
            // 
            this.login_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.login_Panel.BorderRadius = 10;
            this.login_Panel.Controls.Add(this.btn_Login);
            this.login_Panel.Controls.Add(this.namebox);
            this.login_Panel.Controls.Add(this.label5);
            this.login_Panel.Location = new System.Drawing.Point(367, 135);
            this.login_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(358, 282);
            this.login_Panel.TabIndex = 17;
            this.login_Panel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sunucu ismi Launcher - Ayarlar";
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2TrackBar1.LargeChange = 0;
            this.guna2TrackBar1.Location = new System.Drawing.Point(127, 74);
            this.guna2TrackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2TrackBar1.Maximum = 3072;
            this.guna2TrackBar1.Minimum = 512;
            this.guna2TrackBar1.MouseWheelBarPartitions = 1;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(267, 28);
            this.guna2TrackBar1.SmallChange = 0;
            this.guna2TrackBar1.TabIndex = 20;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.White;
            this.guna2TrackBar1.Value = 2048;
            this.guna2TrackBar1.ValueChanged += new System.EventHandler(this.guna2TrackBar1_ValueChanged);
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // rambox
            // 
            this.rambox.AutoSize = true;
            this.rambox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.rambox.ForeColor = System.Drawing.Color.White;
            this.rambox.Location = new System.Drawing.Point(120, 46);
            this.rambox.Name = "rambox";
            this.rambox.Size = new System.Drawing.Size(64, 27);
            this.rambox.TabIndex = 21;
            this.rambox.Text = "Ram:";
            // 
            // Kanal
            // 
            this.Kanal.AutoSize = true;
            this.Kanal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Kanal.ForeColor = System.Drawing.Color.White;
            this.Kanal.Location = new System.Drawing.Point(122, 106);
            this.Kanal.Name = "Kanal";
            this.Kanal.Size = new System.Drawing.Size(84, 27);
            this.Kanal.TabIndex = 23;
            this.Kanal.Text = "Sürüm:";
            // 
            // vercombo
            // 
            this.vercombo.BackColor = System.Drawing.Color.Transparent;
            this.vercombo.BorderRadius = 8;
            this.vercombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vercombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vercombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vercombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vercombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vercombo.ItemHeight = 30;
            this.vercombo.Items.AddRange(new object[] {
            "1.5.2",
            "1.7.10",
            "1.8.9",
            "1.12.2",
            "1.15.2",
            "1.16.5",
            "1.17.1",
            "1.18.2",
            "1.19"});
            this.vercombo.Location = new System.Drawing.Point(125, 134);
            this.vercombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vercombo.Name = "vercombo";
            this.vercombo.Size = new System.Drawing.Size(274, 36);
            this.vercombo.StartIndex = 2;
            this.vercombo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(122, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ekran:";
            // 
            // y
            // 
            this.y.BorderRadius = 8;
            this.y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.y.DefaultText = "480";
            this.y.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.y.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.y.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.y.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.y.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.y.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.y.ForeColor = System.Drawing.Color.Black;
            this.y.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.y.Location = new System.Drawing.Point(290, 212);
            this.y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y.MaxLength = 4;
            this.y.Name = "y";
            this.y.PasswordChar = '\0';
            this.y.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.y.PlaceholderText = "Kullanıcı Adı";
            this.y.SelectedText = "";
            this.y.Size = new System.Drawing.Size(102, 34);
            this.y.TabIndex = 26;
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y.TextChanged += new System.EventHandler(this.y_TextChanged);
            // 
            // x
            // 
            this.x.BorderRadius = 8;
            this.x.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.x.DefaultText = "640";
            this.x.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.x.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.x.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.x.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.x.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.x.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.x.ForeColor = System.Drawing.Color.Black;
            this.x.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.x.Location = new System.Drawing.Point(127, 212);
            this.x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x.MaxLength = 4;
            this.x.Name = "x";
            this.x.PasswordChar = '\0';
            this.x.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.x.PlaceholderText = "Kullanıcı Adı";
            this.x.SelectedText = "";
            this.x.Size = new System.Drawing.Size(110, 34);
            this.x.TabIndex = 27;
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(244, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "✖";
            this.label9.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(125, 258);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Red;
            this.guna2Button1.Size = new System.Drawing.Size(276, 46);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Çıkış Yap!";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "By Hamzaless";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderRadius = 50;
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.guna2Button1);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.x);
            this.settingsPanel.Controls.Add(this.y);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.vercombo);
            this.settingsPanel.Controls.Add(this.Kanal);
            this.settingsPanel.Controls.Add(this.rambox);
            this.settingsPanel.Controls.Add(this.guna2TrackBar1);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Location = new System.Drawing.Point(286, 106);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(521, 338);
            this.settingsPanel.TabIndex = 21;
            this.settingsPanel.Visible = false;
            // 
            // RoudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.game_Panel);
            this.Controls.Add(this.shadow);
            this.Controls.Add(this.ramvalue);
            this.Controls.Add(this.login_Panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoudClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoudClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.game_Panel.ResumeLayout(false);
            this.game_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayarlarlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gameStart.ResumeLayout(false);
            this.gameStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).EndInit();
            this.shadow.ResumeLayout(false);
            this.shadow.PerformLayout();
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar bar2;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private Guna.UI2.WinForms.Guna2GradientPanel game_Panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel gameStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userlabel;
        private Guna.UI2.WinForms.Guna2PictureBox pp;
        private System.Windows.Forms.Label label_RoudClient;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadow;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.Label ramvalue;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox ayarlarlabel;
        private Guna.UI2.WinForms.Guna2Panel login_Panel;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox namebox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel settingsPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox x;
        private Guna.UI2.WinForms.Guna2TextBox y;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox vercombo;
        private System.Windows.Forms.Label Kanal;
        private System.Windows.Forms.Label rambox;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label7;
    }
}

