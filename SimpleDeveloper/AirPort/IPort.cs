﻿using Port;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Port
{
    public interface IPort 
    {
        MPort.Root MultipleGet(MPort.FilterForm form);
    }
}
