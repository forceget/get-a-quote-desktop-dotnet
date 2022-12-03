using City;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public interface ICity 
    {
        MCity.Root MultipleGet(MCity.FilterForm form);
    }
}
