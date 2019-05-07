namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_CadPacientes
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
            this.btnAlterarP = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.dtpDatanasc = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarP
            // 
            this.btnAlterarP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarP.Location = new System.Drawing.Point(341, 277);
            this.btnAlterarP.Name = "btnAlterarP";
            this.btnAlterarP.Size = new System.Drawing.Size(97, 30);
            this.btnAlterarP.TabIndex = 71;
            this.btnAlterarP.Text = "Alterar";
            this.btnAlterarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarP.UseVisualStyleBackColor = false;
            this.btnAlterarP.Click += new System.EventHandler(this.btnAlterarP_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(13, 277);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 30);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(353, 82);
            this.mskCel.Mask = "(00)00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(85, 20);
            this.mskCel.TabIndex = 8;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(350, 66);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(53, 15);
            this.Label14.TabIndex = 69;
            this.Label14.Text = "Celular";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(262, 82);
            this.mskTel.Mask = "(00)0000-9999";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(71, 20);
            this.mskTel.TabIndex = 7;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(367, 180);
            this.mskCep.Mask = "00,000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(65, 20);
            this.mskCep.TabIndex = 14;
            // 
            // cmbUf
            // 
            this.cmbUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA ",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN ",
            "RS",
            "RO",
            "RR ",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(317, 179);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(41, 21);
            this.cmbUf.TabIndex = 13;
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(355, 36);
            this.mskRg.Mask = "00,000,000,0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(72, 20);
            this.mskRg.TabIndex = 4;
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "FEMININO",
            "MASCULINO",
            "OUTROS"});
            this.cmbSexo.Location = new System.Drawing.Point(12, 82);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(119, 21);
            this.cmbSexo.TabIndex = 5;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(258, 37);
            this.mskCpf.Mask = "000,000,000,00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(83, 20);
            this.mskCpf.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(175, 277);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 30);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(254, 228);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(184, 20);
            this.txtProntuario.TabIndex = 16;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(251, 212);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(74, 15);
            this.Label13.TabIndex = 68;
            this.Label13.Text = "Prontuário";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(9, 212);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(93, 15);
            this.Label12.TabIndex = 67;
            this.Label12.Text = "Responsável ";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsavel.Location = new System.Drawing.Point(12, 228);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(236, 20);
            this.txtResponsavel.TabIndex = 15;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(366, 164);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(34, 15);
            this.Label11.TabIndex = 66;
            this.Label11.Text = "CEP";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(316, 163);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(25, 15);
            this.Label10.TabIndex = 65;
            this.Label10.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "SOROCABA"});
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(165, 180);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(144, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(162, 164);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 15);
            this.Label9.TabIndex = 64;
            this.Label9.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(12, 180);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(144, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(9, 164);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(46, 15);
            this.Label8.TabIndex = 62;
            this.Label8.Text = "Bairro";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(359, 115);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(34, 15);
            this.Label7.TabIndex = 60;
            this.Label7.Text = "Nro.";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(362, 131);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(43, 20);
            this.txtNum.TabIndex = 10;
            // 
            // txtEnd
            // 
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Location = new System.Drawing.Point(12, 131);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(332, 20);
            this.txtEnd.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(9, 115);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 15);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "Endereço";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(259, 66);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 15);
            this.Label5.TabIndex = 53;
            this.Label5.Text = "Telefone";
            // 
            // dtpDatanasc
            // 
            this.dtpDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatanasc.Location = new System.Drawing.Point(143, 82);
            this.dtpDatanasc.Name = "dtpDatanasc";
            this.dtpDatanasc.Size = new System.Drawing.Size(110, 20);
            this.dtpDatanasc.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(138, 66);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(105, 15);
            this.Label4.TabIndex = 51;
            this.Label4.Text = "Dt. Nascimento";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(9, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 15);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Sexo";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(352, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 15);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(12, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(236, 20);
            this.txtNome.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(255, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 15);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(9, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 15);
            this.Nome.TabIndex = 39;
            this.Nome.Text = "Nome";
            // 
            // frm_CadPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(454, 323);
            this.Controls.Add(this.btnAlterarP);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.dtpDatanasc);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_CadPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.frm_CadPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAlterarP;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.MaskedTextBox mskCel;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.MaskedTextBox mskTel;
        internal System.Windows.Forms.MaskedTextBox mskCep;
        internal System.Windows.Forms.ComboBox cmbUf;
        internal System.Windows.Forms.MaskedTextBox mskRg;
        internal System.Windows.Forms.ComboBox cmbSexo;
        internal System.Windows.Forms.MaskedTextBox mskCpf;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.TextBox txtProntuario;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtResponsavel;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtNum;
        internal System.Windows.Forms.TextBox txtEnd;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DateTimePicker dtpDatanasc;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Nome;
    }
}