﻿#pragma checksum "..\..\..\..\UI\ViewPokemonAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9122B78D7412789E8D967C99AB7166F16C34375D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SalihEkici_Pokedex.UI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SalihEkici_Pokedex.UI {
    
    
    /// <summary>
    /// ViewPokemon
    /// </summary>
    public partial class ViewPokemon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonPokedexNumber;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox pokemonNameListBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonGeneration;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonWeight;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonHeight;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pokemonDescription;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pokemonType;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SalihEkici_Pokedex;component/ui/viewpokemonadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pokemonPokedexNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.pokemonNameListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
            this.pokemonNameListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pokemonNameListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pokemonName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.pokemonGeneration = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.pokemonWeight = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.pokemonHeight = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.pokemonDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.pokemonType = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 52 "..\..\..\..\UI\ViewPokemonAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

