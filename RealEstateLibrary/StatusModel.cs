using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class StatusModel
    {
        public string Status { get; set; } = "success";

        public RentalRatesParentModel Content { get; set; }


    }
}
