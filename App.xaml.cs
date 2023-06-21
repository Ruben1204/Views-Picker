namespace ControlesTipoVista;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.Picker_Vista();
	}
}
