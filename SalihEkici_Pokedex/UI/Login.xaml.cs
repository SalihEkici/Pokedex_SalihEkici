using SalihEkici_Pokedex.Models;
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
using System.Windows.Shapes;

namespace SalihEkici_Pokedex.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Password.ToString();
            using (PokedexDbContext dbContext= new PokedexDbContext())
            {
                bool userfound = dbContext.User.Any(user => user.Name == username && user.Password == password);
                if (userfound)
                {
                    
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewPokemon win = new ViewPokemon();
            Close();
            win.Show();
        }
        
        private void GrantAccess()
        {
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
