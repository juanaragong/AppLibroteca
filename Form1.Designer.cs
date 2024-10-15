namespace AppLibroteca
{
    partial class Form1
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
            rbAudioLibro = new RadioButton();
            rbLimbroImpreso = new RadioButton();
            groupBox1 = new GroupBox();
            txtEditorial = new TextBox();
            txtCosto = new TextBox();
            txtAutor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtNumeroPaginas = new TextBox();
            txtTiempoMinutos = new TextBox();
            button1 = new Button();
            button2 = new Button();
            rdLibroDigital = new RadioButton();
            txtPesoLibro = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbAudioLibro
            // 
            rbAudioLibro.AutoSize = true;
            rbAudioLibro.Location = new Point(22, 36);
            rbAudioLibro.Name = "rbAudioLibro";
            rbAudioLibro.Size = new Size(130, 29);
            rbAudioLibro.TabIndex = 0;
            rbAudioLibro.TabStop = true;
            rbAudioLibro.Text = "Audio Libro";
            rbAudioLibro.UseVisualStyleBackColor = true;
            rbAudioLibro.CheckedChanged += rbAudioLibro_CheckedChanged;
            // 
            // rbLimbroImpreso
            // 
            rbLimbroImpreso.AutoSize = true;
            rbLimbroImpreso.Location = new Point(22, 71);
            rbLimbroImpreso.Name = "rbLimbroImpreso";
            rbLimbroImpreso.Size = new Size(148, 29);
            rbLimbroImpreso.TabIndex = 1;
            rbLimbroImpreso.TabStop = true;
            rbLimbroImpreso.Text = "Libro Impreso";
            rbLimbroImpreso.UseVisualStyleBackColor = true;
            rbLimbroImpreso.CheckedChanged += rbLimbroImpreso_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEditorial);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(22, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 255);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Libro";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(126, 193);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(150, 31);
            txtEditorial.TabIndex = 7;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(126, 151);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 31);
            txtCosto.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(126, 108);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 31);
            txtAutor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 196);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 4;
            label4.Text = "Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 151);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Costo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 239);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 5;
            label5.Text = "Numero Paginas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 327);
            label6.Name = "label6";
            label6.Size = new Size(166, 25);
            label6.TabIndex = 6;
            label6.Text = "Tiempo en Minutos";
            // 
            // txtNumeroPaginas
            // 
            txtNumeroPaginas.Enabled = false;
            txtNumeroPaginas.Location = new Point(436, 285);
            txtNumeroPaginas.Name = "txtNumeroPaginas";
            txtNumeroPaginas.Size = new Size(150, 31);
            txtNumeroPaginas.TabIndex = 8;
            // 
            // txtTiempoMinutos
            // 
            txtTiempoMinutos.Enabled = false;
            txtTiempoMinutos.Location = new Point(436, 364);
            txtTiempoMinutos.Name = "txtTiempoMinutos";
            txtTiempoMinutos.Size = new Size(150, 31);
            txtTiempoMinutos.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(436, 31);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 10;
            button1.Text = "Inserta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(436, 85);
            button2.Name = "button2";
            button2.Size = new Size(142, 34);
            button2.TabIndex = 11;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rdLibroDigital
            // 
            rdLibroDigital.AutoSize = true;
            rdLibroDigital.Location = new Point(22, 106);
            rdLibroDigital.Name = "rdLibroDigital";
            rdLibroDigital.Size = new Size(131, 29);
            rdLibroDigital.TabIndex = 12;
            rdLibroDigital.TabStop = true;
            rdLibroDigital.Text = "Libro digital";
            rdLibroDigital.UseVisualStyleBackColor = true;
            // 
            // txtPesoLibro
            // 
            txtPesoLibro.Location = new Point(436, 205);
            txtPesoLibro.Name = "txtPesoLibro";
            txtPesoLibro.Size = new Size(150, 31);
            txtPesoLibro.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 157);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 14;
            label7.Text = "Peso del Libro (MB)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 419);
            Controls.Add(label7);
            Controls.Add(txtPesoLibro);
            Controls.Add(rdLibroDigital);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTiempoMinutos);
            Controls.Add(txtNumeroPaginas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(rbLimbroImpreso);
            Controls.Add(rbAudioLibro);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbAudioLibro;
        private RadioButton rbLimbroImpreso;
        private GroupBox groupBox1;
        private TextBox txtEditorial;
        private TextBox txtCosto;
        private TextBox txtAutor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label label5;
        private Label label6;
        private TextBox txtNumeroPaginas;
        private TextBox txtTiempoMinutos;
        private Button button1;
        private Button button2;
        private RadioButton rdLibroDigital;
        private TextBox txtPesoLibro;
        private Label label7;
    }
}
