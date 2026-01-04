namespace SpeedyTurtle
{
    internal class SearchEngineComboBoxItem
    {
        public Image Icon { get; set; }
        public string Text { get; set; }
 
       public SearchEngineComboBoxItem(Image icon, string text)
        {
            this.Icon = icon;
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    internal class SearchEngineComboBoxItems
    {
        public static SearchEngineComboBoxItem[] GetItems ()
        {
            SearchEngineComboBoxItem[] Items = {
                new SearchEngineComboBoxItem(
                    Properties.Resources.googleSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Google)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.bingSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Bing)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.duckDuckGoSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.DuckDuckGo)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.braveSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Brave)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.yahooSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Yahoo)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.ecosiaSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Ecosia)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.baiduSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Baidu)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.yandexSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Yandex)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.askSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Ask)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.naverSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Naver)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.AOLSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.AOL)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.seznamSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Seznam)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.pinterestSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Pinterest)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.BBCSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.BBC)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.robloxSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Roblox)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.IRSSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.IRS)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.charAISearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.CharAI)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.praktikerSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Praktiker)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.stackOverflowSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.StackOverflow)
                ),


                new SearchEngineComboBoxItem(
                    Properties.Resources.redditSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Reddit)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.tikTokSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.TikTok)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.brazilSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Brazil)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.buzzFeedSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.BuzzFeed)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.wikipediaSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Wikipedia)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.steamSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Steam)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.minecraftSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Minecraft)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.LOLSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.LOL)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.valorantSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Valorant)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.CSGOSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.CSGO)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.genshinImpactSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.GenshinImpact)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.fortniteSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Fortnite)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.fandomSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.Fandom)
                ),

                new SearchEngineComboBoxItem(
                    Properties.Resources.epicGamesSearchEngineImage,
                    SearchEngine.GetSearchEngineKindString(SearchEngine.SearchEngineKind.EpicGames)
                ),
            };

            return Items;
        }
    }
}
