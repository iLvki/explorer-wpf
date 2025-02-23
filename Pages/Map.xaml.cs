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
    /// Logika interakcji dla klasy Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        public Map()
        {
            InitializeComponent();
        }

        private void changeImage(object sender, MouseEventArgs e)
        {
            string continent = (sender as Hyperlink).Name;

            Uri imgUri = new Uri($"Assets/Hovers/{continent}-h.png", UriKind.Relative);

            map.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(imgUri)
            };
        }

        private void BackToBaseImg(object sender, MouseEventArgs e)
        {
            map.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri($"Assets/continents.png", UriKind.Relative))
            };
        }
    }
}
