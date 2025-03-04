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
        public ContinentInfo(string c)
        {
            InitializeComponent();
            continentName = c;
            ReadInfo();
        }
     
        public string continentName { get; set; }

        public void ReadInfo()
        {
            info.Text = string.Empty;
            Continent informations = new Continent();

            var uri = new Uri($"pack://application:,,,/Assets/Continents/{continentName}/data.json");
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);
            using (StreamReader reader = new StreamReader(resourceInfo.Stream))
            {
                string json = reader.ReadToEnd();
                informations = JsonSerializer.Deserialize<Continent>(json);
            }

            title.Content = informations.name;

            info.Text = informations.info;
        }
    }
}
