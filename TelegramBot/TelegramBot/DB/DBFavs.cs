using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.GetTrack;

namespace TelegramBot.DB
{
    public class DBFavs
    {
        public string id { get; set; }
        public List<SearchTrackMain> jsresults = new List<SearchTrackMain>();
    }
}
