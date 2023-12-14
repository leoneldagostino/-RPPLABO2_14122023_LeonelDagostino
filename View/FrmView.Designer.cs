namespace View
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstLibros = new ListBox();
            btnIngresarLibro = new Button();
            btnDarBajaLibro = new Button();
            btnListarBiblioteca = new Button();
            pctbox1 = new PictureBox();
            rchDetalleBiblioteca = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pctbox1).BeginInit();
            SuspendLayout();
            // 
            // lstLibros
            // 
            lstLibros.FormattingEnabled = true;
            lstLibros.ItemHeight = 15;
            lstLibros.Location = new Point(12, 12);
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(373, 559);
            lstLibros.TabIndex = 0;
            // 
            // btnIngresarLibro
            // 
            btnIngresarLibro.Location = new Point(433, 146);
            btnIngresarLibro.Name = "btnIngresarLibro";
            btnIngresarLibro.Size = new Size(141, 54);
            btnIngresarLibro.TabIndex = 1;
            btnIngresarLibro.Text = "Ingresar Libro";
            btnIngresarLibro.UseVisualStyleBackColor = true;
            btnIngresarLibro.Click += btnIngresarLibro_Click;
            // 
            // btnDarBajaLibro
            // 
            btnDarBajaLibro.Location = new Point(612, 146);
            btnDarBajaLibro.Name = "btnDarBajaLibro";
            btnDarBajaLibro.Size = new Size(147, 54);
            btnDarBajaLibro.TabIndex = 2;
            btnDarBajaLibro.Text = "Dar de baja libro seleccionado";
            btnDarBajaLibro.UseVisualStyleBackColor = true;
            btnDarBajaLibro.Click += btnDarBajaLibro_Click;
            // 
            // btnListarBiblioteca
            // 
            btnListarBiblioteca.Location = new Point(799, 146);
            btnListarBiblioteca.Name = "btnListarBiblioteca";
            btnListarBiblioteca.Size = new Size(140, 54);
            btnListarBiblioteca.TabIndex = 3;
            btnListarBiblioteca.Text = "Listar Biblioteca";
            btnListarBiblioteca.UseVisualStyleBackColor = true;
            btnListarBiblioteca.Click += btnListarBiblioteca_Click;
            // 
            // pctbox1
            // 
            pctbox1.Image = (Image)resources.GetObject("pctbox1.Image");
            pctbox1.Location = new Point(612, 12);
            pctbox1.Name = "pctbox1";
            pctbox1.Size = new Size(147, 128);
            pctbox1.SizeMode = PictureBoxSizeMode.Zoom;
            pctbox1.TabIndex = 4;
            pctbox1.TabStop = false;
            // 
            // rchDetalleBiblioteca
            // 
            rchDetalleBiblioteca.Location = new Point(433, 226);
            rchDetalleBiblioteca.Name = "rchDetalleBiblioteca";
            rchDetalleBiblioteca.Size = new Size(506, 345);
            rchDetalleBiblioteca.TabIndex = 5;
            rchDetalleBiblioteca.Text = "";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 590);
            Controls.Add(rchDetalleBiblioteca);
            Controls.Add(pctbox1);
            Controls.Add(btnListarBiblioteca);
            Controls.Add(btnDarBajaLibro);
            Controls.Add(btnIngresarLibro);
            Controls.Add(lstLibros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La biblioteca";
            ((System.ComponentModel.ISupportInitialize)pctbox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstLibros;
        private Button btnIngresarLibro;
        private Button btnDarBajaLibro;
        private Button btnListarBiblioteca;
        private PictureBox pctbox1;
        private RichTextBox rchDetalleBiblioteca;
    }
}