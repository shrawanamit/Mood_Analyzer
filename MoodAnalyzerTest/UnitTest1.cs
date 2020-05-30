using NUnit.Framework;
using moodAnalyzer;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenMassageHappyAndSad_AfterAnalyser_shouldReturnEqualResult()
        {
            Mood mood = new Mood(null);
            string result = mood.analyzerMood();
            Assert.AreEqual("Happy", result);
        }
    }
}