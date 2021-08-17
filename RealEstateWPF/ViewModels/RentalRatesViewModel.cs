using Caliburn.Micro;
using RealEstateLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RealEstateWPF.ViewModels
{
    public class RentalRatesViewModel: Screen
    {
        RentalRatesProcessor rates = new RentalRatesProcessor();
        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }

        
    }
}
