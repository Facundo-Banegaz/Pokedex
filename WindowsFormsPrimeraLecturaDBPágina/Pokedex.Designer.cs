namespace WindowsFormsPrimeraLecturaDBPágina
{
    partial class Pokedex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            this.dgv_pokemon = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_suspender = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_fitros = new System.Windows.Forms.Label();
            this.lbl_filtro_avanzado = new System.Windows.Forms.Label();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.txt_filtro_avanzado = new System.Windows.Forms.TextBox();
            this.cbo_campo = new System.Windows.Forms.ComboBox();
            this.cbo_criterio = new System.Windows.Forms.ComboBox();
            this.btn_detalle = new System.Windows.Forms.Button();
            this.btn_todo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pokemon
            // 
            this.dgv_pokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_pokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_pokemon.Location = new System.Drawing.Point(12, 572);
            this.dgv_pokemon.MultiSelect = false;
            this.dgv_pokemon.Name = "dgv_pokemon";
            this.dgv_pokemon.RowHeadersWidth = 62;
            this.dgv_pokemon.RowTemplate.Height = 28;
            this.dgv_pokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pokemon.Size = new System.Drawing.Size(883, 345);
            this.dgv_pokemon.TabIndex = 0;
            this.dgv_pokemon.SelectionChanged += new System.EventHandler(this.dgv_pokemon_SelectionChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(1045, 363);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(323, 57);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(1045, 218);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(323, 57);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_suspender
            // 
            this.btn_suspender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suspender.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspender.Location = new System.Drawing.Point(1045, 291);
            this.btn_suspender.Name = "btn_suspender";
            this.btn_suspender.Size = new System.Drawing.Size(323, 57);
            this.btn_suspender.TabIndex = 5;
            this.btn_suspender.Text = "Suspender";
            this.btn_suspender.UseVisualStyleBackColor = true;
            this.btn_suspender.Click += new System.EventHandler(this.btn_suspender_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(1045, 146);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(323, 57);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(966, 572);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(402, 345);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 1;
            this.pbx_img.TabStop = false;
            // 
            // btn_filtro
            // 
            this.btn_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro.Location = new System.Drawing.Point(1100, 476);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(91, 46);
            this.btn_filtro.TabIndex = 2;
            this.btn_filtro.Text = "Buscar";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(107, 363);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(164, 35);
            this.lbl_filtro.TabIndex = 8;
            this.lbl_filtro.Text = "Filtro Rapido:";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(308, 363);
            this.txt_filtro.Multiline = true;
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(531, 32);
            this.txt_filtro.TabIndex = 1;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_fitros
            // 
            this.lbl_fitros.AutoSize = true;
            this.lbl_fitros.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fitros.Location = new System.Drawing.Point(448, 251);
            this.lbl_fitros.Name = "lbl_fitros";
            this.lbl_fitros.Size = new System.Drawing.Size(86, 35);
            this.lbl_fitros.TabIndex = 11;
            this.lbl_fitros.Text = "Filtros";
            // 
            // lbl_filtro_avanzado
            // 
            this.lbl_filtro_avanzado.AutoSize = true;
            this.lbl_filtro_avanzado.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_avanzado.Location = new System.Drawing.Point(678, 491);
            this.lbl_filtro_avanzado.Name = "lbl_filtro_avanzado";
            this.lbl_filtro_avanzado.Size = new System.Drawing.Size(57, 25);
            this.lbl_filtro_avanzado.TabIndex = 12;
            this.lbl_filtro_avanzado.Text = "Filtro:";
            // 
            // lbl_campo
            // 
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campo.Location = new System.Drawing.Point(25, 490);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(72, 25);
            this.lbl_campo.TabIndex = 14;
            this.lbl_campo.Text = "Campo:";
            // 
            // lbl_criterio
            // 
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_criterio.Location = new System.Drawing.Point(349, 490);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(77, 25);
            this.lbl_criterio.TabIndex = 13;
            this.lbl_criterio.Text = "Criterio:";
            // 
            // txt_filtro_avanzado
            // 
            this.txt_filtro_avanzado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_filtro_avanzado.Location = new System.Drawing.Point(754, 489);
            this.txt_filtro_avanzado.Name = "txt_filtro_avanzado";
            this.txt_filtro_avanzado.Size = new System.Drawing.Size(298, 26);
            this.txt_filtro_avanzado.TabIndex = 15;
            // 
            // cbo_campo
            // 
            this.cbo_campo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_campo.FormattingEnabled = true;
            this.cbo_campo.Location = new System.Drawing.Point(104, 487);
            this.cbo_campo.Name = "cbo_campo";
            this.cbo_campo.Size = new System.Drawing.Size(218, 28);
            this.cbo_campo.TabIndex = 16;
            this.cbo_campo.SelectedIndexChanged += new System.EventHandler(this.cbo_campo_SelectedIndexChanged);
            // 
            // cbo_criterio
            // 
            this.cbo_criterio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_criterio.FormattingEnabled = true;
            this.cbo_criterio.Location = new System.Drawing.Point(432, 488);
            this.cbo_criterio.Name = "cbo_criterio";
            this.cbo_criterio.Size = new System.Drawing.Size(227, 28);
            this.cbo_criterio.TabIndex = 17;
            // 
            // btn_detalle
            // 
            this.btn_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detalle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle.Location = new System.Drawing.Point(1045, 71);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(323, 57);
            this.btn_detalle.TabIndex = 18;
            this.btn_detalle.Text = "Ver Detalle";
            this.btn_detalle.UseVisualStyleBackColor = true;
            this.btn_detalle.Click += new System.EventHandler(this.btn_detalle_Click);
            // 
            // btn_todo
            // 
            this.btn_todo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todo.Location = new System.Drawing.Point(1226, 476);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(142, 46);
            this.btn_todo.TabIndex = 19;
            this.btn_todo.Text = "Limpiar Filtros";
            this.btn_todo.UseVisualStyleBackColor = true;
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1401, 948);
            this.Controls.Add(this.btn_todo);
            this.Controls.Add(this.btn_detalle);
            this.Controls.Add(this.cbo_criterio);
            this.Controls.Add(this.cbo_campo);
            this.Controls.Add(this.txt_filtro_avanzado);
            this.Controls.Add(this.lbl_campo);
            this.Controls.Add(this.lbl_criterio);
            this.Controls.Add(this.lbl_filtro_avanzado);
            this.Controls.Add(this.lbl_fitros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_suspender);
            this.Controls.Add(this.dgv_pokemon);
            this.Controls.Add(this.btn_agregar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.Pokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pokemon;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_suspender;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_fitros;
        private System.Windows.Forms.Label lbl_filtro_avanzado;
        private System.Windows.Forms.Label lbl_campo;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.TextBox txt_filtro_avanzado;
        private System.Windows.Forms.ComboBox cbo_campo;
        private System.Windows.Forms.ComboBox cbo_criterio;
        private System.Windows.Forms.Button btn_detalle;
        private System.Windows.Forms.Button btn_todo;
    }
}

