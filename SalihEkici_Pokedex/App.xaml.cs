using Microsoft.EntityFrameworkCore.Infrastructure;
using SalihEkici_Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SalihEkici_Pokedex
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade databaseFacade = new DatabaseFacade(new PokedexDbContext());
            databaseFacade.EnsureCreated();
        }
    }
}
