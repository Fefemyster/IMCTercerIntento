
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IMCTercerIntento.Models;

namespace IMCTercerIntento.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double weight;

        [ObservableProperty]
        private double height;

        [ObservableProperty]
        private double imcresult;

        [RelayCommand]
        private async Task CalcularImc()
        {
            ImcCalculadora imc = new ImcCalculadora(Weight, Height); 
            
           if(imc.height==0)
            {
               await Application.Current!.MainPage!.DisplayAlert("Error", "La altura no puede ser cero.", "OK");
                
            }
           else
            {
               Imcresult = imc.weight / (imc.height * imc.height);
            }
        }

    }
}
