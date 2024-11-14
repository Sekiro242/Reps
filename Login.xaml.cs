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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MoviesystemEntities db = new MoviesystemEntities();
        public Login()
        {


            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.NavigationService.Navigate(signUp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ForgetPass forgetPass    = new ForgetPass();
            this.NavigationService.Navigate(forgetPass);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            string Emaile = Emailb.Text;
            string Passwordd = Passb.Text;
            users = db.Users.FirstOrDefault(x => x.Email == Emaile &&x.UserPassword == Passwordd);
            string AdmingE = "Saif.523018@gmail.com";
            string AdminP = "12341234";
            
            
            if(users != null)
            {
                AllMovies allMovies = new AllMovies();
                this.NavigationService.Navigate(allMovies);

            }
            else if(Emaile == AdmingE && Passwordd == AdminP) {
                AdminPage adminPage = new AdminPage();
                this.NavigationService.Navigate(adminPage);
            }
            else
            {
                MessageBox.Show("Wrong Email");
            }
            
          
        }

        
    }
}
