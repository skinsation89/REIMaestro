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
    /// Interaction logic for RentalRatesView.xaml
    /// </summary>
    public partial class RentalRatesView : UserControl
    {
        
        

        public RentalRatesView()
        {
            InitializeComponent();

            
        }

        public async Task<RentalRatesModel> LoadRentalRates()
        {
            

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://mashvisor-api.p.rapidapi.com/rental-rates?state={ StateText.Text }&source={ SourceText.Text }&city={ CityText.Text }&zip_code={ ZipCodeText.Text }"),
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
                    StatusModel status = await response.Content.ReadAsAsync<StatusModel>();

                    return status.Content.Retnal_Rates;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<SampleModel>> LoadDetails()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://mashvisor-api.p.rapidapi.com/rental-rates?state={ StateText.Text }&source={ SourceText.Text }&city={ CityText.Text }&zip_code={ ZipCodeText.Text }"),
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
                    SampleStatusModel status = await response.Content.ReadAsAsync<SampleStatusModel>();

                    return status.Content.Detailed;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
             var r = await LoadRentalRates();
             var d = await LoadDetails();

            studio.Text = r.Studio_Value.ToString();
            one.Text = r.One_Room_Value.ToString();
            two.Text = r.Two_Room_Value.ToString();
            three.Text = r.Three_Room_Value.ToString();
            four.Text = r.Four_Room_Value.ToString();

            
            stateOne.Text = d[0].State;
            cityOne.Text = d[0].City;
            zipcodeOne.Text = d[0].ZipCode;
            bedsOne.Text = d[0].Beds;
            countOne.Text = d[0].Count.ToString();
            minOne.Text = d[0].Min.ToString();
            maxOne.Text = d[0].Max.ToString();
            avgOne.Text = d[0].Avg.ToString();
            medianOne.Text = d[0].Median.ToString();
            adjustedRentOne.Text = d[0].Adjusted_Rental_Income.ToString();
            medianRateOne.Text = d[0].Median_Night_Rate.ToString();
            medianOccupancyOne.Text = d[0].Median_Occupancy.ToString();

            stateTwo.Text = d[1].State;
            cityTwo.Text = d[1].City;
            zipcodeTwo.Text = d[1].ZipCode;
            bedsTwo.Text = d[1].Beds;
            countTwo.Text = d[1].Count.ToString();
            minTwo.Text = d[1].Min.ToString();
            maxTwo.Text = d[1].Max.ToString();
            avgTwo.Text = d[1].Avg.ToString();
            medianTwo.Text = d[1].Median.ToString();
            adjustedRentTwo.Text = d[1].Adjusted_Rental_Income.ToString();
            medianRateTwo.Text = d[1].Median_Night_Rate.ToString();
            medianOccupancyTwo.Text = d[1].Median_Occupancy.ToString();

            stateThree.Text = d[2].State;
            cityThree.Text = d[2].City;
            zipcodeThree.Text = d[2].ZipCode;
            bedsThree.Text = d[2].Beds;
            countThree.Text = d[2].Count.ToString();
            minThree.Text = d[2].Min.ToString();
            maxThree.Text = d[2].Max.ToString();
            avgThree.Text = d[2].Avg.ToString();
            medianThree.Text = d[2].Median.ToString();
            adjustedRentThree.Text = d[2].Adjusted_Rental_Income.ToString();
            medianRateThree.Text = d[2].Median_Night_Rate.ToString();
            medianOccupancyThree.Text = d[2].Median_Occupancy.ToString();

            stateFour.Text = d[3].State;
            cityFour.Text = d[3].City;
            zipcodeFour.Text = d[3].ZipCode;
            bedsFour.Text = d[3].Beds;
            countFour.Text = d[3].Count.ToString();
            minFour.Text = d[3].Min.ToString();
            maxFour.Text = d[3].Max.ToString();
            avgFour.Text = d[3].Avg.ToString();
            medianFour.Text = d[3].Median.ToString();
            adjustedRentFour.Text = d[3].Adjusted_Rental_Income.ToString();
            medianRateFour.Text = d[3].Median_Night_Rate.ToString();
            medianOccupancyFour.Text = d[3].Median_Occupancy.ToString();

            stateFive.Text = d[4].State;
            cityFive.Text = d[4].City;
            zipcodeFive.Text = d[4].ZipCode;
            bedsFive.Text = d[4].Beds;
            countFive.Text = d[4].Count.ToString();
            minFive.Text = d[4].Min.ToString();
            maxFive.Text = d[4].Max.ToString();
            avgFive.Text = d[4].Avg.ToString();
            medianFive.Text = d[4].Median.ToString();
            adjustedRentFive.Text = d[4].Adjusted_Rental_Income.ToString();
            medianRateFive.Text = d[4].Median_Night_Rate.ToString();
            medianOccupancyFive.Text = d[4].Median_Occupancy.ToString();

            stateSix.Text = d[5].State;
            citySix.Text = d[5].City;
            zipcodeSix.Text = d[5].ZipCode;
            bedsSix.Text = d[5].Beds;
            countSix.Text = d[5].Count.ToString();
            minSix.Text = d[5].Min.ToString();
            maxSix.Text = d[5].Max.ToString();
            avgSix.Text = d[5].Avg.ToString();
            medianSix.Text = d[5].Median.ToString();
            adjustedRentSix.Text = d[5].Adjusted_Rental_Income.ToString();
            medianRateSix.Text = d[5].Median_Night_Rate.ToString();
            medianOccupancySix.Text = d[5].Median_Occupancy.ToString();

            stateSeven.Text = d[6].State;
            citySeven.Text = d[6].City;
            zipcodeSeven.Text = d[6].ZipCode;
            bedsSeven.Text = d[6].Beds;
            countSeven.Text = d[6].Count.ToString();
            minSeven.Text = d[6].Min.ToString();
            maxSeven.Text = d[6].Max.ToString();
            avgSeven.Text = d[6].Avg.ToString();
            medianSeven.Text = d[6].Median.ToString();
            adjustedRentSeven.Text = d[6].Adjusted_Rental_Income.ToString();
            medianRateSeven.Text = d[6].Median_Night_Rate.ToString();
            medianOccupancySeven.Text = d[6].Median_Occupancy.ToString();




        }   
    }
}
