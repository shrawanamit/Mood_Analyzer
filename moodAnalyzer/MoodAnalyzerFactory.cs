using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyzer
{
    public  class MoodAnalyzerFactory
    {
        public static object createObjectUsingReflaction(string className)
        {
            Type type = Type.GetType(className);
            if(type == null)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS_EXCEPTION,"please enter proper class");
            }
            try
            {
                var objInstance = Activator.CreateInstance(type);
                if(objInstance == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD_EXCEPTION, "please enter proper method");
                }
                return objInstance;
            }
            catch(MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD_EXCEPTION, "please enter proper method");
            }
        }
    }
}
