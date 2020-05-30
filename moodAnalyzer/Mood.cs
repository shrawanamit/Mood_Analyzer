using System;
using MoodAnalyzer;
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
            try {
                if (massage.Contains("I am in Sad Mood"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.ENTERED_NULL, "Please Enter Proper Mood");
            }

        }
    }
}
