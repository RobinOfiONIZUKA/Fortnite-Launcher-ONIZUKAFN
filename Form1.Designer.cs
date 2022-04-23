using System;

namespace Template_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 243;
            this.label1.Text = "Bienvenido A ONIZUKΛFN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(4, 204);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(74, 21);
            this.Version.TabIndex = 246;
            this.Version.Text = "F Version";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 248;
            this.label3.Text = "Version Del Launcher:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 39;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(214, 106);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(251, 81);
            this.guna2Button1.TabIndex = 249;
            this.guna2Button1.Text = "Inicar Fortnite";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.BackgroundImage")));
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(571, 4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(20, 20);
            this.pictureBox22.TabIndex = 245;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox24.BackgroundImage")));
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(608, 4);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(20, 20);
            this.pictureBox24.TabIndex = 244;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 16;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(4, 59);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(109, 35);
            this.guna2Button2.TabIndex = 252;
            this.guna2Button2.Text = "Verificar Fortnite";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // Form1
            // 
            this.AccentColor = System.Drawing.Color.Black;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 226);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HideBorderWhenMaximized = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "ONIZUKΛFN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

