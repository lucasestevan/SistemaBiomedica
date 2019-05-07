namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_LocalizarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LocalizarPaciente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSelecionarBioq = new System.Windows.Forms.Button();
            this.btnSelecionarHema = new System.Windows.Forms.Button();
            this.btnSelecionarUrina = new System.Windows.Forms.Button();
            this.btnSelecionarMicro = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgLocalizarPac = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalizarPac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(435, 83);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(52, 20);
            this.txtIdPac.TabIndex = 115;
            this.txtIdPac.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(432, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 114;
            this.Label3.Text = "id pac";
            this.Label3.Visible = false;
            // 
            // btnSelecionarBioq
            // 
            this.btnSelecionarBioq.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelecionarBioq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarBioq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarBioq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarBioq.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarBioq.Image")));
            this.btnSelecionarBioq.Location = new System.Drawing.Point(584, 165);
            this.btnSelecionarBioq.Name = "btnSelecionarBioq";
            this.btnSelecionarBioq.Size = new System.Drawing.Size(97, 37);
            this.btnSelecionarBioq.TabIndex = 103;
            this.btnSelecionarBioq.Text = "Selecionar";
            this.btnSelecionarBioq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarBioq.UseVisualStyleBackColor = false;
            this.btnSelecionarBioq.Visible = false;
            this.btnSelecionarBioq.Click += new System.EventHandler(this.btnSelecionarBioq_Click);
            // 
            // btnSelecionarHema
            // 
            this.btnSelecionarHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarHema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarHema.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarHema.Image")));
            this.btnSelecionarHema.Location = new System.Drawing.Point(584, 165);
            this.btnSelecionarHema.Name = "btnSelecionarHema";
            this.btnSelecionarHema.Size = new System.Drawing.Size(97, 37);
            this.btnSelecionarHema.TabIndex = 113;
            this.btnSelecionarHema.Text = "Selecionar";
            this.btnSelecionarHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarHema.UseVisualStyleBackColor = true;
            this.btnSelecionarHema.Visible = false;
            this.btnSelecionarHema.Click += new System.EventHandler(this.btnSelecionarHema_Click);
            // 
            // btnSelecionarUrina
            // 
            this.btnSelecionarUrina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarUrina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarUrina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarUrina.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarUrina.Image")));
            this.btnSelecionarUrina.Location = new System.Drawing.Point(584, 165);
            this.btnSelecionarUrina.Name = "btnSelecionarUrina";
            this.btnSelecionarUrina.Size = new System.Drawing.Size(97, 37);
            this.btnSelecionarUrina.TabIndex = 112;
            this.btnSelecionarUrina.Text = "Selecionar";
            this.btnSelecionarUrina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarUrina.UseVisualStyleBackColor = true;
            this.btnSelecionarUrina.Visible = false;
            this.btnSelecionarUrina.Click += new System.EventHandler(this.btnSelecionarUrina_Click);
            // 
            // btnSelecionarMicro
            // 
            this.btnSelecionarMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarMicro.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarMicro.Image")));
            this.btnSelecionarMicro.Location = new System.Drawing.Point(584, 165);
            this.btnSelecionarMicro.Name = "btnSelecionarMicro";
            this.btnSelecionarMicro.Size = new System.Drawing.Size(97, 37);
            this.btnSelecionarMicro.TabIndex = 111;
            this.btnSelecionarMicro.Text = "Selecionar";
            this.btnSelecionarMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarMicro.UseVisualStyleBackColor = true;
            this.btnSelecionarMicro.Visible = false;
            this.btnSelecionarMicro.Click += new System.EventHandler(this.btnSelecionarMicro_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 66);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(116, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(583, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 37);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(554, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 13);
            this.lblTotal.TabIndex = 109;
            this.lblTotal.Text = "-";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(520, 339);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 108;
            this.Label2.Text = "Total:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(583, 66);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 37);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(583, 115);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 37);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgLocalizarPac
            // 
            this.dgLocalizarPac.AllowUserToAddRows = false;
            this.dgLocalizarPac.AllowUserToDeleteRows = false;
            this.dgLocalizarPac.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgLocalizarPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocalizarPac.Location = new System.Drawing.Point(12, 109);
            this.dgLocalizarPac.MultiSelect = false;
            this.dgLocalizarPac.Name = "dgLocalizarPac";
            this.dgLocalizarPac.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocalizarPac.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLocalizarPac.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgLocalizarPac.Size = new System.Drawing.Size(557, 218);
            this.dgLocalizarPac.TabIndex = 107;
            this.dgLocalizarPac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocalizarPac_CellClick);
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(12, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(288, 20);
            this.txtnome.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(9, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 13);
            this.Label1.TabIndex = 105;
            this.Label1.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Location = new System.Drawing.Point(9, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 104;
            this.Nome.Text = "Nome";
            // 
            // frm_LocalizarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(688, 354);
            this.Controls.Add(this.txtIdPac);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnSelecionarBioq);
            this.Controls.Add(this.btnSelecionarHema);
            this.Controls.Add(this.btnSelecionarUrina);
            this.Controls.Add(this.btnSelecionarMicro);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgLocalizarPac);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_LocalizarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Paciente";
            this.Load += new System.EventHandler(this.frm_LocalizarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalizarPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtIdPac;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSelecionarBioq;
        internal System.Windows.Forms.Button btnSelecionarHema;
        internal System.Windows.Forms.Button btnSelecionarUrina;
        internal System.Windows.Forms.Button btnSelecionarMicro;
        internal System.Windows.Forms.TextBox txtCpf;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.DataGridView dgLocalizarPac;
        internal System.Windows.Forms.TextBox txtnome;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Nome;
    }
}