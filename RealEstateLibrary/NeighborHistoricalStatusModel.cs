using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class NeighborHistoricalStatusModel
    {
        public string Status { get; set; } = "success";
        public NeighborHistoricalParentModel Content { get; set; }
    }
}
