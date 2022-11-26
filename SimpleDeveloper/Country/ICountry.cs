using Country;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Country
{
    public interface ICountry : IBase<MCountry.Response, MCountry, MCountry.FilterForm>
    {

    }
}
