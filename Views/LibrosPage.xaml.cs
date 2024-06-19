
using JulianaSosaLibromvvm.Services;
using JulianaSosaLibromvvm.ViewModel;

namespace JulianaSosaLibromvvm.Views;

public partial class LibrosPage : ContentPage
{
	private readonly LibroViewModel _viewModel;	
	public LibrosPage()
	{
		InitializeComponent();
		_viewModel = new LibroViewModel();	
		var libroService= DependencyService.Get<ILibroService>();
		var libros = libroService.ObtenerLibro();

 
	}
}