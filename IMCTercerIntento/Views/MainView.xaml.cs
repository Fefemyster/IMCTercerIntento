using IMCTercerIntento.ViewModels;

namespace IMCTercerIntento.Views;

public partial class MainView : ContentPage
{
	MainViewModel viewModel;	
    public MainView()
	{
		InitializeComponent();
		viewModel = new MainViewModel();
		BindingContext = viewModel;
    }
}