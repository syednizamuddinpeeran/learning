using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public delegate void ProcessExecutionCompleteEventHandler();

    public interface IProcessExecutable
    {
        event ProcessExecutionCompleteEventHandler ExecutionComplete;

        bool Execute(out string ErrorMessage);
    }

}