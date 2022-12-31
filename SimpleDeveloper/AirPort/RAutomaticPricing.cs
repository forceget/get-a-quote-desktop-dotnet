using AutomaticPricing;
using City;
using Forceget.Apilibrary;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;

namespace State
{
    public class RAutomaticPricing : IAutomaticPricing
    {

        public MAutomaticPricing.Root GetAQuate(MAutomaticPricing.Form form)
        {

            MAutomaticPricing.Root rb = new MAutomaticPricing.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddParameter("FromLocationId", form.FromLocationId);
                request.AddParameter("FromLocationCountryId", form.FromLocationCountryId);
                request.AddParameter("FromType", form.FromType);

                request.AddParameter("ToLocationId", form.ToLocationId);
                request.AddParameter("ToLocationCountryId", form.ToLocationCountryId);
                request.AddParameter("ToType", form.ToType);
                
                request.AddParameter("ProductAmount", form.ProductAmount);
                request.AddParameter("ProductReadyDate", form.ProductReadyDate);
                request.AddParameter("ShipmentLoadType", form.ShipmentLoadType);
                request.AddParameter("CustomsClearance", form.CustomsClearance);
                request.AddParameter("Insurance", form.Insurance);
                request.AddParameter("HazardousGoods", form.HazardousGoods);

                request.AddParameter("Email", form.Email);
                request.AddParameter("FirstName", form.FirstName);
                request.AddParameter("LastName", form.LastName);
                request.AddParameter("PhoneNumber", form.PhoneNumber);
                request.AddParameter("CompanyName", form.CompanyName);
                request.AddParameter("CompanyId", form.CompanyId);
                if (form.Packages != null)
                {
                    foreach (var item in form.Packages)
                    {
                        request.AddParameter("Packages[0].TotalUnit", item.TotalUnit);
                        request.AddParameter("Packages[0].Length", item.Length);
                        request.AddParameter("Packages[0].Height", item.Height);
                        request.AddParameter("Packages[0].Weight", item.Weight);
                        request.AddParameter("Packages[0].Width", item.Width);
                        request.AddParameter("Packages[0].MetricType", item.MetricType);
                        request.AddParameter("Packages[0].PackageTypeId", item.PackageTypeId);
                    }
                }
                else
                {
                    foreach (var item in form.Containers)
                    {
                        request.AddParameter("Containers[0].Size", item.Size);
                        request.AddParameter("Containers[0].TotalUnit", item.TotalUnit);
                    }
                }

                var response = RNetworkingOperation.Post<MAutomaticPricing.Root>(Config.Server + "/api/AutomaticPricing/GetAQuote", request);

                return response;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
