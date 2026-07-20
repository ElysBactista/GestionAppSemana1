namespace ProyectoFinalListas
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.listVisual = new System.Windows.Forms.ListBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnOrdenado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(115, 35);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(136, 20);
            this.txtDato.TabIndex = 0;
            // 
            // listVisual
            // 
            this.listVisual.FormattingEnabled = true;
            this.listVisual.Location = new System.Drawing.Point(312, 35);
            this.listVisual.Name = "listVisual";
            this.listVisual.Size = new System.Drawing.Size(120, 95);
            this.listVisual.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(115, 98);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(136, 23);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Insertar Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(115, 158);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(136, 23);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Insertar Final ";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(115, 212);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(136, 23);
            this.btnPosicion.TabIndex = 4;
            this.btnPosicion.Text = "Insertar Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnOrdenado
            // 
            this.btnOrdenado.Location = new System.Drawing.Point(115, 265);
            this.btnOrdenado.Name = "btnOrdenado";
            this.btnOrdenado.Size = new System.Drawing.Size(136, 23);
            this.btnOrdenado.TabIndex = 5;
            this.btnOrdenado.Text = "Insertar Ordenado";
            this.btnOrdenado.UseVisualStyleBackColor = true;
            this.btnOrdenado.Click += new System.EventHandler(this.btnOrdenado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(115, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Primero";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOrdenado);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.listVisual);
            this.Controls.Add(this.txtDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ListBox listVisual;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnOrdenado;
        private System.Windows.Forms.Button btnEliminar;
    }
}

