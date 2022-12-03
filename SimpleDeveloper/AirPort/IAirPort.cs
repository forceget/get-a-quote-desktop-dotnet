using AirPort;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPort
{
    public interface IAirPort 
    {
        MAirPort.Root MultipleGet(MAirPort.FilterForm form);
    }
}
