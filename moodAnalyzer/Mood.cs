using System;
using MoodAnalyzer;

namespace moodAnalyzer
{
    public class Mood
    {
        string massege="amit";
        public Mood() { }
        public Mood(string massage) {
            this.massege = massage;
        }
        public string analyzerMood()
            {
            try {
                if(this.massege == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.ENTERED_NULL, "Please Enter Proper Mood");
                }

                if (massege.Contains("I am in Sad Mood"))
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
