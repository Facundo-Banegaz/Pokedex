namespace WindowsFormsPrimeraLecturaDBPágina
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregar));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_debilidad = new System.Windows.Forms.Label();
            this.txt_Img = new System.Windows.Forms.TextBox();
            this.lbl_img = new System.Windows.Forms.Label();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.cbo_debilidad = new System.Windows.Forms.ComboBox();
            this.btn_agregar_img = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_campos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbx_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_aceptar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(244, 634);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(105, 39);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.UseWaitCursor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(20, 113);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(79, 25);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(159, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(267, 26);
            this.txt_nombre.TabIndex = 2;
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(516, 102);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(393, 370);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 3;
            this.pbx_img.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_cancelar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(566, 634);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(115, 39);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.UseWaitCursor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(24, 330);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(50, 25);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(159, 176);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(267, 121);
            this.txt_descripcion.TabIndex = 3;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(20, 196);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(113, 25);
            this.lbl_descripcion.TabIndex = 0;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(20, 55);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(72, 25);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Codigo:";
            // 
            // lbl_debilidad
            // 
            this.lbl_debilidad.AutoSize = true;
            this.lbl_debilidad.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debilidad.Location = new System.Drawing.Point(20, 416);
            this.lbl_debilidad.Name = "lbl_debilidad";
            this.lbl_debilidad.Size = new System.Drawing.Size(88, 25);
            this.lbl_debilidad.TabIndex = 0;
            this.lbl_debilidad.Text = "Debilidad";
            // 
            // txt_Img
            // 
            this.txt_Img.Location = new System.Drawing.Point(159, 520);
            this.txt_Img.Name = "txt_Img";
            this.txt_Img.Size = new System.Drawing.Size(267, 26);
            this.txt_Img.TabIndex = 2;
            this.txt_Img.Leave += new System.EventHandler(this.txt_Img_Leave);
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.Location = new System.Drawing.Point(20, 518);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(104, 25);
            this.lbl_img.TabIndex = 0;
            this.lbl_img.Text = "Imagen Url:";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(159, 332);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(267, 28);
            this.cbo_tipo.TabIndex = 4;
            // 
            // cbo_debilidad
            // 
            this.cbo_debilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_debilidad.FormattingEnabled = true;
            this.cbo_debilidad.Location = new System.Drawing.Point(159, 418);
            this.cbo_debilidad.Name = "cbo_debilidad";
            this.cbo_debilidad.Size = new System.Drawing.Size(267, 28);
            this.cbo_debilidad.TabIndex = 5;
            // 
            // btn_agregar_img
            // 
            this.btn_agregar_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_img.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_img.Location = new System.Drawing.Point(566, 514);
            this.btn_agregar_img.Name = "btn_agregar_img";
            this.btn_agregar_img.Size = new System.Drawing.Size(280, 56);
            this.btn_agregar_img.TabIndex = 19;
            this.btn_agregar_img.Text = "Agregar Imagen Local";
            this.btn_agregar_img.UseVisualStyleBackColor = true;
            this.btn_agregar_img.Click += new System.EventHandler(this.btn_agregar_img_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(159, 57);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(267, 26);
            this.txt_numero.TabIndex = 21;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbx_campos
            // 
            this.gbx_campos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbx_campos.Controls.Add(this.txt_Img);
            this.gbx_campos.Controls.Add(this.txt_numero);
            this.gbx_campos.Controls.Add(this.lbl_nombre);
            this.gbx_campos.Controls.Add(this.txt_nombre);
            this.gbx_campos.Controls.Add(this.cbo_debilidad);
            this.gbx_campos.Controls.Add(this.lbl_tipo);
            this.gbx_campos.Controls.Add(this.cbo_tipo);
            this.gbx_campos.Controls.Add(this.lbl_descripcion);
            this.gbx_campos.Controls.Add(this.lbl_debilidad);
            this.gbx_campos.Controls.Add(this.txt_descripcion);
            this.gbx_campos.Controls.Add(this.lbl_numero);
            this.gbx_campos.Controls.Add(this.lbl_img);
            this.gbx_campos.Location = new System.Drawing.Point(4, 12);
            this.gbx_campos.Name = "gbx_campos";
            this.gbx_campos.Size = new System.Drawing.Size(477, 570);
            this.gbx_campos.TabIndex = 22;
            this.gbx_campos.TabStop = false;
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 703);
            this.Controls.Add(this.gbx_campos);
            this.Controls.Add(this.btn_agregar_img);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.btn_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Pokemon";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbx_campos.ResumeLayout(false);
            this.gbx_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_debilidad;
        private System.Windows.Forms.TextBox txt_Img;
        private System.Windows.Forms.Label lbl_img;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.ComboBox cbo_debilidad;
        private System.Windows.Forms.Button btn_agregar_img;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gbx_campos;
    }
}