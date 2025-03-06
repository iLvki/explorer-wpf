using odkrywca.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;

namespace odkrywca.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Sources.xaml
    /// </summary>
    public partial class Sources : Page
    {
        public Sources()
        {
            InitializeComponent();
            ReadSources();
        }


        public void ReadSources()
        {
            res.Text = string.Empty;
            List<Source> sources = new List<Source>();

            var uri = new Uri("pack://application:,,,/Assets/sources.json");
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);
            using (StreamReader reader = new StreamReader(resourceInfo.Stream))
            {
                string json = reader.ReadToEnd();
                sources = JsonSerializer.Deserialize<List<Source>>(json);
            }

            foreach (Source s in sources)
            {
                res.Text += $" > {s.title}: {s.link} \n\n\n";
            }
        }
    }
}
