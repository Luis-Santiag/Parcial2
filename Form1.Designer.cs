namespace _2doParcial_Aranza
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
            btnFrmJugador = new Button();
            btnFrmInventario = new Button();
            btnFrmBloques = new Button();
            buttonSalir = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // btnFrmJugador
            // 
            btnFrmJugador.Font = new Font("Showcard Gothic", 12F);
            btnFrmJugador.ForeColor = Color.BlueViolet;
            btnFrmJugador.Location = new Point(286, 175);
            btnFrmJugador.Name = "btnFrmJugador";
            btnFrmJugador.Size = new Size(165, 38);
            btnFrmJugador.TabIndex = 0;
            btnFrmJugador.Text = "Jugadores";
            btnFrmJugador.UseVisualStyleBackColor = true;
            btnFrmJugador.Click += btnFrmJugador_Click;
            // 
            // btnFrmInventario
            // 
            btnFrmInventario.Font = new Font("Showcard Gothic", 12F);
            btnFrmInventario.ForeColor = Color.BlueViolet;
            btnFrmInventario.Location = new Point(286, 240);
            btnFrmInventario.Name = "btnFrmInventario";
            btnFrmInventario.Size = new Size(165, 38);
            btnFrmInventario.TabIndex = 1;
            btnFrmInventario.Text = "Inventario";
            btnFrmInventario.UseVisualStyleBackColor = true;
            btnFrmInventario.Click += btnFrmInventario_Click;
            // 
            // btnFrmBloques
            // 
            btnFrmBloques.Font = new Font("Showcard Gothic", 12F);
            btnFrmBloques.ForeColor = Color.BlueViolet;
            btnFrmBloques.Location = new Point(515, 175);
            btnFrmBloques.Name = "btnFrmBloques";
            btnFrmBloques.Size = new Size(165, 38);
            btnFrmBloques.TabIndex = 2;
            btnFrmBloques.Text = "Bloques";
            btnFrmBloques.UseVisualStyleBackColor = true;
            btnFrmBloques.Click += btnFrmBloques_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Showcard Gothic", 12F);
            buttonSalir.ForeColor = Color.BlueViolet;
            buttonSalir.Location = new Point(515, 240);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(165, 38);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 520);
            Controls.Add(buttonSalir);
            Controls.Add(btnFrmBloques);
            Controls.Add(btnFrmInventario);
            Controls.Add(btnFrmJugador);
            ForeColor = Color.Crimson;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmJugador;
        private Button btnFrmInventario;
        private Button btnFrmBloques;
        private Button buttonSalir;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
