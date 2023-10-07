using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsPrimeraLecturaDBPágina
{
    public partial class FrmDetalle : Form
    {
        // me sirve para pasar un pokemon a el constructor sobre cargado cuando aprete el boton detalle
        //seria un pasaje de ventanas
        private Pokemon pokemon;

        //private List<Pokemon> listarPokemon;

        public FrmDetalle()
        {
            InitializeComponent();
        }
        public FrmDetalle(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Detalle del Pokemon";
        }
        private void cargar()
        {
            
            LogicaDeNegocio logicaNegocio = new LogicaDeNegocio();
            
            try
            {

                lbl_mostrar_numero.Text = pokemon.Numero.ToString();
                lbl_mostrar_nombre.Text = pokemon.Nombre;
                txt_mostrar_descripcion.Text = pokemon.Descripcion.ToString();
                lbl_mostrar_debilidad.Text = pokemon.Debilidad.ToString();  
                lbl_mostrar_tipo.Text = pokemon.Tipo.ToString();
                


                cargarImg(pokemon.UrlImagen);

                logicaNegocio.MostrarDetalle(pokemon);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void cargarImg(string imagen)
        {
            try
            {
                pbx_img.Load(imagen);
            }
            catch (Exception ex)
            {

                pbx_img.Load("https://tse2.mm.bing.net/th?id=OIP.ibWtmX0fBiVIm9sd5z2GUgHaE7&pid=Api&P=0&h=180");
            }

        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            cargar();

        }


    }
}
