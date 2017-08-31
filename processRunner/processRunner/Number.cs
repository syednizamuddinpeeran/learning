using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public class Number : IParameteriseAble
    {
        private string _name;
        private float _value;

        public string GetName()
        {
            return _name;
        }

        public object GetValue()
        {
            return _value;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetValue(object value)
        {
            if (value is float)
            {
                _value = (float)value;
            }
            else
            {
                throw new TypeMismatchException(this.GetType(),value.GetType());
            }
        }
    }
}