using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RealEstateLibrary;

namespace RealEstateWPF.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
        
        

        public async Task HomeView(object sender, RoutedEventArgs e)
        {
            await ActivateItemAsync(IoC.Get<HomeViewModel>(), new CancellationToken());
        }

        public async Task RadioButton_Click(object sender, RoutedEventArgs e)
        {
           

            await ActivateItemAsync(IoC.Get<RentalRatesViewModel>(), new CancellationToken());
        }

        public async Task ShortTerm_Click(object sender, RoutedEventArgs e)
        {
            await ActivateItemAsync(IoC.Get<ShortTermViewModel>(), new CancellationToken());
        }

        


    }
}
