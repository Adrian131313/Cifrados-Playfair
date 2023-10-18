namespace Playfair
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
            btnCifrado = new Button();
            btnDescifrar = new Button();
            txtInput = new TextBox();
            txtEncryptedOutput = new TextBox();
            txtDecryptedOutput = new TextBox();
            btnShowMatrix = new Button();
            txtMatrix = new TextBox();
            txtUserKey = new TextBox();
            btnSetKey = new Button();
            SuspendLayout();
            // 
            // btnCifrado
            // 
            btnCifrado.Location = new Point(149, 292);
            btnCifrado.Name = "btnCifrado";
            btnCifrado.Size = new Size(75, 23);
            btnCifrado.TabIndex = 0;
            btnCifrado.Text = "Cifrar";
            btnCifrado.UseVisualStyleBackColor = true;
            btnCifrado.Click += btnCifrado_Click;
            // 
            // btnDescifrar
            // 
            btnDescifrar.Location = new Point(349, 292);
            btnDescifrar.Name = "btnDescifrar";
            btnDescifrar.Size = new Size(75, 23);
            btnDescifrar.TabIndex = 1;
            btnDescifrar.Text = "Descifrar";
            btnDescifrar.UseVisualStyleBackColor = true;
            btnDescifrar.Click += btnDescifrar_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(137, 214);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 2;
            // 
            // txtEncryptedOutput
            // 
            txtEncryptedOutput.Location = new Point(336, 214);
            txtEncryptedOutput.Name = "txtEncryptedOutput";
            txtEncryptedOutput.Size = new Size(100, 23);
            txtEncryptedOutput.TabIndex = 3;
            // 
            // txtDecryptedOutput
            // 
            txtDecryptedOutput.Location = new Point(336, 356);
            txtDecryptedOutput.Name = "txtDecryptedOutput";
            txtDecryptedOutput.Size = new Size(100, 23);
            txtDecryptedOutput.TabIndex = 4;
            // 
            // btnShowMatrix
            // 
            btnShowMatrix.Location = new Point(602, 292);
            btnShowMatrix.Name = "btnShowMatrix";
            btnShowMatrix.Size = new Size(118, 23);
            btnShowMatrix.TabIndex = 5;
            btnShowMatrix.Text = "Mostrar matriz";
            btnShowMatrix.UseVisualStyleBackColor = true;
            btnShowMatrix.Click += btnShowMatrix_Click;
            // 
            // txtMatrix
            // 
            txtMatrix.Location = new Point(619, 168);
            txtMatrix.Multiline = true;
            txtMatrix.Name = "txtMatrix";
            txtMatrix.Size = new Size(86, 94);
            txtMatrix.TabIndex = 6;
            // 
            // txtUserKey
            // 
            txtUserKey.Location = new Point(107, 67);
            txtUserKey.Name = "txtUserKey";
            txtUserKey.Size = new Size(117, 23);
            txtUserKey.TabIndex = 7;
            // 
            // btnSetKey
            // 
            btnSetKey.Location = new Point(107, 108);
            btnSetKey.Name = "btnSetKey";
            btnSetKey.Size = new Size(117, 23);
            btnSetKey.TabIndex = 8;
            btnSetKey.Text = "Confirmar llave";
            btnSetKey.UseVisualStyleBackColor = true;
            btnSetKey.Click += btnSetKey_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetKey);
            Controls.Add(txtUserKey);
            Controls.Add(txtMatrix);
            Controls.Add(btnShowMatrix);
            Controls.Add(txtDecryptedOutput);
            Controls.Add(txtEncryptedOutput);
            Controls.Add(txtInput);
            Controls.Add(btnDescifrar);
            Controls.Add(btnCifrado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCifrado;
        private Button btnDescifrar;
        private TextBox txtInput;
        private TextBox txtEncryptedOutput;
        private TextBox txtDecryptedOutput;
        private Button btnShowMatrix;
        private TextBox txtMatrix;
        private TextBox txtUserKey;
        private Button btnSetKey;
    }
}