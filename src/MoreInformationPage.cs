namespace SpeedyTurtle
{
    public partial class MoreInformationPage : Form
    {
        private Color validLinkColor;
        private Color invalidLinkColor;

        public MoreInformationPage()
        {
            InitializeComponent();

            validLinkColor = ColorHelper.FromString(Browser.Config!.validLinkHighlightColor);
            invalidLinkColor = ColorHelper.FromString(Browser.Config.invalidLinkHighlightColor);

        }

        public void MoreInformationPage_Load(object sender, EventArgs e)
        {
            searchEngineCBox.Items.AddRange(SearchEngineComboBoxItems.GetItems());

            var selectedItem = searchEngineCBox.Items
                .OfType<SearchEngineComboBoxItem>()
                .FirstOrDefault(i =>
                    string.Equals(i.Text, Browser.Config!.searchEngine, StringComparison.OrdinalIgnoreCase)
                );

            searchEngineCBox.SelectedItem = selectedItem ?? searchEngineCBox.Items[0];


            homePageAddressBar.Text = Browser.Config!.homePageURL;
        }



        public void searchEngineCBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if (searchEngineCBox.Items[e.Index] is not SearchEngineComboBoxItem item)
                return;

            Color backColor = searchEngineCBox.BackColor;
            Color foreColor = searchEngineCBox.ForeColor;

            using (var backgroundBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }


            int iconSize = 59;
            int padding = 40;

            int iconY = e.Bounds.Top + (e.Bounds.Height - iconSize) / 2;

            Rectangle fullBounds = new Rectangle(
                e.Bounds.X,
                e.Bounds.Y,
                searchEngineCBox.Width,
                e.Bounds.Height
            );

            e.Graphics.DrawImage(
                item.Icon,
                new Rectangle(
                    e.Bounds.Left + padding,
                    iconY,
                    iconSize,
                    iconSize
                )
            );

            using var brush = new SolidBrush(e.ForeColor);

            e.Graphics.DrawString(
                item.Text,
                e.Font ?? searchEngineCBox.Font,
                brush,
                e.Bounds.Left + padding + iconSize + 6,
                e.Bounds.Top + (e.Bounds.Height - e.Font!.Height) / 2
            );
        }

        private void applyConfigBtn_Click(object sender, EventArgs e)
        {
            SpeedyTurtleConfig? oldConfig = Browser.ConfigManager.GetConfig();

            if (searchEngineCBox.SelectedItem is not SearchEngineComboBoxItem selectedSearchEngine)
            {
                MessageBox.Show("No search engine selected.");
                return;
            }

            string searchEngine = selectedSearchEngine.Text;
            string homePageAddress = homePageAddressBar.Text;


            Browser.Config!.searchEngine = searchEngine;
            Browser.Config.homePageURL = homePageAddress;
            Browser.Config.validLinkHighlightColor = ColorHelper.ToString(validLinkColor);
            Browser.Config.invalidLinkHighlightColor = ColorHelper.ToString(invalidLinkColor);
            Browser.Config.highlightLink = LinkHighlightCheckBox.Checked;



            Browser.ConfigManager.WriteConfig(Browser.Config);
            if (!Browser.ConfigManager.ValidateConfig())
            {
                Browser.Config = oldConfig;
                Browser.ConfigManager.WriteConfig(oldConfig!);
                MessageBox.Show("Invalid config, returning to the previous one.");
            }


            Browser.Engine = new SearchEngine(
                SearchEngine.GetSearchEngineKindFromString(
                    Browser.Config!.searchEngine
                )
            );


            ChangeLinkHighlightInvalidColorBtn.BackColor = ColorHelper.FromString(Browser.Config.invalidLinkHighlightColor);
            ChangeLinkHighlightValidColorBtn.BackColor = ColorHelper.FromString(Browser.Config.validLinkHighlightColor);

            LinkHighlightInvalidLabel.Text = Browser.Config.invalidLinkHighlightColor;
            LinkHighlightInvalidLabel.BackColor = ColorHelper.FromString(Browser.Config.invalidLinkHighlightColor);

            LinkHighlightValidLabel.Text = Browser.Config.validLinkHighlightColor;
            LinkHighlightValidLabel.BackColor = ColorHelper.FromString(Browser.Config.validLinkHighlightColor);

            LinkHighlightCheckBox.Checked = Browser.Config.highlightLink;

        }

        private void ChangeLinkHighlightValidColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                this.validLinkColor = colorDialog.Color;
            }
        }

        private void ChangeLinkHighlightInvalidColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                this.invalidLinkColor = colorDialog.Color;
            }
        }
    }
}
