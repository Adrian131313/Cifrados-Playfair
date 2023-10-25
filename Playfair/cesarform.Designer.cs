namespace Cifrados_Seguridad
{
    partial class cesarform
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
            btnCargar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnDescifrar = new Button();
            btnCifrar = new Button();
            label5 = new Label();
            txtClave = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTextoDescifrado = new TextBox();
            txtTextoCifrado = new TextBox();
            txtTexto = new TextBox();
            Guardar_txt = new Button();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.ActiveCaptionText;
            btnCargar.ForeColor = SystemColors.ButtonHighlight;
            btnCargar.Location = new Point(279, 76);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(31, 25);
            btnCargar.TabIndex = 31;
            btnCargar.Text = "...";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(523, 259);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaptionText;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(523, 210);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnDescifrar
            // 
            btnDescifrar.BackColor = SystemColors.ActiveCaptionText;
            btnDescifrar.ForeColor = SystemColors.ButtonHighlight;
            btnDescifrar.Location = new Point(523, 124);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(75, 23);
            btnDescifrar.TabIndex = 28;
            btnDescifrar.Text = "DESCIFRAR";
            btnDescifrar.UseVisualStyleBackColor = false;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // btnCifrar
            // 
            btnCifrar.BackColor = SystemColors.ActiveCaptionText;
            btnCifrar.ForeColor = SystemColors.ButtonHighlight;
            btnCifrar.Location = new Point(523, 75);
            btnCifrar.Name = "btnCifrar";
            btnCifrar.Size = new Size(75, 23);
            btnCifrar.TabIndex = 27;
            btnCifrar.Text = "CIFRAR";
            btnCifrar.UseVisualStyleBackColor = false;
            btnCifrar.Click += btnCifrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(27, 127);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 26;
            label5.Text = "CLAVE";
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.ActiveCaptionText;
            txtClave.ForeColor = SystemColors.ButtonHighlight;
            txtClave.Location = new Point(106, 125);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(204, 23);
            txtClave.TabIndex = 25;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(27, 235);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 24;
            label4.Text = "TEXTO DESCIFRADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 52);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 23;
            label3.Text = "INGRESE EL TEXTO";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 168);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 22;
            label2.Text = "TEXTO CIFRADO";
            // 
            // txtTextoDescifrado
            // 
            txtTextoDescifrado.BackColor = SystemColors.ActiveCaptionText;
            txtTextoDescifrado.ForeColor = SystemColors.ButtonHighlight;
            txtTextoDescifrado.Location = new Point(27, 259);
            txtTextoDescifrado.Name = "txtTextoDescifrado";
            txtTextoDescifrado.Size = new Size(283, 23);
            txtTextoDescifrado.TabIndex = 21;
            txtTextoDescifrado.TextChanged += txtTextoDescifrado_TextChanged;
            // 
            // txtTextoCifrado
            // 
            txtTextoCifrado.BackColor = SystemColors.ActiveCaptionText;
            txtTextoCifrado.ForeColor = SystemColors.ButtonHighlight;
            txtTextoCifrado.Location = new Point(27, 192);
            txtTextoCifrado.Name = "txtTextoCifrado";
            txtTextoCifrado.Size = new Size(283, 23);
            txtTextoCifrado.TabIndex = 20;
            txtTextoCifrado.TextChanged += txtTextoCifrado_TextChanged;
            // 
            // txtTexto
            // 
            txtTexto.BackColor = SystemColors.ActiveCaptionText;
            txtTexto.ForeColor = SystemColors.ButtonHighlight;
            txtTexto.Location = new Point(27, 76);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(252, 23);
            txtTexto.TabIndex = 19;
            txtTexto.TextChanged += txtTexto_TextChanged;
            // 
            // Guardar_txt
            // 
            Guardar_txt.BackColor = SystemColors.ActiveCaptionText;
            Guardar_txt.ForeColor = SystemColors.ButtonHighlight;
            Guardar_txt.Location = new Point(523, 166);
            Guardar_txt.Name = "Guardar_txt";
            Guardar_txt.Size = new Size(75, 23);
            Guardar_txt.TabIndex = 32;
            Guardar_txt.Text = "GUARDAR";
            Guardar_txt.UseVisualStyleBackColor = false;
            Guardar_txt.Click += Guardartxt_Click;
            // 
            // cesarform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
//            BackgroundImage = Properties.Resources.fondo_seguridad;
            ClientSize = new Size(625, 334);
            Controls.Add(Guardar_txt);
            Controls.Add(btnCargar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDescifrar);
            Controls.Add(btnCifrar);
            Controls.Add(label5);
            Controls.Add(txtClave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTextoDescifrado);
            Controls.Add(txtTextoCifrado);
            Controls.Add(txtTexto);
            Name = "cesarform";
            Text = "cesarform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnDescifrar;
        private Button btnCifrar;
        private Label label5;
        private TextBox txtClave;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTextoDescifrado;
        private TextBox txtTextoCifrado;
        private TextBox txtTexto;
        private Button Guardar_txt;
    }
}