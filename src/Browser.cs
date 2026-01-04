namespace SpeedyTurtle
{
    public partial class Browser : Form
    {
        private PageLinkHandler LinkHandler = new PageLinkHandler();

        public static SpeedyTurtleConfigManager ConfigManager = new SpeedyTurtleConfigManager();
        public static SpeedyTurtleConfig? Config;

        private Form? MoreInfoPage;

        public static SearchEngine? Engine;

        #region original nav panel rectangle positions and size
        private Rectangle originalNavPanelSize;
        private Rectangle originalNavPanelGoBackBtnRectangle;
        private Rectangle originalNavPanelGoNextBtnRectangle;
        private Rectangle originalNavPanelReloadBtnRectangle;
        private Rectangle originalNavPanelMoreInfoBtnRectangle;
        private Rectangle originalNavPanelAdressBarRectangle;
        #endregion

        public Browser()
        {
            InitializeComponent();
            if (ConfigManager.ValidateConfig())
            {
                Config = ConfigManager.GetConfig()!;
            }
            else
            {
                Config = new SpeedyTurtleConfig()!;
            }

            Engine = new SearchEngine(
                SearchEngine.GetSearchEngineKindFromString(
                    Config.searchEngine
                )
            );

            LinkHandler.LoadPage(this.webViewer, this.addressBar, Config.homePageURL, false);
        }


        #region Browser resizing and loading functions
        public async void Browser_Load(object sender, EventArgs e)
        {
            originalNavPanelSize = new Rectangle(navPanel.Location.X, navPanel.Location.Y, navPanel.Size.Width, navPanel.Size.Height);
            originalNavPanelGoBackBtnRectangle = new Rectangle(goBackBtn.Location.X, goBackBtn.Location.Y, goBackBtn.Size.Width, goBackBtn.Size.Height);
            originalNavPanelGoNextBtnRectangle = new Rectangle(goNextBtn.Location.X, goNextBtn.Location.Y, goNextBtn.Size.Width, goNextBtn.Size.Height);
            originalNavPanelReloadBtnRectangle = new Rectangle(reloadBtn.Location.X, reloadBtn.Location.Y, reloadBtn.Size.Width, reloadBtn.Size.Height);
            originalNavPanelMoreInfoBtnRectangle = new Rectangle(moreInfoBtn.Location.X, moreInfoBtn.Location.Y, moreInfoBtn.Size.Width, moreInfoBtn.Size.Height);
            originalNavPanelAdressBarRectangle = new Rectangle(addressBar.Location.X, addressBar.Location.Y, addressBar.Size.Width, addressBar.Size.Height);
        }

        private void Browser_Resize(object sender, EventArgs e)
        {
            // int oldaddressBarX = addressBar.Location.X;
            ResizeNavPanelControl(originalNavPanelMoreInfoBtnRectangle, moreInfoBtn);

            // NOTE: to not move, remove these.
            ResizeNavPanelControl(originalNavPanelGoBackBtnRectangle, goBackBtn);
            ResizeNavPanelControl(originalNavPanelGoNextBtnRectangle, goNextBtn);
            ResizeNavPanelControl(originalNavPanelReloadBtnRectangle, reloadBtn);

            ResizeNavPanelControl(originalNavPanelAdressBarRectangle, addressBar, true);

            // addressBar.Location = new Point(oldaddressBarX, addressBar.Location.Y);
            // addressBar.Size = new Size((int)((navPanel.Size.Width / 2) * 1.1), navPanel.Size.Height);

        }

        private void ResizeNavPanelControl(Rectangle rect, Control control, bool resize = false)
        {
            float xRatio = (float)(navPanel.Width) / (float)(originalNavPanelSize.Width);
            float yRatio = (float)(navPanel.Height) / (float)(originalNavPanelSize.Height);

            int newX = (int)(rect.Location.X * xRatio);
            int newY = (int)(rect.Location.Y * yRatio);
            control.Location = new Point(newX, newY);
            if (resize)
            {
                int newWidth = (int)(rect.Width * xRatio);
                int newHeight = (int)(rect.Height * yRatio);
                control.Size = new Size(newWidth, newHeight);
            }
        }
        #endregion


        #region Button clicking functions

        private void goBackBtn_Click(object? sender, EventArgs e)
        {
            LinkHandler.GoBack(webViewer);
        }
        private void goNextBtn_Click(object? sender, EventArgs e)
        {
            LinkHandler.GoNext(webViewer);
        }
        private void reloadBtn_Click(object? sender, EventArgs e)
        {
            if (
                webViewer != null &&
                webViewer.CoreWebView2 != null
                ) 
            {
                try
                {
                    LinkHandler.HardReload(webViewer!);
                }
                catch {}
            }

        }
        private void moreInfoBtn_Click(object? sender, EventArgs e)
        {
            if (MoreInfoPage == null || MoreInfoPage.IsDisposed)
            {
                MoreInfoPage = new MoreInformationPage();

                MoreInfoPage.FormClosed += (s, args) =>
                {
                    MoreInfoPage = null;
                };

                MoreInfoPage.Show();
                return;
            }

            if (MoreInfoPage.WindowState == FormWindowState.Minimized)
            {
                MoreInfoPage.WindowState = FormWindowState.Normal;
                MoreInfoPage.BringToFront();
                MoreInfoPage.Activate();
                return;
            }

            MoreInfoPage.Close();


        }

        #endregion

        public void addressBar_KeyDown(object? sender, KeyEventArgs e)
        {
            string addressText = addressBar.Text;

            if (Browser.Config!.highlightLink)
            {
                addressBar.ForeColor = PageLinkHandler.VerifyLink(addressText) ? ColorHelper.FromString(Config!.validLinkHighlightColor) : ColorHelper.FromString(Config!.invalidLinkHighlightColor);
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                addressBar.ForeColor = Color.FromArgb(199, 199, 199);  // default color.

                if (PageLinkHandler.isPorn(addressText.ToLower()))
                {
                    Engine = new SearchEngine(SearchEngine.SearchEngineKind.Baidu);
                    MessageBox.Show(@"please do not search porn on your browser.
Because of that we have decided that you need to search using Baidu instead of " + Browser.Config!.searchEngine
);
                    return;
                }

                // not a valid url, then we search.
                if (!LinkHandler.LoadPage(this.webViewer, this.addressBar, addressText))
                {
                    LinkHandler.LoadPage(this.webViewer, this.addressBar, Engine!.Search(addressText));
                }
            }
        }


    }
}
