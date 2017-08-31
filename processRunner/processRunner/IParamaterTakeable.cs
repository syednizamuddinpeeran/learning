using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public interface IParamaterTakeable
    {
        bool SetParameters(List<IParameteriseAble> parameterList);
        bool SetParameter(IParameteriseAble parameter);
        List<IParameteriseAble> GetParameters();
        IParameteriseAble GetParameter();

    }
}