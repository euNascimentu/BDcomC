namespace InsertInto
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
            lblNome = new Label();
            txtCPF = new Label();
            lblRG = new Label();
            lblCLLR = new Label();
            lblCodCliente = new Label();
            lblDataNascimento = new Label();
            lblSexo = new Label();
            lblUF = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            mskRG = new MaskedTextBox();
            mskDataNascimento = new MaskedTextBox();
            txtCodCliente = new TextBox();
            rdbMasc = new RadioButton();
            rdbFem = new RadioButton();
            cmbUF = new ComboBox();
            mskCEL = new MaskedTextBox();
            btnInserir = new Button();
            btnExcluirTodos = new Button();
            btnExcluirCliente = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtCPF
            // 
            txtCPF.AutoSize = true;
            txtCPF.Location = new Point(12, 58);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(31, 15);
            txtCPF.TabIndex = 1;
            txtCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(175, 58);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(25, 15);
            lblRG.TabIndex = 2;
            lblRG.Text = "RG:";
            // 
            // lblCLLR
            // 
            lblCLLR.AutoSize = true;
            lblCLLR.Location = new Point(309, 58);
            lblCLLR.Name = "lblCLLR";
            lblCLLR.Size = new Size(30, 15);
            lblCLLR.TabIndex = 3;
            lblCLLR.Text = "CEL:";
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Location = new Point(262, 105);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(89, 15);
            lblCodCliente.TabIndex = 4;
            lblCodCliente.Text = "Código Cliente:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(12, 105);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 5;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(8, 139);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo:";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(122, 141);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(111, 15);
            lblUF.TabIndex = 7;
            lblUF.Text = "Unidade Federativa:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(290, 23);
            txtNome.TabIndex = 8;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(49, 50);
            mskCPF.Mask = "000,000,000/00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 9;
            // 
            // mskRG
            // 
            mskRG.Location = new Point(203, 50);
            mskRG.Mask = "00,000,000,00";
            mskRG.Name = "mskRG";
            mskRG.Size = new Size(100, 23);
            mskRG.TabIndex = 10;
            // 
            // mskDataNascimento
            // 
            mskDataNascimento.Location = new Point(135, 97);
            mskDataNascimento.Mask = "0000/00/00";
            mskDataNascimento.Name = "mskDataNascimento";
            mskDataNascimento.Size = new Size(100, 23);
            mskDataNascimento.TabIndex = 11;
            mskDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtCodCliente
            // 
            txtCodCliente.Location = new Point(357, 97);
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.Size = new Size(100, 23);
            txtCodCliente.TabIndex = 12;
            // 
            // rdbMasc
            // 
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(43, 139);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(36, 19);
            rdbMasc.TabIndex = 13;
            rdbMasc.TabStop = true;
            rdbMasc.Text = "M";
            rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            rdbFem.AutoSize = true;
            rdbFem.Location = new Point(85, 139);
            rdbFem.Name = "rdbFem";
            rdbFem.Size = new Size(31, 19);
            rdbFem.TabIndex = 14;
            rdbFem.TabStop = true;
            rdbFem.Text = "F";
            rdbFem.UseVisualStyleBackColor = true;
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC ", "AL ", "AP ", "AM ", "BA ", "CE ", "DF ", "ES ", "GO ", "MA", "MT ", "MS ", "MG ", "PA ", "PB ", "PR ", "PE ", "PI ", "RJ ", "RN", "RS ", "RO ", "RR ", "SC ", "SP ", "SE", "TO" });
            cmbUF.Location = new Point(239, 133);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(64, 23);
            cmbUF.TabIndex = 15;
            // 
            // mskCEL
            // 
            mskCEL.Location = new Point(345, 50);
            mskCEL.Mask = "(00)00000-0000";
            mskCEL.Name = "mskCEL";
            mskCEL.Size = new Size(89, 23);
            mskCEL.TabIndex = 16;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 202);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnExcluirTodos
            // 
            btnExcluirTodos.Location = new Point(228, 202);
            btnExcluirTodos.Name = "btnExcluirTodos";
            btnExcluirTodos.Size = new Size(84, 23);
            btnExcluirTodos.TabIndex = 18;
            btnExcluirTodos.Text = "Excluir Todos";
            btnExcluirTodos.UseVisualStyleBackColor = true;
            btnExcluirTodos.Click += btnExcluirTodos_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(110, 202);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(90, 23);
            btnExcluirCliente.TabIndex = 19;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnExcluirTodos);
            Controls.Add(btnInserir);
            Controls.Add(mskCEL);
            Controls.Add(cmbUF);
            Controls.Add(rdbFem);
            Controls.Add(rdbMasc);
            Controls.Add(txtCodCliente);
            Controls.Add(mskDataNascimento);
            Controls.Add(mskRG);
            Controls.Add(mskCPF);
            Controls.Add(txtNome);
            Controls.Add(lblUF);
            Controls.Add(lblSexo);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblCodCliente);
            Controls.Add(lblCLLR);
            Controls.Add(lblRG);
            Controls.Add(txtCPF);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label txtCPF;
        private Label lblRG;
        private Label lblCLLR;
        private Label lblCodCliente;
        private Label lblDataNascimento;
        private Label lblSexo;
        private Label lblUF;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private MaskedTextBox mskRG;
        private MaskedTextBox mskDataNascimento;
        private TextBox txtCodCliente;
        private RadioButton rdbMasc;
        private RadioButton rdbFem;
        private ComboBox cmbUF;
        private MaskedTextBox mskCEL;
        private Button btnInserir;
        private Button btnExcluirTodos;
        private Button btnExcluirCliente;
    }
}