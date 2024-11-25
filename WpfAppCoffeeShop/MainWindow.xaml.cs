using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCoffeeShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Coffee> coffees;
        public MainWindow()
        {
            InitializeComponent();
            LoadCoffeeData();
            BindDataGrid();
        }

		private void LoadCoffeeData() 
        { 
            DataSource.CreateData(); 
            coffees = DataSource.Coffees; 
        }
		private void BindDataGrid() 
        { 
            CoffeeDataGrid.ItemsSource = null; 
            CoffeeDataGrid.ItemsSource = coffees; 
        }
		private void AddCoffeeButton_Click(object sender, RoutedEventArgs e) 
        { 
            var newCoffee = new Coffee() 
            { 
                OrderName = "New Order", 
                BeverageName = "New Coffee", 
                BrewStrength = "Strength", 
                SizeInOunces = 0, 
                InStock = false, 
                BeveragePrice = 0.00, 
                Roast = Roast.medium, 
                Temperature = 
                Temperature.hot 
            }; 
            
            coffees.Add(newCoffee); 
            BindDataGrid(); 
        }
		private void RemoveCoffeeButton_Click(object sender, RoutedEventArgs e)
		{
			if (CoffeeDataGrid.SelectedItem != null) 
            { 
                var selectedCoffee = (Coffee)CoffeeDataGrid.SelectedItem; 
                coffees.Remove(selectedCoffee); 
                BindDataGrid(); 
            } 
            else 
            { 
                MessageBox.Show("No coffee selected to remove."); 
            }

		}
    }
}