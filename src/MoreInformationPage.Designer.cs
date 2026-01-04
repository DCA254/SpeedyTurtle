using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace SpeedyTurtle
{
    partial class MoreInformationPage
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            topPanel = new Panel();
            homePageAddressBar = new TextBox();
            homePageTextLabel = new Label();
            searchEngineTextLabel = new Label();
            searchEngineCBox = new ComboBox();
            bottomRightPanel = new Panel();
            applyConfigBtn = new Button();
            LeftPanel = new Panel();
            LinkHighlightInvalidCurrentColorLabel = new Label();
            LinkHighlightValidCurrentColorLabel = new Label();
            ChangeLinkHighlightInvalidColorBtn = new Button();
            ChangeLinkHighlightValidColorBtn = new Button();
            LinkHighlightInvalidLabel = new Label();
            LinkHighlightValidLabel = new Label();
            LinkHighlightCheckBox = new CheckBox();
            topPanel.SuspendLayout();
            bottomRightPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(homePageAddressBar);
            topPanel.Controls.Add(homePageTextLabel);
            topPanel.Controls.Add(searchEngineTextLabel);
            topPanel.Controls.Add(searchEngineCBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 68);
            topPanel.TabIndex = 0;
            // 
            // homePageAddressBar
            // 
            homePageAddressBar.BackColor = Color.FromArgb(40, 40, 40);
            homePageAddressBar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homePageAddressBar.ForeColor = Color.FromArgb(199, 199, 199);
            homePageAddressBar.Location = new Point(12, 29);
            homePageAddressBar.Name = "homePageAddressBar";
            homePageAddressBar.Size = new Size(363, 25);
            homePageAddressBar.TabIndex = 3;
            // 
            // homePageTextLabel
            // 
            homePageTextLabel.AutoSize = true;
            homePageTextLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homePageTextLabel.ForeColor = Color.FromArgb(199, 199, 199);
            homePageTextLabel.Location = new Point(12, 9);
            homePageTextLabel.Name = "homePageTextLabel";
            homePageTextLabel.Size = new Size(105, 17);
            homePageTextLabel.TabIndex = 2;
            homePageTextLabel.Text = "Home page url:";
            homePageTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchEngineTextLabel
            // 
            searchEngineTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchEngineTextLabel.AutoSize = true;
            searchEngineTextLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEngineTextLabel.ForeColor = Color.FromArgb(199, 199, 199);
            searchEngineTextLabel.Location = new Point(295, 9);
            searchEngineTextLabel.Name = "searchEngineTextLabel";
            searchEngineTextLabel.Size = new Size(99, 17);
            searchEngineTextLabel.TabIndex = 1;
            searchEngineTextLabel.Text = "Search engine:";
            searchEngineTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchEngineCBox
            // 
            searchEngineCBox.BackColor = Color.FromArgb(60, 60, 60);
            searchEngineCBox.Dock = DockStyle.Right;
            searchEngineCBox.DrawMode = DrawMode.OwnerDrawFixed;
            searchEngineCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchEngineCBox.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEngineCBox.ForeColor = Color.FromArgb(199, 199, 199);
            searchEngineCBox.FormattingEnabled = true;
            searchEngineCBox.IntegralHeight = false;
            searchEngineCBox.ItemHeight = 62;
            searchEngineCBox.Location = new Point(396, 0);
            searchEngineCBox.Name = "searchEngineCBox";
            searchEngineCBox.Size = new Size(404, 68);
            searchEngineCBox.TabIndex = 0;
            searchEngineCBox.DrawItem += searchEngineCBox_DrawItem;
            // 
            // bottomRightPanel
            // 
            bottomRightPanel.Controls.Add(applyConfigBtn);
            bottomRightPanel.Dock = DockStyle.Bottom;
            bottomRightPanel.Location = new Point(0, 389);
            bottomRightPanel.Name = "bottomRightPanel";
            bottomRightPanel.Size = new Size(800, 61);
            bottomRightPanel.TabIndex = 1;
            // 
            // applyConfigBtn
            // 
            applyConfigBtn.BackColor = Color.FromArgb(60, 60, 60);
            applyConfigBtn.Dock = DockStyle.Right;
            applyConfigBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            applyConfigBtn.FlatAppearance.BorderSize = 0;
            applyConfigBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            applyConfigBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 40);
            applyConfigBtn.FlatStyle = FlatStyle.Flat;
            applyConfigBtn.Font = new Font("Segoe UI Black", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyConfigBtn.ForeColor = Color.FromArgb(199, 199, 199);
            applyConfigBtn.Location = new Point(618, 0);
            applyConfigBtn.Name = "applyConfigBtn";
            applyConfigBtn.Size = new Size(182, 61);
            applyConfigBtn.TabIndex = 0;
            applyConfigBtn.Text = "Apply";
            applyConfigBtn.UseVisualStyleBackColor = false;
            applyConfigBtn.Click += applyConfigBtn_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(LinkHighlightInvalidCurrentColorLabel);
            LeftPanel.Controls.Add(LinkHighlightValidCurrentColorLabel);
            LeftPanel.Controls.Add(ChangeLinkHighlightInvalidColorBtn);
            LeftPanel.Controls.Add(ChangeLinkHighlightValidColorBtn);
            LeftPanel.Controls.Add(LinkHighlightInvalidLabel);
            LeftPanel.Controls.Add(LinkHighlightValidLabel);
            LeftPanel.Controls.Add(LinkHighlightCheckBox);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 68);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(308, 321);
            LeftPanel.TabIndex = 2;
            // 
            // LinkHighlightInvalidCurrentColorLabel
            // 
            LinkHighlightInvalidCurrentColorLabel.AutoSize = true;
            LinkHighlightInvalidCurrentColorLabel.Location = new Point(44, 179);
            LinkHighlightInvalidCurrentColorLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkHighlightInvalidCurrentColorLabel.ForeColor = Color.FromArgb(199, 199, 199);
            LinkHighlightInvalidCurrentColorLabel.TextAlign = ContentAlignment.MiddleCenter;
            LinkHighlightInvalidCurrentColorLabel.Name = "LinkHighlightInvalidCurrentColorLabel";
            LinkHighlightInvalidCurrentColorLabel.Size = new Size(94, 15);
            LinkHighlightInvalidCurrentColorLabel.TabIndex = 7;
            LinkHighlightInvalidCurrentColorLabel.Text = "Invalid link color:";
            // 
            // LinkHighlightValidCurrentColorLabel
            // 
            LinkHighlightValidCurrentColorLabel.AutoSize = true;
            LinkHighlightValidCurrentColorLabel.Location = new Point(48, 46);
            LinkHighlightValidCurrentColorLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkHighlightValidCurrentColorLabel.ForeColor = Color.FromArgb(199, 199, 199);
            LinkHighlightValidCurrentColorLabel.TextAlign = ContentAlignment.MiddleCenter;
            LinkHighlightValidCurrentColorLabel.Name = "LinkHighlightValidCurrentColorLabel";
            LinkHighlightValidCurrentColorLabel.Size = new Size(84, 15);
            LinkHighlightValidCurrentColorLabel.TabIndex = 6;
            LinkHighlightValidCurrentColorLabel.Text = "Valid link color:";
            // 
            // ChangeLinkHighlightInvalidColorBtn
            // 
            ChangeLinkHighlightInvalidColorBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            ChangeLinkHighlightInvalidColorBtn.FlatAppearance.BorderSize = 0;
            ChangeLinkHighlightInvalidColorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            ChangeLinkHighlightInvalidColorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 40);
            ChangeLinkHighlightInvalidColorBtn.FlatStyle = FlatStyle.Flat;
            ChangeLinkHighlightInvalidColorBtn.Font = new Font("Segoe UI Black", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeLinkHighlightInvalidColorBtn.ForeColor = Color.FromArgb(199, 199, 199);
            ChangeLinkHighlightInvalidColorBtn.BackColor = ColorHelper.FromString(Browser.Config.invalidLinkHighlightColor);
            ChangeLinkHighlightInvalidColorBtn.Location = new Point(12, 197);
            ChangeLinkHighlightInvalidColorBtn.Name = "ChangeLinkHighlightInvalidColorBtn";
            ChangeLinkHighlightInvalidColorBtn.Size = new Size(156, 51);
            ChangeLinkHighlightInvalidColorBtn.TabIndex = 5;
            ChangeLinkHighlightInvalidColorBtn.Text = "Change";
            ChangeLinkHighlightInvalidColorBtn.UseVisualStyleBackColor = true;
            ChangeLinkHighlightInvalidColorBtn.Click += ChangeLinkHighlightInvalidColorBtn_Click;
            // 
            // ChangeLinkHighlightValidColorBtn
            // 
            ChangeLinkHighlightValidColorBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            ChangeLinkHighlightValidColorBtn.FlatAppearance.BorderSize = 0;
            ChangeLinkHighlightValidColorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            ChangeLinkHighlightValidColorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 40);
            ChangeLinkHighlightValidColorBtn.FlatStyle = FlatStyle.Flat;
            ChangeLinkHighlightValidColorBtn.Font = new Font("Segoe UI Black", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeLinkHighlightValidColorBtn.ForeColor = Color.FromArgb(199, 199, 199);
            ChangeLinkHighlightValidColorBtn.BackColor = ColorHelper.FromString(Browser.Config.validLinkHighlightColor);
            ChangeLinkHighlightValidColorBtn.Location = new Point(12, 63);
            ChangeLinkHighlightValidColorBtn.Name = "ChangeLinkHighlightValidColorBtn";
            ChangeLinkHighlightValidColorBtn.Size = new Size(156, 51);
            ChangeLinkHighlightValidColorBtn.TabIndex = 4;
            ChangeLinkHighlightValidColorBtn.Text = "Change";
            ChangeLinkHighlightValidColorBtn.UseVisualStyleBackColor = true;
            ChangeLinkHighlightValidColorBtn.Click += ChangeLinkHighlightValidColorBtn_Click;
            // 
            // LinkHighlightInvalidLabel
            // 
            LinkHighlightInvalidLabel.AutoSize = true;
            LinkHighlightInvalidLabel.Location = new Point(196, 215);
            LinkHighlightInvalidLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkHighlightInvalidLabel.ForeColor = Color.FromArgb(199, 199, 199);
            LinkHighlightInvalidLabel.BackColor = ColorHelper.FromString(Browser.Config.invalidLinkHighlightColor);
            LinkHighlightInvalidLabel.TextAlign = ContentAlignment.MiddleCenter;
            LinkHighlightInvalidLabel.Name = "LinkHighlightInvalidLabel";
            LinkHighlightInvalidLabel.Size = new Size(45, 15);
            LinkHighlightInvalidLabel.TabIndex = 3;
            LinkHighlightInvalidLabel.Text = Browser.Config.invalidLinkHighlightColor;
            // 
            // LinkHighlightValidLabel
            // 
            LinkHighlightValidLabel.AutoSize = true;
            LinkHighlightValidLabel.Location = new Point(196, 81);
            LinkHighlightValidLabel.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkHighlightValidLabel.ForeColor = Color.FromArgb(199, 199, 199);
            LinkHighlightValidLabel.BackColor = ColorHelper.FromString(Browser.Config.validLinkHighlightColor);
            LinkHighlightValidLabel.TextAlign = ContentAlignment.MiddleCenter;
            LinkHighlightValidLabel.Name = "LinkHighlightValidLabel";
            LinkHighlightValidLabel.Size = new Size(45, 15);
            LinkHighlightValidLabel.TabIndex = 2;
            LinkHighlightValidLabel.Text = Browser.Config.validLinkHighlightColor;
            // 
            // LinkHighlightCheckBox
            // 
            LinkHighlightCheckBox.AutoSize = true;
            LinkHighlightCheckBox.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            LinkHighlightCheckBox.FlatAppearance.BorderSize = 0;
            LinkHighlightCheckBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            LinkHighlightCheckBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 40);
            LinkHighlightCheckBox.FlatStyle = FlatStyle.Flat;
            LinkHighlightCheckBox.Font = new Font("Segoe UI Black", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkHighlightCheckBox.ForeColor = Color.FromArgb(199, 199, 199);
            LinkHighlightCheckBox.Location = new Point(20, 0);
            LinkHighlightCheckBox.Name = "LinkHighlightCheckBox";
            LinkHighlightCheckBox.Size = new Size(140, 27);
            LinkHighlightCheckBox.TabIndex = 1;
            LinkHighlightCheckBox.Checked = Browser.Config.highlightLink;
            LinkHighlightCheckBox.Text = "Link highlight";
            LinkHighlightCheckBox.UseVisualStyleBackColor = true;
            LinkHighlightCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MoreInformationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(LeftPanel);
            Controls.Add(bottomRightPanel);
            Controls.Add(topPanel);
            Icon = Properties.Resources.speedyTurtleIcon;
            MinimumSize = new Size(800, 450);
            Name = "MoreInformationPage";
            Text = "More Information Page";
            Load += MoreInformationPage_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomRightPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private ComboBox searchEngineCBox;
        private Panel bottomRightPanel;
        private Button applyConfigBtn;
        private Label searchEngineTextLabel;
        private Label homePageTextLabel;
        private TextBox homePageAddressBar;
        private Panel LeftPanel;
        private CheckBox LinkHighlightCheckBox;
        private Label LinkHighlightInvalidLabel;
        private Label LinkHighlightValidLabel;
        private Label LinkHighlightInvalidCurrentColorLabel;
        private Label LinkHighlightValidCurrentColorLabel;
        private Button ChangeLinkHighlightInvalidColorBtn;
        private Button ChangeLinkHighlightValidColorBtn;
    }
}