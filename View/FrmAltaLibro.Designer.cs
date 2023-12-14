namespace View
{
    partial class FrmAltaLibro
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
            cmbTipoLibro = new ComboBox();
            cmbDificultad = new ComboBox();
            chbEdicionEspecial = new CheckBox();
            chbAColor = new CheckBox();
            btnCrear = new Button();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(12, 44);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(225, 23);
            cmbTipoLibro.TabIndex = 0;
            cmbTipoLibro.SelectedIndexChanged += cmbTipoLibro_SelectedIndexChanged;
            // 
            // cmbDificultad
            // 
            cmbDificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Location = new Point(12, 127);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(225, 23);
            cmbDificultad.TabIndex = 1;
            // 
            // chbEdicionEspecial
            // 
            chbEdicionEspecial.AutoSize = true;
            chbEdicionEspecial.Location = new Point(23, 239);
            chbEdicionEspecial.Name = "chbEdicionEspecial";
            chbEdicionEspecial.Size = new Size(132, 19);
            chbEdicionEspecial.TabIndex = 3;
            chbEdicionEspecial.Text = "Es edicion especial ?";
            chbEdicionEspecial.UseVisualStyleBackColor = true;
            // 
            // chbAColor
            // 
            chbAColor.AutoSize = true;
            chbAColor.Location = new Point(23, 288);
            chbAColor.Name = "chbAColor";
            chbAColor.Size = new Size(69, 19);
            chbAColor.TabIndex = 4;
            chbAColor.Text = "A color?";
            chbAColor.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(23, 338);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(214, 65);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del libro";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 6;
            // 
            // FrmAltaLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtNombre);
            Controls.Add(btnCrear);
            Controls.Add(chbAColor);
            Controls.Add(chbEdicionEspecial);
            Controls.Add(cmbDificultad);
            Controls.Add(cmbTipoLibro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAltaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaLibro";
            Load += FrmAltaLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoLibro;
        private ComboBox cmbDificultad;
        private CheckBox chbEdicionEspecial;
        private CheckBox chbAColor;
        private Button btnCrear;
        private TextBox txtNombre;
    }
}