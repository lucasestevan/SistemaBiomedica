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
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Botaologout = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsExames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHema = new System.Windows.Forms.ToolStripMenuItem();
            this.Exame2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmUri = new System.Windows.Forms.ToolStripMenuItem();
            this.Exame4ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmMicro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmBio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaExame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.MsCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(503, 49);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(8, 12);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "-";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.toolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 43);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStrip1.Size = new System.Drawing.Size(567, 22);
            this.StatusStrip1.TabIndex = 14;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 17);
            this.lblUsuario.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Botaologout
            // 
            this.Botaologout.BackColor = System.Drawing.Color.Transparent;
            this.Botaologout.Location = new System.Drawing.Point(487, 5);
            this.Botaologout.Name = "Botaologout";
            this.Botaologout.Size = new System.Drawing.Size(75, 23);
            this.Botaologout.TabIndex = 13;
            this.Botaologout.Text = "Logout";
            this.Botaologout.UseVisualStyleBackColor = false;
            this.Botaologout.Click += new System.EventHandler(this.Botaologout_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsExames,
            this.tsmConsultaExame,
            this.tsmLocalizar,
            this.MsCadastro});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(567, 39);
            this.MenuStrip1.TabIndex = 12;
            this.MenuStrip1.Text = "MenuStrip1";
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
            this.MsExames.Image = ((System.Drawing.Image)(resources.GetObject("MsExames.Image")));
            this.MsExames.Name = "MsExames";
            this.MsExames.Size = new System.Drawing.Size(58, 35);
            this.MsExames.Text = "&Exames";
            this.MsExames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmHema
            // 
            this.tsmHema.Name = "tsmHema";
            this.tsmHema.Size = new System.Drawing.Size(180, 22);
            this.tsmHema.Text = "Hematologia";
            this.tsmHema.Click += new System.EventHandler(this.tsmHema_Click);
            // 
            // Exame2ToolStripMenuItem
            // 
            this.Exame2ToolStripMenuItem.Name = "Exame2ToolStripMenuItem";
            this.Exame2ToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmUri
            // 
            this.tsmUri.Name = "tsmUri";
            this.tsmUri.Size = new System.Drawing.Size(180, 22);
            this.tsmUri.Text = "Urinálise";
            this.tsmUri.Click += new System.EventHandler(this.tsmUri_Click);
            // 
            // Exame4ToolStripMenuItem
            // 
            this.Exame4ToolStripMenuItem.Name = "Exame4ToolStripMenuItem";
            this.Exame4ToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmMicro
            // 
            this.tsmMicro.Name = "tsmMicro";
            this.tsmMicro.Size = new System.Drawing.Size(180, 22);
            this.tsmMicro.Text = "Microbiologia";
            this.tsmMicro.Click += new System.EventHandler(this.tsmMicro_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmBio
            // 
            this.tsmBio.Name = "tsmBio";
            this.tsmBio.Size = new System.Drawing.Size(180, 22);
            this.tsmBio.Text = "Bioquímica";
            this.tsmBio.Click += new System.EventHandler(this.tsmBio_Click);
            // 
            // tsmConsultaExame
            // 
            this.tsmConsultaExame.Image = ((System.Drawing.Image)(resources.GetObject("tsmConsultaExame.Image")));
            this.tsmConsultaExame.Name = "tsmConsultaExame";
            this.tsmConsultaExame.Size = new System.Drawing.Size(107, 35);
            this.tsmConsultaExame.Text = "&Consultar Exame";
            this.tsmConsultaExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmConsultaExame.Click += new System.EventHandler(this.tsmConsultaExame_Click);
            // 
            // tsmLocalizar
            // 
            this.tsmLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsmLocalizar.Image")));
            this.tsmLocalizar.Name = "tsmLocalizar";
            this.tsmLocalizar.Size = new System.Drawing.Size(68, 35);
            this.tsmLocalizar.Text = "&Localizar ";
            this.tsmLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmLocalizar.Click += new System.EventHandler(this.tsmLocalizar_Click);
            // 
            // MsCadastro
            // 
            this.MsCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.MsCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmColaborador,
            this.ToolStripMenuItem2,
            this.tsmPaciente});
            this.MsCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MsCadastro.Image")));
            this.MsCadastro.Name = "MsCadastro";
            this.MsCadastro.Size = new System.Drawing.Size(66, 35);
            this.MsCadastro.Text = "&Cadastro";
            this.MsCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.Name = "tsmPaciente";
            this.tsmPaciente.Size = new System.Drawing.Size(180, 22);
            this.tsmPaciente.Text = "Paciente";
            this.tsmPaciente.Click += new System.EventHandler(this.tsmPaciente_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmColaborador
            // 
            this.tsmColaborador.Name = "tsmColaborador";
            this.tsmColaborador.Size = new System.Drawing.Size(180, 22);
            this.tsmColaborador.Text = "Colaborador";
            this.tsmColaborador.Click += new System.EventHandler(this.tsmColaborador_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 65);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Botaologout);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.Button Botaologout;
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
    }
}