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
            Mood mood = new Mood("I am in happy mood");
            string result = mood.analyzerMood();
            Assert.AreEqual("Sad", result);
        }
    }
}