namespace SpeedyTurtle
{
    internal class ColorHelper
    {
        public static Color FromString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Color.Empty;

            if (value.StartsWith("#"))
            {
                return ColorTranslator.FromHtml(value);
            }

            return Color.FromName(value);
        }

        public static string ToString(Color color)
        {
            if (color.IsKnownColor)
                return color.Name;
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
