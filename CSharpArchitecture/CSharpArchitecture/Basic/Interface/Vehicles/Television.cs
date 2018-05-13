﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArchitecture.Basic.Interface.Vehicles
{
    // Because we implemented the 
    // ElectronicDevice interface any
    // other device we create will know
    // exactly how to interface with it.
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }
    }
}
