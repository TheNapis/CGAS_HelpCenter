namespace CGASHelpProgram
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeMenu1 = new CGASHelpProgram.Home.HomeMenu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Date_label);
            this.panel1.Controls.Add(this.Time_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 63);
            this.panel1.TabIndex = 0;
            // 
            // Date_label
            // 
            this.Date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.Color.White;
            this.Date_label.Location = new System.Drawing.Point(629, 31);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(46, 21);
            this.Date_label.TabIndex = 15;
            this.Date_label.Text = "Date";
            this.Date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Time_label
            // 
            this.Time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.ForeColor = System.Drawing.Color.White;
            this.Time_label.Location = new System.Drawing.Point(629, 9);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(50, 22);
            this.Time_label.TabIndex = 14;
            this.Time_label.Text = "Time";
            this.Time_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.Color.White;
            this.Date_label.Location = new System.Drawing.Point(629, 31);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(46, 21);
            this.Date_label.TabIndex = 15;
            this.Date_label.Text = "Date";
            this.Date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeMenu1
            // 
            this.homeMenu1.BackColor = System.Drawing.Color.Transparent;
            this.homeMenu1.Location = new System.Drawing.Point(0, 60);
            this.homeMenu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeMenu1.Name = "homeMenu1";
            this.homeMenu1.Size = new System.Drawing.Size(734, 384);
            this.homeMenu1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CGASHelpProgram.Properties.Resources.logo_CGAS__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.homeMenu1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Home.HomeMenu homeMenu1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

