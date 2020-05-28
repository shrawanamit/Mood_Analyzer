using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyzer
{
    public class Mood
    {
        public string analyzerMood(string massage)
        {
            if (massage == "I am in any mood")
            {
                return "Happy";
            }
            else
            {
                return "Sad";
            }
        }
    }
}
