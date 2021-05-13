using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleQuiz.Models
{
    public class KvizPitanje
    {
        public String pitanje { get; set; }
        public String[] odgovori { get; set; }
        public int tacanOdgovor { get; set; }

        public KvizPitanje()
        {
            odgovori = new String[4];
        }
    }
}
