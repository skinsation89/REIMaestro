using RealEstateLibrary;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RealEstateWPF.Views
{
    /// <summary>
    /// Interaction logic for ShortTermView.xaml
    /// </summary>
    public partial class ShortTermView : UserControl
    {
        public ShortTermView()
        {
            InitializeComponent();
        }

        public async Task<List<NeighborHistoricalModel>> LoadNeighborHistorical()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://mashvisor-api.p.rapidapi.com/neighborhood/{ NeighborId.CaretIndex }/historical/airbnb?state={ State.Text }&average_by=occupancy&percentile_rate=1"),
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
                    NeighborHistoricalStatusModel status = await response.Content.ReadAsAsync<NeighborHistoricalStatusModel>();

                    return status.Content.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var n = await LoadNeighborHistorical();

            janYear.Text = n[0].Year.ToString();
            janValue.Text = n[0].Value.ToString();

            febYear.Text = n[1].Year.ToString();
            febValue.Text = n[1].Value.ToString();

            marchYear.Text = n[2].Year.ToString();
            marchValue.Text = n[2].Value.ToString();

            aprilYear.Text = n[3].Year.ToString();
            aprilValue.Text = n[3].Value.ToString();

            mayYear.Text = n[4].Year.ToString();
            mayValue.Text = n[4].Value.ToString();

            juneYear.Text = n[5].Year.ToString();
            juneValue.Text = n[5].Value.ToString();

            julyYear.Text = n[6].Year.ToString();
            julyValue.Text = n[6].Value.ToString();

            augustYear.Text = n[7].Year.ToString();
            augustValue.Text = n[7].Value.ToString();

            sepYear.Text = n[8].Year.ToString();
            sepValue.Text = n[8].Value.ToString();

            octYear.Text = n[9].Year.ToString();
            octValue.Text = n[9].Value.ToString();

            novYear.Text = n[10].Year.ToString();
            novValue.Text = n[10].Value.ToString();

            decYear.Text = n[11].Year.ToString();
            decValue.Text = n[11].Value.ToString();

                
                
            
        }

        public async Task<MarketSummaryModel> LoadMarketSummary()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://mashvisor-api.p.rapidapi.com/airbnb-property/market-summary?state={ marketState.Text }&city={ marketCity.Text }"),
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
                    MarketSummaryStatusModel status = await response.Content.ReadAsAsync<MarketSummaryStatusModel>();

                    return status.Content.Occupancy_Histogram;
                } 
                else if (response.IsSuccessStatusCode)
                {
                    MarketSummaryStatusModel status = await response.Content.ReadAsAsync<MarketSummaryStatusModel>();

                    return status.Content.Night_Price_Histogram;
                }
                else if (response.IsSuccessStatusCode)
                {
                    MarketSummaryStatusModel status = await response.Content.ReadAsAsync<MarketSummaryStatusModel>();

                    return status.Content.Rental_Income_Histogram;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private async void MarketSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var m = await LoadMarketSummary();

            avgOcc.Text = m.Average_Occupancy.ToString();
            avgPrice.Text = m.Average_Price.ToString();
            avgRent.Text = m.Average_Rental_Income.ToString();
        }
    }
}
