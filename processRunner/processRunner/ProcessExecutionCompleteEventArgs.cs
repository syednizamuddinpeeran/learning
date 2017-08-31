using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public struct ProcessExecutionCompleteEventArgs
    {
        bool ErrorOccured;
        string ErrorCode;
        string ErrorMessage;
        DateTime TimeOfExecutionStart;
        DateTime TimeOfExecutionEnd;
    }
}