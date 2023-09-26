using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace B07_daily_life
{
    internal class Score
    {

        public Score(string iUserName,DateTime iBegin, DateTime iEnd,int iTimeTook,double dScore) { 
            userName = iUserName;
            begin= iBegin;
            end= iEnd;
            timeTook= iTimeTook;
            score = dScore;
        }

        public string userName { get; set; }
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
        public int timeTook { get; set; }
        public double score { get; set; }

        public void saveToJson()
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(@"\scores.json", json);
        }
        
    }
}
