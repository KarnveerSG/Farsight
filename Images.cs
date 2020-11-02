using System;
using System.Drawing;
using System.IO;

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

        public static Image SummonerSpell(string spellName)
        {
            return Image.FromFile(projectDirectory + @"\Blue-ward\Images\img\spell\" + spellName + ".png");
        }

        public static Image SummonerProfileIcon(int iconId)
        {
            return Image.FromFile(projectDirectory + @"\Blue-Ward\Images\img\profileicon\" + iconId.ToString() + ".png");
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
