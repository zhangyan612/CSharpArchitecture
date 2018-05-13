﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArchitecture.Basic.Interface.Vehicles
{
    interface ICommand
    {
        // We can model what happens when
        // a button is pressed for example
        // a power button. By breaking
        // everything down we can add
        // an infinite amount of flexibility
        void Execute();
        void Undo();
    }
}
