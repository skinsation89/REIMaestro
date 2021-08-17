using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class SampleModel
    {
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Beds { get; set; }
        public decimal Count { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Avg { get; set; }
        public decimal Median { get; set; }
        public decimal Adjusted_Rental_Income { get; set; }
        public decimal Median_Night_Rate { get; set; }
        public decimal Median_Occupancy { get; set; }
    }
}
