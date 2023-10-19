using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace B07_daily_life
{
    internal class Score
    {

        public Score(string? userName, DateTime begin, DateTime end, int timeTook, double score)
        {
            this.userName = userName;
            this.begin = begin;
            this.end = end;
            this.timeTook = timeTook;
            this.score = score;
        }

        public string? userName { get; set; }
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
        public int timeTook { get; set; }
        public double score { get; set; }

        public void saveToJson()
        {
            string json = JsonSerializer.Serialize(this);
            DateTime now = DateTime.Now;

            File.WriteAllText(@".\scores_"+ now.Day + "_" + now.Hour + "_" + now.Minute + ".json",json);
            
        }

    }
}
