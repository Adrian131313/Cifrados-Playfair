﻿namespace Playfair
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
            txtEncryptedOutput = new TextBox();
            btnSetKey = new Button();
            txtUserKey = new TextBox();
            txtMatrix = new TextBox();
            btnShowMatrix = new Button();
            txtDecryptedOutput = new TextBox();
            txtInput = new TextBox();
            btnDescifrar = new Button();
            btnCifrado = new Button();
            SuspendLayout();
            // 
            // txtEncryptedOutput
            // 
            txtEncryptedOutput.Location = new Point(351, 216);
            txtEncryptedOutput.Name = "txtEncryptedOutput";
            txtEncryptedOutput.Size = new Size(100, 23);
            txtEncryptedOutput.TabIndex = 21;
            // 
            // btnSetKey
            // 
            btnSetKey.Location = new Point(94, 110);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(117, 23);
            btnSetKey.TabIndex = 26;
            btnSetKey.Text = "Confirmar llave";
            btnSetKey.UseVisualStyleBackColor = true;
            btnSetKey.Click += btnSetKey_Click;
            // 
            // txtUserKey
            // 
            txtUserKey.Location = new Point(94, 69);
            txtUserKey.Name = "txtUserKey";
            txtUserKey.Size = new Size(117, 23);
            txtUserKey.TabIndex = 25;
            // 
            // txtMatrix
            // 
            txtMatrix.Location = new Point(606, 170);
            txtMatrix.Multiline = true;
            txtMatrix.Name = "txtMatrix";
            txtMatrix.Size = new Size(86, 94);
            txtMatrix.TabIndex = 24;
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
            // txtDecryptedOutput
            // 
            txtDecryptedOutput.Location = new Point(323, 358);
            txtDecryptedOutput.Name = "txtDecryptedOutput";
            txtDecryptedOutput.Size = new Size(100, 23);
            txtDecryptedOutput.TabIndex = 22;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(124, 216);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 20;
            // 
            // btnDescifrar
            // 
            btnDescifrar.Location = new Point(336, 294);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(75, 23);
            btnDescifrar.TabIndex = 19;
            btnDescifrar.Text = "Descifrar";
            btnDescifrar.UseVisualStyleBackColor = true;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // btnCifrado
            // 
            btnCifrado.Location = new Point(136, 294);
            btnCifrado.Name = "btnCifrado";
            btnCifrado.Size = new Size(75, 23);
            btnCifrado.TabIndex = 18;
            btnCifrado.Text = "Cifrar";
            btnCifrado.UseVisualStyleBackColor = true;
            btnCifrado.Click += btnCifrado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEncryptedOutput);
            Controls.Add(btnSetKey);
            Controls.Add(txtUserKey);
            Controls.Add(txtMatrix);
            Controls.Add(btnShowMatrix);
            Controls.Add(txtDecryptedOutput);
            Controls.Add(txtInput);
            Controls.Add(btnDescifrar);
            Controls.Add(btnCifrado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEncryptedOutput;
        private Button btnSetKey;
        private TextBox txtUserKey;
        private TextBox txtMatrix;
        private Button btnShowMatrix;
        private TextBox txtDecryptedOutput;
        private TextBox txtInput;
        private Button btnDescifrar;
        private Button btnCifrado;
    }
}