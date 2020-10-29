﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    public partial class newActiveGameWindow : Form
    {
        HttpClient client = new HttpClient();
        private CurrentGameStats stats = new CurrentGameStats();
        private List<championMastery> fullChampionMasteryList = new List<championMastery>();
        private List<currentChampMastery> currentChamp = new List<currentChampMastery>();
        
        Champion champion = new Champion();
        public newActiveGameWindow(string accountId, Champion champion)
        {
            InitializeComponent();
            this.champion = champion;
            createActiveGameStats(accountId);
        }

        public void findCurrentChampMastery() {                          
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < fullChampionMasteryList[i].championMasteries.Count; j++)
                {
                    if (stats.participants[i].championId == fullChampionMasteryList[i].championMasteries[j].championId) {
                        currentChampMastery temp = new currentChampMastery("");
                        currentChamp.Add(temp); 
                        currentChamp[i].summonerName = fullChampionMasteryList[i].summonerName;
                        currentChamp[i].currentMastery.championId = fullChampionMasteryList[i].championMasteries[j].championId;
                        currentChamp[i].currentMastery.championLevel = fullChampionMasteryList[i].championMasteries[j].championLevel;
                        currentChamp[i].currentMastery.championName = fullChampionMasteryList[i].championMasteries[j].championName;
                        currentChamp[i].currentMastery.championPoints = fullChampionMasteryList[i].championMasteries[j].championPoints;
                        currentChamp[i].currentMastery.summonerId = fullChampionMasteryList[i].championMasteries[j].summonerId;
                    }
                }
            }
        }

        private void newActiveGameWindow_Load(object sender, EventArgs e)
        {
        }

        public async void createActiveGameStats(string accountId)
        {
            await PopulateGameStats(accountId);
            if (stats.participants != null)
            {
                await createChampionMasteryHistory();
            }
        }

        public async Task PopulateGameStats(string accountId)
        {
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/spectator/v4/active-games/by-summoner/" + accountId + "?api_key=RGAPI-773a429c-c92d-49be-926c-b9275c8a0e3d");
            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                stats = JsonConvert.DeserializeObject<CurrentGameStats>(jsonString);
                if (stats.participants == null) {
                    MessageBox.Show("Selected player is not in a game currently!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async Task createChampionMasteryHistory()
        {
            for (int i = 0; i < 10; i++)
            {
                await PopulateChampionMasteryHistory(stats.participants[i].summonerId, i); //Finds champion mastery data for all 10 participants in a game
            }
            findCurrentChampMastery();
        }
        public async Task PopulateChampionMasteryHistory(string ID, int index)
        {
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/" + ID + "?api_key=RGAPI-773a429c-c92d-49be-926c-b9275c8a0e3d");
            if (response != null)
            {
                championMastery temp = new championMastery();
                string jsonString = await response.Content.ReadAsStringAsync();
                temp.championMasteries = JsonConvert.DeserializeObject<List<championMastery.ChampionMasteryDTO>>(jsonString);
                this.fullChampionMasteryList.Add(temp);
                this.fullChampionMasteryList[index].summonerName = stats.participants[index].summonerName;              //Uses participant data to insert summoner name into mastery list 

                for (int i = 0; i < this.fullChampionMasteryList[index].championMasteries.Count; i++)                           //This adds champion names to all champion IDs in mastery.
                {
                    int temp2 = Convert.ToInt32(this.fullChampionMasteryList[index].championMasteries[i].championId);
                    champion.keys.TryGetValue(temp2, out string temp3);
                    this.fullChampionMasteryList[index].championMasteries[i].championName = temp3;
                }
            }
        }
    }
}