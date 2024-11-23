namespace NoteCheck
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.MessageHide = new System.Windows.Forms.Timer(this.components);
            this.imgInfo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 71);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Tempo excedido";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(66, 24);
            this.lblMessage.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(69, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "MENSAGEM";
            // 
            // MessageHide
            // 
            this.MessageHide.Enabled = true;
            this.MessageHide.Tick += new System.EventHandler(this.MessageHide_Tick);
            // 
            // imgInfo
            // 
            this.imgInfo.BackgroundImage = global::NoteCheck.Properties.Resources.icons8_info_96;
            this.imgInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgInfo.Location = new System.Drawing.Point(19, 12);
            this.imgInfo.Name = "imgInfo";
            this.imgInfo.Size = new System.Drawing.Size(36, 36);
            this.imgInfo.TabIndex = 1;
            this.imgInfo.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(298, 59);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox imgInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer MessageHide;
    }
}