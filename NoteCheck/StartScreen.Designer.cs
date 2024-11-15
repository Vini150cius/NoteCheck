using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace NoteCheck
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            this.pnlProgram.SuspendLayout();
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
            this.pnlBack.TabIndex = 0;
            this.pnlBack.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBack_Paint);
            // 
            // pnlProgram
            // 
            this.pnlProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.pnlProgram.Controls.Add(this.btnStatus);
            this.pnlProgram.Controls.Add(this.btnHistorico);
            this.pnlProgram.Controls.Add(this.btnEntregar);
            this.pnlProgram.Controls.Add(this.lblBoasVindas);
            this.pnlProgram.Controls.Add(this.btnRetirar);
            this.pnlProgram.Controls.Add(this.pnlControles);
            this.pnlProgram.Location = new System.Drawing.Point(56, 12);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(969, 510);
            this.pnlProgram.TabIndex = 2;
            this.pnlProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProgram_Paint);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Location = new System.Drawing.Point(296, 322);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(377, 44);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Status dos notebooks";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Location = new System.Drawing.Point(296, 401);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(377, 44);
            this.btnHistorico.TabIndex = 6;
            this.btnHistorico.Text = "Histórico de retirada";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregar.Location = new System.Drawing.Point(296, 243);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(377, 44);
            this.btnEntregar.TabIndex = 5;
            this.btnEntregar.Text = "Devolver notebooks";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.lblBoasVindas.Location = new System.Drawing.Point(399, 102);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(170, 32);
            this.lblBoasVindas.TabIndex = 1;
            this.lblBoasVindas.Text = "Seja bem vindo!!";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Location = new System.Drawing.Point(296, 164);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(377, 44);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar notebooks";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
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
            this.btnMinimizar.TabIndex = 1;
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
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "❌";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::NoteCheck.Properties.Resources.LogoTipoNoteCheckFinal;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(27, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(166, 30);
            this.imgLogo.TabIndex = 12;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 535);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlProgram.ResumeLayout(false);
            this.pnlProgram.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Panel pnlProgram;
        private Panel pnlControles;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button btnRetirar;
        private Button btnStatus;
        private Button btnHistorico;
        private Button btnEntregar;
        private PictureBox imgLogo;
    }
}