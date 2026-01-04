namespace SpeedyTurtle
{
    public class SearchEngine
    {
        private SearchEngineKind Engine { get; set; }

        public SearchEngine(SearchEngineKind searchEngine)
        {
            this.Engine = searchEngine;
        }

        public enum SearchEngineKind
        {
            Google,
            Bing,
            DuckDuckGo,
            Brave,
            Yahoo,
            Ecosia,
            Baidu,
            Yandex,
            Ask,
            Naver,
            AOL,
            Seznam,
            // ===================== //
            //     MEME ENGINES      //
            // ===================== //
            Pinterest,
            BBC,       // British Broadcasting Corporation
            Roblox,
            IRS,       // Internal Revenue Service
            CharAI,    // Character AI
            Praktiker, // Praktiker.bg
            StackOverflow,
            Reddit,
            TikTok,
            Brazil,
            BuzzFeed,
            Wikipedia,
            Steam,
            Minecraft, // Minecraft Wiki
            LOL,       // League of Legends
            Valorant,
            CSGO,
            GenshinImpact,
            Fortnite,
            Fandom,
            EpicGames
        }

        public static string GetSearchEngineKindString(SearchEngineKind searchEngineKind)
        {
            return searchEngineKind switch
            {
                SearchEngineKind.Google => "Google",
                SearchEngineKind.Bing => "Bing",
                SearchEngineKind.DuckDuckGo => "Duck Duck Go",
                SearchEngineKind.Brave => "Brave",
                SearchEngineKind.Yahoo => "Yahoo",
                SearchEngineKind.Ecosia => "Ecosia",
                SearchEngineKind.Baidu => "Baidu",
                SearchEngineKind.Yandex => "Yandex",
                SearchEngineKind.Ask => "Ask",
                SearchEngineKind.Naver => "Naver",
                SearchEngineKind.AOL => "AOL",
                SearchEngineKind.Seznam => "Seznam",
                SearchEngineKind.Pinterest => "Pinterest",
                SearchEngineKind.BBC => "British Broadcasting Corporation",
                SearchEngineKind.Roblox => "Roblox",
                SearchEngineKind.IRS => "Internal Revenue Service",
                SearchEngineKind.CharAI => "Character AI",
                SearchEngineKind.Praktiker => "Praktiker.bg",
                SearchEngineKind.StackOverflow => "Stack Overflow",
                SearchEngineKind.Reddit => "Reddit",
                SearchEngineKind.TikTok => "TikTok",
                SearchEngineKind.Brazil => "Brazil",
                SearchEngineKind.BuzzFeed => "Buzz Feed",
                SearchEngineKind.Wikipedia => "Wikipedia",
                SearchEngineKind.Steam => "Steam",
                SearchEngineKind.Minecraft => "Minecraft",
                SearchEngineKind.LOL => "League Of Legends",
                SearchEngineKind.Valorant => "Valorant",
                SearchEngineKind.CSGO => "Counter Strike Global Offensive",
                SearchEngineKind.GenshinImpact => "Genshin Impact",
                SearchEngineKind.Fortnite => "Fortnite",
                SearchEngineKind.Fandom => "Fandom",
                SearchEngineKind.EpicGames => "Epic Games",
                _ => throw new NotImplementedException()
            };
        }

        public static SearchEngineKind GetSearchEngineKindFromString(string name)
        {
            return name switch
            {
                "Google" => SearchEngineKind.Google,
                "Bing" => SearchEngineKind.Bing,
                "Duck Duck Go" => SearchEngineKind.DuckDuckGo,
                "Brave" => SearchEngineKind.Brave,
                "Yahoo" => SearchEngineKind.Yahoo,
                "Ecosia" => SearchEngineKind.Ecosia,
                "Baidu" => SearchEngineKind.Baidu,
                "Yandex" => SearchEngineKind.Yandex,
                "Ask" => SearchEngineKind.Ask,
                "Naver" => SearchEngineKind.Naver,
                "AOL" => SearchEngineKind.AOL,
                "Seznam" => SearchEngineKind.Seznam,
                "Pinterest" => SearchEngineKind.Pinterest,
                "British Broadcasting Corporation" => SearchEngineKind.BBC,
                "Roblox" => SearchEngineKind.Roblox,
                "Internal Revenue Service" => SearchEngineKind.IRS,
                "Character AI" => SearchEngineKind.CharAI,
                "Praktiker.bg" => SearchEngineKind.Praktiker,
                "Stack Overflow" => SearchEngineKind.StackOverflow,
                "Reddit" => SearchEngineKind.Reddit,
                "TikTok" => SearchEngineKind.TikTok,
                "Brazil" => SearchEngineKind.Brazil,
                "Buzz Feed" => SearchEngineKind.BuzzFeed,
                "Wikipedia" => SearchEngineKind.Wikipedia,
                "Steam" => SearchEngineKind.Steam,
                "Minecraft" => SearchEngineKind.Minecraft,
                "League Of Legends" => SearchEngineKind.LOL,
                "Valorant" => SearchEngineKind.Valorant,
                "Counter Strike Global Offensive" => SearchEngineKind.CSGO,
                "Genshin Impact" => SearchEngineKind.GenshinImpact,
                "Fortnite" => SearchEngineKind.Fortnite,
                "Fandom" => SearchEngineKind.Fandom,
                "Epic Games" => SearchEngineKind.EpicGames,
                _ => throw new NotImplementedException()
            };
        }


        public string Search(string target)
        {
            string baseUrl = this.Engine switch
            {
                SearchEngineKind.Google => "https://www.google.com/search?q=",
                SearchEngineKind.Bing => "https://www.bing.com/search?q=",
                SearchEngineKind.DuckDuckGo => "https://duckduckgo.com/?q=",
                SearchEngineKind.Brave => "https://search.brave.com/search?q=",
                SearchEngineKind.Yahoo => "https://search.yahoo.com/search?p=",
                SearchEngineKind.Ecosia => "https://www.ecosia.org/search?q=",
                SearchEngineKind.Baidu => "https://www.baidu.com/s?wd=",
                SearchEngineKind.Yandex => "https://yandex.com/search?text=",
                SearchEngineKind.Ask => "https://www.ask.com/web?q=",
                SearchEngineKind.Naver => "https://search.naver.com/search.naver?query=",
                SearchEngineKind.AOL => "https://search.aol.com/aol/search?q=",
                SearchEngineKind.Seznam => "https://search.seznam.cz/?q=",
                SearchEngineKind.Pinterest => "https://pinterest.com/search/pins/?q=",
                SearchEngineKind.BBC => "https://www.bbc.com/search?q=",
                SearchEngineKind.Roblox => "https://www.roblox.com/discover/?Keyword=",
                SearchEngineKind.IRS => "https://www.irs.gov/site-index-search?search=",
                SearchEngineKind.CharAI => "https://character.ai/search?q=",
                SearchEngineKind.Praktiker => "https://praktiker.bg/bg/search/",
                SearchEngineKind.StackOverflow => "https://stackoverflow.com/search?q=batata",
                SearchEngineKind.Reddit => "https://www.reddit.com/search/?q=",
                SearchEngineKind.TikTok => "https://www.tiktok.com/search?q=",
                SearchEngineKind.Brazil => "https://www.gov.br/search?SearchableText=",
                SearchEngineKind.BuzzFeed => "https://www.buzzfeed.com/search?q=",
                SearchEngineKind.Wikipedia => "https://wikipedia.org/w/index.php?search=",
                SearchEngineKind.Steam => "https://store.steampowered.com/search?term=",
                SearchEngineKind.Minecraft => "https://minecraft.wiki/?search=",
                SearchEngineKind.LOL => "https://wiki.leagueoflegends.com/en-us/Special:Search?search=",
                SearchEngineKind.Valorant => "https://valorant.fandom.com/wiki/Special:Search?query=",
                SearchEngineKind.CSGO => "https://liquipedia.net/counterstrike/index.php?search=oi",
                SearchEngineKind.GenshinImpact => "https://www.hoyolab.com/search?keyword=",
                SearchEngineKind.Fortnite => "https://fortnitetracker.com/profile/search?q=",
                SearchEngineKind.Fandom => "https://community.fandom.com/wiki/Special:Search?query=",
                SearchEngineKind.EpicGames => "https://store.epicgames.com/browse?q=",
                _ => throw new NotImplementedException()
            };

            return baseUrl + Uri.EscapeDataString(target);
        }

        public static bool isValid( string SearchEngineKindString )
        {
            try
            {
                SearchEngineKind _ = GetSearchEngineKindFromString(SearchEngineKindString);
                return true;
            }
            catch (NotImplementedException) { return false; }
        }
    
    
    }
}
