using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class Form1 : Form
    {
        private string summonerName;
        User[] userList = new User[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summonerName = summonerNameTxtBox.Text;

            for (int i = 0; i < userList.Length; i++)
            {
                if (userList[i] == null)
                {
                    userList[i] = new User(summonerName);
                    PopulateUser(i);    //turn into a gui output
                    return;
                }

                if (i == userList.Length && userList[i] != null)
                {
                    Console.WriteLine("Out of summoner space");
                }
            }
        }

        public async void PopulateUser(int userID)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=RGAPI-b5585198-babd-491e-80ac-6cf78ae20ea2");

            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                userList[userID] = JsonConvert.DeserializeObject<User>(jsonString);
            }
        }
    }
}
