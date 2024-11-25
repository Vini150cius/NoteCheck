﻿namespace NoteCheck
{
    partial class HistoricoRetirada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoRetirada));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNumeroNote = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.dtpDataDesejada = new System.Windows.Forms.DateTimePicker();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tmrTelas = new System.Windows.Forms.Timer(this.components);
            this.pnlBack.SuspendLayout();
            this.pnlProgram.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBack.Controls.Add(this.pnlProgram);
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1080, 535);
            this.pnlBack.TabIndex = 3;
            // 
            // pnlProgram
            // 
            this.pnlProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.pnlProgram.Controls.Add(this.lblAte);
            this.pnlProgram.Controls.Add(this.dtpDataFinal);
            this.pnlProgram.Controls.Add(this.dtpDataInicial);
            this.pnlProgram.Controls.Add(this.cbxTipoRelatorio);
            this.pnlProgram.Controls.Add(this.lblTipo);
            this.pnlProgram.Controls.Add(this.txtNumeroNote);
            this.pnlProgram.Controls.Add(this.txtNomeAluno);
            this.pnlProgram.Controls.Add(this.dtpDataDesejada);
            this.pnlProgram.Controls.Add(this.pnlTimer);
            this.pnlProgram.Controls.Add(this.dgDados);
            this.pnlProgram.Controls.Add(this.btnVoltar);
            this.pnlProgram.Controls.Add(this.lblBoasVindas);
            this.pnlProgram.Controls.Add(this.lblAcao);
            this.pnlProgram.Controls.Add(this.pnlControles);
            this.pnlProgram.Location = new System.Drawing.Point(56, 12);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(969, 510);
            this.pnlProgram.TabIndex = 2;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(380, 97);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(35, 20);
            this.lblAte.TabIndex = 36;
            this.lblAte.Text = "até";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(418, 97);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(110, 22);
            this.dtpDataFinal.TabIndex = 35;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(267, 97);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(110, 22);
            this.dtpDataInicial.TabIndex = 34;
            this.dtpDataInicial.ValueChanged += new System.EventHandler(this.dtpDataInicial_ValueChanged);
            // 
            // cbxTipoRelatorio
            // 
            this.cbxTipoRelatorio.DisplayMember = "Diário";
            this.cbxTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRelatorio.FormattingEnabled = true;
            this.cbxTipoRelatorio.Items.AddRange(new object[] {
            "Diário",
            "Outro"});
            this.cbxTipoRelatorio.Location = new System.Drawing.Point(152, 97);
            this.cbxTipoRelatorio.Name = "cbxTipoRelatorio";
            this.cbxTipoRelatorio.Size = new System.Drawing.Size(109, 21);
            this.cbxTipoRelatorio.TabIndex = 33;
            this.cbxTipoRelatorio.ValueMember = "Diário";
            this.cbxTipoRelatorio.SelectedIndexChanged += new System.EventHandler(this.cbxTipoRelatorio_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(19, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(144, 20);
            this.lblTipo.TabIndex = 32;
            this.lblTipo.Text = "Tipo de relatório:";
            // 
            // txtNumeroNote
            // 
            this.txtNumeroNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNote.Location = new System.Drawing.Point(770, 97);
            this.txtNumeroNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroNote.Name = "txtNumeroNote";
            this.txtNumeroNote.Size = new System.Drawing.Size(185, 23);
            this.txtNumeroNote.TabIndex = 31;
            this.txtNumeroNote.TextChanged += new System.EventHandler(this.txtNumeroNote_TextChanged);
            this.txtNumeroNote.Enter += new System.EventHandler(this.txtNumeroNote_Enter);
            this.txtNumeroNote.Leave += new System.EventHandler(this.txtNumeroNote_Leave);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(579, 97);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(187, 23);
            this.txtNomeAluno.TabIndex = 30;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.txtNomeAluno_TextChanged);
            this.txtNomeAluno.Enter += new System.EventHandler(this.txtNomeAluno_Enter);
            this.txtNomeAluno.Leave += new System.EventHandler(this.txtNomeAluno_Leave);
            // 
            // dtpDataDesejada
            // 
            this.dtpDataDesejada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDesejada.Location = new System.Drawing.Point(267, 97);
            this.dtpDataDesejada.Name = "dtpDataDesejada";
            this.dtpDataDesejada.Size = new System.Drawing.Size(276, 22);
            this.dtpDataDesejada.TabIndex = 29;
            this.dtpDataDesejada.ValueChanged += new System.EventHandler(this.dtpDataDesejada_ValueChanged);
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(870, 477);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(110, 43);
            this.pnlTimer.TabIndex = 28;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.Location = new System.Drawing.Point(19, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(60, 24);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00";
            // 
            // dgDados
            // 
            this.dgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(13, 125);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgDados.RowHeadersWidth = 62;
            this.dgDados.Size = new System.Drawing.Size(942, 328);
            this.dgDados.TabIndex = 27;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::NoteCheck.Properties.Resources.seta;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(11, 59);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 27);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "‬Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.Black;
            this.lblBoasVindas.Location = new System.Drawing.Point(375, 59);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(257, 31);
            this.lblBoasVindas.TabIndex = 8;
            this.lblBoasVindas.Text = "Historico de retirada";
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.lblAcao.Location = new System.Drawing.Point(365, 108);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(73, 25);
            this.lblAcao.TabIndex = 1;
            this.lblAcao.Text = "Ação: ";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlControles.Controls.Add(this.imgLogo);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnFechar);
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(969, 40);
            this.pnlControles.TabIndex = 2;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::NoteCheck.Properties.Resources.LogoTipoNoteCheckFinal;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(27, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(166, 30);
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.Location = new System.Drawing.Point(870, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 27);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "➖";
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(921, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 27);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "❌";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tmrTelas
            // 
            this.tmrTelas.Enabled = true;
            this.tmrTelas.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HistoricoRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 535);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoricoRetirada";
            this.Text = "HistoricoRetirada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HistoricoRetirada_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlProgram.ResumeLayout(false);
            this.pnlProgram.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlProgram;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dtpDataDesejada;
        private System.Windows.Forms.Timer tmrTelas;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtNumeroNote;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipoRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lblAte;
    }
}