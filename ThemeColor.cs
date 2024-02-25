using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletroMath
{
    internal class ThemeColor
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecundaryColor { get; set; }
        public static List<string> ColorList = new List<string>{"#065535",
                                                                "#007777",
                                                                "#006666",
                                                                "#005555",
                                                                "#004444",
                                                                "#003333",
                                                                "#52bf90",
                                                                "#49ab81",
                                                                "#419873",
                                                                "#398564",
                                                                "#317256",
                                                                "#011f4b",
                                                                "#03396c",
                                                                "#005b96",
                                                                "#6497b1",
                                                                "#133337",
                                                                "#333333",
                                                                "#ff0000",
                                                                "#00d27f"};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }

}
