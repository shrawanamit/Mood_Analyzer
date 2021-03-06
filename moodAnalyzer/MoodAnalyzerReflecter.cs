﻿using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace moodAnalyzer
{
    public  class MoodAnalyzerReflecter

    {
        //create Object Using Reflaction
        public static object createObjectUsingReflaction(string className, params object[] message)
        {
            Type type = Type.GetType(className);
            if (type == null)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS_EXCEPTION, "please enter proper class");
            }
            try
            {
                var objInstance = Activator.CreateInstance(type,message);
                if (objInstance == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD_EXCEPTION, "please enter proper method");
                }
                return objInstance;
            }
            catch (MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD_EXCEPTION, "please enter proper method");
            }
        }

        //invoke Method Using Reflaction return Happy
        public static object invokeMethodUsingReflaction(string methodName)
        {
            Type moodAnalyserType = Type.GetType("moodAnalyzer.Mood");
            MethodInfo methodInfo = moodAnalyserType.GetMethod(methodName);
            string[] moodMassege = { "I am in Happy Mood" };
            object objInstance = Activator.CreateInstance(moodAnalyserType, moodMassege);
            try
            {
                string returnValue = null;
                if (methodInfo != null)
                {

                    returnValue = (string)methodInfo.Invoke(objInstance, null);
                    
                }
                return returnValue;
            }
            catch(MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD_EXCEPTION, "please enter proper method");
            }
        }

        //set field value Dynamicaly
        public static object setFieldUsingReflaction(string methodName,string fieldName,string fieldValue)
        {
            Type moodAnalyserType = Type.GetType("moodAnalyzer.Mood");
            MethodInfo methodInfo = moodAnalyserType.GetMethod(methodName);
            string[] moodMassege = { "I am in Sad Mood" };
            object objInstance = Activator.CreateInstance(moodAnalyserType, moodMassege);
            try
            {
                string returnValue = null;
                if (fieldName != null)
                {
                    try
                    {
                        FieldInfo fieldInfo = moodAnalyserType.GetField(fieldName);
                        try { 
                            fieldInfo.SetValue(objInstance, fieldValue); 
                        }
                        catch (MoodAnalyzerException)
                        {
                            throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.FIELD_VALUE_NULL, "please enter proper field");
                        }
                    }
                    catch (MoodAnalyzerException)
                    {
                        throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.FIELD_INFO_NULL, "please enter proper field");
                    }
                }
                if (methodInfo != null)
                {

                    returnValue = (string)methodInfo.Invoke(objInstance, null);

                }
                return returnValue;
            }
            catch (MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD_EXCEPTION, "please enter proper method");
            }


        }
    }
}
