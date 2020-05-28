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
            Mood mood = new Mood();
            string result = mood.analyzerMood("I am in any mood");
            Assert.AreEqual("Sad", result);
        }
    }
}