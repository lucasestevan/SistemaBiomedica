﻿namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_Microbiologia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Microbiologia));
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNdia = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.txtGram2 = new System.Windows.Forms.TextBox();
            this.txtMicr1 = new System.Windows.Forms.TextBox();
            this.txtCcol = new System.Windows.Forms.TextBox();
            this.txtMicr2 = new System.Windows.Forms.TextBox();
            this.txtCcol2 = new System.Windows.Forms.TextBox();
            this.txtBaar = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.txtIdcola = new System.Windows.Forms.TextBox();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnSelecionarColaMicro = new System.Windows.Forms.Button();
            this.btnAlterarM = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSelecionarPacMicro = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.Label33 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(56, 125);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 15);
            this.Label2.TabIndex = 127;
            this.Label2.Text = "Data:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(244, 125);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 15);
            this.Label4.TabIndex = 128;
            this.Label4.Text = "Nº dia:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(360, 63);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(39, 13);
            this.Label16.TabIndex = 150;
            this.Label16.Text = "id Cola";
            this.Label16.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(100, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 130;
            // 
            // txtNdia
            // 
            this.txtNdia.Location = new System.Drawing.Point(292, 121);
            this.txtNdia.MaxLength = 4;
            this.txtNdia.Name = "txtNdia";
            this.txtNdia.Size = new System.Drawing.Size(38, 20);
            this.txtNdia.TabIndex = 4;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(100, 121);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(64, 20);
            this.mskData.TabIndex = 3;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(404, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(21, 20);
            this.txtId.TabIndex = 132;
            this.txtId.Visible = false;
            this.txtId.WordWrap = false;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(26, 191);
            this.txtMat.Multiline = true;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(63, 20);
            this.txtMat.TabIndex = 5;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(133, 191);
            this.txtGram.Multiline = true;
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(63, 20);
            this.txtGram.TabIndex = 6;
            // 
            // txtGram2
            // 
            this.txtGram2.Location = new System.Drawing.Point(236, 191);
            this.txtGram2.Multiline = true;
            this.txtGram2.Name = "txtGram2";
            this.txtGram2.Size = new System.Drawing.Size(63, 20);
            this.txtGram2.TabIndex = 7;
            // 
            // txtMicr1
            // 
            this.txtMicr1.Location = new System.Drawing.Point(334, 191);
            this.txtMicr1.Multiline = true;
            this.txtMicr1.Name = "txtMicr1";
            this.txtMicr1.Size = new System.Drawing.Size(63, 20);
            this.txtMicr1.TabIndex = 8;
            // 
            // txtCcol
            // 
            this.txtCcol.Location = new System.Drawing.Point(26, 254);
            this.txtCcol.Multiline = true;
            this.txtCcol.Name = "txtCcol";
            this.txtCcol.Size = new System.Drawing.Size(63, 20);
            this.txtCcol.TabIndex = 9;
            // 
            // txtMicr2
            // 
            this.txtMicr2.Location = new System.Drawing.Point(133, 254);
            this.txtMicr2.Multiline = true;
            this.txtMicr2.Name = "txtMicr2";
            this.txtMicr2.Size = new System.Drawing.Size(63, 20);
            this.txtMicr2.TabIndex = 10;
            // 
            // txtCcol2
            // 
            this.txtCcol2.Location = new System.Drawing.Point(236, 254);
            this.txtCcol2.Multiline = true;
            this.txtCcol2.Name = "txtCcol2";
            this.txtCcol2.Size = new System.Drawing.Size(63, 20);
            this.txtCcol2.TabIndex = 11;
            // 
            // txtBaar
            // 
            this.txtBaar.Location = new System.Drawing.Point(334, 254);
            this.txtBaar.Multiline = true;
            this.txtBaar.Name = "txtBaar";
            this.txtBaar.Size = new System.Drawing.Size(63, 20);
            this.txtBaar.TabIndex = 12;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(23, 175);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(30, 13);
            this.Label6.TabIndex = 133;
            this.Label6.Text = "MAT";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(130, 175);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 134;
            this.Label5.Text = "GRAM";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(233, 175);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 135;
            this.Label8.Text = "GRAM";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Location = new System.Drawing.Point(331, 175);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 136;
            this.Label7.Text = "MICR 1";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(23, 238);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 13);
            this.Label10.TabIndex = 137;
            this.Label10.Text = "C.COL";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(131, 238);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(43, 13);
            this.Label9.TabIndex = 138;
            this.Label9.Text = "MICR 2";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(233, 238);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(38, 13);
            this.Label12.TabIndex = 139;
            this.Label12.Text = "C.COL";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(331, 238);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 13);
            this.Label11.TabIndex = 140;
            this.Label11.Text = "BAAR";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(144, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 24);
            this.Label3.TabIndex = 129;
            this.Label3.Text = "Microbiologia";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Location = new System.Drawing.Point(346, 29);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(49, 13);
            this.Label13.TabIndex = 143;
            this.Label13.Text = "id exame";
            this.Label13.Visible = false;
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(405, 93);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(21, 20);
            this.txtIdPac.TabIndex = 144;
            this.txtIdPac.Visible = false;
            this.txtIdPac.WordWrap = false;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Location = new System.Drawing.Point(361, 96);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(38, 13);
            this.Label14.TabIndex = 145;
            this.Label14.Text = "id paci";
            this.Label14.Visible = false;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(9, 63);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(90, 15);
            this.Label15.TabIndex = 146;
            this.Label15.Text = "Colaborador:";
            // 
            // txtCola
            // 
            this.txtCola.Enabled = false;
            this.txtCola.Location = new System.Drawing.Point(100, 60);
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(230, 20);
            this.txtCola.TabIndex = 147;
            // 
            // txtIdcola
            // 
            this.txtIdcola.Location = new System.Drawing.Point(404, 60);
            this.txtIdcola.Name = "txtIdcola";
            this.txtIdcola.Size = new System.Drawing.Size(21, 20);
            this.txtIdcola.TabIndex = 149;
            this.txtIdcola.Visible = false;
            this.txtIdcola.WordWrap = false;
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // btnSelecionarColaMicro
            // 
            this.btnSelecionarColaMicro.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarColaMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarColaMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarColaMicro.FlatAppearance.BorderSize = 0;
            this.btnSelecionarColaMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarColaMicro.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarColaMicro.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.research__2_;
            this.btnSelecionarColaMicro.Location = new System.Drawing.Point(332, 55);
            this.btnSelecionarColaMicro.Name = "btnSelecionarColaMicro";
            this.btnSelecionarColaMicro.Size = new System.Drawing.Size(23, 23);
            this.btnSelecionarColaMicro.TabIndex = 1;
            this.btnSelecionarColaMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarColaMicro.UseVisualStyleBackColor = false;
            this.btnSelecionarColaMicro.Click += new System.EventHandler(this.btnSelecionarColaMicro_Click);
            // 
            // btnAlterarM
            // 
            this.btnAlterarM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarM.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.edit__1_;
            this.btnAlterarM.Location = new System.Drawing.Point(315, 315);
            this.btnAlterarM.Name = "btnAlterarM";
            this.btnAlterarM.Size = new System.Drawing.Size(97, 30);
            this.btnAlterarM.TabIndex = 125;
            this.btnAlterarM.Text = "Alterar";
            this.btnAlterarM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarM.UseVisualStyleBackColor = false;
            this.btnAlterarM.Click += new System.EventHandler(this.btnAlterarM_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.add;
            this.btnNovo.Location = new System.Drawing.Point(21, 315);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 30);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSelecionarPacMicro
            // 
            this.btnSelecionarPacMicro.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarPacMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarPacMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarPacMicro.FlatAppearance.BorderSize = 0;
            this.btnSelecionarPacMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarPacMicro.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarPacMicro.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.research__2_;
            this.btnSelecionarPacMicro.Location = new System.Drawing.Point(332, 87);
            this.btnSelecionarPacMicro.Name = "btnSelecionarPacMicro";
            this.btnSelecionarPacMicro.Size = new System.Drawing.Size(23, 23);
            this.btnSelecionarPacMicro.TabIndex = 2;
            this.btnSelecionarPacMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarPacMicro.UseVisualStyleBackColor = false;
            this.btnSelecionarPacMicro.Click += new System.EventHandler(this.btnSelecionarPacMicro_Click);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncad.Image = global::SistemaBiomedicinaCsharp25042019.Properties.Resources.save;
            this.btncad.Location = new System.Drawing.Point(171, 315);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(97, 30);
            this.btncad.TabIndex = 13;
            this.btncad.Text = "Salvar";
            this.btncad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.Color.Transparent;
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.Location = new System.Drawing.Point(32, 93);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(67, 15);
            this.Label33.TabIndex = 184;
            this.Label33.Text = "Paciente:";
            // 
            // frm_Microbiologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(426, 358);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtIdcola);
            this.Controls.Add(this.btnSelecionarColaMicro);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtIdPac);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.btnAlterarM);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSelecionarPacMicro);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtBaar);
            this.Controls.Add(this.txtCcol2);
            this.Controls.Add(this.txtMicr2);
            this.Controls.Add(this.txtCcol);
            this.Controls.Add(this.txtMicr1);
            this.Controls.Add(this.txtGram2);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.txtNdia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Microbiologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microbiologia";
            this.Load += new System.EventHandler(this.frm_Microbiologia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtNdia;
        internal System.Windows.Forms.MaskedTextBox mskData;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button btncad;
        internal System.Windows.Forms.Button btnSelecionarPacMicro;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnSelecionarColaMicro;
        internal System.Windows.Forms.PrintDialog PrintDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        public System.Windows.Forms.TextBox txtMat;
        public System.Windows.Forms.TextBox txtGram;
        public System.Windows.Forms.TextBox txtGram2;
        public System.Windows.Forms.TextBox txtMicr1;
        public System.Windows.Forms.TextBox txtCcol;
        public System.Windows.Forms.TextBox txtMicr2;
        public System.Windows.Forms.TextBox txtCcol2;
        public System.Windows.Forms.TextBox txtBaar;
        public System.Windows.Forms.Button btnAlterarM;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtIdPac;
        public System.Windows.Forms.TextBox txtCola;
        public System.Windows.Forms.TextBox txtIdcola;
        internal System.Windows.Forms.Label Label33;
    }
}