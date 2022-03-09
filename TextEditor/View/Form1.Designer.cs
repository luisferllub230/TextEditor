namespace TextEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivos = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.Adelantar = new System.Windows.Forms.ToolStripMenuItem();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.formato = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivos,
            this.Editar,
            this.color,
            this.formato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivos
            // 
            this.Archivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Guardar,
            this.nuevo,
            this.Cerrar});
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(65, 20);
            this.Archivos.Text = "Archivos";
            // 
            // Abrir
            // 
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(180, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(180, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(180, 22);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Editar
            // 
            this.Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Adelantar,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.seleccionarTodo,
            this.eliminarTodo});
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(49, 20);
            this.Editar.Text = "Editar";
            // 
            // Atras
            // 
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(163, 22);
            this.Atras.Text = "Atras";
            // 
            // Adelantar
            // 
            this.Adelantar.Name = "Adelantar";
            this.Adelantar.Size = new System.Drawing.Size(163, 22);
            this.Adelantar.Text = "Adelantar ";
            // 
            // Copiar
            // 
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(163, 22);
            this.Copiar.Text = "Copiar";
            // 
            // Cortar
            // 
            this.Cortar.Name = "Cortar";
            this.Cortar.Size = new System.Drawing.Size(163, 22);
            this.Cortar.Text = "Cortar";
            // 
            // Pegar
            // 
            this.Pegar.Name = "Pegar";
            this.Pegar.Size = new System.Drawing.Size(163, 22);
            this.Pegar.Text = "Pegar";
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.Size = new System.Drawing.Size(163, 22);
            this.seleccionarTodo.Text = "Seleccionar Todo";
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.Size = new System.Drawing.Size(163, 22);
            this.eliminarTodo.Text = "Eliminar todo";
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(48, 20);
            this.color.Text = "Color";
            // 
            // formato
            // 
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(67, 20);
            this.formato.Text = "Formato ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 401);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // nuevo
            // 
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(180, 22);
            this.nuevo.Text = "nuevo";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 425);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivos;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem Atras;
        private System.Windows.Forms.ToolStripMenuItem Adelantar;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodo;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem formato;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
    }
}

