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

        public static Image PrimaryRuneTree(int rune)
        {
            string ending = "";

            switch (rune) 
            {
                case 8100:
                    ending = "7200_Domination";
                    break;
                case 8000:
                    ending = "7201_Precision";
                    break;
                case 8200:
                    ending = "7202_Sorcery";
                    break;
                case 8300:
                    ending = "7203_Whimsy";
                    break;
                case 8400:
                    ending = "7204_Resolve";
                    break;
            }

            return Image.FromFile(projectDirectory + @"\Farsight\Images\perk-images\Styles\" + ending + ".png");
        }

        public static Image SecondaryRuneTree(int rune)
        {
            string ending = "";

            switch (rune)
            {
                case 8100:
                    ending = "7200_Domination";
                    break;
                case 8000:
                    ending = "7201_Precision";
                    break;
                case 8200:
                    ending = "7202_Sorcery";
                    break;
                case 8300:
                    ending = "7203_Whimsy";
                    break;
                case 8400:
                    ending = "7204_Resolve";
                    break;
            }

            return Image.FromFile(projectDirectory + @"\Farsight\Images\perk-images\Styles\" + ending + ".png");
        }

        public static Image Item(int itemId)
        {

            if(itemId == 0){
                return Image.FromFile(projectDirectory + @"\Farsight\Images\img\item\" + 4403 + ".png");
            }

            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\item\" + itemId.ToString() + ".png");
        }

        public static Image SummonerSpell(int spellId)
        {
            string spellName = "";
            switch (spellId) 
            {

                case (21):
                    spellName = "SummonerBarrier";
                    break;
                case (1):
                    spellName = "SummonerBoost";
                    break;
                case (14):
                    spellName = "SummonerDot";
                    break;
                case (3):
                    spellName = "SummonerExhaust";
                    break;
                case (4):
                    spellName = "SummonerFlash";
                    break;
                case (6):
                    spellName = "SummonerHaste";
                    break;
                case (7):
                    spellName = "SummonerHeal";
                    break;
                case (13):
                    spellName = "SummonerMana";
                    break;
                case (11):
                    spellName = "SummonerSmite";
                    break;
                case (12):
                    spellName = "SummonerTeleport";
                    break;
                case (32):
                    spellName = "SummonerSnowball";
                    break;

            }
            //SummonerBarrier = Barrier (21)
            //SummonerBoost = Cleanse (1)
            //SummonerDot = Ignite (14)
            //SummonerExhaust = Exhaust (3)
            //SummonerFlash = Flash (4)
            //SummonerHaste = Ghost (6)
            //SummonerHeal = Heal (7)
            //SummonerMana = Clarity (13)
            //SummonerSmite = Smite (11)
            //SummonerTeleport = Teleport (12)
            //SummonerSnowball = Snowball (32)

            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\spell\" + spellName + ".png");
        }

        public static Image SummonerProfileIcon(int iconId)
        {
            return Image.FromFile(projectDirectory + @"\Farsight\Images\img\profileicon\" + iconId.ToString() + ".png");
            
        }
    }
}
