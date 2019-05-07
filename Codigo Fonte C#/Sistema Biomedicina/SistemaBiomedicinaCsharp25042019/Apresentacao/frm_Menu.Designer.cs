namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.lblData = new System.Windows.Forms.Label();
            this.Btnlogout = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaExame = new System.Windows.Forms.ToolStripMenuItem();
            this.MsExames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBio = new System.Windows.Forms.ToolStripMenuItem();
            this.Exame2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHema = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmMicro = new System.Windows.Forms.ToolStripMenuItem();
            this.Exame4ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmUri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblData.Location = new System.Drawing.Point(462, 6);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(10, 13);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "-";
            // 
            // Btnlogout
            // 
            this.Btnlogout.BackColor = System.Drawing.SystemColors.Control;
            this.Btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btnlogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btnlogout.Location = new System.Drawing.Point(41, 326);
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Size = new System.Drawing.Size(75, 23);
            this.Btnlogout.TabIndex = 13;
            this.Btnlogout.Text = "Sair";
            this.Btnlogout.UseVisualStyleBackColor = false;
            this.Btnlogout.Click += new System.EventHandler(this.Botaologout_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsCadastro,
            this.tsmConsultaExame,
            this.MsExames,
            this.tsmLocalizar});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(29, 32);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(144, 210);
            this.MenuStrip1.TabIndex = 12;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // MsCadastro
            // 
            this.MsCadastro.BackColor = System.Drawing.Color.Transparent;
            this.MsCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmColaborador,
            this.ToolStripMenuItem2,
            this.tsmPaciente});
            this.MsCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsCadastro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MsCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MsCadastro.Image")));
            this.MsCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MsCadastro.Name = "MsCadastro";
            this.MsCadastro.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.MsCadastro.Size = new System.Drawing.Size(138, 51);
            this.MsCadastro.Text = "&Cadastro";
            // 
            // tsmColaborador
            // 
            this.tsmColaborador.Name = "tsmColaborador";
            this.tsmColaborador.Size = new System.Drawing.Size(180, 22);
            this.tsmColaborador.Text = "Colaborador";
            this.tsmColaborador.Click += new System.EventHandler(this.tsmColaborador_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.Name = "tsmPaciente";
            this.tsmPaciente.Size = new System.Drawing.Size(180, 22);
            this.tsmPaciente.Text = "Paciente";
            this.tsmPaciente.Click += new System.EventHandler(this.tsmPaciente_Click);
            // 
            // tsmConsultaExame
            // 
            this.tsmConsultaExame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmConsultaExame.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tsmConsultaExame.Image = ((System.Drawing.Image)(resources.GetObject("tsmConsultaExame.Image")));
            this.tsmConsultaExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmConsultaExame.Name = "tsmConsultaExame";
            this.tsmConsultaExame.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.tsmConsultaExame.Size = new System.Drawing.Size(138, 51);
            this.tsmConsultaExame.Text = "&Consultar Exames";
            this.tsmConsultaExame.Click += new System.EventHandler(this.tsmConsultaExame_Click);
            // 
            // MsExames
            // 
            this.MsExames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBio,
            this.Exame2ToolStripMenuItem,
            this.tsmHema,
            this.ToolStripMenuItem1,
            this.tsmMicro,
            this.Exame4ToolStripMenuItem,
            this.tsmUri});
            this.MsExames.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsExames.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MsExames.Image = ((System.Drawing.Image)(resources.GetObject("MsExames.Image")));
            this.MsExames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MsExames.Name = "MsExames";
            this.MsExames.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.MsExames.Size = new System.Drawing.Size(138, 51);
            this.MsExames.Text = "&Exames";
            // 
            // tsmBio
            // 
            this.tsmBio.Name = "tsmBio";
            this.tsmBio.Size = new System.Drawing.Size(180, 22);
            this.tsmBio.Text = "Bioquímica";
            this.tsmBio.Click += new System.EventHandler(this.tsmBio_Click);
            // 
            // Exame2ToolStripMenuItem
            // 
            this.Exame2ToolStripMenuItem.Name = "Exame2ToolStripMenuItem";
            this.Exame2ToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmHema
            // 
            this.tsmHema.Name = "tsmHema";
            this.tsmHema.Size = new System.Drawing.Size(180, 22);
            this.tsmHema.Text = "Hematologia";
            this.tsmHema.Click += new System.EventHandler(this.tsmHema_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmMicro
            // 
            this.tsmMicro.Name = "tsmMicro";
            this.tsmMicro.Size = new System.Drawing.Size(180, 22);
            this.tsmMicro.Text = "Microbiologia";
            this.tsmMicro.Click += new System.EventHandler(this.tsmMicro_Click);
            // 
            // Exame4ToolStripMenuItem
            // 
            this.Exame4ToolStripMenuItem.Name = "Exame4ToolStripMenuItem";
            this.Exame4ToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmUri
            // 
            this.tsmUri.Name = "tsmUri";
            this.tsmUri.Size = new System.Drawing.Size(180, 22);
            this.tsmUri.Text = "Urinálise";
            this.tsmUri.Click += new System.EventHandler(this.tsmUri_Click);
            // 
            // tsmLocalizar
            // 
            this.tsmLocalizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmLocalizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tsmLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsmLocalizar.Image")));
            this.tsmLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmLocalizar.Name = "tsmLocalizar";
            this.tsmLocalizar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.tsmLocalizar.Size = new System.Drawing.Size(138, 51);
            this.tsmLocalizar.Text = "&Localizar ";
            this.tsmLocalizar.Click += new System.EventHandler(this.tsmLocalizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.MenuStrip1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 248);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Location = new System.Drawing.Point(-1, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 26);
            this.panel2.TabIndex = 17;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 16);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(227, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(536, 406);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.Button Btnlogout;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem MsExames;
        internal System.Windows.Forms.ToolStripMenuItem tsmHema;
        internal System.Windows.Forms.ToolStripSeparator Exame2ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem tsmUri;
        internal System.Windows.Forms.ToolStripSeparator Exame4ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem tsmMicro;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem tsmBio;
        internal System.Windows.Forms.ToolStripMenuItem tsmConsultaExame;
        internal System.Windows.Forms.ToolStripMenuItem tsmLocalizar;
        internal System.Windows.Forms.ToolStripMenuItem MsCadastro;
        internal System.Windows.Forms.ToolStripMenuItem tsmPaciente;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem tsmColaborador;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}