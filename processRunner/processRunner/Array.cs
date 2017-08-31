using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public class Array : IParameteriseAble, IParamaterTakeable
    {
        private string _name;

        private Number _lengthOftheArray;

        private List<IParameteriseAble> _Array;

        public string GetName()
        {
            return _name;
        }

        public object GetValue()
        {
            return this;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetValue(object value)
        {
            if (value is Array)
            {
                SetParameters(((IParamaterTakeable)value).GetParameters());
            }
            else
            {
                throw new TypeMismatchException(this.GetType(),value.GetType());
            }
        }

        public void SetParameters(List<IParameteriseAble> parameterList)
        {
            foreach (IParameteriseAble param in parameterList)
            {
                SetParameter(param.GetName(), param);
            }
        }

        public void SetParameter(string parameterName, IParameteriseAble parameter)
        {
            switch (parameterName)
            {
                case "LengthOfTheArray":
                    SetLengthOfTheArray(parameter);
                    break;
                case "Array":
                    SetArray(parameter);
                    break;
                default:
                    throw new TypeMismatchException();
            }
        }

        public List<IParameteriseAble> GetParameters()
        {
            throw new NotImplementedException();
        }

        public IParameteriseAble GetParameter(string paramaterName)
        {
            throw new NotImplementedException();
        }

        #region PrivateMethods
        private void SetLengthOfTheArray(IParameteriseAble param)
        {
            if (param is Number)
            {
                // need work here
                throw new Exception("The property cannot be set because its read only");
            }
            else
            {
                throw new TypeMismatchException(_lengthOftheArray.GetType(), param.GetType());
            }
        }
        private void SetArray(IParameteriseAble param)
        {
            if (param.GetValue() is List<IParameteriseAble>)
            {
                _Array = (List<IParameteriseAble>)param.GetValue();
                _lengthOftheArray = new Number("LengthOfTheArray", _Array.Count );
            }
            else
            {
                throw new TypeMismatchException(_Array.GetType(), param.GetType());
            }
        } 
        #endregion
    }
}