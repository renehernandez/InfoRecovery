using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core
{
    public interface IEntryModulePoint
    {

        void ProcessJson(string inputJsonPath, string outputJsonPath);

    }
}
