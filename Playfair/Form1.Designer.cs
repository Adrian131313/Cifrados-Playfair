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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}