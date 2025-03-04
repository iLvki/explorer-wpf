using odkrywca.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
        private Continent informations = new Continent();
        private MediaPlayer mp { get; set; }

        public void ReadInfo()
        {
            informations = new Continent();
            var uri = new Uri($"pack://application:,,,/Assets/Continents/{continentName}/data.json");
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);
            using (StreamReader reader = new StreamReader(resourceInfo.Stream))
            {
                string json = reader.ReadToEnd();
                informations = JsonSerializer.Deserialize<Continent>(json);
            }

            this.WindowTitle = informations.name;
            title.Content = informations.name;
            info.Text = informations.info;
            uri = new Uri($"pack://application:,,,/Assets/Continents/{continentName}/{informations.name.ToLower()}.jpg", UriKind.Absolute);
            continentImg.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(uri)
            };

            PlayMusic();
        }

        private void PlayMusic()
        {
            mp = new MediaPlayer();
            var uri = new Uri($"pack://application:,,,/Assets/Continents/{continentName}/{informations.music}.wav");
            string[] musicDetails = informations.music.Split('_');
            mp.Open(uri);
            mp.Play();
            musicInfo.Content = $"Muzyka w tle: {musicDetails[0]} - {musicDetails[1]}";
        }
    }
}
