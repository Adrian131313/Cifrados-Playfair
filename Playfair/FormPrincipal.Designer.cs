namespace Playfair
{
    partial class FormPrincipal
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
            btnOpenPlayfair = new Guna.UI2.WinForms.Guna2Button();
            btnOpenVigenere = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnOpenPlayfair
            // 
            btnOpenPlayfair.CustomizableEdges = customizableEdges1;
            btnOpenPlayfair.DisabledState.BorderColor = Color.DarkGray;
            btnOpenPlayfair.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenPlayfair.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenPlayfair.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenPlayfair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenPlayfair.ForeColor = Color.White;
            btnOpenPlayfair.Location = new Point(141, 145);
            btnOpenPlayfair.Name = "btnOpenPlayfair";
            btnOpenPlayfair.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOpenPlayfair.Size = new Size(180, 45);
            btnOpenPlayfair.TabIndex = 0;
            btnOpenPlayfair.Text = "Playfair";
            btnOpenPlayfair.Click += btnOpenPlayfair_Click;
            // 
            // btnOpenVigenere
            // 
            btnOpenVigenere.CustomizableEdges = customizableEdges3;
            btnOpenVigenere.DisabledState.BorderColor = Color.DarkGray;
            btnOpenVigenere.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenVigenere.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenVigenere.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenVigenere.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenVigenere.ForeColor = Color.White;
            btnOpenVigenere.Location = new Point(427, 145);
            btnOpenVigenere.Name = "btnOpenVigenere";
            btnOpenVigenere.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnOpenVigenere.Size = new Size(180, 45);
            btnOpenVigenere.TabIndex = 1;
            btnOpenVigenere.Text = "Vigenere";
            btnOpenVigenere.Click += btnOpenVigenere_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenVigenere);
            Controls.Add(btnOpenPlayfair);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOpenPlayfair;
        private Guna.UI2.WinForms.Guna2Button btnOpenVigenere;
    }
}