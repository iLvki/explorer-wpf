using odkrywca.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;

namespace odkrywca.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy ContinentInfo.xaml
    /// </summary>
    public partial class ContinentInfo : Page
    {
        public ContinentInfo()
        {
            InitializeComponent();
        }

        public void ReadSources()
        {
            info.Text = string.Empty;
            List<Continent> informations = new List<Continent>();

            var uri = new Uri("pack://application:,,,/Assets/Continents/europe/data.json");
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);
            using (StreamReader reader = new StreamReader(resourceInfo.Stream))
            {
                string json = reader.ReadToEnd();
                informations = JsonSerializer.Deserialize<List<Continent>>(json);
            }

            
        }
    }
}
