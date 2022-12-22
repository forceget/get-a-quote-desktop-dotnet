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

                request.AddParameter("Packages", form.Packages);
                request.AddParameter("Containers", form.Containers);
                request.AddParameter("ProductAmount", form.ProductAmount);
                request.AddParameter("ProductReadyDate", form.ProductReadyDate);
                request.AddParameter("ShipmentLoadType", form.ShipmentLoadType);
                request.AddParameter("CustomsClearance", form.CustomsClearance);
                request.AddParameter("Insurance", form.Insurance);

                request.AddParameter("Email", "analyn@titansourcing.com");
                request.AddParameter("FirstName", "analyn");
                request.AddParameter("LastName", "titan");
                request.AddParameter("CompanyName", "TitanSourcing");
                request.AddParameter("AffilatePartnerId", "b592813a-df2a-4f66-aa66-5d80384f7053");
                request.AddParameter("PhoneNumber", "11");
                request.AddParameter("CompanyId", "0c79f71f-ec98-4b8d-9a9b-af9bf6a38ba5");


                var response = RNetworkingOperation.Post<MAutomaticPricing.Root>("https://localhost:44392/api/AutomaticPricing/GetAQuote", request);

                return response;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
