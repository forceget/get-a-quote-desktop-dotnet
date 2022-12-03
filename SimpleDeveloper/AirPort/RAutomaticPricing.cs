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

        public MAutomaticPricing.Root GetAQuate(MAutomaticPricing.FilterForm form)
        {

            MAutomaticPricing.Root rb = new MAutomaticPricing.Root();
            try
            {
                var request = new RestRequest(Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddParameter("ToLocationCountryId", "cd4928df-b552-4c56-8601-e861aac3a923");
                request.AddParameter("LastName", "Yolga");
                request.AddParameter("ProductReadyDate", "12/3/2022 12:00:00 AM");
                request.AddParameter("FromType", "Factory/Warehouse");
                request.AddParameter("ProductAmount", "1000");
                request.AddParameter("CompanyName", "Navimod");
                request.AddParameter("ToLocationId", "160bdff4-e11c-4e01-ad8f-a347debefc3f");
                request.AddParameter("Packages", "");
                request.AddParameter("ShipmentTypeId", "");
                request.AddParameter("FreightosNumber", "");
                request.AddParameter("Containers", "");
                request.AddParameter("FromLocationCountryId", "4f1799dd-8bf5-4fe1-a5f0-747ca4780319");
                request.AddParameter("ToType", "Amazon Fulfillment Center");
                request.AddParameter("AffilatePartnerId", "");
                request.AddParameter("PhoneNumber", "11");
                request.AddParameter("CompanyId", "");
                request.AddParameter("CustomsClearance", "2");
                request.AddParameter("ShipmentLoadType", "2");
                request.AddParameter("Insurance", "2");
                request.AddParameter("FromLocationId", "66f3e9ab-b8a4-4d1a-acc4-41d20cd326d5");
                request.AddParameter("Id", "");
                request.AddParameter("FirstName", "Nihan");
                request.AddParameter("Email", "nihanyolga84@gmail.com");
                request.AddParameter("Contains", "");

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
