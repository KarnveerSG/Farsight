using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void mainScreen_Load(object sender, EventArgs e)
        {

        }

        private void addNewSummonerButtton_Click(object sender, EventArgs e)
        {
            newSummonerWindow newWindow = new newSummonerWindow();

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
                currentUserIndex++;
            }

            userList[currentUserIndex - 1].print();

        }
    }
}
