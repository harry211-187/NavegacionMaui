namespace NavegacionMaui.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		//Crea los controles que escribimos en el XAML
		InitializeComponent();
	}

	private async void OnVerInformacionClicked(object sender, EventArgs e)
	{
		// abre la pagina asociada a esta ruta
		await Shell.Current.GoToAsync("informacion");
	}
}