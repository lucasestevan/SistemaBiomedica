namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_ConsultaExame
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLocalizarUri = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.rbMicrobiologia = new System.Windows.Forms.RadioButton();
            this.rbUrinalise = new System.Windows.Forms.RadioButton();
            this.rbHematologia = new System.Windows.Forms.RadioButton();
            this.rbBio = new System.Windows.Forms.RadioButton();
            this.btnLocalizarHema = new System.Windows.Forms.Button();
            this.btnLocalizarBio = new System.Windows.Forms.Button();
            this.btnExcluirUri = new System.Windows.Forms.Button();
            this.btnExcluirBio = new System.Windows.Forms.Button();
            this.btnExcluirHema = new System.Windows.Forms.Button();
            this.btnAlterarHema = new System.Windows.Forms.Button();
            this.btnAlterarBio = new System.Windows.Forms.Button();
            this.btnAlterarUri = new System.Windows.Forms.Button();
            this.txtNomePaci = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAlterarMicro = new System.Windows.Forms.Button();
            this.btnExcluirMicro = new System.Windows.Forms.Button();
            this.btnLocalizarMicro = new System.Windows.Forms.Button();
            this.dgConsultarExame = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultarExame)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(49, 134);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 524;
            this.Label1.Text = "id Exame";
            this.Label1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 150);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(51, 20);
            this.txtId.TabIndex = 523;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(309, 150);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 509;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnLocalizarUri
            // 
            this.btnLocalizarUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarUri.Location = new System.Drawing.Point(454, 18);
            this.btnLocalizarUri.Name = "btnLocalizarUri";
            this.btnLocalizarUri.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarUri.TabIndex = 506;
            this.btnLocalizarUri.Text = "Pesquisar";
            this.btnLocalizarUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarUri.UseVisualStyleBackColor = true;
            this.btnLocalizarUri.Click += new System.EventHandler(this.btnLocalizarUri_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Location = new System.Drawing.Point(37, 17);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 522;
            this.Nome.Text = "Nome";
            // 
            // rbMicrobiologia
            // 
            this.rbMicrobiologia.AutoSize = true;
            this.rbMicrobiologia.BackColor = System.Drawing.Color.Transparent;
            this.rbMicrobiologia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMicrobiologia.Location = new System.Drawing.Point(350, 61);
            this.rbMicrobiologia.Name = "rbMicrobiologia";
            this.rbMicrobiologia.Size = new System.Drawing.Size(87, 17);
            this.rbMicrobiologia.TabIndex = 526;
            this.rbMicrobiologia.TabStop = true;
            this.rbMicrobiologia.Text = "Microbiologia";
            this.rbMicrobiologia.UseVisualStyleBackColor = false;
            this.rbMicrobiologia.CheckedChanged += new System.EventHandler(this.rbMicrobiologia_CheckedChanged);
            // 
            // rbUrinalise
            // 
            this.rbUrinalise.AutoSize = true;
            this.rbUrinalise.BackColor = System.Drawing.Color.Transparent;
            this.rbUrinalise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbUrinalise.Location = new System.Drawing.Point(350, 84);
            this.rbUrinalise.Name = "rbUrinalise";
            this.rbUrinalise.Size = new System.Drawing.Size(65, 17);
            this.rbUrinalise.TabIndex = 525;
            this.rbUrinalise.TabStop = true;
            this.rbUrinalise.Text = "Urinalise";
            this.rbUrinalise.UseVisualStyleBackColor = false;
            this.rbUrinalise.CheckedChanged += new System.EventHandler(this.rbUrinalise_CheckedChanged);
            // 
            // rbHematologia
            // 
            this.rbHematologia.AutoSize = true;
            this.rbHematologia.BackColor = System.Drawing.Color.Transparent;
            this.rbHematologia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbHematologia.Location = new System.Drawing.Point(350, 38);
            this.rbHematologia.Name = "rbHematologia";
            this.rbHematologia.Size = new System.Drawing.Size(84, 17);
            this.rbHematologia.TabIndex = 527;
            this.rbHematologia.TabStop = true;
            this.rbHematologia.Text = "Hematologia";
            this.rbHematologia.UseVisualStyleBackColor = false;
            this.rbHematologia.CheckedChanged += new System.EventHandler(this.rbHematologia_CheckedChanged);
            // 
            // rbBio
            // 
            this.rbBio.AutoSize = true;
            this.rbBio.BackColor = System.Drawing.Color.Transparent;
            this.rbBio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBio.Location = new System.Drawing.Point(350, 18);
            this.rbBio.Name = "rbBio";
            this.rbBio.Size = new System.Drawing.Size(76, 17);
            this.rbBio.TabIndex = 528;
            this.rbBio.TabStop = true;
            this.rbBio.Text = "Bioquimica";
            this.rbBio.UseVisualStyleBackColor = false;
            this.rbBio.CheckedChanged += new System.EventHandler(this.rbBio_CheckedChanged);
            // 
            // btnLocalizarHema
            // 
            this.btnLocalizarHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarHema.Location = new System.Drawing.Point(454, 18);
            this.btnLocalizarHema.Name = "btnLocalizarHema";
            this.btnLocalizarHema.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarHema.TabIndex = 521;
            this.btnLocalizarHema.Text = "Pesquisar";
            this.btnLocalizarHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarHema.UseVisualStyleBackColor = true;
            this.btnLocalizarHema.Click += new System.EventHandler(this.btnLocalizarHema_Click);
            // 
            // btnLocalizarBio
            // 
            this.btnLocalizarBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarBio.Location = new System.Drawing.Point(454, 18);
            this.btnLocalizarBio.Name = "btnLocalizarBio";
            this.btnLocalizarBio.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarBio.TabIndex = 520;
            this.btnLocalizarBio.Text = "Pesquisar";
            this.btnLocalizarBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarBio.UseVisualStyleBackColor = true;
            this.btnLocalizarBio.Click += new System.EventHandler(this.btnLocalizarBio_Click);
            // 
            // btnExcluirUri
            // 
            this.btnExcluirUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUri.Location = new System.Drawing.Point(454, 140);
            this.btnExcluirUri.Name = "btnExcluirUri";
            this.btnExcluirUri.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirUri.TabIndex = 508;
            this.btnExcluirUri.Text = "Excluir";
            this.btnExcluirUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirUri.UseVisualStyleBackColor = true;
            this.btnExcluirUri.Click += new System.EventHandler(this.btnExcluirUri_Click);
            // 
            // btnExcluirBio
            // 
            this.btnExcluirBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirBio.Location = new System.Drawing.Point(454, 140);
            this.btnExcluirBio.Name = "btnExcluirBio";
            this.btnExcluirBio.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirBio.TabIndex = 519;
            this.btnExcluirBio.Text = "Excluir";
            this.btnExcluirBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirBio.UseVisualStyleBackColor = true;
            this.btnExcluirBio.Click += new System.EventHandler(this.btnExcluirBio_Click);
            // 
            // btnExcluirHema
            // 
            this.btnExcluirHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirHema.Location = new System.Drawing.Point(454, 140);
            this.btnExcluirHema.Name = "btnExcluirHema";
            this.btnExcluirHema.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirHema.TabIndex = 518;
            this.btnExcluirHema.Text = "Excluir";
            this.btnExcluirHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirHema.UseVisualStyleBackColor = true;
            this.btnExcluirHema.Click += new System.EventHandler(this.btnExcluirHema_Click);
            // 
            // btnAlterarHema
            // 
            this.btnAlterarHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarHema.Location = new System.Drawing.Point(454, 77);
            this.btnAlterarHema.Name = "btnAlterarHema";
            this.btnAlterarHema.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarHema.TabIndex = 507;
            this.btnAlterarHema.Text = "Alterar";
            this.btnAlterarHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarHema.UseVisualStyleBackColor = true;
            this.btnAlterarHema.Click += new System.EventHandler(this.btnAlterarHema_Click);
            // 
            // btnAlterarBio
            // 
            this.btnAlterarBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarBio.Location = new System.Drawing.Point(454, 77);
            this.btnAlterarBio.Name = "btnAlterarBio";
            this.btnAlterarBio.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarBio.TabIndex = 517;
            this.btnAlterarBio.Text = "Alterar";
            this.btnAlterarBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarBio.UseVisualStyleBackColor = true;
            this.btnAlterarBio.Click += new System.EventHandler(this.btnAlterarBio_Click);
            // 
            // btnAlterarUri
            // 
            this.btnAlterarUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUri.Location = new System.Drawing.Point(454, 77);
            this.btnAlterarUri.Name = "btnAlterarUri";
            this.btnAlterarUri.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarUri.TabIndex = 516;
            this.btnAlterarUri.Text = "Alterar";
            this.btnAlterarUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarUri.UseVisualStyleBackColor = true;
            this.btnAlterarUri.Click += new System.EventHandler(this.btnAlterarUri_Click);
            // 
            // txtNomePaci
            // 
            this.txtNomePaci.Location = new System.Drawing.Point(39, 33);
            this.txtNomePaci.Name = "txtNomePaci";
            this.txtNomePaci.Size = new System.Drawing.Size(240, 20);
            this.txtNomePaci.TabIndex = 505;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(507, 417);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 13);
            this.lblTotal.TabIndex = 515;
            this.lblTotal.Text = "-";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(473, 417);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 514;
            this.Label2.Text = "Total:";
            // 
            // btnAlterarMicro
            // 
            this.btnAlterarMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarMicro.Location = new System.Drawing.Point(454, 77);
            this.btnAlterarMicro.Name = "btnAlterarMicro";
            this.btnAlterarMicro.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarMicro.TabIndex = 513;
            this.btnAlterarMicro.Text = "Alterar";
            this.btnAlterarMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarMicro.UseVisualStyleBackColor = true;
            this.btnAlterarMicro.Click += new System.EventHandler(this.btnAlterarMicro_Click);
            // 
            // btnExcluirMicro
            // 
            this.btnExcluirMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMicro.Location = new System.Drawing.Point(454, 140);
            this.btnExcluirMicro.Name = "btnExcluirMicro";
            this.btnExcluirMicro.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirMicro.TabIndex = 512;
            this.btnExcluirMicro.Text = "Excluir";
            this.btnExcluirMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirMicro.UseVisualStyleBackColor = true;
            this.btnExcluirMicro.Click += new System.EventHandler(this.btnExcluirMicro_Click);
            // 
            // btnLocalizarMicro
            // 
            this.btnLocalizarMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarMicro.Location = new System.Drawing.Point(454, 18);
            this.btnLocalizarMicro.Name = "btnLocalizarMicro";
            this.btnLocalizarMicro.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarMicro.TabIndex = 511;
            this.btnLocalizarMicro.Text = "Pesquisar";
            this.btnLocalizarMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarMicro.UseVisualStyleBackColor = true;
            this.btnLocalizarMicro.Click += new System.EventHandler(this.btnLocalizarMicro_Click);
            // 
            // dgConsultarExame
            // 
            this.dgConsultarExame.AllowUserToAddRows = false;
            this.dgConsultarExame.AllowUserToDeleteRows = false;
            this.dgConsultarExame.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgConsultarExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultarExame.Location = new System.Drawing.Point(14, 204);
            this.dgConsultarExame.Name = "dgConsultarExame";
            this.dgConsultarExame.ReadOnly = true;
            this.dgConsultarExame.Size = new System.Drawing.Size(536, 207);
            this.dgConsultarExame.TabIndex = 510;
            this.dgConsultarExame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultarExame_CellClick);
            // 
            // frm_ConsultaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 434);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLocalizarUri);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.rbMicrobiologia);
            this.Controls.Add(this.rbUrinalise);
            this.Controls.Add(this.rbHematologia);
            this.Controls.Add(this.rbBio);
            this.Controls.Add(this.btnLocalizarHema);
            this.Controls.Add(this.btnLocalizarBio);
            this.Controls.Add(this.btnExcluirUri);
            this.Controls.Add(this.btnExcluirBio);
            this.Controls.Add(this.btnExcluirHema);
            this.Controls.Add(this.btnAlterarHema);
            this.Controls.Add(this.btnAlterarBio);
            this.Controls.Add(this.btnAlterarUri);
            this.Controls.Add(this.txtNomePaci);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnAlterarMicro);
            this.Controls.Add(this.btnExcluirMicro);
            this.Controls.Add(this.btnLocalizarMicro);
            this.Controls.Add(this.dgConsultarExame);
            this.Name = "frm_ConsultaExame";
            this.Text = "Consultar Exames";
            this.Load += new System.EventHandler(this.frm_ConsultaExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultarExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnLocalizarUri;
        internal System.Windows.Forms.Label Nome;
        internal System.Windows.Forms.RadioButton rbMicrobiologia;
        internal System.Windows.Forms.RadioButton rbUrinalise;
        internal System.Windows.Forms.RadioButton rbHematologia;
        internal System.Windows.Forms.RadioButton rbBio;
        internal System.Windows.Forms.Button btnLocalizarHema;
        internal System.Windows.Forms.Button btnLocalizarBio;
        protected System.Windows.Forms.Button btnExcluirUri;
        internal System.Windows.Forms.Button btnExcluirBio;
        internal System.Windows.Forms.Button btnExcluirHema;
        internal System.Windows.Forms.Button btnAlterarHema;
        internal System.Windows.Forms.Button btnAlterarBio;
        internal System.Windows.Forms.Button btnAlterarUri;
        internal System.Windows.Forms.TextBox txtNomePaci;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAlterarMicro;
        internal System.Windows.Forms.Button btnExcluirMicro;
        internal System.Windows.Forms.Button btnLocalizarMicro;
        internal System.Windows.Forms.DataGridView dgConsultarExame;
    }
}