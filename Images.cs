using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    class Images
    {
        private static string workingDirectory = Environment.CurrentDirectory;
        private static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public Images()
        {

        }

        public static Image ChampionImage(string championName)
        {
            return Image.FromFile(projectDirectory + @"\Blue-Ward\Images\img\champion\" + championName + ".png");
        }

        public static Image PrimaryRuneTree(string rune)
        {
            return Image.FromFile(projectDirectory + @"\Blue-Ward\Images\perk-images\Styles\" + rune + ".png");
        }

        public static Image SecondaryRuneTree(string rune)
        {
            return Image.FromFile(projectDirectory + @"\Blue-Ward\Images\perk-images\Styles\" + rune + ".png");
        }

        public static Image Item(int itemId)
        {
            return Image.FromFile(projectDirectory + @"\Blue-Ward\Images\img\item\" + itemId.ToString() + ".png");
        }
    }
}
