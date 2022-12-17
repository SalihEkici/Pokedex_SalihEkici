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
using SalihEkici_Pokedex.UI;
using System.Xml.Linq;

namespace SalihEkici_Pokedex.UI
{
    /// <summary>
    /// Interaction logic for ViewPokemon.xaml
    /// </summary>
    public partial class ViewPokemon : Window
    {
        public ViewPokemon()
        {
            InitializeComponent();
            GetPokemon();
        }

        public void GetPokemon()
        {
            using (PokedexDbContext db = new PokedexDbContext())
            {
                var pokemonList = db.Pokemons.Select(p=> p.Name).ToList();
                
                foreach(var pokemon in pokemonList)
                {
                    pokemonNameListBox.Items.Add(pokemon.ToString());
                }
            }
        }

        private void pokemonNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (PokedexDbContext db = new PokedexDbContext())
            {

                string Name = pokemonNameListBox.SelectedItem.ToString();
                if(Name != null) {
                    string Height = db.Pokemons.Where(p => p.Name == Name).Select(p => p.Height).FirstOrDefault();
                    string Weight = db.Pokemons.Where(p => p.Name == Name).Select(p => p.Weight).FirstOrDefault();
                    string PokedexNumber = db.Pokemons.Where(p => p.Name == Name).Select(p => p.PokedexNumber).FirstOrDefault().ToString();
                    string Type = db.Pokemons.Where(p => p.Name == Name).Select(p => p.Type).FirstOrDefault();
                    string Description = db.Pokemons.Where(p => p.Name == Name).Select(p => p.Description).FirstOrDefault();
                    string Generation = db.Pokemons.Where(p => p.Name == Name).Select(p => p.Generation).FirstOrDefault();

                    
                    pokemonName.Content = Name;
                    pokemonHeight.Content = Height;
                    pokemonWeight.Content = Weight;
                    pokemonType.Content = Type;
                    pokemonGeneration.Content = Generation;
                    pokemonPokedexNumber.Content = PokedexNumber;
                    pokemonDescription.Text = Description;

                    pokemonImage.Source = new BitmapImage(new Uri($"../Images/{Name}.jpg", UriKind.Relative));
                }
                

                

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Login win = new Login();
            Close();
            win.Show();
        }
    }
}
