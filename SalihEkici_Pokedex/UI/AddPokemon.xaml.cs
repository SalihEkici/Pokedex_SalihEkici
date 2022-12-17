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
    /// Interaction logic for AddPokemon.xaml
    /// </summary>
    public partial class AddPokemon : Window
    {
        public AddPokemon()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            Close();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (PokedexDbContext db = new PokedexDbContext())
            {
                if(PokemonDescription.Text == string.Empty) {
                    MessageBox.Show("Enter Description");
                    PokemonDescription.Focus();
                    return;
                }
                if (PokemonType.Text == string.Empty)
                {
                    MessageBox.Show("Enter Type");
                    PokemonType.Focus();
                    return;
                }
                if (PokemonName.Text == string.Empty)
                {
                    MessageBox.Show("Enter Name");
                    PokemonName.Focus();
                    return;
                }
                if (PokemonWeight.Text == string.Empty)
                {
                    MessageBox.Show("Enter Weight");
                    PokemonWeight.Focus();
                    return;
                }
                if (PokemonHeight.Text == string.Empty)
                {
                    MessageBox.Show("Enter Height");
                    PokemonHeight.Focus();
                    return;
                }
                if (PokemonPokedexNumber.Text == string.Empty)
                {
                    MessageBox.Show("Enter Pokedex Number");
                    PokemonPokedexNumber.Focus();
                    return;
                }
                Pokemon pokemon = new Pokemon()
                {
                    Name = PokemonName.Text,
                    Height = PokemonHeight.Text,
                    Weight = PokemonWeight.Text,
                    PokedexNumber = Convert.ToInt32(PokemonPokedexNumber.Text),
                    Type = PokemonType.Text,
                    Description = PokemonDescription.Text,
                    Generation = PokemonGeneration.Text,
                };
                db.Pokemons.Add(pokemon);


                if(db.SaveChanges() > 0) {
                    MessageBox.Show("Pokemon Has Been Saved");
                    PokemonName.Clear();
                    PokemonHeight.Clear();
                    PokemonWeight.Clear();
                    PokemonType.Clear();
                    PokemonDescription.Clear();
                    PokemonPokedexNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Pokemon has not been saved");
                }
            }
            

        }
    }
}
