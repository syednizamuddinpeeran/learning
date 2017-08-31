using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public interface IParamaterTakeable
    {
        void SetParameters(List<IParameteriseAble> parameterList);
        void SetParameter(string parameterName,IParameteriseAble parameter);
        List<IParameteriseAble> GetParameters();
        IParameteriseAble GetParameter(string paramaterName);
    }

    [Serializable]
    public class unknownParameterException : Exception
    {
        public unknownParameterException() { }
        public unknownParameterException(string message) : base(message) { }
        public unknownParameterException(string message, Exception inner) : base(message, inner) { }
        protected unknownParameterException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}