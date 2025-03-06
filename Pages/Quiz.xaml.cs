using odkrywca.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Resources;
using Application = System.Windows.Application;

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
            continent = (cName != "") ? cName : "";
            GetQuizData(continent);
        }

        public string continent { get; set; }
        private int i = 0;
        private int points = 0;
        private int maxPoints { get; set; }
        private List<QuizC> questions { get; set; }

        private void GoToSite(object sender, RoutedEventArgs e)
        {
            if (continent != null)
            {
                ContinentInfo cInfoPage = new ContinentInfo(continent);
                this.NavigationService.Navigate(cInfoPage);
            }
        }

        private void GetQuizData(string c)
        {
            Continent con = new Continent();
            var uri = new Uri($"pack://application:,,,/Assets/Continents/{continent}/data.json");
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);
            using (StreamReader reader = new StreamReader(resourceInfo.Stream))
            {
                string json = reader.ReadToEnd();
                con = JsonSerializer.Deserialize<Continent>(json);
            }
            questions = con.questions;
            maxPoints = questions.Count;
            score.Content = $"{points}/{maxPoints}";

            ShowQuizData();
        }

        private void ShowQuizData()
        {
            int row = 1, col = 0;
            qGrid.Children.Clear();

            TextBlock txt = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 40,
                FontWeight = FontWeights.Bold,
                Text = $"{questions[i].question}",
                TextAlignment = TextAlignment.Center,
                TextWrapping = TextWrapping.Wrap
            };

            Grid.SetRow(txt, 0);
            Grid.SetColumnSpan(txt, 2);
            qGrid.Children.Add(txt);

            for (int j = 0; j < questions[i].answers.Length; j++)
            {
                if (j == 2) { row = 2; col = 0; }

                Label lbl = new Label
                {
                    FontSize = 32,
                    FontWeight = FontWeights.Bold,
                    Content = $"{questions[i].answers[j].an}",
                    Cursor = Cursors.Hand,
                    Tag = j,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center
                };

                lbl.PreviewMouseDown += CheckAnswer;
                Grid.SetRow(lbl, row);
                Grid.SetColumn(lbl, col++);
                qGrid.Children.Add(lbl);

            }

            prevQBtn.Visibility = (i == 0) ? Visibility.Hidden : Visibility.Visible;
            nextQBtn.Visibility = (i == 1) ? Visibility.Hidden : Visibility.Visible;
        }

        private void ChangeQuestion(object sender, RoutedEventArgs e)
        {
            string btnName = (sender as Button).Name;

            switch (btnName)
            {
                case "prevQBtn": --i; ShowQuizData(); break;
                case "nextQBtn": ++i; ShowQuizData(); break;
            }
        }

        private void CheckAnswer(object sender, MouseButtonEventArgs e)
        {
            int idx = (int)(sender as Label).Tag;

            if(idx == questions[i].correctAns)
            {
                (sender as Label).Foreground = Brushes.Green;
                UpdatePoints();
            }
            else {
                (sender as Label).Foreground = Brushes.Red;
                ShowCorrectAns();
            }

            foreach (UIElement element in qGrid.Children)
            {
                element.PreviewMouseDown -= CheckAnswer;
            }
        }

        private void ShowCorrectAns()
        {
            foreach (UIElement element in qGrid.Children)
            {
                if (element is Label lbl && (int)lbl.Tag == questions[i].correctAns)
                {
                    lbl.Foreground = Brushes.Green;
                }
            }
        }

        private void UpdatePoints()
        {
            score.Content = $"{++points}/{maxPoints}";
        }
    }
}
