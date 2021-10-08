namespace LogIn_Soriana
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.boton_logIn = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Usuario.Location = new System.Drawing.Point(104, 19);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(69, 17);
            this.label_Usuario.TabIndex = 0;
            this.label_Usuario.Text = "Usuario:";
            this.label_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Contraseña.Location = new System.Drawing.Point(88, 90);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(96, 17);
            this.label_Contraseña.TabIndex = 1;
            this.label_Contraseña.Text = "Contraseña:";
            this.label_Contraseña.Click += new System.EventHandler(this.label_Contraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(59, 48);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(59, 120);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(156, 23);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // boton_logIn
            // 
            this.boton_logIn.BackColor = System.Drawing.Color.Olive;
            this.boton_logIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_logIn.FlatAppearance.BorderSize = 0;
            this.boton_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_logIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.boton_logIn.Location = new System.Drawing.Point(59, 171);
            this.boton_logIn.Name = "boton_logIn";
            this.boton_logIn.Size = new System.Drawing.Size(156, 43);
            this.boton_logIn.TabIndex = 5;
            this.boton_logIn.Text = "Iniciar Sesión";
            this.boton_logIn.UseVisualStyleBackColor = false;
            this.boton_logIn.Click += new System.EventHandler(this.boton_logIn_Click);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(104, 229);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(60, 13);
            this.Registro.TabIndex = 6;
            this.Registro.TabStop = true;
            this.Registro.Text = "Registrarse";
            this.Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 261);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.boton_logIn);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button boton_logIn;
        private System.Windows.Forms.LinkLabel Registro;
    }
}

