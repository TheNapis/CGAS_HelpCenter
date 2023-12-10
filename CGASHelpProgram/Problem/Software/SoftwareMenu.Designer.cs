namespace CGASHelpProgram.Problem.Software
{
    partial class SoftwareMenu
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Unlogiciel_Button = new FontAwesome.Sharp.IconButton();
            this.Pluslogiciel_Button = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "J\'ai un problème avec :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Unlogiciel_Button
            // 
            this.Unlogiciel_Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Unlogiciel_Button.FlatAppearance.BorderSize = 0;
            this.Unlogiciel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unlogiciel_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unlogiciel_Button.ForeColor = System.Drawing.Color.White;
            this.Unlogiciel_Button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Unlogiciel_Button.IconColor = System.Drawing.Color.Black;
            this.Unlogiciel_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Unlogiciel_Button.Location = new System.Drawing.Point(80, 89);
            this.Unlogiciel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Unlogiciel_Button.Name = "Unlogiciel_Button";
            this.Unlogiciel_Button.Size = new System.Drawing.Size(150, 81);
            this.Unlogiciel_Button.TabIndex = 1;
            this.Unlogiciel_Button.Text = "Un logiciel";
            this.Unlogiciel_Button.UseVisualStyleBackColor = false;
            this.Unlogiciel_Button.Click += new System.EventHandler(this.Unlogiciel_Button_Click);
            // 
            // Pluslogiciel_Button
            // 
            this.Pluslogiciel_Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Pluslogiciel_Button.FlatAppearance.BorderSize = 0;
            this.Pluslogiciel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pluslogiciel_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pluslogiciel_Button.ForeColor = System.Drawing.Color.White;
            this.Pluslogiciel_Button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Pluslogiciel_Button.IconColor = System.Drawing.Color.Black;
            this.Pluslogiciel_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pluslogiciel_Button.Location = new System.Drawing.Point(80, 218);
            this.Pluslogiciel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Pluslogiciel_Button.Name = "Pluslogiciel_Button";
            this.Pluslogiciel_Button.Size = new System.Drawing.Size(150, 81);
            this.Pluslogiciel_Button.TabIndex = 2;
            this.Pluslogiciel_Button.Text = "Plusieurs logiciels";
            this.Pluslogiciel_Button.UseVisualStyleBackColor = false;
            this.Pluslogiciel_Button.Click += new System.EventHandler(this.Pluslogiciel_Button_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "Réinstalle le logiciel sélectionné dans la prochaine étape";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 81);
            this.label3.TabIndex = 4;
            this.label3.Text = "Réinstalle tous les logiciels de l\'ordinateur\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoftwareMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pluslogiciel_Button);
            this.Controls.Add(this.Unlogiciel_Button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SoftwareMenu";
            this.Size = new System.Drawing.Size(731, 344);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Unlogiciel_Button;
        private FontAwesome.Sharp.IconButton Pluslogiciel_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
