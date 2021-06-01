namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configAppUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.containerControl3 = new System.Windows.Forms.ContainerControl();
            this.spinner = new System.Windows.Forms.PictureBox();
            this.goForward = new System.Windows.Forms.Button();
            this.goback = new System.Windows.Forms.Button();
            this.containerControl4 = new System.Windows.Forms.ContainerControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.containerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            this.containerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 32);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configAppUrlToolStripMenuItem});
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.containerControl3_Click);
            // 
            // configAppUrlToolStripMenuItem
            // 
            this.configAppUrlToolStripMenuItem.Name = "configAppUrlToolStripMenuItem";
            this.configAppUrlToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.configAppUrlToolStripMenuItem.Text = "Config App Url";
            this.configAppUrlToolStripMenuItem.Click += new System.EventHandler(this.appUrl_click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.onReturn);
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 34);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(800, 25);
            this.webView21.Source = new System.Uri("https://demo-odoo.acesy.nl/", System.UriKind.Absolute);
            this.webView21.TabIndex = 18;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // containerControl1
            // 
            this.containerControl1.Location = new System.Drawing.Point(455, 374);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(75, 10);
            this.containerControl1.TabIndex = 20;
            this.containerControl1.Text = "containerControl1";
            // 
            // containerControl3
            // 
            this.containerControl3.Controls.Add(this.spinner);
            this.containerControl3.Controls.Add(this.webView21);
            this.containerControl3.Controls.Add(this.goForward);
            this.containerControl3.Controls.Add(this.goback);
            this.containerControl3.Location = new System.Drawing.Point(0, 27);
            this.containerControl3.Name = "containerControl3";
            this.containerControl3.Size = new System.Drawing.Size(812, 145);
            this.containerControl3.TabIndex = 21;
            this.containerControl3.Text = "containerControl3";
            this.containerControl3.Visible = false;
            this.containerControl3.Click += new System.EventHandler(this.containerControl3_Click);
            // 
            // spinner
            // 
            this.spinner.Image = ((System.Drawing.Image)(resources.GetObject("spinner.Image")));
            this.spinner.Location = new System.Drawing.Point(516, 3);
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(25, 25);
            this.spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spinner.TabIndex = 4;
            this.spinner.TabStop = false;
            this.spinner.Visible = false;
            this.spinner.Click += new System.EventHandler(this.spinner_Click);
            // 
            // goForward
            // 
            this.goForward.Enabled = false;
            this.goForward.Image = global::WindowsFormsApp3.Properties.Resources.right;
            this.goForward.Location = new System.Drawing.Point(417, 0);
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(69, 26);
            this.goForward.TabIndex = 5;
            this.goForward.UseVisualStyleBackColor = true;
            this.goForward.Click += new System.EventHandler(this.onclick_next);
            // 
            // goback
            // 
            this.goback.Enabled = false;
            this.goback.Image = global::WindowsFormsApp3.Properties.Resources.left;
            this.goback.Location = new System.Drawing.Point(325, 0);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(77, 28);
            this.goback.TabIndex = 6;
            this.goback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.onclick_back);
            // 
            // containerControl4
            // 
            this.containerControl4.Controls.Add(this.pictureBox2);
            this.containerControl4.Controls.Add(this.button1);
            this.containerControl4.Controls.Add(this.pictureBox1);
            this.containerControl4.Location = new System.Drawing.Point(0, 178);
            this.containerControl4.Name = "containerControl4";
            this.containerControl4.Size = new System.Drawing.Size(788, 543);
            this.containerControl4.TabIndex = 22;
            this.containerControl4.Text = "containerControl4";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.pos1;
            this.pictureBox2.Location = new System.Drawing.Point(261, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 268);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(187, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open my ACESY POS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onOpenUrl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(270, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 733);
            this.Controls.Add(this.containerControl4);
            this.Controls.Add(this.containerControl3);
            this.Controls.Add(this.containerControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ACESY POS CLient V1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.containerControl3.ResumeLayout(false);
            this.containerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            this.containerControl4.ResumeLayout(false);
            this.containerControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configAppUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.PictureBox spinner;
        private System.Windows.Forms.Button goForward;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.ContainerControl containerControl1;
        private System.Windows.Forms.ContainerControl containerControl3;
        private System.Windows.Forms.ContainerControl containerControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

