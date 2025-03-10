using Minhas_Compras.Helpers;

namespace Minhas_Compras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _database;

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (_database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _database = new SQLiteDatabaseHelper(path);
                }

                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            InitializeComponent();
            _ = Database.InitializeAsync(); // Inicializa o banco
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
