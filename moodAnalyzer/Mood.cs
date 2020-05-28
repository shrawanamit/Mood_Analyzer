using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyzer
{
    public class Mood
    {
        string massage;
        public Mood() { }
        public Mood(string massage) {
            this.massage = massage;
        }
        public string analyzerMood()
        {
            if (massage.Contains("I am in sad mood"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
