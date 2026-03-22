namespace Tyuiu.StachinskiiVS.Sprint7.Project.V6
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.buttonOk_SVS = new System.Windows.Forms.Button();
            this.labelRuc_SVS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk_SVS
            // 
            this.buttonOk_SVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk_SVS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOk_SVS.Location = new System.Drawing.Point(1404, 679);
            this.buttonOk_SVS.Name = "buttonOk_SVS";
            this.buttonOk_SVS.Size = new System.Drawing.Size(53, 47);
            this.buttonOk_SVS.TabIndex = 0;
            this.buttonOk_SVS.Text = "Ок";
            this.buttonOk_SVS.UseVisualStyleBackColor = true;
            this.buttonOk_SVS.Click += new System.EventHandler(this.buttonOk_SVS_Click);
            // 
            // labelRuc_SVS
            // 
            this.labelRuc_SVS.AutoSize = true;
            this.labelRuc_SVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRuc_SVS.Location = new System.Drawing.Point(2, 9);
            this.labelRuc_SVS.Name = "labelRuc_SVS";
            this.labelRuc_SVS.Size = new System.Drawing.Size(1438, 580);
            this.labelRuc_SVS.TabIndex = 1;
            this.labelRuc_SVS.Text = resources.GetString("labelRuc_SVS.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 738);
            this.Controls.Add(this.labelRuc_SVS);
            this.Controls.Add(this.buttonOk_SVS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство по использованию приложения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_SVS;
        private System.Windows.Forms.Label labelRuc_SVS;
    }
}
