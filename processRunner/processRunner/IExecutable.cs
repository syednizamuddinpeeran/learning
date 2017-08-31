using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public delegate void ProcessExecutionCompleteEventHandler(ProcessExecutionCompleteEventArgs e);


    public interface IExecutable
    {
        event ProcessExecutionCompleteEventHandler ExecutionComplete;

        bool Execute();
    }

}