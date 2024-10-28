namespace NoteCheck
{
    partial class StatusNotebook
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
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrTelas = new System.Windows.Forms.Timer(this.components);
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlControles.Controls.Add(this.imgLogo);
            this.pnlControles.Controls.Add(this.lblLogo);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnFechar);
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(969, 40);
            this.pnlControles.TabIndex = 4;
            this.pnlControles.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControles_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.lblLogo.Location = new System.Drawing.Point(53, 4);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(117, 32);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "NoteCheck";
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
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::NoteCheck.Properties.Resources.logoBeta;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(11, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(36, 33);
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Location = new System.Drawing.Point(870, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 34);
            this.panel1.TabIndex = 23;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.Location = new System.Drawing.Point(34, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer";
            // 
            // tmrTelas
            // 
            this.tmrTelas.Enabled = true;
            this.tmrTelas.Interval = 1;
            // 
            // StatusNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusNotebook";
            this.Text = "StatusNotebook";
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrTelas;
    }
}