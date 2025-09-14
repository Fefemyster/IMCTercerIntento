
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

            if (imc.height <= 0 || imc.weight <=0)
            {
                await Application.Current!.MainPage!.DisplayAlert("Error", "La altura o el peso no puede ser cero o negativo.", "OK");

            }
            else
            {
                Imcresult = imc.weight / (imc.height * imc.height);
            }




        }       

    
        [RelayCommand]
        private void Clean()
        {
            Weight = 0;
            Height = 0;
            Imcresult = 0;
        }
    }
}
