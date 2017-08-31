using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public interface IParameteriseAble
    {
        string GetName();
        object GetValue();
        void SetName(string name);
        void SetValue(object value);
    }


    [Serializable]
    public class TypeMismatchException : Exception
    {
        public Type ExpectedType;
        public Type RecievedType;

        public TypeMismatchException()
        {
        }

        public TypeMismatchException(string message) : base(message)
        {
        }

        public TypeMismatchException(string message, Exception inner) : base(message, inner)
        {
        }
        protected TypeMismatchException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public TypeMismatchException(Type expected, Type actual)
        {
            ExpectedType = expected;
            RecievedType = actual;
        }
    }
}