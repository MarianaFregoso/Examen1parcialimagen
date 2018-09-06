namespace Examen1parcial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.histogramaRedToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // histogramaRedToolStripMenuItem
            // 
            this.histogramaRedToolStripMenuItem.Name = "histogramaRedToolStripMenuItem";
            this.histogramaRedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramaRedToolStripMenuItem.Text = "HistogramaRed";
            this.histogramaRedToolStripMenuItem.Click += new System.EventHandler(this.histogramaRedToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.AutoSize = true;
            this.histogramBox1.Location = new System.Drawing.Point(331, 98);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(419, 221);
            this.histogramBox1.TabIndex = 3;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(225, 325);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(269, 219);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Enabled = false;
            this.imageBox1.Location = new System.Drawing.Point(12, 98);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(297, 221);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ExamenParcial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        protected Emgu.CV.UI.ImageBox imageBox1;
    }
}

