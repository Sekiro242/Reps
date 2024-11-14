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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for AllMovies.xaml
    /// </summary>
    public partial class AllMovies : Page
    {
       MoviesystemEntities db = new MoviesystemEntities();
        public AllMovies()
        {
            InitializeComponent();
            DG1.ItemsSource = db.Movies.Select(x => new {x.MovieID,x.MovieName,x.MovieCategory}).ToList();
        }

        private void Button_Click(object sender, object e)
        {
            DG1.ItemsSource = db.Movies.Where(x=> x.MovieCategory == comboboxcate.Text).Select(x=> new {x.MovieID,x.MovieName, x.MovieCategory}).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MovieDetails details = new MovieDetails();
            Movies movie = db.Movies.FirstOrDefault(x => x.MovieID == int.Parse(MovieIDTXT.Text));
            details.NameLabel.Content = movie.MovieName;
            details.CategoryLabel.Content = movie.MovieCategory;

            
          
        }
    }
}
