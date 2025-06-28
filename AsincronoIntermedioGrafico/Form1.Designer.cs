namespace AsincronoIntermedioGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcesar = new Button();
            btnCancelar = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(189, 100);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "PROCESAR";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(376, 101);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(302, 171);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(38, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(btnCancelar);
            Controls.Add(btnProcesar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcesar;
        private Button btnCancelar;
        private Label lblEstado;
    }
}
