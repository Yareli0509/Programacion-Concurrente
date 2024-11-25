namespace DemoConcurrencia
{
    partial class FrmBloqueo
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
            btnIncrementar = new Button();
            lblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(20, 13);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(124, 57);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(33, 130);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(17, 20);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // btnDisminuir
            // 
            btnDisminuir.Location = new Point(21, 194);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(123, 65);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = true;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(29, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            splitContainer1.Panel1.Controls.Add(lblContador);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(769, 430);
            splitContainer1.SplitterDistance = 256;
            splitContainer1.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(3, 3);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(503, 423);
            txtResultado.TabIndex = 1;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // FrmBloqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueo";
            Text = "Gestion de Bloqueo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label lblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox txtResultado;
    }
}