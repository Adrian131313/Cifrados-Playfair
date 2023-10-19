namespace Playfair
{
    partial class PlayfairForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSetKey = new Button();
            btnShowMatrix = new Button();
            btnDescifrar = new Button();
            btnCifrado = new Button();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            txtDecryptedOutput = new Guna.UI2.WinForms.Guna2TextBox();
            txtEncryptedOutput = new Guna.UI2.WinForms.Guna2TextBox();
            txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            txtMatrix = new Guna.UI2.WinForms.Guna2TextBox();
            txtUserKey = new Guna.UI2.WinForms.Guna2TextBox();
            btnOpenFile = new Guna.UI2.WinForms.Guna2Button();
            openFileDialog = new OpenFileDialog();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSetKey
            // 
            btnSetKey.Location = new Point(236, 105);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(117, 23);
            btnSetKey.TabIndex = 26;
            btnSetKey.Text = "Confirmar llave";
            btnSetKey.UseVisualStyleBackColor = true;
            btnSetKey.Click += btnSetKey_Click;
            // 
            // btnShowMatrix
            // 
            btnShowMatrix.Location = new Point(589, 294);
            btnShowMatrix.Name = "btnShowMatrix";
            btnShowMatrix.Size = new Size(118, 23);
            btnShowMatrix.TabIndex = 23;
            btnShowMatrix.Text = "Mostrar matriz";
            btnShowMatrix.UseVisualStyleBackColor = true;
            btnShowMatrix.Click += btnShowMatrix_Click;
            // 
            // btnDescifrar
            // 
            btnDescifrar.Location = new Point(457, 285);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(75, 23);
            btnDescifrar.TabIndex = 19;
            btnDescifrar.Text = "Descifrar";
            btnDescifrar.UseVisualStyleBackColor = true;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // btnCifrado
            // 
            btnCifrado.Location = new Point(166, 285);
            btnCifrado.Name = "btnCifrado";
            btnCifrado.Size = new Size(75, 23);
            btnCifrado.TabIndex = 18;
            btnCifrado.Text = "Cifrar";
            btnCifrado.UseVisualStyleBackColor = true;
            btnCifrado.Click += btnCifrado_Click;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2HtmlLabel2);
            guna2GradientPanel1.Controls.Add(btnSetKey);
            guna2GradientPanel1.Controls.Add(txtDecryptedOutput);
            guna2GradientPanel1.Controls.Add(txtEncryptedOutput);
            guna2GradientPanel1.Controls.Add(txtInput);
            guna2GradientPanel1.Controls.Add(txtMatrix);
            guna2GradientPanel1.Controls.Add(txtUserKey);
            guna2GradientPanel1.Controls.Add(btnOpenFile);
            guna2GradientPanel1.Controls.Add(btnCifrado);
            guna2GradientPanel1.Controls.Add(btnDescifrar);
            guna2GradientPanel1.CustomizableEdges = customizableEdges13;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 12, 57);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 20, 89);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2GradientPanel1.Size = new Size(800, 450);
            guna2GradientPanel1.TabIndex = 27;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // txtDecryptedOutput
            // 
            txtDecryptedOutput.CustomizableEdges = customizableEdges1;
            txtDecryptedOutput.DefaultText = "";
            txtDecryptedOutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDecryptedOutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDecryptedOutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDecryptedOutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDecryptedOutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDecryptedOutput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDecryptedOutput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDecryptedOutput.Location = new Point(308, 342);
            txtDecryptedOutput.Multiline = true;
            txtDecryptedOutput.Name = "txtDecryptedOutput";
            txtDecryptedOutput.PasswordChar = '\0';
            txtDecryptedOutput.PlaceholderText = "";
            txtDecryptedOutput.SelectedText = "";
            txtDecryptedOutput.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtDecryptedOutput.Size = new Size(244, 80);
            txtDecryptedOutput.TabIndex = 32;
            // 
            // txtEncryptedOutput
            // 
            txtEncryptedOutput.CustomizableEdges = customizableEdges3;
            txtEncryptedOutput.DefaultText = "";
            txtEncryptedOutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEncryptedOutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEncryptedOutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEncryptedOutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEncryptedOutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEncryptedOutput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEncryptedOutput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEncryptedOutput.Location = new Point(308, 170);
            txtEncryptedOutput.Multiline = true;
            txtEncryptedOutput.Name = "txtEncryptedOutput";
            txtEncryptedOutput.PasswordChar = '\0';
            txtEncryptedOutput.PlaceholderText = "";
            txtEncryptedOutput.SelectedText = "";
            txtEncryptedOutput.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEncryptedOutput.Size = new Size(244, 102);
            txtEncryptedOutput.TabIndex = 31;
            // 
            // txtInput
            // 
            txtInput.CustomizableEdges = customizableEdges5;
            txtInput.DefaultText = "";
            txtInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInput.Location = new Point(25, 170);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.PasswordChar = '\0';
            txtInput.PlaceholderText = "";
            txtInput.SelectedText = "";
            txtInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtInput.Size = new Size(260, 102);
            txtInput.TabIndex = 30;
            // 
            // txtMatrix
            // 
            txtMatrix.CustomizableEdges = customizableEdges7;
            txtMatrix.DefaultText = "";
            txtMatrix.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMatrix.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMatrix.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMatrix.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMatrix.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatrix.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatrix.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatrix.Location = new Point(589, 143);
            txtMatrix.Multiline = true;
            txtMatrix.Name = "txtMatrix";
            txtMatrix.PasswordChar = '\0';
            txtMatrix.PlaceholderText = "";
            txtMatrix.SelectedText = "";
            txtMatrix.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMatrix.Size = new Size(116, 129);
            txtMatrix.TabIndex = 29;
            // 
            // txtUserKey
            // 
            txtUserKey.CustomizableEdges = customizableEdges9;
            txtUserKey.DefaultText = "";
            txtUserKey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserKey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserKey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserKey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserKey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserKey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserKey.Location = new Point(199, 44);
            txtUserKey.Name = "txtUserKey";
            txtUserKey.PasswordChar = '\0';
            txtUserKey.PlaceholderText = "";
            txtUserKey.SelectedText = "";
            txtUserKey.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtUserKey.Size = new Size(200, 36);
            txtUserKey.TabIndex = 28;
            txtUserKey.TextChanged += txtUserKey_TextChanged;
            // 
            // btnOpenFile
            // 
            btnOpenFile.CustomizableEdges = customizableEdges11;
            btnOpenFile.DisabledState.BorderColor = Color.DarkGray;
            btnOpenFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(41, 281);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnOpenFile.Size = new Size(97, 34);
            btnOpenFile.TabIndex = 23;
            btnOpenFile.Text = "cargar documento";
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.White;
            guna2HtmlLabel2.ForeColor = SystemColors.ActiveCaptionText;
            guna2HtmlLabel2.Location = new Point(41, 54);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(121, 17);
            guna2HtmlLabel2.TabIndex = 33;
            guna2HtmlLabel2.Text = "Ingrese la llave (clave):";
            // 
            // PlayfairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowMatrix);
            Controls.Add(guna2GradientPanel1);
            Name = "PlayfairForm";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSetKey;
        private Button btnShowMatrix;
        private Button btnDescifrar;
        private Button btnCifrado;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Button btnOpenFile;
        private Guna.UI2.WinForms.Guna2TextBox txtUserKey;
        private Guna.UI2.WinForms.Guna2TextBox txtMatrix;
        private Guna.UI2.WinForms.Guna2TextBox txtEncryptedOutput;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private Guna.UI2.WinForms.Guna2TextBox txtDecryptedOutput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}