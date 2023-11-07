using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_alura
{

    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        

    }

    public partial class MainPage : ContentPage
    {

        public List<Veiculo> Veiculos { get; set; }    
        public MainPage()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo {Nome="Gol Bolinha", Preco=35000},
                new Veiculo { Nome="Variante",Preco=15000},
                new Veiculo {Nome="Golf",Preco=55000},
                new Veiculo {Nome="Onix",Preco=80000}
            };

            this.BindingContext = this;

           // listViewVeiculos.ItemsSource = this.Veiculos;

           // listViewVeiculos.ItemsSource = new string[]
           // {
           //     "Gol Bolinha",
           //     "Variante",
           //     "Jeep",
           // };
        }
    }
}

