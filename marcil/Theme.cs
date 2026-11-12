using System.Drawing.Text;

namespace SchoolApp
{
    /// <summary>
    /// Tema abu-ungu + font Russo One (dimuat dari Fonts/RussoOne-Regular.ttf).
    /// </summary>
    internal static class Theme
    {
        // Palet abu-ungu
        public static readonly Color FormBg      = ColorTranslator.FromHtml("#DDD8E4");
        public static readonly Color NavBar      = ColorTranslator.FromHtml("#4B4558");
        public static readonly Color NavActive   = ColorTranslator.FromHtml("#8C7BA6");
        public static readonly Color NavInactive = ColorTranslator.FromHtml("#6A6278");
        public static readonly Color Accent      = ColorTranslator.FromHtml("#5E4F7A");
        public static readonly Color Button      = ColorTranslator.FromHtml("#7E6D9A");
        public static readonly Color ButtonText  = Color.White;
        public static readonly Color InputBg     = ColorTranslator.FromHtml("#F2EFF6");
        public static readonly Color GridBg      = ColorTranslator.FromHtml("#CFC9D9");
        public static readonly Color RowAlt      = ColorTranslator.FromHtml("#E4DFEC");
        public static readonly Color GridLine    = ColorTranslator.FromHtml("#B8B0C6");

        private static readonly PrivateFontCollection fonts = new();
        private static readonly FontFamily? russo = Load();

        private static FontFamily? Load()
        {
            try
            {
                string path = Path.Combine(
                    AppContext.BaseDirectory, "Fonts", "RussoOne-Regular.ttf");
                if (!File.Exists(path))
                    return null;
                fonts.AddFontFile(path);
                return fonts.Families.Length > 0 ? fonts.Families[0] : null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Font Russo One; jatuh ke Segoe UI jika file font tidak ditemukan.</summary>
        public static Font Font(float size, GraphicsUnit unit = GraphicsUnit.Point)
        {
            return russo != null
                ? new Font(russo, size, FontStyle.Regular, unit)
                : new Font("Segoe UI", size, FontStyle.Bold, unit);
        }
    }
}
