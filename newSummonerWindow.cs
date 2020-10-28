using Newtonsoft.Json;
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
            HttpResponseMessage response = await client.GetAsync("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=RGAPI-a8d0fd7f-2073-4232-867b-ed5d4912e651");

            if (response != null)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                user = JsonConvert.DeserializeObject<User>(jsonString);
                this.mainScreen.setSummoner(user);
            }
        }

        private void summonerNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSummonerWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
