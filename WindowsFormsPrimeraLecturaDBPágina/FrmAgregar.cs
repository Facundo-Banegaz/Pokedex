﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace WindowsFormsPrimeraLecturaDBPágina
{
    public partial class FrmAgregar : Form
    {
        private Pokemon Pokemon = null;
        private OpenFileDialog archivo = null;

        public FrmAgregar()
        {
            InitializeComponent();
        }
        
        public FrmAgregar( Pokemon pokemon)
        {
            InitializeComponent();
            this.Pokemon = pokemon;
            Text = "Modificar Pokemon";
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            
            LogicaDeNegocio logicaDeNegocio = new LogicaDeNegocio();
            try 
               
            {
                if(Pokemon ==null)
                    Pokemon = new Pokemon();
                
                Pokemon.Numero = int.Parse(txt_numero.Text);
                Pokemon.Nombre= txt_nombre.Text;
                Pokemon.Descripcion= txt_descripcion.Text;
                Pokemon.UrlImagen = txt_Img.Text;
                Pokemon.Tipo = (Elemento)cbo_tipo.SelectedItem;
                Pokemon.Debilidad = (Elemento)cbo_debilidad.SelectedItem;

                if (Pokemon.Id != 0)
                {
                    logicaDeNegocio.Modificar(Pokemon);
                    MessageBox.Show("Modificado exitosamente!!!");
                }
                else
                {
                    logicaDeNegocio.Agregar(Pokemon);
                    MessageBox.Show("Agregado Exitosamente!!!");
                }
                //guardar archivo localmente
                if (archivo != null && txt_Img.Text.ToUpper().Contains("HTTP"))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.FileName);
                }

                this.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                //codigo de los combobox, cargado de valores
                cbo_debilidad.DataSource = elementoNegocio.list();
                cbo_debilidad.ValueMember = "Id";
                cbo_debilidad.DisplayMember = "Descripcion";

                cbo_tipo.DataSource = elementoNegocio.list();
                cbo_tipo.ValueMember = "Id";
                cbo_tipo.DisplayMember = "Descripcion";


                if (Pokemon != null)
                {
                    txt_numero.Text = Pokemon.Numero.ToString();
                    txt_nombre.Text = Pokemon.Nombre;
                    txt_descripcion.Text = Pokemon.Descripcion;
                    txt_Img.Text = Pokemon.UrlImagen;

                    cargarImg(Pokemon.UrlImagen);


                    cbo_debilidad.SelectedValue = Pokemon.Debilidad.Id;
                    cbo_tipo.SelectedValue = Pokemon.Tipo.Id;

                }
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
        private void txt_Img_Leave(object sender, EventArgs e)
        {
            cargarImg(txt_Img.Text);
        }

        private void btn_agregar_img_Click(object sender, EventArgs e)
        {
             archivo = new OpenFileDialog();

            archivo.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txt_Img.Text = archivo.FileName;
                cargarImg(archivo.FileName);

                
            
            }
        }
    }
}
