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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guardar_txt = new Button();
            txtTextoDescifrado = new Guna.UI2.WinForms.Guna2TextBox();
            txtTextoCifrado = new Guna.UI2.WinForms.Guna2TextBox();
            txtTexto = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.ActiveCaptionText;
            btnCargar.ForeColor = SystemColors.ButtonHighlight;
            btnCargar.Location = new Point(475, 52);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(38, 27);
            btnCargar.TabIndex = 31;
            btnCargar.Text = "...";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(707, 428);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 49);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaptionText;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(707, 339);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 49);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnDescifrar
            // 
            btnDescifrar.BackColor = SystemColors.ActiveCaptionText;
            btnDescifrar.ForeColor = SystemColors.ButtonHighlight;
            btnDescifrar.Location = new Point(707, 167);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(118, 49);
            btnDescifrar.TabIndex = 28;
            btnDescifrar.Text = "DESCIFRAR";
            btnDescifrar.UseVisualStyleBackColor = false;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // btnCifrar
            // 
            btnCifrar.BackColor = SystemColors.ActiveCaptionText;
            btnCifrar.ForeColor = SystemColors.ButtonHighlight;
            btnCifrar.Location = new Point(707, 79);
            btnCifrar.Name = "btnCifrar";
            btnCifrar.Size = new Size(118, 49);
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
            label5.Location = new Point(27, 155);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 26;
            label5.Text = "CLAVE";
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.ActiveCaptionText;
            txtClave.ForeColor = SystemColors.ButtonHighlight;
            txtClave.Location = new Point(106, 153);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(363, 23);
            txtClave.TabIndex = 25;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(27, 363);
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
            label3.Location = new Point(27, 23);
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
            label2.Location = new Point(27, 219);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 22;
            label2.Text = "TEXTO CIFRADO";
            // 
            // Guardar_txt
            // 
            Guardar_txt.BackColor = SystemColors.ActiveCaptionText;
            Guardar_txt.ForeColor = SystemColors.ButtonHighlight;
            Guardar_txt.Location = new Point(707, 250);
            Guardar_txt.Name = "Guardar_txt";
            Guardar_txt.Size = new Size(118, 49);
            Guardar_txt.TabIndex = 32;
            Guardar_txt.Text = "GUARDAR";
            Guardar_txt.UseVisualStyleBackColor = false;
            Guardar_txt.Click += Guardartxt_Click;
            // 
            // txtTextoDescifrado
            // 
            txtTextoDescifrado.BackColor = Color.MediumAquamarine;
            txtTextoDescifrado.BorderColor = Color.MediumAquamarine;
            txtTextoDescifrado.BorderThickness = 0;
            txtTextoDescifrado.CustomizableEdges = customizableEdges1;
            txtTextoDescifrado.DefaultText = "";
            txtTextoDescifrado.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTextoDescifrado.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTextoDescifrado.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTextoDescifrado.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTextoDescifrado.FillColor = Color.Black;
            txtTextoDescifrado.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTextoDescifrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextoDescifrado.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTextoDescifrado.Location = new Point(27, 397);
            txtTextoDescifrado.Multiline = true;
            txtTextoDescifrado.Name = "txtTextoDescifrado";
            txtTextoDescifrado.PasswordChar = '\0';
            txtTextoDescifrado.PlaceholderText = "";
            txtTextoDescifrado.SelectedText = "";
            txtTextoDescifrado.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTextoDescifrado.Size = new Size(442, 101);
            txtTextoDescifrado.TabIndex = 62;
            // 
            // txtTextoCifrado
            // 
            txtTextoCifrado.BackColor = Color.MediumAquamarine;
            txtTextoCifrado.BorderColor = Color.MediumAquamarine;
            txtTextoCifrado.BorderThickness = 0;
            txtTextoCifrado.CustomizableEdges = customizableEdges3;
            txtTextoCifrado.DefaultText = "";
            txtTextoCifrado.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTextoCifrado.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTextoCifrado.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTextoCifrado.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTextoCifrado.FillColor = Color.Black;
            txtTextoCifrado.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTextoCifrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextoCifrado.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTextoCifrado.Location = new Point(27, 252);
            txtTextoCifrado.Multiline = true;
            txtTextoCifrado.Name = "txtTextoCifrado";
            txtTextoCifrado.PasswordChar = '\0';
            txtTextoCifrado.PlaceholderText = "";
            txtTextoCifrado.SelectedText = "";
            txtTextoCifrado.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTextoCifrado.Size = new Size(442, 91);
            txtTextoCifrado.TabIndex = 63;
            // 
            // txtTexto
            // 
            txtTexto.BackColor = Color.MediumAquamarine;
            txtTexto.BorderColor = Color.MediumAquamarine;
            txtTexto.BorderThickness = 0;
            txtTexto.CustomizableEdges = customizableEdges5;
            txtTexto.DefaultText = "";
            txtTexto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTexto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTexto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTexto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTexto.FillColor = Color.Black;
            txtTexto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTexto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTexto.ForeColor = SystemColors.ButtonHighlight;
            txtTexto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTexto.Location = new Point(27, 52);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.PasswordChar = '\0';
            txtTexto.PlaceholderText = "";
            txtTexto.SelectedText = "";
            txtTexto.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTexto.Size = new Size(442, 91);
            txtTexto.TabIndex = 64;
            // 
            // cesarform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 528);
            Controls.Add(txtTexto);
            Controls.Add(txtTextoCifrado);
            Controls.Add(txtTextoDescifrado);
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
            FormBorderStyle = FormBorderStyle.None;
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
        private Button Guardar_txt;
        private Guna.UI2.WinForms.Guna2TextBox txtTextoDescifrado;
        private Guna.UI2.WinForms.Guna2TextBox txtTextoCifrado;
        private Guna.UI2.WinForms.Guna2TextBox txtTexto;
    }
}