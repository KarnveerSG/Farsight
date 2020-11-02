using System;
using System.Drawing;
using System.IO;

namespace Farsight
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
            if (championName == "Wukong") {
                championName = "MonkeyKing";
            }

            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\champion\" + championName + ".png");
        }

        public static Image PrimaryRuneTree(string rune)
        {
            return Image.FromFile(projectDirectory + @"\Farsight\Images\perk-images\Styles\" + rune + ".png");
        }

        public static Image SecondaryRuneTree(string rune)
        {
            return Image.FromFile(projectDirectory + @"\Farsight\Images\perk-images\Styles\" + rune + ".png");
        }

        public static Image Item(int itemId)
        {

            if(itemId == 0){
                return Image.FromFile(projectDirectory + @"\Farsight\Images\img\item\" + 4403 + ".png");
            }

            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\item\" + itemId.ToString() + ".png");
        }

        public static Image SummonerSpell(string spellName)
        {
            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\spell\" + spellName + ".png");
        }

        public static Image SummonerProfileIcon(int iconId)
        {
            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\profileicon\" + iconId.ToString() + ".png");
            //SummonerBarrier = Barrier
            //SummonerBoost = Cleanse
            //SummunerDot = Ignite
            //SummonerExhaust = Exhaust
            //SummonerFlash = Flash
            //SummonerHaste = Ghost
            //SummonerHeal = Heal
            //SummonerMana = Clarity
            //SummonerSmite = Smite
            //SummonerTeleport = Teleport
        }
    }
}
