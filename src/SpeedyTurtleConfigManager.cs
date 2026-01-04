using System.Text.Json;

namespace SpeedyTurtle
{
    public class SpeedyTurtleConfigManager
    {
        private static readonly DirectoryInfo __ProgramData = 
            new DirectoryInfo( Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) );

        public static readonly DirectoryInfo SpeedyTurtleConfigDir = 
            new DirectoryInfo( Path.Join(__ProgramData.FullName, "SpeedyTurtle") );

        public static readonly FileInfo SpeedyTurtleConfigFile =
            new FileInfo( Path.Join(SpeedyTurtleConfigDir.FullName, "config.json") );

        public SpeedyTurtleConfigManager()
        {
            if (SpeedyTurtleConfigDir.Exists == false)
            {
                SpeedyTurtleConfigDir.Create();
            }

            if (SpeedyTurtleConfigFile.Exists == false)
            {
                SpeedyTurtleConfigFile.Create().Dispose();
                File.WriteAllText( 
                    SpeedyTurtleConfigFile.FullName,
                    JsonSerializer.Serialize(
                        new DefaultSpeedyTurtleConfig(),
                        new JsonSerializerOptions { WriteIndented = true }
                    )
                );
            }


        }
    
        public bool ValidateConfig()
        {
            SpeedyTurtleConfig? config = GetConfig();

            if (config == null) { return false; }

            bool isSearchEngineValid = SearchEngine.isValid(config.searchEngine);
            bool isHomePageURLValid = PageLinkHandler.VerifyLink(config.homePageURL);


            return isSearchEngineValid 
            && isHomePageURLValid
            ;
        }
    
        public SpeedyTurtleConfig? GetConfig()
        {
            try
            {
                return JsonSerializer.Deserialize<SpeedyTurtleConfig> (
                    File.ReadAllText(SpeedyTurtleConfigFile.FullName)
                );
            }
            catch
            {
                return null;
            }
        }

        public void WriteConfig(SpeedyTurtleConfig config)
        {
            string configJson = JsonSerializer.Serialize(
                config,
                new JsonSerializerOptions { WriteIndented = true, IndentSize = 4 }
            );

            try
            {
                File.WriteAllText(SpeedyTurtleConfigFile.FullName, configJson);
            }
            catch { }
        }


    }
    public class SpeedyTurtleConfig
    {
        public string searchEngine { get; set; }
        public string homePageURL { get; set; }

        public bool highlightLink { get; set; }

        public string validLinkHighlightColor { get; set; }
        public string invalidLinkHighlightColor { get; set; }
        public SpeedyTurtleConfig()
        {
            SearchEngine.SearchEngineKind defaultEngine = SearchEngine.SearchEngineKind.DuckDuckGo;
            string defaultHomePage = "about:blank";

            bool defaultHighlightLink = true;

            string defaultValidLinkHighlightColor = ColorHelper.ToString(Color.LightGreen);
            string defaultInvalidLinkHighlightColor =  ColorHelper.ToString(Color.Yellow);


            searchEngine = SearchEngine.GetSearchEngineKindString(defaultEngine);
            homePageURL = defaultHomePage;
            highlightLink = defaultHighlightLink;
            validLinkHighlightColor = defaultValidLinkHighlightColor;
            invalidLinkHighlightColor = defaultInvalidLinkHighlightColor;
        }
    }

    public class DefaultSpeedyTurtleConfig
    {

        public string searchEngine;
        public string homePageURL;

        public bool highlightLink;

        public string validLinkHighlightColor;
        public string invalidLinkHighlightColor;

        public DefaultSpeedyTurtleConfig()
        {
            SpeedyTurtleConfig config = new SpeedyTurtleConfig();

            searchEngine = config.searchEngine;
            homePageURL = config.homePageURL;

            highlightLink = config.highlightLink;

            validLinkHighlightColor = config.validLinkHighlightColor;
            invalidLinkHighlightColor = config.invalidLinkHighlightColor;
        }
    }
}
