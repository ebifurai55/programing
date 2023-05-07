namespace AmaterasuVer1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            MainMenu = new MenuStrip();
            setting = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            お気に入りToolStripMenuItem = new ToolStripMenuItem();
            お気に入りへ追加ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            GoButton = new Button();
            Stop = new Button();
            Reload = new Button();
            Fwd = new Button();
            Prev = new Button();
            UrlList = new ComboBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox1.SuspendLayout();
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(MainMenu);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(GoButton);
            groupBox1.Controls.Add(Stop);
            groupBox1.Controls.Add(Reload);
            groupBox1.Controls.Add(Fwd);
            groupBox1.Controls.Add(Prev);
            groupBox1.Controls.Add(UrlList);
            groupBox1.Controls.Add(webView21);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 17, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1024, 716);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "天照大御神";
            // 
            // MainMenu
            // 
            MainMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MainMenu.Dock = DockStyle.None;
            MainMenu.ImageScalingSize = new Size(20, 20);
            MainMenu.Items.AddRange(new ToolStripItem[] { setting });
            MainMenu.Location = new Point(981, -5);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(7, 3, 0, 3);
            MainMenu.Size = new Size(38, 30);
            MainMenu.TabIndex = 1;
            MainMenu.Text = "menuStrip1";
            MainMenu.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // setting
            // 
            setting.DisplayStyle = ToolStripItemDisplayStyle.Image;
            setting.DropDownItems.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem, お気に入りToolStripMenuItem, お気に入りへ追加ToolStripMenuItem });
            setting.Image = (Image)resources.GetObject("setting.Image");
            setting.Name = "setting";
            setting.Padding = new Padding(0, 0, 5, 0);
            setting.Size = new Size(29, 24);
            setting.Text = "toolStripMenuItem1";
            setting.Click += setting_Click;
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Image = (Image)resources.GetObject("設定ToolStripMenuItem.Image");
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(224, 26);
            設定ToolStripMenuItem.Text = "設定";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // お気に入りToolStripMenuItem
            // 
            お気に入りToolStripMenuItem.Image = (Image)resources.GetObject("お気に入りToolStripMenuItem.Image");
            お気に入りToolStripMenuItem.Name = "お気に入りToolStripMenuItem";
            お気に入りToolStripMenuItem.Size = new Size(224, 26);
            お気に入りToolStripMenuItem.Text = "お気に入り";
            // 
            // お気に入りへ追加ToolStripMenuItem
            // 
            お気に入りへ追加ToolStripMenuItem.Name = "お気に入りへ追加ToolStripMenuItem";
            お気に入りへ追加ToolStripMenuItem.Size = new Size(224, 26);
            お気に入りへ追加ToolStripMenuItem.Text = "お気に入りへ追加";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(950, -7);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // GoButton
            // 
            GoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GoButton.AutoSize = true;
            GoButton.Image = (Image)resources.GetObject("GoButton.Image");
            GoButton.Location = new Point(922, -7);
            GoButton.Margin = new Padding(3, 4, 3, 4);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(32, 32);
            GoButton.TabIndex = 6;
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // Stop
            // 
            Stop.BackgroundImage = (Image)resources.GetObject("Stop.BackgroundImage");
            Stop.Location = new Point(210, -3);
            Stop.Margin = new Padding(3, 4, 3, 4);
            Stop.Name = "Stop";
            Stop.Size = new Size(32, 32);
            Stop.TabIndex = 5;
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Reload
            // 
            Reload.BackgroundImage = (Image)resources.GetObject("Reload.BackgroundImage");
            Reload.Location = new Point(181, -3);
            Reload.Margin = new Padding(3, 4, 3, 4);
            Reload.Name = "Reload";
            Reload.Size = new Size(32, 32);
            Reload.TabIndex = 4;
            Reload.UseVisualStyleBackColor = true;
            Reload.Click += Reload_Click;
            // 
            // Fwd
            // 
            Fwd.BackgroundImage = (Image)resources.GetObject("Fwd.BackgroundImage");
            Fwd.Location = new Point(152, -3);
            Fwd.Margin = new Padding(3, 4, 3, 4);
            Fwd.Name = "Fwd";
            Fwd.Size = new Size(32, 32);
            Fwd.TabIndex = 3;
            Fwd.UseVisualStyleBackColor = true;
            Fwd.Click += Fwd_Click;
            // 
            // Prev
            // 
            Prev.BackgroundImage = (Image)resources.GetObject("Prev.BackgroundImage");
            Prev.Location = new Point(121, -3);
            Prev.Margin = new Padding(3, 4, 3, 4);
            Prev.Name = "Prev";
            Prev.Size = new Size(32, 32);
            Prev.TabIndex = 2;
            Prev.UseVisualStyleBackColor = true;
            Prev.Click += button1_Click;
            // 
            // UrlList
            // 
            UrlList.Anchor = AnchorStyles.Top;
            UrlList.AutoCompleteCustomSource.AddRange(new string[] { "https://", "http://" });
            UrlList.AutoCompleteMode = AutoCompleteMode.Suggest;
            UrlList.AutoCompleteSource = AutoCompleteSource.HistoryList;
            UrlList.FormatString = "https://";
            UrlList.FormattingEnabled = true;
            UrlList.Items.AddRange(new object[] { "https://www.yahoo.co.jp", "https://www.google.co.jp", "https://ebifurai55.work" });
            UrlList.Location = new Point(243, 0);
            UrlList.Margin = new Padding(3, 4, 3, 4);
            UrlList.Name = "UrlList";
            UrlList.Size = new Size(683, 28);
            UrlList.TabIndex = 1;
            UrlList.Text = "https://www.yahoo.co.jp";
            UrlList.SelectedIndexChanged += UrlList_SelectedIndexChanged;
            UrlList.KeyDown += UrlList_KeyDown;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 24);
            webView21.Margin = new Padding(3, 4, 3, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(1018, 688);
            webView21.Source = new Uri("https://www.yahoo.co.jp", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 716);
            Controls.Add(groupBox1);
            MainMenuStrip = MainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "アマテラスver1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button GoButton;
        private Button Stop;
        private Button Reload;
        private Button Fwd;
        private Button Prev;
        private ComboBox UrlList;
        private Button button1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem setting;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem お気に入りToolStripMenuItem;
        private ToolStripMenuItem お気に入りへ追加ToolStripMenuItem;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}