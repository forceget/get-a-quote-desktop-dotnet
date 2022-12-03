using Token;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Token
{
    public interface IToken
    {
        MToken.Root Login(MToken.FilterForm form);
    }
}
