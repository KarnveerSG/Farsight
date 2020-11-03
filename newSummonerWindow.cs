using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farsight
{
    public partial class newSummonerWindow : Form
    {
        private string summonerName;
        User user = new User();
        private mainScreen mainScreen;
        private string apiKey = "RGAPI-8818d132-30c9-43f1-8282-02034fab4c05";

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
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
