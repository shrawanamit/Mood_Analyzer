using NUnit.Framework;
using moodAnalyzer;
using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_GivenMessageContainsSad_ShouldReturnSad()
        {
            Mood mood = new Mood("I am in Sad Mood");
            string result = mood.analyzerMood();
            Assert.AreEqual("Sad", result);
        }

        [Test]
        public void When_GivenMessageAnyMood_ShouldReturnHappy()
        {
            Mood mood = new Mood("I am in Any Mood");
            string result = mood.analyzerMood();
            Assert.AreEqual("Happy", result);
        }


        [Test]
        public void givenMassageNull_AfterAnalyser_shouldReturnEqualResult()
        {
            try
            {
                Mood mood = new Mood(null);
                string result = mood.analyzerMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

        [Test]
        public void givenMassageEmpty_AfterAnalyser_shouldReturnEqualResult()
        {
            try
            {
                Mood mood = new Mood(" ");
                string result = mood.analyzerMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.ENTERED_EMPTY, e.type);
            }
        }

        [Test]
        public void givenMoodAnalyser_whenProper_shouldReturnObject()
        {
            object reflactionObj = MoodAnalyzerFactory.createObjectUsingReflaction("moodAnalyzer.Mood");
            Mood mood = new Mood();
            bool actual = mood.Equals(reflactionObj);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void givenMoodAnalyserModdClass_whenInProper_shouldReturnNoSuchClass()
        {

            try
            {
                object reflactionObj = MoodAnalyzerFactory.createObjectUsingReflaction("moodAnalyzer.mood");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS_EXCEPTION, e.type);
            }
        }
    }
}