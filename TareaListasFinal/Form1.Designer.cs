namespace TareaListasFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnOrdenado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listVisual = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(33, 67);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(128, 20);
            this.txtDato.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(33, 134);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(128, 23);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Insertar al Frente";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(33, 163);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(128, 23);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Insertar al Final";
            this.btnFinal.UseVisualStyleBackColor = true;
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(33, 192);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(128, 23);
            this.btnPosicion.TabIndex = 4;
            this.btnPosicion.Text = "Insertar en Posición";
            this.btnPosicion.UseVisualStyleBackColor = true;
            // 
            // btnOrdenado
            // 
            this.btnOrdenado.Location = new System.Drawing.Point(33, 221);
            this.btnOrdenado.Name = "btnOrdenado";
            this.btnOrdenado.Size = new System.Drawing.Size(128, 23);
            this.btnOrdenado.TabIndex = 5;
            this.btnOrdenado.Text = "Insertar Ordenado";
            this.btnOrdenado.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(33, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar al Frente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button5_Click);
            // 
            // listVisual
            // 
            this.listVisual.FormattingEnabled = true;
            this.listVisual.Location = new System.Drawing.Point(205, 134);
            this.listVisual.Name = "listVisual";
            this.listVisual.Size = new System.Drawing.Size(120, 95);
            this.listVisual.TabIndex = 7;
            this.listVisual.SelectedIndexChanged += new System.EventHandler(this.listVisual_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.listVisual);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOrdenado);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnOrdenado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listVisual;
    }
}

