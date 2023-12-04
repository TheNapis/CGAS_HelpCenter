namespace CGASHelpProgram.PowerOptions
{
    partial class PowerOptionMenu
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
            this.ShutD_Button = new FontAwesome.Sharp.IconButton();
            this.Reboot_Button = new FontAwesome.Sharp.IconButton();
            this.AdvOptions_Button = new FontAwesome.Sharp.IconButton();
            this.SignOff_Button = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShutD_Button
            // 
            this.ShutD_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ShutD_Button.FlatAppearance.BorderSize = 0;
            this.ShutD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutD_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutD_Button.ForeColor = System.Drawing.Color.White;
            this.ShutD_Button.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ShutD_Button.IconColor = System.Drawing.Color.White;
            this.ShutD_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ShutD_Button.IconSize = 70;
            this.ShutD_Button.Location = new System.Drawing.Point(3, 88);
            this.ShutD_Button.Name = "ShutD_Button";
            this.ShutD_Button.Size = new System.Drawing.Size(130, 201);
            this.ShutD_Button.TabIndex = 18;
            this.ShutD_Button.Text = "Eteindre\n";
            this.ShutD_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShutD_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShutD_Button.UseVisualStyleBackColor = false;
            this.ShutD_Button.Click += new System.EventHandler(this.ShutD_Button_Click);
            // 
            // Reboot_Button
            // 
            this.Reboot_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Reboot_Button.FlatAppearance.BorderSize = 0;
            this.Reboot_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reboot_Button.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Reboot_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reboot_Button.ForeColor = System.Drawing.Color.White;
            this.Reboot_Button.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.Reboot_Button.IconColor = System.Drawing.Color.White;
            this.Reboot_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reboot_Button.IconSize = 70;
            this.Reboot_Button.Location = new System.Drawing.Point(139, 88);
            this.Reboot_Button.Name = "Reboot_Button";
            this.Reboot_Button.Size = new System.Drawing.Size(130, 201);
            this.Reboot_Button.TabIndex = 19;
            this.Reboot_Button.Text = "Redémarrer";
            this.Reboot_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reboot_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Reboot_Button.UseVisualStyleBackColor = false;
            this.Reboot_Button.Click += new System.EventHandler(this.Reboot_Button_Click);
            // 
            // AdvOptions_Button
            // 
            this.AdvOptions_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.AdvOptions_Button.FlatAppearance.BorderSize = 0;
            this.AdvOptions_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvOptions_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvOptions_Button.ForeColor = System.Drawing.Color.White;
            this.AdvOptions_Button.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.AdvOptions_Button.IconColor = System.Drawing.Color.White;
            this.AdvOptions_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdvOptions_Button.IconSize = 70;
            this.AdvOptions_Button.Location = new System.Drawing.Point(465, 89);
            this.AdvOptions_Button.Name = "AdvOptions_Button";
            this.AdvOptions_Button.Size = new System.Drawing.Size(130, 201);
            this.AdvOptions_Button.TabIndex = 20;
            this.AdvOptions_Button.Text = "Options\r\nAvancées\r\n";
            this.AdvOptions_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdvOptions_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AdvOptions_Button.UseVisualStyleBackColor = false;
            this.AdvOptions_Button.Click += new System.EventHandler(this.AdvOptions_Button_Click);
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.SignOff_Button.FlatAppearance.BorderSize = 0;
            this.SignOff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOff_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOff_Button.ForeColor = System.Drawing.Color.White;
            this.SignOff_Button.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.SignOff_Button.IconColor = System.Drawing.Color.White;
            this.SignOff_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SignOff_Button.IconSize = 70;
            this.SignOff_Button.Location = new System.Drawing.Point(601, 88);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(130, 201);
            this.SignOff_Button.TabIndex = 22;
            this.SignOff_Button.Text = "Déconnexion";
            this.SignOff_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SignOff_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SignOff_Button.UseVisualStyleBackColor = false;
            this.SignOff_Button.Click += new System.EventHandler(this.SignOff_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sélectionner une option";
            // 
            // PowerOptionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignOff_Button);
            this.Controls.Add(this.AdvOptions_Button);
            this.Controls.Add(this.Reboot_Button);
            this.Controls.Add(this.ShutD_Button);
            this.Name = "PowerOptionMenu";
            this.Size = new System.Drawing.Size(734, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ShutD_Button;
        private FontAwesome.Sharp.IconButton Reboot_Button;
        private FontAwesome.Sharp.IconButton AdvOptions_Button;
        private FontAwesome.Sharp.IconButton SignOff_Button;
        private System.Windows.Forms.Label label1;
    }
}
