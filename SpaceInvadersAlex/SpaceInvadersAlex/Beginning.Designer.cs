namespace SpaceInvadersAlex
{
    partial class frmBeginning
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
            this.btnbegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbegin
            // 
            this.btnbegin.AccessibleName = "";
            this.btnbegin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbegin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnbegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbegin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbegin.Location = new System.Drawing.Point(399, 159);
            this.btnbegin.Name = "btnbegin";
            this.btnbegin.Size = new System.Drawing.Size(256, 101);
            this.btnbegin.TabIndex = 0;
            this.btnbegin.Text = "New Game";
            this.btnbegin.UseVisualStyleBackColor = false;
            this.btnbegin.Click += new System.EventHandler(this.Btnbegin_Click);
            // 
            // frmBeginning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceInvadersAlex.Properties.Resources.beginning_b;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnbegin);
            this.Name = "frmBeginning";
            this.Text = "Space Invaders";
            this.Load += new System.EventHandler(this.frmBeginning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbegin;
    }
}