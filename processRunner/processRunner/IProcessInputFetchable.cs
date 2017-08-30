using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processRunner
{
    public interface IProcessInputFetchable
    {
        event System.EventHandler FetchInputComplete;

        bool FetchInput(string input);
    }

    public interface CopyOfIProcessInputFetchable
    {
        event System.EventHandler FetchInputComplete;

        bool FetchInput(string input);
    }
}