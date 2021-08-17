using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class MarketSummaryParentModel
    {
        public MarketSummaryModel Occupancy_Histogram { get; set; }

        public MarketSummaryModel Night_Price_Histogram { get; set; }

        public MarketSummaryModel Rental_Income_Histogram { get; set; }
    }
}
