using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuraanAPI
{

    public class Suras
    {
        public int code { get; set; }
        public string status { get; set; }
        public SuraData[] data { get; set; }
    }

    public class SuraData
    {
        public int number { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public string englishNameTranslation { get; set; }
        public int numberOfAyahs { get; set; }
        public string revelationType { get; set; }
    }


}
