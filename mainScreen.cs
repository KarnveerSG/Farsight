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
        private summonerContainer userList = new summonerContainer();
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
    }
}
