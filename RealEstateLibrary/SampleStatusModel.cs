using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateLibrary
{
    public class SampleStatusModel
    {
        public string Status { get; set; } = "success";
        public SampleParentModel Content { get; set; }
    }
}
