using State;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IState 
    {
        MState.Root MultipleGet(MState.FilterForm form);
    }
}
