using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class newMatchHistoryWindow : Form
    {
        HttpClient client = new HttpClient();
        matchHistory matchHistory = new matchHistory();
        matchData matchData = new matchData();
        List<championMastery> championMasteryList = new List<championMastery>();

        public newMatchHistoryWindow(string accountID)
        {
            InitializeComponent();
            createMatchHistory(accountID);

            for (int i = 1; i <= 100; i++)
            {
                matchNumberBox.Items.Add(i);
            }
        }

        public async void createMatchHistory(string accountID)
        {
            await PopulateMatchHistory(accountID);
        }

        public async Task PopulateMatchHistory(string accountID)
        {
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountID + "?api_key=RGAPI-6dad0715-7e7c-40ae-a0c5-e2f1de04747d");

            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                matchHistory = JsonConvert.DeserializeObject<matchHistory>(jsonString);
            }
        }

        private void matchHistoryButton_Click(object sender, EventArgs e)
        {
            createSelectedMatchHistory();           //Finds history for selected match & all champion masteries for all participants
        }

        public async Task createChampionMasteryHistory(string ID, int index)
        {
            await PopulateChampionMasteryHistory(ID, index);
        }

        public async Task PopulateChampionMasteryHistory(string ID, int index)
        {
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/" + ID + "?api_key=RGAPI-6dad0715-7e7c-40ae-a0c5-e2f1de04747d");
            if (response != null)
            {
                championMastery temp = new championMastery();
                string jsonString = await response.Content.ReadAsStringAsync();
                temp.championMasteries = JsonConvert.DeserializeObject<List<championMastery.ChampionMasteryDTO>>(jsonString);
                this.championMasteryList.Add(temp);
            }
        }

        public async void createSelectedMatchHistory()
        {
            await PopulateSelectedMatchHistory();
        }

        public async Task PopulateSelectedMatchHistory()
        {
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/match/v4/matches/" + matchHistory.matches[matchNumberBox.SelectedIndex].gameId + "?api_key=RGAPI-6dad0715-7e7c-40ae-a0c5-e2f1de04747d");

            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                matchData = JsonConvert.DeserializeObject<matchData>(jsonString);

                for (int i = 0; i < 10; i++)
                {
                    await createChampionMasteryHistory(matchData.participantIdentities[i].player.summonerId, i); //Finds champion mastery data for all 10 participants in a game
                }
            }
        }
    }
}