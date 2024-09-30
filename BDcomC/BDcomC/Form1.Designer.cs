namespace BDcomC
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
            lblTitulo = new Label();
            lblServer = new Label();
            lblDatabase = new Label();
            lblUserID = new Label();
            lblSenha = new Label();
            lblString = new Label();
            txtServer = new TextBox();
            txtDB = new TextBox();
            txtUserID = new TextBox();
            txtSenha = new TextBox();
            txtString = new TextBox();
            btnMostrar = new Button();
            btnConectar = new Button();
            btnDesconectar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(130, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(138, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Criar STRING de conexão";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(82, 136);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(42, 15);
            lblServer.TabIndex = 1;
            lblServer.Text = "Server:";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(66, 161);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(58, 15);
            lblDatabase.TabIndex = 2;
            lblDatabase.Text = "Database:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(77, 185);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(47, 15);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(64, 209);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Password:";
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Location = new Point(83, 233);
            lblString.Name = "lblString";
            lblString.Size = new Size(41, 15);
            lblString.TabIndex = 5;
            lblString.Text = "String:";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(130, 128);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(100, 23);
            txtServer.TabIndex = 6;
            // 
            // txtDB
            // 
            txtDB.Location = new Point(130, 153);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(100, 23);
            txtDB.TabIndex = 7;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(130, 177);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(100, 23);
            txtUserID.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(130, 201);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 9;
            // 
            // txtString
            // 
            txtString.Location = new Point(130, 225);
            txtString.Name = "txtString";
            txtString.Size = new Size(280, 23);
            txtString.TabIndex = 10;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(130, 266);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(100, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar String";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(236, 266);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(100, 23);
            btnConectar.TabIndex = 12;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(342, 266);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(100, 23);
            btnDesconectar.TabIndex = 13;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(btnMostrar);
            Controls.Add(txtString);
            Controls.Add(txtSenha);
            Controls.Add(txtUserID);
            Controls.Add(txtDB);
            Controls.Add(txtServer);
            Controls.Add(lblString);
            Controls.Add(lblSenha);
            Controls.Add(lblUserID);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblServer;
        private Label lblDatabase;
        private Label lblUserID;
        private Label lblSenha;
        private Label lblString;
        private TextBox txtServer;
        private TextBox txtDB;
        private TextBox txtUserID;
        private TextBox txtSenha;
        private TextBox txtString;
        private Button btnMostrar;
        private Button btnConectar;
        private Button btnDesconectar;
    }
}