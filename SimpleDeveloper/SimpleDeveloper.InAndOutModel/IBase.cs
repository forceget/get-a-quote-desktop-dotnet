using Port;
using System;
using System.Collections.Generic;
using System.Text;

namespace Port
{
     public partial interface IBase<T,T1,T2>
    {
        ResponseBase<T> SingleGet(string id, string currentUserId);

        ResponseBase<List<T>> MultipleGet(T2 form);

        ResponseBase<T> Add(T1 form, string currentUserId);

        ResponseBase<T> Update(T1 form, string currentUserId);

        ResponseBase<string> Delete(string id, string currentUserId);

        ResponseBase<string> Delete(T2 form, string currentUserId);

    }

    public partial interface IBase2<T, T1, T2>
    {
        ResponseBase<T> SingleGet(int id, string currentUserId);

        ResponseBase<List<T>> MultipleGet(T2 form, string currentUserId);

        ResponseBase<T> Add(T1 form, string currentUserId);

        ResponseBase<T> Update(T1 form, string currentUserId);

        ResponseBase<string> Delete(int id, string currentUserId);

        ResponseBase<string> Delete(T2 form, string currentUserId);

    }
}
