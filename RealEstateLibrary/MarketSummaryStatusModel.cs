using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class MarketSummaryStatusModel
    {
        public string Status { get; set; } = "success";

        public MarketSummaryParentModel Content { get; set; }
    }
}
