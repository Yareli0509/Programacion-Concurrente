namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignarcadenaconexion = new Button();
            btnObtenercadenaconexion = new Button();
            txtCadenaConexion = new TextBox();
            LblCadenaconexion = new Label();
            LblRecuperacioncadenaconexion = new Label();
            SuspendLayout();
            // 
            // btnAsignarcadenaconexion
            // 
            btnAsignarcadenaconexion.Location = new Point(61, 117);
            btnAsignarcadenaconexion.Name = "btnAsignarcadenaconexion";
            btnAsignarcadenaconexion.Size = new Size(127, 50);
            btnAsignarcadenaconexion.TabIndex = 0;
            btnAsignarcadenaconexion.Text = "Asignar Cadena de Conexion";
            btnAsignarcadenaconexion.UseVisualStyleBackColor = true;
            btnAsignarcadenaconexion.Click += btnAsignarcadenaconexion_Click;
            // 
            // btnObtenercadenaconexion
            // 
            btnObtenercadenaconexion.Location = new Point(61, 210);
            btnObtenercadenaconexion.Name = "btnObtenercadenaconexion";
            btnObtenercadenaconexion.Size = new Size(127, 51);
            btnObtenercadenaconexion.TabIndex = 1;
            btnObtenercadenaconexion.Text = "Obtener Cadena de Conexion";
            btnObtenercadenaconexion.UseVisualStyleBackColor = true;
            btnObtenercadenaconexion.Click += btnObtenercadenaconexion_Click;
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(55, 53);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(493, 27);
            txtCadenaConexion.TabIndex = 2;
            // 
            // LblCadenaconexion
            // 
            LblCadenaconexion.AutoSize = true;
            LblCadenaconexion.Location = new Point(64, 17);
            LblCadenaconexion.Name = "LblCadenaconexion";
            LblCadenaconexion.Size = new Size(125, 20);
            LblCadenaconexion.TabIndex = 3;
            LblCadenaconexion.Text = "Cadena Conexion";
            // 
            // LblRecuperacioncadenaconexion
            // 
            LblRecuperacioncadenaconexion.AutoSize = true;
            LblRecuperacioncadenaconexion.Location = new Point(252, 213);
            LblRecuperacioncadenaconexion.Name = "LblRecuperacioncadenaconexion";
            LblRecuperacioncadenaconexion.Size = new Size(18, 20);
            LblRecuperacioncadenaconexion.TabIndex = 4;
            LblRecuperacioncadenaconexion.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 311);
            Controls.Add(LblRecuperacioncadenaconexion);
            Controls.Add(LblCadenaconexion);
            Controls.Add(txtCadenaConexion);
            Controls.Add(btnObtenercadenaconexion);
            Controls.Add(btnAsignarcadenaconexion);
            Name = "FrmPatronSingleton";
            Text = "FrmPatronSingleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignarcadenaconexion;
        private Button btnObtenercadenaconexion;
        private TextBox txtCadenaConexion;
        private Label LblCadenaconexion;
        private Label LblRecuperacioncadenaconexion;
    }
}