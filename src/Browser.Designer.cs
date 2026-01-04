namespace SpeedyTurtle
{
    partial class Browser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            navPanel = new Panel();
            moreInfoBtn = new Button();
            reloadBtn = new Button();
            goNextBtn = new Button();
            goBackBtn = new Button();
            addressBar = new TextBox();
            viewerPanel = new Panel();
            webViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            navPanel.SuspendLayout();
            viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewer).BeginInit();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(60, 60, 60);
            navPanel.Controls.Add(moreInfoBtn);
            navPanel.Controls.Add(reloadBtn);
            navPanel.Controls.Add(goNextBtn);
            navPanel.Controls.Add(goBackBtn);
            navPanel.Controls.Add(addressBar);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(800, 48);
            navPanel.TabIndex = 0;
            // 
            // moreInfoBtn
            // 
            moreInfoBtn.BackColor = Color.FromArgb(60, 60, 60);
            moreInfoBtn.Cursor = Cursors.Hand;
            moreInfoBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            moreInfoBtn.FlatAppearance.BorderSize = 0;
            moreInfoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            moreInfoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            moreInfoBtn.FlatStyle = FlatStyle.Flat;
            moreInfoBtn.ForeColor = Color.FromArgb(199, 199, 199);
            moreInfoBtn.Image = Properties.Resources.MoreInfoBtnImageIco;
            moreInfoBtn.Location = new Point(646, 8);
            moreInfoBtn.Name = "moreInfoBtn";
            moreInfoBtn.RightToLeft = RightToLeft.No;
            moreInfoBtn.Size = new Size(26, 26);
            moreInfoBtn.TabIndex = 4;
            moreInfoBtn.UseVisualStyleBackColor = false;
            moreInfoBtn.Click += moreInfoBtn_Click;
            // 
            // reloadBtn
            // 
            reloadBtn.BackColor = Color.FromArgb(60, 60, 60);
            reloadBtn.Cursor = Cursors.Hand;
            reloadBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            reloadBtn.FlatAppearance.BorderSize = 0;
            reloadBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            reloadBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            reloadBtn.FlatStyle = FlatStyle.Flat;
            reloadBtn.ForeColor = Color.FromArgb(199, 199, 199);
            reloadBtn.Image = Properties.Resources.reloadBtnImageIco;
            reloadBtn.Location = new Point(107, 8);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(26, 26);
            reloadBtn.TabIndex = 3;
            reloadBtn.UseVisualStyleBackColor = false;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // goNextBtn
            // 
            goNextBtn.BackColor = Color.FromArgb(60, 60, 60);
            goNextBtn.Cursor = Cursors.Hand;
            goNextBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            goNextBtn.FlatAppearance.BorderSize = 0;
            goNextBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            goNextBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            goNextBtn.FlatStyle = FlatStyle.Flat;
            goNextBtn.ForeColor = Color.FromArgb(199, 199, 199);
            goNextBtn.Image = Properties.Resources.goNextBtnImageIco;
            goNextBtn.ImageAlign = ContentAlignment.TopCenter;
            goNextBtn.Location = new Point(66, 8);
            goNextBtn.Name = "goNextBtn";
            goNextBtn.Size = new Size(26, 26);
            goNextBtn.TabIndex = 2;
            goNextBtn.UseVisualStyleBackColor = false;
            goNextBtn.Click += goNextBtn_Click;
            // 
            // goBackBtn
            // 
            goBackBtn.BackColor = Color.FromArgb(60, 60, 60);
            goBackBtn.Cursor = Cursors.Hand;
            goBackBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            goBackBtn.FlatAppearance.BorderSize = 0;
            goBackBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            goBackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            goBackBtn.FlatStyle = FlatStyle.Flat;
            goBackBtn.ForeColor = Color.FromArgb(199, 199, 199);
            goBackBtn.Image = Properties.Resources.goBackBtnImageIco;
            goBackBtn.Location = new Point(21, 10);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(26, 26);
            goBackBtn.TabIndex = 1;
            goBackBtn.UseVisualStyleBackColor = false;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // addressBar
            // 
            addressBar.BackColor = Color.FromArgb(40, 40, 40);
            addressBar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressBar.ForeColor = Color.FromArgb(199, 199, 199);
            addressBar.Location = new Point(149, 11);
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(450, 25);
            addressBar.TabIndex = 0;
            addressBar.KeyDown += addressBar_KeyDown;
            // 
            // viewerPanel
            // 
            viewerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewerPanel.BackColor = Color.Gray;
            viewerPanel.Controls.Add(webViewer);
            viewerPanel.Location = new Point(0, 40);
            viewerPanel.Name = "viewerPanel";
            viewerPanel.Size = new Size(803, 412);
            viewerPanel.TabIndex = 1;
            // 
            // webViewer
            // 
            webViewer.AllowExternalDrop = true;
            webViewer.CreationProperties = null;
            webViewer.DefaultBackgroundColor = Color.White;
            webViewer.Dock = DockStyle.Fill;
            webViewer.Location = new Point(0, 0);
            webViewer.Name = "webViewer";
            webViewer.Size = new Size(803, 412);
            webViewer.TabIndex = 0;
            webViewer.ZoomFactor = 1D;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewerPanel);
            Controls.Add(navPanel);
            MinimumSize = new Size(800, 450);
            Name = "Browser";
            Text = "Speedy turtle";
            Icon = Properties.Resources.speedyTurtleIcon;
            Load += Browser_Load;
            Resize += Browser_Resize;
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewer).EndInit();
            ResumeLayout(false);
        }

        private Panel navPanel;
        private Panel viewerPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewer;
        private Button moreInfoBtn;
        private Button reloadBtn;
        private Button goNextBtn;
        private Button goBackBtn;
        private TextBox addressBar;
    }
}
