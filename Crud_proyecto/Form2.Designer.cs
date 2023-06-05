namespace Crud_proyecto
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.text_tipo = new System.Windows.Forms.TextBox();
            this.textcontenido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(635, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(259, 120);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(206, 20);
            this.text_nombre.TabIndex = 1;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(259, 162);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(206, 20);
            this.text_descripcion.TabIndex = 2;
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(259, 198);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(206, 20);
            this.text_precio.TabIndex = 3;
            // 
            // text_tipo
            // 
            this.text_tipo.Location = new System.Drawing.Point(259, 235);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(206, 20);
            this.text_tipo.TabIndex = 4;
            // 
            // textcontenido
            // 
            this.textcontenido.Location = new System.Drawing.Point(259, 284);
            this.textcontenido.Name = "textcontenido";
            this.textcontenido.Size = new System.Drawing.Size(206, 20);
            this.textcontenido.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 82);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Crud_proyecto.Properties.Resources.Copia_de_fondo_de_pantalla_frase_motivacional_marmol_rosa_negro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textcontenido);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Fr_agreagr";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.TextBox text_tipo;
        private System.Windows.Forms.TextBox textcontenido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}