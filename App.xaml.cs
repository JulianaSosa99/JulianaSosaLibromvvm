using JulianaSosaLibromvvm.Services;

namespace JulianaSosaLibromvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ILibroService, LibroService>();



            MainPage = new AppShell();
        }
    }
}
