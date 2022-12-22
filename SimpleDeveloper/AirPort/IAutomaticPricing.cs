using AutomaticPricing;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticPricing
{
    public interface IAutomaticPricing 
    {
        MAutomaticPricing.Root GetAQuate(MAutomaticPricing.Form form);
    }
}
