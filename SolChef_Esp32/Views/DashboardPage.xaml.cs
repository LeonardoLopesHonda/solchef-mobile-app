using SolChef_Esp32.ViewModels;

namespace SolChef_Esp32.Views;

public partial class DashboardPage : ContentPage {
	public DashboardPage() {
		InitializeComponent();

        BindingContext = new DashboardViewModel();
    }
}