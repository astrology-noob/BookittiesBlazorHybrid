using WpfBlazorBooks.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WpfBlazorBooks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddDbContext<AppDBContext>(options =>
              options.UseSqlServer(
                  ConfigurationManager.ConnectionStrings["AppDBContext"].ConnectionString));
            serviceCollection.AddScoped(sp =>
			{
				var dbContext = sp.CreateScope().ServiceProvider.GetRequiredService<AppDBContext>();
				return new BookService(dbContext);
			});
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
