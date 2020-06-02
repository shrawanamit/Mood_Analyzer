using System;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_CLASS_EXCEPTION, NO_SUCH_METHOD_EXCEPTION, NO_SUCH_FIELD_EXCEPTION, FIELD_INFO_NULL, FIELD_VALUE_NULL
        }
        public ExceptionType type;

        public MoodAnalyzerException(ExceptionType type,string message) : base(message)
        {
           this.type = type;
        }
    }
}
