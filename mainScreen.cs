using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Farsight
{
    public partial class mainScreen : Form
    {
        private User[] userList = new User[5];
        int currentUserIndex = 0;
        Champion champion = new Champion();

        private matchHistory matchHistory = new matchHistory();
        private List<matchData> allMatchData = new List<matchData>();
        private List<championMastery> championMasteryList = new List<championMastery>();

        public mainScreen()
        {
            for (int i = 0; i < userList.Length; i++)
            {
                userList[i] = new User();
            }

            InitializeComponent();
            matchHistoryFlowLayoutPanel.AutoScroll = true;

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            champion.DeserialiseJSON(JSONParser.ChampionsFull());

            //this.matchHistoryFlowLayoutPanel.Controls.Add(matchUserControl);
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

        }

        private void addNewSummonerButton_Click(object sender, EventArgs e)
        {
            newSummonerWindow newWindow = new newSummonerWindow(this);
            newWindow.Show();
        }

        public void setSummoner(User user)
        {
            for (int i = 0; i < userList.Length; i++)
            {
                if (user.name == userList[i].name && userList != null)
                {
                    Console.WriteLine("Summoner Already Added");    //change into window popup
                    return;
                }
            }

            if (currentUserIndex >= 5)
            {
                Console.WriteLine("Too many summoners");    //change into window popup
            }
            else
            {
                userList[currentUserIndex] = user;
                summonerAccounts.Items.Add(user.name);
                MessageBox.Show("New Summoner '" + user.name + "' was added");
                currentUserIndex++;
            }

            userList[currentUserIndex - 1].print();
        }

        private void addMatchHistoryButton_Click(object sender, EventArgs e)
        {
            if (userList[0] == null)
            {
                MessageBox.Show("Atleast one summoner must be added before viewing match history!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newMatchHistoryWindow newWindow = new newMatchHistoryWindow(userList[currentUserIndex - 1].accountId, champion, this);
                newWindow.Show();
            }
        }

        private void activeGameButton_Click(object sender, EventArgs e)
        {
            if (userList[0] == null)
            {
                MessageBox.Show("Atleast one summoner must be added before viewing match history!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newActiveGameWindow newGameWindow = new newActiveGameWindow(userList[currentUserIndex - 1].id, champion);
            }
        }

        public void setData(matchHistory matchHistory, List<matchData> allMatchData, List<championMastery> championMasteryList)
        {
            this.matchHistory = matchHistory;
            this.allMatchData = allMatchData;
            this.championMasteryList = championMasteryList;
            populateData();
        }

        private void populateData()
        {
            for (int i = 0; i < 5; i++)
            {
                int userIndex = -1;
                for (int j = 0; j < 10; j++)
                {
                    if (userList[0].accountId == allMatchData[i].participantIdentities[j].player.currentAccountId)
                    {
                        string name = allMatchData[i].participantIdentities[j].player.summonerName;
                        userIndex = j;
                    }
                }
                matchUserControl matchUserControl = new matchUserControl();

                summonerInfoControl summonerInfoControl = new summonerInfoControl();
                summonerInfoControl.summonerProfileIconPictureBox.Image = Images.SummonerProfileIcon(allMatchData[i].participantIdentities[userIndex].player.profileIcon);
                summonerInfoControl.summonerNameLabel.Text = allMatchData[i].participantIdentities[userIndex].player.summonerName;
                summonerInfoControl.summonerRankLabel.Text = userList[currentUserIndex].summonerLevel.ToString();
                this.summonerInfoPanel.Controls.Add(summonerInfoControl);

                matchUserControl.championPictureBox.Image = Images.ChampionImage(matchHistory.matches[i].championName);

                matchUserControl.primaryRunePictureBox.Image = Images.PrimaryRuneTree("7201_Precision");
                matchUserControl.secondaryRunePictureBox.Image = Images.SecondaryRuneTree("7204_Resolve");

                matchUserControl.spell1PictureBox.Image = Images.SummonerSpell("SummonerTeleport");
                matchUserControl.spell2PictureBox.Image = Images.SummonerSpell("SummonerFlash");

                if (allMatchData[i].participants[userIndex].stats.win)
                {
                    matchUserControl.gameOutcomeLabel.ForeColor = Color.MediumPurple;
                    matchUserControl.gameOutcomeLabel.Text = "Victory!";
                }
                else
                {
                    matchUserControl.gameOutcomeLabel.ForeColor = Color.Orange;
                    matchUserControl.gameOutcomeLabel.Text = "Defeat";
                }

                matchUserControl.KDALabel.Text = allMatchData[i].participants[userIndex].stats.kills.ToString();
                matchUserControl.KPLabel.Text = (allMatchData[i].participants[userIndex].stats.kills + allMatchData[i].participants[userIndex].stats.assists).ToString();

                matchUserControl.item1PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item0);
                matchUserControl.item2PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item1);
                matchUserControl.item3PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item2);
                matchUserControl.item4PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item3);
                matchUserControl.item5PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item4);
                matchUserControl.item6PictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item5);
                matchUserControl.wardPictureBox.Image = Images.Item(allMatchData[i].participants[userIndex].stats.item6);

                matchUserControl.champ0PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[0].championName);
                matchUserControl.champ0Label.Text = allMatchData[i].participants[0].summonerName +
                                                    " -- " +
                                                    allMatchData[i].participants[0].stats.kills
                                                    + "/" + allMatchData[i].participants[0].stats.deaths + "/" + allMatchData[i].participants[0].stats.assists;

                matchUserControl.champ1PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[1].championName);
                matchUserControl.champ1Label.Text = allMatchData[i].participants[1].summonerName +
                                                    " -- " +
                                                    allMatchData[i].participants[1].stats.kills
                                                    + "/" + allMatchData[i].participants[1].stats.deaths + "/" + allMatchData[i].participants[1].stats.assists;

                matchUserControl.champ2PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[2].championName);
                matchUserControl.champ2Label.Text = allMatchData[i].participants[2].summonerName +
                                                    " -- " +
                                                    allMatchData[i].participants[2].stats.kills
                                                    + "/" + allMatchData[i].participants[2].stats.deaths + "/" + allMatchData[i].participants[2].stats.assists;

                matchUserControl.champ3PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[3].championName);
                matchUserControl.champ3Label.Text = allMatchData[i].participants[3].summonerName +
                                                    " -- " + allMatchData[i].participants[3].stats.kills
                                                    + "/" + allMatchData[i].participants[3].stats.deaths + "/" + allMatchData[i].participants[3].stats.assists;

                matchUserControl.champ4PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[4].championName);
                matchUserControl.champ4Label.Text = allMatchData[i].participants[4].summonerName +
                                                    " -- " + allMatchData[i].participants[4].stats.kills
                                                    + "/" + allMatchData[i].participants[4].stats.deaths + "/" + allMatchData[i].participants[4].stats.assists;

                matchUserControl.champ5PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[5].championName);
                matchUserControl.champ5Label.Text = allMatchData[i].participants[5].summonerName + " -- " + allMatchData[i].participants[5].stats.kills
                                                + "/" + allMatchData[i].participants[5].stats.deaths + "/" + allMatchData[i].participants[5].stats.assists;

                matchUserControl.champ6PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[6].championName);
                matchUserControl.champ6Label.Text = allMatchData[i].participants[6].summonerName +
                                                    " -- " + allMatchData[i].participants[6].stats.kills
                                                    + "/" + allMatchData[i].participants[6].stats.deaths + "/" + allMatchData[i].participants[6].stats.assists;

                matchUserControl.champ7PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[7].championName);
                matchUserControl.champ7Label.Text = allMatchData[i].participants[7].summonerName +
                                                    " -- " + allMatchData[i].participants[7].stats.kills
                                                    + "/" + allMatchData[i].participants[7].stats.deaths + "/" + allMatchData[i].participants[7].stats.assists;

                matchUserControl.champ8PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[8].championName);
                matchUserControl.champ8Label.Text = allMatchData[i].participants[8].summonerName +
                                                    " -- " + allMatchData[i].participants[8].stats.kills
                                                    + "/" + allMatchData[i].participants[8].stats.deaths + "/" + allMatchData[i].participants[8].stats.assists;

                matchUserControl.champ9PictureBox.Image = Images.ChampionImage(allMatchData[i].participants[9].championName);
                matchUserControl.champ9Label.Text = allMatchData[i].participants[9].summonerName +
                                                    " -- " + allMatchData[i].participants[9].stats.kills
                                                    + "/" + allMatchData[i].participants[9].stats.deaths + "/" + allMatchData[i].participants[9].stats.assists;

                matchHistoryFlowLayoutPanel.Controls.Add(matchUserControl);
            }
        }
    }
}
