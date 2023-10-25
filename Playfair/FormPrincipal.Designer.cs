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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnOpenPlayfair = new Guna.UI2.WinForms.Guna2Button();
            btnOpenVigenere = new Guna.UI2.WinForms.Guna2Button();
            btnOpenCesar = new Guna.UI2.WinForms.Guna2Button();
            pnlMenu = new Panel();
            pnlContainer = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenPlayfair
            // 
            btnOpenPlayfair.Anchor = AnchorStyles.None;
            btnOpenPlayfair.CustomizableEdges = customizableEdges1;
            btnOpenPlayfair.DisabledState.BorderColor = Color.DarkGray;
            btnOpenPlayfair.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenPlayfair.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenPlayfair.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenPlayfair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenPlayfair.ForeColor = Color.White;
            btnOpenPlayfair.Location = new Point(35, 283);
            btnOpenPlayfair.Name = "btnOpenPlayfair";
            btnOpenPlayfair.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOpenPlayfair.Size = new Size(180, 45);
            btnOpenPlayfair.TabIndex = 0;
            btnOpenPlayfair.Text = "Playfair";
            btnOpenPlayfair.Click += btnOpenPlayfair_Click;
            // 
            // btnOpenVigenere
            // 
            btnOpenVigenere.Anchor = AnchorStyles.None;
            btnOpenVigenere.CustomizableEdges = customizableEdges3;
            btnOpenVigenere.DisabledState.BorderColor = Color.DarkGray;
            btnOpenVigenere.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenVigenere.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenVigenere.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenVigenere.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenVigenere.ForeColor = Color.White;
            btnOpenVigenere.Location = new Point(35, 202);
            btnOpenVigenere.Name = "btnOpenVigenere";
            btnOpenVigenere.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnOpenVigenere.Size = new Size(180, 45);
            btnOpenVigenere.TabIndex = 1;
            btnOpenVigenere.Text = "Vigenere";
            btnOpenVigenere.Click += btnOpenVigenere_Click;
            // 
            // btnOpenCesar
            // 
            btnOpenCesar.Anchor = AnchorStyles.None;
            btnOpenCesar.CustomizableEdges = customizableEdges5;
            btnOpenCesar.DisabledState.BorderColor = Color.DarkGray;
            btnOpenCesar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenCesar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenCesar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenCesar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenCesar.ForeColor = Color.White;
            btnOpenCesar.Location = new Point(35, 358);
            btnOpenCesar.Name = "btnOpenCesar";
            btnOpenCesar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnOpenCesar.Size = new Size(180, 45);
            btnOpenCesar.TabIndex = 2;
            btnOpenCesar.Text = "Cesar";
            btnOpenCesar.Click += guna2Button1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveBorder;
            pnlMenu.Controls.Add(btnOpenVigenere);
            pnlMenu.Controls.Add(btnOpenPlayfair);
            pnlMenu.Controls.Add(btnOpenCesar);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(259, 567);
            pnlMenu.TabIndex = 4;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ButtonShadow;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(259, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(999, 567);
            pnlContainer.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 567);
            Controls.Add(pnlContainer);
            Controls.Add(pnlMenu);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOpenPlayfair;
        private Guna.UI2.WinForms.Guna2Button btnOpenVigenere;
        private Guna.UI2.WinForms.Guna2Button btnOpenCesar;
        private Panel pnlMenu;
        private Panel pnlContainer;
    }
}