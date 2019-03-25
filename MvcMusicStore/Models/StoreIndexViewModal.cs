using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class StoreIndexViewModal
    {
        public int NumberOfGenres { get; set; }
        public List<string> Genres { get; set; }
    }
}