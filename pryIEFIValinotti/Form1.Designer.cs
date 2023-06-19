namespace pryIEFIValinotti
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTituloChico = new System.Windows.Forms.Label();
            this.pbLogoGrande = new System.Windows.Forms.PictureBox();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.pbLogoChico = new System.Windows.Forms.PictureBox();
            this.lblTituloGrande = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoChico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.lblTituloChico);
            this.panelMenu.Controls.Add(this.pbLogoGrande);
            this.panelMenu.Controls.Add(this.cmdVentas);
            this.panelMenu.Controls.Add(this.cmdProductos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 497);
            this.panelMenu.TabIndex = 0;
            // 
            // lblTituloChico
            // 
            this.lblTituloChico.AutoSize = true;
            this.lblTituloChico.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChico.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloChico.Location = new System.Drawing.Point(79, 29);
            this.lblTituloChico.Name = "lblTituloChico";
            this.lblTituloChico.Size = new System.Drawing.Size(131, 68);
            this.lblTituloChico.TabIndex = 3;
            this.lblTituloChico.Text = "Ventas";
            // 
            // pbLogoGrande
            // 
            this.pbLogoGrande.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoGrande.Image")));
            this.pbLogoGrande.Location = new System.Drawing.Point(12, 36);
            this.pbLogoGrande.Name = "pbLogoGrande";
            this.pbLogoGrande.Size = new System.Drawing.Size(50, 50);
            this.pbLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoGrande.TabIndex = 1;
            this.pbLogoGrande.TabStop = false;
            // 
            // cmdVentas
            // 
            this.cmdVentas.FlatAppearance.BorderSize = 0;
            this.cmdVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdVentas.Image = ((System.Drawing.Image)(resources.GetObject("cmdVentas.Image")));
            this.cmdVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentas.Location = new System.Drawing.Point(2, 204);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(225, 46);
            this.cmdVentas.TabIndex = 2;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.FlatAppearance.BorderSize = 0;
            this.cmdProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdProductos.Image = ((System.Drawing.Image)(resources.GetObject("cmdProductos.Image")));
            this.cmdProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProductos.Location = new System.Drawing.Point(2, 144);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(225, 46);
            this.cmdProductos.TabIndex = 1;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = true;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // pbLogoChico
            // 
            this.pbLogoChico.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoChico.Image")));
            this.pbLogoChico.Location = new System.Drawing.Point(368, 100);
            this.pbLogoChico.Name = "pbLogoChico";
            this.pbLogoChico.Size = new System.Drawing.Size(150, 150);
            this.pbLogoChico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoChico.TabIndex = 2;
            this.pbLogoChico.TabStop = false;
            // 
            // lblTituloGrande
            // 
            this.lblTituloGrande.AutoSize = true;
            this.lblTituloGrande.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrande.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloGrande.Location = new System.Drawing.Point(563, 144);
            this.lblTituloGrande.Name = "lblTituloGrande";
            this.lblTituloGrande.Size = new System.Drawing.Size(190, 103);
            this.lblTituloGrande.TabIndex = 4;
            this.lblTituloGrande.Text = "Ventas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(759, 465);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 23);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Lucas Valinotti";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(857, 497);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloGrande);
            this.Controls.Add(this.pbLogoChico);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ventas";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoChico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Label lblTituloChico;
        private System.Windows.Forms.PictureBox pbLogoGrande;
        private System.Windows.Forms.PictureBox pbLogoChico;
        private System.Windows.Forms.Label lblTituloGrande;
        private System.Windows.Forms.Label lblNombre;
    }
}

