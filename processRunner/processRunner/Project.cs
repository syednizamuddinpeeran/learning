using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public class Project : IExecutable, IParameteriseAble, IParamaterTakeable
    {

        #region Execute implementation
        public event ProcessExecutionCompleteEventHandler ExecutionComplete;

        public bool Execute()
        {

            if (ExecutionComplete != null)
            {
                ExecutionComplete(new ProcessExecutionCompleteEventArgs());
            }
            throw new NotImplementedException();
        }


        #endregion

        #region Paramateriseable implementation
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public object GetValue()
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void SetValue(object value)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ParameterTakable implementation

        public List<IParameteriseAble> GetParameters()
        {
            throw new NotImplementedException();
        }

        public bool SetParameter(IParameteriseAble parameter)
        {
            throw new NotImplementedException();
        }

        public bool SetParameters(List<IParameteriseAble> parameterList)
        {
            throw new NotImplementedException();
        }

        public IParameteriseAble GetParameter()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}