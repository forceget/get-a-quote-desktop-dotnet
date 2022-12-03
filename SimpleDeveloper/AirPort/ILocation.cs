using Location;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Location
{
    public interface ILocation 
    {
        MLocation.Root MultipleGet(MLocation.FilterForm form);
    }
}
