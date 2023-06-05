namespace Crud_proyecto
{
    partial class Form3
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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.text_contenido = new System.Windows.Forms.TextBox();
            this.text_tipo = new System.Windows.Forms.TextBox();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Gold;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(598, 205);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(153, 43);
            this.buttonActualizar.TabIndex = 0;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 144);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // text_nombre
            // 
            this.text_nombre.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(248, 113);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(219, 24);
            this.text_nombre.TabIndex = 2;
            this.text_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_precio
            // 
            this.text_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_precio.Location = new System.Drawing.Point(556, 104);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(98, 24);
            this.text_precio.TabIndex = 3;
            this.text_precio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // text_contenido
            // 
            this.text_contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contenido.Location = new System.Drawing.Point(173, 163);
            this.text_contenido.Name = "text_contenido";
            this.text_contenido.Size = new System.Drawing.Size(179, 24);
            this.text_contenido.TabIndex = 4;
            this.text_contenido.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_tipo
            // 
            this.text_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tipo.Location = new System.Drawing.Point(556, 163);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(195, 24);
            this.text_tipo.TabIndex = 5;
            this.text_tipo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Descripcion.Location = new System.Drawing.Point(173, 205);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(405, 24);
            this.text_Descripcion.TabIndex = 6;
            this.text_Descripcion.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form3
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Crud_proyecto.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_Descripcion);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.text_contenido);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonActualizar);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Fr_actualizar";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.TextBox text_contenido;
        private System.Windows.Forms.TextBox text_tipo;
        private System.Windows.Forms.TextBox text_Descripcion;
    }
}