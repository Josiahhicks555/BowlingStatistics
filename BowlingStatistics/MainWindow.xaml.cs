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

namespace BowlingStatistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double game1;
        double game2;
        double game3;
        double borad1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EndGame_1_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Board.Text, out borad1);
            double answer = borad1;
            Game_1.Text = answer.ToString();
            EndGame_1.IsEnabled = false;
        }

        private void EndGame_2_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Board.Text, out borad1);
            double answer = borad1;
            Game_2.Text = answer.ToString();
            EndGame_2.IsEnabled = false;
        }

        private void EndGame_3_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Board.Text, out borad1);
            double answer = borad1;
            Game_3.Text = answer.ToString();
            EndGame_3.IsEnabled = false;
        }
    

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            Name.IsEnabled = false;
            Gender.IsEnabled = false;

        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int RandomNumber = random.Next();
            Double answer = random.Next(0,10);
            Board.Text = answer.ToString();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Game_1.Text, out game1);
            Double.TryParse(Game_2.Text, out game2);
            Double.TryParse(Game_3.Text, out game3);
            if (game1 > game2 && game1 > game3)
            {
                double x1 = game1;
                High.Text = x1.ToString();
            }
            else if (game1 < game2 && game2 > game3)
            {
                double x2 = game2;
                High.Text = x2.ToString();
            }
            else if (game3 > game1 && game3 > game2)
            {
                double x3 = game3;
                High.Text = x3.ToString();
            }

            else
            {
                MessageBox.Show("Tie");
            }

            double answer = game1 + game2 + game3 / 3;
            Adverage.Text = answer.ToString();

            double Handi = 200 - game1 + game2 + game3 / 3 * 8;
            Handicap.Text = Handi.ToString();

            CalculateBtn.IsEnabled = false;

        }
    }
}
