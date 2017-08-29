using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processRunner
{
    interface process
    {
        bool execute(out string message);
    }
}
