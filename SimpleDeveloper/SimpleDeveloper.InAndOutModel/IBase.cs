using Port;
using System;
using System.Collections.Generic;
using System.Text;

namespace Port
{
     public partial interface IBase<T,T1,T2>
    {

        ResponseBase<List<T>> MultipleGet(T2 form);


    }

    public partial interface IBase2<T, T1, T2>
    {
       
    }
}
