using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraConexionDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtgPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Atributo 
        private List<Pokemon> listaPokemon;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Invocar la lectura de la base de datos
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dtgPokemons.DataSource = listaPokemon;

            CargarImagen(listaPokemon[0].UrlImagen);
        }

        //Cuando cambie la seleccion va a pasar algo
        private void dtgPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //CurrentRow> se refiere a la fila actual que está seleccionada
            //DataBoundItem> Devuelve el objeto que está enlazado a esa fila
            Pokemon selecionado = (Pokemon)dtgPokemons.CurrentRow.DataBoundItem;
            CargarImagen(selecionado.UrlImagen);
        }

        private void CargarImagen(string imagen )
        {
            try
            {
                pbxPokemons.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemons.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk="); 
            }
            
        }
    }
}
