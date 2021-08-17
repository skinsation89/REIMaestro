using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateLibrary
{
    public class RentalRatesProcessor
    {
        public async Task<RentalRatesModel> LoadRentalRates(string state, string source, string city, int zipCode)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://mashvisor-api.p.rapidapi.com/rental-rates?state={ state }&source={ source }&city={ city }&zip_code={ zipCode }"),
                Headers =
            {
                { "x-rapidapi-key", "46579899c2msh2f6a49b3ceee042p1157aejsn194fd32ad0a2" },
                { "x-rapidapi-host", "mashvisor-api.p.rapidapi.com" },
            },
            };


            using (HttpResponseMessage response = await ApiHelper.ApiClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    RentalRatesParentModel result = await response.Content.ReadAsAsync<RentalRatesParentModel>();

                    return result.Retnal_Rates;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
