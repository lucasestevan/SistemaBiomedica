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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaExame));
            this.Label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnImprimirBio = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.rbMicrobiologia = new System.Windows.Forms.RadioButton();
            this.rbUrinalise = new System.Windows.Forms.RadioButton();
            this.rbHematologia = new System.Windows.Forms.RadioButton();
            this.rbBio = new System.Windows.Forms.RadioButton();
            this.btnLocalizarHema = new System.Windows.Forms.Button();
            this.btnLocalizarBio = new System.Windows.Forms.Button();
            this.btnExcluirBio = new System.Windows.Forms.Button();
            this.btnExcluirHema = new System.Windows.Forms.Button();
            this.btnAlterarHema = new System.Windows.Forms.Button();
            this.btnAlterarBio = new System.Windows.Forms.Button();
            this.btnAlterarUri = new System.Windows.Forms.Button();
            this.txtIdExame = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAlterarMicro = new System.Windows.Forms.Button();
            this.btnExcluirMicro = new System.Windows.Forms.Button();
            this.btnLocalizarMicro = new System.Windows.Forms.Button();
            this.dgConsultarExame = new System.Windows.Forms.DataGridView();
            this.btnLocalizarUri = new System.Windows.Forms.Button();
            this.btnExcluirUri = new System.Windows.Forms.Button();
            this.btnImprimirUri = new System.Windows.Forms.Button();
            this.btnImprimirMicro = new System.Windows.Forms.Button();
            this.btnImprimirHema = new System.Windows.Forms.Button();
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
            this.txtId.Visible = false;
            // 
            // btnImprimirBio
            // 
            this.btnImprimirBio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimirBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirBio.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.printer__1_;
            this.btnImprimirBio.Location = new System.Drawing.Point(527, 218);
            this.btnImprimirBio.Name = "btnImprimirBio";
            this.btnImprimirBio.Size = new System.Drawing.Size(97, 37);
            this.btnImprimirBio.TabIndex = 509;
            this.btnImprimirBio.Text = "Imprimir";
            this.btnImprimirBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirBio.UseVisualStyleBackColor = false;
            this.btnImprimirBio.Click += new System.EventHandler(this.BtnImprimirBio_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Location = new System.Drawing.Point(12, 38);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(54, 13);
            this.Nome.TabIndex = 522;
            this.Nome.Text = "N° Exame";
            // 
            // rbMicrobiologia
            // 
            this.rbMicrobiologia.AutoSize = true;
            this.rbMicrobiologia.BackColor = System.Drawing.Color.Transparent;
            this.rbMicrobiologia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMicrobiologia.Location = new System.Drawing.Point(409, 76);
            this.rbMicrobiologia.Name = "rbMicrobiologia";
            this.rbMicrobiologia.Size = new System.Drawing.Size(87, 17);
            this.rbMicrobiologia.TabIndex = 526;
            this.rbMicrobiologia.Text = "Microbiologia";
            this.rbMicrobiologia.UseVisualStyleBackColor = false;
            this.rbMicrobiologia.CheckedChanged += new System.EventHandler(this.rbMicrobiologia_CheckedChanged);
            // 
            // rbUrinalise
            // 
            this.rbUrinalise.AutoSize = true;
            this.rbUrinalise.BackColor = System.Drawing.Color.Transparent;
            this.rbUrinalise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbUrinalise.Location = new System.Drawing.Point(409, 99);
            this.rbUrinalise.Name = "rbUrinalise";
            this.rbUrinalise.Size = new System.Drawing.Size(65, 17);
            this.rbUrinalise.TabIndex = 525;
            this.rbUrinalise.Text = "Urinalise";
            this.rbUrinalise.UseVisualStyleBackColor = false;
            this.rbUrinalise.CheckedChanged += new System.EventHandler(this.rbUrinalise_CheckedChanged);
            // 
            // rbHematologia
            // 
            this.rbHematologia.AutoSize = true;
            this.rbHematologia.BackColor = System.Drawing.Color.Transparent;
            this.rbHematologia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbHematologia.Location = new System.Drawing.Point(409, 53);
            this.rbHematologia.Name = "rbHematologia";
            this.rbHematologia.Size = new System.Drawing.Size(84, 17);
            this.rbHematologia.TabIndex = 527;
            this.rbHematologia.Text = "Hematologia";
            this.rbHematologia.UseVisualStyleBackColor = false;
            this.rbHematologia.CheckedChanged += new System.EventHandler(this.rbHematologia_CheckedChanged);
            // 
            // rbBio
            // 
            this.rbBio.AutoSize = true;
            this.rbBio.BackColor = System.Drawing.Color.Transparent;
            this.rbBio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBio.Location = new System.Drawing.Point(409, 33);
            this.rbBio.Name = "rbBio";
            this.rbBio.Size = new System.Drawing.Size(76, 17);
            this.rbBio.TabIndex = 528;
            this.rbBio.Text = "Bioquimica";
            this.rbBio.UseVisualStyleBackColor = false;
            this.rbBio.CheckedChanged += new System.EventHandler(this.rbBio_CheckedChanged);
            // 
            // btnLocalizarHema
            // 
            this.btnLocalizarHema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLocalizarHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarHema.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarHema.Image")));
            this.btnLocalizarHema.Location = new System.Drawing.Point(527, 33);
            this.btnLocalizarHema.Name = "btnLocalizarHema";
            this.btnLocalizarHema.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarHema.TabIndex = 521;
            this.btnLocalizarHema.Text = "Pesquisar";
            this.btnLocalizarHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarHema.UseVisualStyleBackColor = false;
            this.btnLocalizarHema.Click += new System.EventHandler(this.btnLocalizarHema_Click);
            // 
            // btnLocalizarBio
            // 
            this.btnLocalizarBio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLocalizarBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarBio.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarBio.Image")));
            this.btnLocalizarBio.Location = new System.Drawing.Point(527, 33);
            this.btnLocalizarBio.Name = "btnLocalizarBio";
            this.btnLocalizarBio.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarBio.TabIndex = 520;
            this.btnLocalizarBio.Text = "Pesquisar";
            this.btnLocalizarBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarBio.UseVisualStyleBackColor = false;
            this.btnLocalizarBio.Click += new System.EventHandler(this.btnLocalizarBio_Click);
            // 
            // btnExcluirBio
            // 
            this.btnExcluirBio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirBio.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirBio.Image")));
            this.btnExcluirBio.Location = new System.Drawing.Point(527, 155);
            this.btnExcluirBio.Name = "btnExcluirBio";
            this.btnExcluirBio.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirBio.TabIndex = 519;
            this.btnExcluirBio.Text = "Excluir";
            this.btnExcluirBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirBio.UseVisualStyleBackColor = false;
            this.btnExcluirBio.Click += new System.EventHandler(this.btnExcluirBio_Click);
            // 
            // btnExcluirHema
            // 
            this.btnExcluirHema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirHema.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirHema.Image")));
            this.btnExcluirHema.Location = new System.Drawing.Point(527, 155);
            this.btnExcluirHema.Name = "btnExcluirHema";
            this.btnExcluirHema.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirHema.TabIndex = 518;
            this.btnExcluirHema.Text = "Excluir";
            this.btnExcluirHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirHema.UseVisualStyleBackColor = false;
            this.btnExcluirHema.Click += new System.EventHandler(this.btnExcluirHema_Click);
            // 
            // btnAlterarHema
            // 
            this.btnAlterarHema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarHema.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarHema.Image")));
            this.btnAlterarHema.Location = new System.Drawing.Point(527, 92);
            this.btnAlterarHema.Name = "btnAlterarHema";
            this.btnAlterarHema.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarHema.TabIndex = 3;
            this.btnAlterarHema.Text = "Alterar";
            this.btnAlterarHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarHema.UseVisualStyleBackColor = false;
            this.btnAlterarHema.Click += new System.EventHandler(this.btnAlterarHema_Click);
            // 
            // btnAlterarBio
            // 
            this.btnAlterarBio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarBio.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarBio.Image")));
            this.btnAlterarBio.Location = new System.Drawing.Point(527, 92);
            this.btnAlterarBio.Name = "btnAlterarBio";
            this.btnAlterarBio.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarBio.TabIndex = 517;
            this.btnAlterarBio.Text = "Alterar";
            this.btnAlterarBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarBio.UseVisualStyleBackColor = false;
            this.btnAlterarBio.Click += new System.EventHandler(this.btnAlterarBio_Click);
            // 
            // btnAlterarUri
            // 
            this.btnAlterarUri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUri.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarUri.Image")));
            this.btnAlterarUri.Location = new System.Drawing.Point(527, 92);
            this.btnAlterarUri.Name = "btnAlterarUri";
            this.btnAlterarUri.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarUri.TabIndex = 516;
            this.btnAlterarUri.Text = "Alterar";
            this.btnAlterarUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarUri.UseVisualStyleBackColor = false;
            this.btnAlterarUri.Click += new System.EventHandler(this.btnAlterarUri_Click);
            // 
            // txtIdExame
            // 
            this.txtIdExame.Location = new System.Drawing.Point(70, 33);
            this.txtIdExame.Name = "txtIdExame";
            this.txtIdExame.Size = new System.Drawing.Size(110, 20);
            this.txtIdExame.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(506, 417);
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
            this.Label2.Location = new System.Drawing.Point(469, 417);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 514;
            this.Label2.Text = "Total:";
            // 
            // btnAlterarMicro
            // 
            this.btnAlterarMicro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarMicro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarMicro.Image")));
            this.btnAlterarMicro.Location = new System.Drawing.Point(527, 92);
            this.btnAlterarMicro.Name = "btnAlterarMicro";
            this.btnAlterarMicro.Size = new System.Drawing.Size(97, 37);
            this.btnAlterarMicro.TabIndex = 513;
            this.btnAlterarMicro.Text = "Alterar";
            this.btnAlterarMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarMicro.UseVisualStyleBackColor = false;
            this.btnAlterarMicro.Click += new System.EventHandler(this.btnAlterarMicro_Click);
            // 
            // btnExcluirMicro
            // 
            this.btnExcluirMicro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMicro.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMicro.Image")));
            this.btnExcluirMicro.Location = new System.Drawing.Point(527, 155);
            this.btnExcluirMicro.Name = "btnExcluirMicro";
            this.btnExcluirMicro.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirMicro.TabIndex = 512;
            this.btnExcluirMicro.Text = "Excluir";
            this.btnExcluirMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirMicro.UseVisualStyleBackColor = false;
            this.btnExcluirMicro.Click += new System.EventHandler(this.btnExcluirMicro_Click);
            // 
            // btnLocalizarMicro
            // 
            this.btnLocalizarMicro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLocalizarMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarMicro.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarMicro.Image")));
            this.btnLocalizarMicro.Location = new System.Drawing.Point(527, 33);
            this.btnLocalizarMicro.Name = "btnLocalizarMicro";
            this.btnLocalizarMicro.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarMicro.TabIndex = 511;
            this.btnLocalizarMicro.Text = "Pesquisar";
            this.btnLocalizarMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarMicro.UseVisualStyleBackColor = false;
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
            this.dgConsultarExame.Size = new System.Drawing.Size(506, 207);
            this.dgConsultarExame.TabIndex = 510;
            this.dgConsultarExame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultarExame_CellClick);
            // 
            // btnLocalizarUri
            // 
            this.btnLocalizarUri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLocalizarUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarUri.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarUri.Image")));
            this.btnLocalizarUri.Location = new System.Drawing.Point(527, 33);
            this.btnLocalizarUri.Name = "btnLocalizarUri";
            this.btnLocalizarUri.Size = new System.Drawing.Size(97, 37);
            this.btnLocalizarUri.TabIndex = 2;
            this.btnLocalizarUri.Text = "Pesquisar";
            this.btnLocalizarUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarUri.UseVisualStyleBackColor = false;
            this.btnLocalizarUri.Click += new System.EventHandler(this.btnLocalizarUri_Click);
            // 
            // btnExcluirUri
            // 
            this.btnExcluirUri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUri.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirUri.Image")));
            this.btnExcluirUri.Location = new System.Drawing.Point(527, 155);
            this.btnExcluirUri.Name = "btnExcluirUri";
            this.btnExcluirUri.Size = new System.Drawing.Size(97, 37);
            this.btnExcluirUri.TabIndex = 4;
            this.btnExcluirUri.Text = "Excluir";
            this.btnExcluirUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirUri.UseVisualStyleBackColor = false;
            this.btnExcluirUri.Click += new System.EventHandler(this.btnExcluirUri_Click);
            // 
            // btnImprimirUri
            // 
            this.btnImprimirUri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimirUri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirUri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirUri.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.printer__1_;
            this.btnImprimirUri.Location = new System.Drawing.Point(527, 218);
            this.btnImprimirUri.Name = "btnImprimirUri";
            this.btnImprimirUri.Size = new System.Drawing.Size(97, 37);
            this.btnImprimirUri.TabIndex = 529;
            this.btnImprimirUri.Text = "Imprimir";
            this.btnImprimirUri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirUri.UseVisualStyleBackColor = false;
            this.btnImprimirUri.Click += new System.EventHandler(this.BtnImprimirUri_Click);
            // 
            // btnImprimirMicro
            // 
            this.btnImprimirMicro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimirMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirMicro.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.printer__1_;
            this.btnImprimirMicro.Location = new System.Drawing.Point(527, 218);
            this.btnImprimirMicro.Name = "btnImprimirMicro";
            this.btnImprimirMicro.Size = new System.Drawing.Size(97, 37);
            this.btnImprimirMicro.TabIndex = 530;
            this.btnImprimirMicro.Text = "Imprimir";
            this.btnImprimirMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirMicro.UseVisualStyleBackColor = false;
            this.btnImprimirMicro.Click += new System.EventHandler(this.BtnImprimirMicro_Click);
            // 
            // btnImprimirHema
            // 
            this.btnImprimirHema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimirHema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirHema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirHema.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.printer__1_;
            this.btnImprimirHema.Location = new System.Drawing.Point(527, 218);
            this.btnImprimirHema.Name = "btnImprimirHema";
            this.btnImprimirHema.Size = new System.Drawing.Size(97, 37);
            this.btnImprimirHema.TabIndex = 531;
            this.btnImprimirHema.Text = "Imprimir";
            this.btnImprimirHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirHema.UseVisualStyleBackColor = false;
            this.btnImprimirHema.Click += new System.EventHandler(this.BtnImprimirHema_Click);
            // 
            // frm_ConsultaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(628, 434);
            this.Controls.Add(this.btnImprimirHema);
            this.Controls.Add(this.btnImprimirMicro);
            this.Controls.Add(this.btnImprimirUri);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnImprimirBio);
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
            this.Controls.Add(this.txtIdExame);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnAlterarMicro);
            this.Controls.Add(this.btnExcluirMicro);
            this.Controls.Add(this.btnLocalizarMicro);
            this.Controls.Add(this.dgConsultarExame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ConsultaExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Exames";
            this.Load += new System.EventHandler(this.frm_ConsultaExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultarExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Button btnImprimirBio;
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
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAlterarMicro;
        internal System.Windows.Forms.Button btnExcluirMicro;
        internal System.Windows.Forms.Button btnLocalizarMicro;
        internal System.Windows.Forms.DataGridView dgConsultarExame;
        internal System.Windows.Forms.TextBox txtIdExame;
        internal System.Windows.Forms.Button btnImprimirUri;
        internal System.Windows.Forms.Button btnImprimirMicro;
        internal System.Windows.Forms.Button btnImprimirHema;
    }
}