using CosyShelf.Data.Database;

namespace CosyShelf.UI
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Start initializing DB asynchronously
            InitialiseDb(serviceProvider);

            MainPage = new AppShell();
        }

        private async void InitialiseDb(IServiceProvider services)
        {
            try
            {
                var dbPath = services.GetRequiredService<string>();
                var dbInit = new DatabaseInitialiser(dbPath);
                await dbInit.InitialiseDatabaseAsync();
            }
            catch (Exception ex)
            {
                // Log or display error
                System.Diagnostics.Debug.WriteLine($"DB init failed: {ex.Message}");
            }
        }
    }
}
