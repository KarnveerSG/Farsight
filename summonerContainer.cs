using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Blue_Ward
{  
    class summonerContainer
    {
        private User[] users = new User[10];

        public summonerContainer()
        {
            
        }

        public string getSummonerName(int index)
        {
            return users[index].name;
        }


    }
}
