namespace MusicPlayerUIDLL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControl12 = new MusicPlayerDLL.UserControl1();
            this.imagenCancion2 = new MusicPlayerDLL.ComponentesPersonalizados.ImagenCancion();
            this.botonAdelantar2 = new MusicPlayerDLL.ComponentesPersonalizados.BotonAdelantar();
            this.botonCarpeta2 = new MusicPlayer.ComponentesPersonalizados.BotonCarpeta();
            this.barra2 = new MusicPlayerDLL.ComponentesPersonalizados.Barra();
            this.botonCerrar2 = new MusicPlayerDLL.ComponentesPersonalizados.BotonCerrar();
            this.descripcionCancion2 = new MusicPlayerDLL.ComponentesPersonalizados.DescripcionCancion();
            this.botonPlay2 = new MusicPlayerPersonalizado.ComponentesPersonalizados.BotonPlay();
            this.botonRetroceder2 = new MusicPlayerDLL.ComponentesPersonalizados.BotonRetroceder();
            this.nombreCancion2 = new MusicPlayerDLL.ComponentesPersonalizados.NombreCancion();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCancion2)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.userControl12.Location = new System.Drawing.Point(25, 12);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(356, 593);
            this.userControl12.TabIndex = 0;
            // 
            // imagenCancion2
            // 
            this.imagenCancion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.imagenCancion2.Image = ((System.Drawing.Image)(resources.GetObject("imagenCancion2.Image")));
            this.imagenCancion2.Location = new System.Drawing.Point(97, 114);
            this.imagenCancion2.Name = "imagenCancion2";
            this.imagenCancion2.RutaCancion = null;
            this.imagenCancion2.Size = new System.Drawing.Size(200, 200);
            this.imagenCancion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenCancion2.TabIndex = 1;
            this.imagenCancion2.TabStop = false;
            // 
            // botonAdelantar2
            // 
            this.botonAdelantar2.ColorBorde = System.Drawing.Color.Transparent;
            this.botonAdelantar2.ColorFondo = System.Drawing.Color.Brown;
            this.botonAdelantar2.ColorIcono = System.Drawing.Color.White;
            this.botonAdelantar2.FlatAppearance.BorderSize = 0;
            this.botonAdelantar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdelantar2.GrosorBorde = 2;
            this.botonAdelantar2.Location = new System.Drawing.Point(97, 507);
            this.botonAdelantar2.Name = "botonAdelantar2";
            this.botonAdelantar2.Size = new System.Drawing.Size(55, 55);
            this.botonAdelantar2.TabIndex = 2;
            this.botonAdelantar2.Text = "botonAdelantar2";
            this.botonAdelantar2.UseVisualStyleBackColor = true;
            // 
            // botonCarpeta2
            // 
            this.botonCarpeta2.ColorBorde = System.Drawing.Color.Transparent;
            this.botonCarpeta2.ColorFondo = System.Drawing.Color.Brown;
            this.botonCarpeta2.ColorIcono = System.Drawing.Color.White;
            this.botonCarpeta2.FlatAppearance.BorderSize = 0;
            this.botonCarpeta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCarpeta2.GrosorBorde = 2;
            this.botonCarpeta2.Location = new System.Drawing.Point(53, 42);
            this.botonCarpeta2.Name = "botonCarpeta2";
            this.botonCarpeta2.Size = new System.Drawing.Size(55, 55);
            this.botonCarpeta2.TabIndex = 3;
            this.botonCarpeta2.Text = "botonCarpeta2";
            this.botonCarpeta2.UseVisualStyleBackColor = true;
            // 
            // barra2
            // 
            this.barra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.barra2.ForeColor = System.Drawing.Color.White;
            this.barra2.Location = new System.Drawing.Point(40, 441);
            this.barra2.Maximo = 100;
            this.barra2.Minimo = 0;
            this.barra2.Name = "barra2";
            this.barra2.Size = new System.Drawing.Size(323, 40);
            this.barra2.TabIndex = 4;
            this.barra2.Text = "barra2";
            this.barra2.Valor = 1;
            // 
            // botonCerrar2
            // 
            this.botonCerrar2.ColorBorde = System.Drawing.Color.Transparent;
            this.botonCerrar2.ColorFondo = System.Drawing.Color.Brown;
            this.botonCerrar2.ColorIcono = System.Drawing.Color.White;
            this.botonCerrar2.FlatAppearance.BorderSize = 0;
            this.botonCerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar2.GrosorBorde = 2;
            this.botonCerrar2.Location = new System.Drawing.Point(288, 42);
            this.botonCerrar2.Name = "botonCerrar2";
            this.botonCerrar2.Size = new System.Drawing.Size(55, 55);
            this.botonCerrar2.TabIndex = 5;
            this.botonCerrar2.Text = "botonCerrar2";
            this.botonCerrar2.UseVisualStyleBackColor = true;
            // 
            // descripcionCancion2
            // 
            this.descripcionCancion2.AutoSize = true;
            this.descripcionCancion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.descripcionCancion2.Font = new System.Drawing.Font("Arial", 11F);
            this.descripcionCancion2.ForeColor = System.Drawing.Color.White;
            this.descripcionCancion2.Location = new System.Drawing.Point(114, 395);
            this.descripcionCancion2.Name = "descripcionCancion2";
            this.descripcionCancion2.Size = new System.Drawing.Size(183, 17);
            this.descripcionCancion2.TabIndex = 6;
            this.descripcionCancion2.Text = "C# WPF Mp3 Music Player";
            this.descripcionCancion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonPlay2
            // 
            this.botonPlay2.ColorBorde = System.Drawing.Color.Transparent;
            this.botonPlay2.ColorFondo = System.Drawing.Color.Brown;
            this.botonPlay2.ColorIcono = System.Drawing.Color.White;
            this.botonPlay2.FlatAppearance.BorderSize = 0;
            this.botonPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPlay2.GrosorBorde = 2;
            this.botonPlay2.Location = new System.Drawing.Point(169, 507);
            this.botonPlay2.Name = "botonPlay2";
            this.botonPlay2.Size = new System.Drawing.Size(55, 55);
            this.botonPlay2.TabIndex = 7;
            this.botonPlay2.Text = "botonPlay2";
            this.botonPlay2.UseVisualStyleBackColor = true;
            // 
            // botonRetroceder2
            // 
            this.botonRetroceder2.ColorBorde = System.Drawing.Color.Transparent;
            this.botonRetroceder2.ColorFondo = System.Drawing.Color.Brown;
            this.botonRetroceder2.ColorIcono = System.Drawing.Color.White;
            this.botonRetroceder2.FlatAppearance.BorderSize = 0;
            this.botonRetroceder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRetroceder2.GrosorBorde = 2;
            this.botonRetroceder2.Location = new System.Drawing.Point(242, 507);
            this.botonRetroceder2.Name = "botonRetroceder2";
            this.botonRetroceder2.Size = new System.Drawing.Size(55, 55);
            this.botonRetroceder2.TabIndex = 8;
            this.botonRetroceder2.Text = "botonRetroceder2";
            this.botonRetroceder2.UseVisualStyleBackColor = true;
            // 
            // nombreCancion2
            // 
            this.nombreCancion2.AutoSize = true;
            this.nombreCancion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nombreCancion2.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nombreCancion2.ForeColor = System.Drawing.Color.White;
            this.nombreCancion2.Location = new System.Drawing.Point(129, 340);
            this.nombreCancion2.Name = "nombreCancion2";
            this.nombreCancion2.Size = new System.Drawing.Size(153, 30);
            this.nombreCancion2.TabIndex = 9;
            this.nombreCancion2.Text = "Song name";
            this.nombreCancion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(406, 630);
            this.Controls.Add(this.nombreCancion2);
            this.Controls.Add(this.botonRetroceder2);
            this.Controls.Add(this.botonPlay2);
            this.Controls.Add(this.descripcionCancion2);
            this.Controls.Add(this.botonCerrar2);
            this.Controls.Add(this.barra2);
            this.Controls.Add(this.botonCarpeta2);
            this.Controls.Add(this.botonAdelantar2);
            this.Controls.Add(this.imagenCancion2);
            this.Controls.Add(this.userControl12);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagenCancion2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusicPlayerDLL.UserControl1 userControl11;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonAdelantar botonAdelantar1;
        private MusicPlayerDLL.ComponentesPersonalizados.Barra barra1;
        private MusicPlayerPersonalizado.ComponentesPersonalizados.BotonPlay botonPlay1;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonRetroceder botonRetroceder1;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonCerrar botonCerrar1;
        private MusicPlayerDLL.ComponentesPersonalizados.DescripcionCancion descripcionCancion1;
        private MusicPlayerDLL.ComponentesPersonalizados.NombreCancion nombreCancion1;
        private MusicPlayerDLL.ComponentesPersonalizados.ImagenCancion imagenCancion1;
        private MusicPlayer.ComponentesPersonalizados.BotonCarpeta botonCarpeta1;
        private MusicPlayerDLL.UserControl1 userControl12;
        private MusicPlayerDLL.ComponentesPersonalizados.ImagenCancion imagenCancion2;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonAdelantar botonAdelantar2;
        private MusicPlayer.ComponentesPersonalizados.BotonCarpeta botonCarpeta2;
        private MusicPlayerDLL.ComponentesPersonalizados.Barra barra2;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonCerrar botonCerrar2;
        private MusicPlayerDLL.ComponentesPersonalizados.DescripcionCancion descripcionCancion2;
        private MusicPlayerPersonalizado.ComponentesPersonalizados.BotonPlay botonPlay2;
        private MusicPlayerDLL.ComponentesPersonalizados.BotonRetroceder botonRetroceder2;
        private MusicPlayerDLL.ComponentesPersonalizados.NombreCancion nombreCancion2;
    }
}

