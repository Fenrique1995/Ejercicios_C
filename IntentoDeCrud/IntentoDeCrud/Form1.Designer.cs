namespace IntentoDeCrud
{
    partial class Guardar
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
            label1 = new Label();
            label2 = new Label();
            labelDni = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            comboBoxPuesto = new ComboBox();
            guardarTrabajador = new Button();
            mostrarTrabajador = new Button();
            txtMostrarTrabajadores = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(112, 45);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(112, 95);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDni.Location = new Point(112, 148);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(44, 21);
            labelDni.TabIndex = 2;
            labelDni.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(259, 89);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 3;
            label4.Text = "Puesto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(104, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(104, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(112, 172);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(104, 23);
            txtDNI.TabIndex = 6;
            // 
            // comboBoxPuesto
            // 
            comboBoxPuesto.FormattingEnabled = true;
            comboBoxPuesto.Location = new Point(259, 113);
            comboBoxPuesto.Name = "comboBoxPuesto";
            comboBoxPuesto.Size = new Size(117, 23);
            comboBoxPuesto.TabIndex = 7;
            comboBoxPuesto.SelectedIndexChanged += comboBoxPuesto_SelectedIndexChanged;
            // 
            // guardarTrabajador
            // 
            guardarTrabajador.Font = new Font("Segoe UI", 12F);
            guardarTrabajador.Location = new Point(261, 172);
            guardarTrabajador.Name = "guardarTrabajador";
            guardarTrabajador.Size = new Size(115, 45);
            guardarTrabajador.TabIndex = 8;
            guardarTrabajador.Text = "Guardar";
            guardarTrabajador.UseVisualStyleBackColor = true;
            guardarTrabajador.Click += guardarTrabajador_Click;
            // 
            // mostrarTrabajador
            // 
            mostrarTrabajador.Location = new Point(261, 223);
            mostrarTrabajador.Name = "mostrarTrabajador";
            mostrarTrabajador.Size = new Size(115, 45);
            mostrarTrabajador.TabIndex = 9;
            mostrarTrabajador.Text = "Mostrar";
            mostrarTrabajador.UseVisualStyleBackColor = true;
            mostrarTrabajador.Click += mostrarTrabajador_Click;
            // 
            // txtMostrarTrabajadores
            // 
            txtMostrarTrabajadores.FormattingEnabled = true;
            txtMostrarTrabajadores.ItemHeight = 15;
            txtMostrarTrabajadores.Location = new Point(425, 18);
            txtMostrarTrabajadores.Name = "txtMostrarTrabajadores";
            txtMostrarTrabajadores.Size = new Size(249, 259);
            txtMostrarTrabajadores.TabIndex = 10;
            // 
            // Guardar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 308);
            Controls.Add(txtMostrarTrabajadores);
            Controls.Add(mostrarTrabajador);
            Controls.Add(guardarTrabajador);
            Controls.Add(comboBoxPuesto);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(labelDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Guardar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelDni;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private ComboBox comboBoxPuesto;
        private Button guardarTrabajador;
        private Button mostrarTrabajador;
        private ListBox txtMostrarTrabajadores;
    }
}
