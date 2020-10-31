﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class newSummonerWindow : Form
    {
        private string summonerName;
        User user = new User();
        private mainScreen mainScreen;
        private string apiKey = "RGAPI-7842efec-8a88-4be0-89c0-b6448e6fe168";

        public newSummonerWindow()
        {
            InitializeComponent();
        }

        public newSummonerWindow(mainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summonerName = summonerNameTxtBox.Text;
            createNewUser();
        }

        public async void createNewUser()
        {
            await PopulateUser();
            this.Close();
        }

        public async Task PopulateUser()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=" + apiKey);

            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                user = JsonConvert.DeserializeObject<User>(jsonString);
                this.mainScreen.setSummoner(user);
            }
        }

        private void summonerNameTxtBox_Click(object sender, EventArgs e)
        {
            summonerNameTxtBox.Text = "";
        }

        private void newSummonerWindow_Load(object sender, EventArgs e)
        {

        }

        private void summonerNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
