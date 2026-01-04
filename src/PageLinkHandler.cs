using System.Net;
using System.Text.RegularExpressions;

namespace SpeedyTurtle
{
    internal class PageLinkHandler
    {
        private string? CurrentPageLink { get; set; }
        private string? CurrentPageString { get; set; }

        #region Linking and page string rendering
        public void EnsurePageLinkAndPageString()
        {
            this.CurrentPageLink = this.PrepareLinkString(this.CurrentPageLink!);
            this.CurrentPageString = this.ClearLink(this.CurrentPageLink);
        }

        public bool LoadPage(Microsoft.Web.WebView2.WinForms.WebView2 webViewer, TextBox addresssBar, string link, bool changeAddresssBar = true)
        {
            this.CurrentPageLink = link;
            this.EnsurePageLinkAndPageString();

            if (changeAddresssBar)
            {
                addresssBar.Text = this.CurrentPageString;
            }

            if (VerifyLink(this.CurrentPageLink) == false)
            {
                return false;
            }

            if (webViewer.CoreWebView2 == null)
            {
                try
                {
                    webViewer.EnsureCoreWebView2Async(null).ContinueWith(task =>
                        {
                            if (task.IsCompletedSuccessfully)
                            {
                                webViewer.CoreWebView2!.Navigate(this.CurrentPageLink);
                            }
                        }, TaskScheduler.FromCurrentSynchronizationContext()
                    );
                    return false;
                }
                catch { return false; }
            }

            webViewer.CoreWebView2.Navigate(this.CurrentPageLink);
            return true;
        }

        public static bool VerifyLink(string link)
        {
            link = link.Trim();

            if (string.IsNullOrWhiteSpace(link))
                return false;


            if (Uri.TryCreate(link, UriKind.Absolute, out var uri))
                return VerifyUri(uri);

            if (Uri.TryCreate("http://" + link, UriKind.Absolute, out uri))
                return VerifyUri(uri);

            return false;
        }

        private static bool VerifyUri(Uri uri)
        {
            if (uri == null)
                return false;

            if (uri.Scheme == Uri.UriSchemeFile)
            {
                return File.Exists(uri.LocalPath);
            }

            if (uri.IsLoopback)
                return true;

            if (uri.Host.Equals("localhost", StringComparison.OrdinalIgnoreCase))
                return true;

            if (uri.Scheme == "about")
            {
                return uri.AbsoluteUri.Equals("about:blank", StringComparison.OrdinalIgnoreCase);
            }

            if (
                uri.Scheme != Uri.UriSchemeHttp &&
                uri.Scheme != Uri.UriSchemeHttps &&
                uri.Scheme != Uri.UriSchemeFile &&
                uri.Scheme != Uri.UriSchemeFtp &&
                uri.Scheme != Uri.UriSchemeFtps
               )
                return false;


            if (IPAddress.TryParse(uri.Host, out _))
                return true;

            if (!uri.Host.Contains('.'))
                return false;

            if (uri.Host.StartsWith('.') || uri.Host.EndsWith('.'))
                return false;

            return true;
        }

        public string ClearLink(string link)
        {
            string[] replaces = { 
                "https://",
                "http://",
                "www.",
                "file:///", // unix like path, '/'
                "file://", // dos like path, '\'
            };

            foreach (string s in replaces)
                link = link.Replace(s, "");

            return link;
        }

        public string PrepareLinkString(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
                return Browser.Config!.homePageURL;

            // local path
            if (Path.IsPathRooted(link))
            {
                return new Uri(link).AbsoluteUri;
            }

            if (link.Contains("://"))
                return link;

            return "https://" + link;
        }

        #endregion

        public static bool isPorn(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string[] nsfwKeywords =
            {
            "xvideos", "xnxx", "redtube",
            "hentai", "rule34", "onlyfans", "brazzers",
            "spankbang", "fapello",
            "porn", "sex", "xxx",
            "nsfw", "boobs", "pussy", "dick",
            "anal", "oral", "blowjob", "handjob", "cum",
            "milf", "teen", "fetish", "escort", "camgirl",
            "onlyfans", "nude", "nudity", "dildo"
            };
            // NOTE: there are way more, but im lazy as fuck and im not in the mood to search it.

            foreach (string s in nsfwKeywords)
            {
                if (input.Trim().Contains(s))
                {
                    return true;
                }
            }

            return false;
        }


        #region Primitive webviewer wrappers
        public void GoBack(Microsoft.Web.WebView2.WinForms.WebView2 webViewer)
        {
            if (webViewer.CanGoBack)
            {
                webViewer.GoBack();
            }
        }

        public void GoNext(Microsoft.Web.WebView2.WinForms.WebView2 webViewer)
        {
            if (webViewer.CanGoForward)
            {
                webViewer.GoForward();
            }
        }

        public void Reload(Microsoft.Web.WebView2.WinForms.WebView2 webViewer)
        {
            webViewer.Refresh(); // reloads using cache
        }

        public void HardReload(Microsoft.Web.WebView2.WinForms.WebView2 webViewer)
        {
            webViewer.Reload(); // reloads without cache
        }

        public void StopLoad(Microsoft.Web.WebView2.WinForms.WebView2 webViewer)
        {
            webViewer.Stop();
        }

        #endregion

    }
}
