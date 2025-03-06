using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace odkrywca.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Quiz.xaml
    /// </summary>
    public partial class Quiz : Page
    {
        public Quiz(string? cName)
        {
            InitializeComponent();
            c = (cName != "") ? cName : "";
        }

        public string c { get; set; }

        private void GoToSite(object sender, RoutedEventArgs e)
        {
            if (c != null)
            {
                ContinentInfo cInfoPage = new ContinentInfo(c);
                this.NavigationService.Navigate(cInfoPage);
            }
        }
    }
}
