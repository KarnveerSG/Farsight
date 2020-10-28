using System;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class mainScreen : Form
    {
        private User[] userList = new User[5];
        int currentUserIndex = 0;

        public mainScreen()
        {

            InitializeComponent();

        }

        public void AddNewSummoner(User newUser)
        {
            setSummoner(newUser);
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
            if (currentUserIndex >= 5)
            {
                Console.WriteLine("Too many summoners");
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
                newMatchHistoryWindow newWindow = new newMatchHistoryWindow(userList[currentUserIndex - 1].accountId);
                newWindow.Show();
            }
        }
    }
}
