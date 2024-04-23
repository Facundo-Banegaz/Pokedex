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
    public partial class Pokedex : Form
    {

        private List<Pokemon> listarPokemon;


        public Pokedex()
        {
            InitializeComponent();
        }

        private void Pokedex_Load(object sender, EventArgs e)
        {
            cargar();
            cbo_campo.Items.Add("Id");
            cbo_campo.Items.Add("Nombre");
            cbo_campo.Items.Add("Descripción");
        }



        private void dgv_pokemon_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_pokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgv_pokemon.CurrentRow.DataBoundItem;

                cargarImg(seleccionado.UrlImagen);
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

        private void cargar()
        {
            //aqui trabajo con la lectura a base de datos  invocando
            LogicaDeNegocio negocio = new LogicaDeNegocio();

            try
            {

                listarPokemon = negocio.ListarPokemon();

                dgv_pokemon.DataSource = listarPokemon;

                ocultarColumnas();

                cargarImg(listarPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //siguiente Ventana

            FrmAgregar agregar = new FrmAgregar();

            agregar.ShowDialog();

            cargar();



        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgv_pokemon.CurrentRow != null)
            {
                Pokemon pokemonSeleccionado;

                pokemonSeleccionado = (Pokemon)dgv_pokemon.CurrentRow.DataBoundItem;
                FrmAgregar modificar = new FrmAgregar(pokemonSeleccionado);

                modificar.ShowDialog();

                cargar();
            }
            else
            {
                // Si no hay ninguna fila seleccionada, mostrar un mensaje o manejar el caso de alguna otra manera
                MessageBox.Show("No hay ningún Pokémon seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_suspender_Click(object sender, EventArgs e)
        {

            // Verificar si hay una fila seleccionada
            if (dgv_pokemon.CurrentRow != null)
            {
                Eliminar(true);
            }
            else
            {
                // Si no hay ninguna fila seleccionada, mostrar un mensaje o manejar el caso de alguna otra manera
                MessageBox.Show("No hay ningún Pokémon seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgv_pokemon.CurrentRow != null)
            {
                Eliminar(false);
            }
            else
            {
                // Si no hay ninguna fila seleccionada, mostrar un mensaje o manejar el caso de alguna otra manera
                MessageBox.Show("No hay ningún Pokémon seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Eliminar(bool logico)
        {
            LogicaDeNegocio logicaDeNegocio = new LogicaDeNegocio();
            Pokemon pokemonseleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿Estas seguro de realizar esta accion?", "Resultado exitoso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    pokemonseleccionado = (Pokemon)dgv_pokemon.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        logicaDeNegocio.Suspender(pokemonseleccionado.Id);
                    }
                    else
                    {
                        logicaDeNegocio.Eliminar(pokemonseleccionado.Id);
                    }
                    cargar();
                }
                else
                {
                    MessageBox.Show("Entendido!");

                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }




        private void ocultarColumnas()
        {
            dgv_pokemon.Columns["UrlImagen"].Visible = false;
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;



            string filtro = txt_filtro.Text;


            if (filtro.Length >= 3)
            {
                listaFiltrada = listarPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listarPokemon;
            }

            dgv_pokemon.DataSource = null;
            dgv_pokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbo_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbo_campo.SelectedItem.ToString();

            if (opcion == "Id")
            {
                cbo_criterio.Items.Clear();
                cbo_criterio.Items.Add("Mayor a");
                cbo_criterio.Items.Add("Menor a");
                cbo_criterio.Items.Add("Igual a");
            }
            else
            {
                cbo_criterio.Items.Clear();
                cbo_criterio.Items.Add("Comienza con");
                cbo_criterio.Items.Add("Termina con");
                cbo_criterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (cbo_campo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");

                return true;
            }
            if (cbo_criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");

                return true;
            }
            if (cbo_campo.SelectedItem.ToString() == "Número")
            {
                if (!(soloNumeros(txt_filtro_avanzado.Text)))
                {
                    MessageBox.Show("Solo Números para filtrar por favor.");
                    return true;
                }
                if (txt_filtro_avanzado.Text == "")
                {
                    MessageBox.Show("Por favor, Escriba algo en el campo.");

                    return true;
                }
            }

            return false;
        }


        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter))) 
                {
                    return false;
                }
            }
            return true;
        } 


        
        private void btn_filtro_Click(object sender, EventArgs e)
        {

            LogicaDeNegocio logicaDeNegocio = new LogicaDeNegocio();

            try
            {

                if (validarFiltro())
                    return;

                string campo = cbo_campo.SelectedItem.ToString();
                string criterio = cbo_criterio.SelectedItem.ToString();
                string filtro = txt_filtro_avanzado.Text;


                dgv_pokemon.DataSource = logicaDeNegocio.Filtrar(campo,criterio,filtro);

                
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgv_pokemon.CurrentRow != null)
            {
                // Si hay una fila seleccionada, obtener el Pokemon seleccionado
                Pokemon pokemonSeleccionado = (Pokemon)dgv_pokemon.CurrentRow.DataBoundItem;

                // Crear la ventana de detalle y pasar el Pokemon seleccionado como parámetro
                FrmDetalle detalle = new FrmDetalle(pokemonSeleccionado);

                // Mostrar la ventana de detalle
                detalle.ShowDialog();

                // Recargar los datos después de cerrar la ventana de detalle
                cargar();
            }
            else
            {
                // Si no hay ninguna fila seleccionada, mostrar un mensaje o manejar el caso de alguna otra manera
                MessageBox.Show("No hay ningún Pokémon seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_todo_Click(object sender, EventArgs e)
        {
            txt_filtro_avanzado.Clear();
            txt_filtro.Clear();
            cargar();
        }
    }
}
