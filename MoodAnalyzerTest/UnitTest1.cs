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
        //testCase 1.1:massage I am in Sad Mood analyser return sad
        [Test]
        public void WhenGivenMessageContainsSad_WhenProper_ShouldReturnSad()
        {
            Mood mood = new Mood("I am in Sad Mood");
            string result = mood.analyzerMood();
            Assert.AreEqual("Sad", result);
        }

        //testCase 1.2:massage I am in Any Mood analyser return Happy
        [Test]
        public void When_GivenMessageAnyMood_ShouldReturnHappy()
        {
            Mood mood = new Mood("I am in Any Mood");
            string result = mood.analyzerMood();
            Assert.AreEqual("Happy", result);
        }

        ////testCase 3.1:given message null throwException
        [Test]
        public void givenMassageNull_AfterAnalyser_shouldthrowException()
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
        //testCase 3.2:given message Empty throwException
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
        //testCase 4.1:given class name return object through reflaction
        [Test]
        public void givenMoodAnalyser_whenProper_shouldReturnObject()
        {
            object reflactionObj = MoodAnalyzerReflecter.createObjectUsingReflaction("moodAnalyzer.Mood");
            Mood mood = new Mood();
            bool actual = mood.Equals(reflactionObj);
            Assert.AreEqual(false, actual);
        }
        //testCase 4.2:given class name improper return object through reflaction
        [Test]
        public void givenMoodAnalyserModdClass_whenInProper_shouldReturnNoSuchClass()
        {

            try
            {
                object reflactionObj = MoodAnalyzerReflecter.createObjectUsingReflaction("moodAnalyzer.mood");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS_EXCEPTION, e.type);
            }
        }
        //testCase 5.1:given parmeter constructer return object through reflaction
        [Test]
        public void givenMoodAnalyserWithParameteriseConstructer_whenProper_shouldReturnObject()
        {
            object reflactionObj = MoodAnalyzerReflecter.createObjectUsingReflaction("moodAnalyzer.Mood", "I am in Sad Mood");
            Mood mood = new Mood("I am in Sad Mood");
            bool actual = mood.Equals(reflactionObj);
            Assert.AreEqual(false, actual);
        }

        ////testCase 5.1:given parmeter constructer improper return object through reflaction
        [Test]
        public void givenMoodAnalyserWithParameteriseConstructer_whenInProper_shouldReturnNoSuchClass()
        {

            try
            {
                object reflactionObj = MoodAnalyzerReflecter.createObjectUsingReflaction("moodAnalyzer.mood");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS_EXCEPTION, e.type);
            }
        }

        // //useCase 6.1:invoke method using reflaction
        [Test]
        public void givenMoodAnalyserMethod_whenProper_shouldReturnProperMessage()
        {
            object value = MoodAnalyzerReflecter.invokeMethodUsingReflaction("analyzerMood");
            Assert.AreEqual("Happy", value);
        }

        // //useCase 6.2:imProper methodName through exception
        [Test]
        public void givenMoodAnalyserImproperMethod_whenProper_shouldReturnProperMessage()
        {
            try
            {
                object value = MoodAnalyzerReflecter.invokeMethodUsingReflaction("analyzermood");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD_EXCEPTION, e.type);
            }
        }

         //useCase 7.1:set field value Dynamic using reflaction
        [Test]
        public void givenMoodAnalyserMethod_whenSetFieldDynamicaly_shouldReturnProperMessage()
        {
            object value = MoodAnalyzerReflecter.setFieldUsingReflaction("analyzerMood","massege", "I am in Happy Mood");
            Assert.AreEqual("Happy", value);
        }

        //useCase 7.2:field name inProper through exception
        [Test]
        public void givenMoodAnalyserImproperField_whenInProper_shouldThrowException()
        {
            try
            {
                object value = MoodAnalyzerReflecter.setFieldUsingReflaction("analyzerMood", "Massege", "I am in Sad Mood");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD_EXCEPTION, e.type);
            }
        }

        //useCase 7.3:field value set null through exception
        [Test]
        public void givenProperField_SetNull_shouldThrowException()
        {
            try
            {
                object value = MoodAnalyzerReflecter.setFieldUsingReflaction("analyzerMood", "massege",null);
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD_EXCEPTION, e.type);
            }
        }
    }
}