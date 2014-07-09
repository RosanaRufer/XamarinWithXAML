using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SemiTransparentModalPage.Helpers
{
    public static class Fonts
    {
        public static Font TitleFont;
        public static Font SubtitleFont;
        public static Font LabelFont;

        static Fonts()
        {
            TitleFont = Font.SystemFontOfSize(32);
            SubtitleFont = Font.SystemFontOfSize(30);
            LabelFont = Font.SystemFontOfSize(20);
        }
    }
}
