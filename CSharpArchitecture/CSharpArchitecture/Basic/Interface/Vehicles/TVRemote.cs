using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArchitecture.Basic.Interface.Vehicles
{
    class TVRemote
    {
        // Now we are modeling the action of
        // picking up the remote with our hand
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
