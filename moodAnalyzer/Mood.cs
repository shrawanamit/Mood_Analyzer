using System;
using MoodAnalyzer;

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
                if(this.massage == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.ENTERED_NULL, "Please Enter Proper Mood");
                }

                if (massage.Contains("I am in Sad Mood"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (MoodAnalyzerException)
            {
                return "Happy";
            }

        }
    }
}
