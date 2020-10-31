using System;
using System.IO;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class mainScreen : Form
    {
        private User[] userList = new User[5];
        int currentUserIndex = 0;
        Champion champion = new Champion();

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

            //this.matchHistoryFlowLayoutPanel.Controls.Add(matchUserControl);
            for (int i = 0; i < 20; i++)
            {
                matchUserControl matchUserControl = new matchUserControl();

                matchUserControl.championPictureBox.Image = Images.ChampionImage("Darius");

                matchUserControl.primaryRunePictureBox.Image = Images.PrimaryRuneTree("7201_Precision");
                matchUserControl.secondaryRunePictureBox.Image = Images.SecondaryRuneTree("7204_Resolve");


                matchUserControl.gameOutcomeLabel.Text = "Victory";
                matchUserControl.KDALabel.Text = "2.5 KDA";
                matchUserControl.KPLabel.Text = "6 KP";

                matchUserControl.item1PictureBox.Image = Images.Item(3071);
                matchUserControl.item2PictureBox.Image = Images.Item(3812);
                matchUserControl.item3PictureBox.Image = Images.Item(3047);
                matchUserControl.item4PictureBox.Image = Images.Item(3053);
                matchUserControl.item5PictureBox.Image = Images.Item(3026);
                matchUserControl.item6PictureBox.Image = Images.Item(3065);
                matchUserControl.wardPictureBox.Image = Images.Item(3340);

                matchUserControl.champ1PictureBox.Image = Images.ChampionImage("Aatrox");
                matchUserControl.champ1Label.Text = "Aatrox";
                matchUserControl.champ2PictureBox.Image = Images.ChampionImage("Rammus");
                matchUserControl.champ2Label.Text = "Rammus";
                matchUserControl.champ3PictureBox.Image = Images.ChampionImage("LeeSin");
                matchUserControl.champ3Label.Text = "LeeSin";
                matchUserControl.champ4PictureBox.Image = Images.ChampionImage("Amumu");
                matchUserControl.champ4Label.Text = "Amumu";
                matchUserControl.champ5PictureBox.Image = Images.ChampionImage("Darius");
                matchUserControl.champ5Label.Text = "Darius";

                matchUserControl.champ6PictureBox.Image = Images.ChampionImage("Senna");
                matchUserControl.champ6Label.Text = "Senna";
                matchUserControl.champ7PictureBox.Image = Images.ChampionImage("Sona");
                matchUserControl.champ7Label.Text = "Sona";
                matchUserControl.champ8PictureBox.Image = Images.ChampionImage("Braum");
                matchUserControl.champ8Label.Text = "Braum";
                matchUserControl.champ9PictureBox.Image = Images.ChampionImage("Thresh");
                matchUserControl.champ9Label.Text = "Thresh";
                matchUserControl.champ10PictureBox.Image = Images.ChampionImage("Leona");
                matchUserControl.champ10Label.Text = "Leona";
                matchHistoryFlowLayoutPanel.Controls.Add(matchUserControl);
            }
            champion.DeserialiseJSON(JSONParser.ChampionsFull());
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
                newMatchHistoryWindow newWindow = new newMatchHistoryWindow(userList[currentUserIndex - 1].accountId, champion);
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
    }
}
