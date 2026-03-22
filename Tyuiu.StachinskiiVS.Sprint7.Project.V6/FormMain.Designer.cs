namespace Tyuiu.StachinskiiVS.Sprint7.Project.V6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            buttonInfoRazrab_SVS = new Button();
            buttonPatients_SVS = new Button();
            buttonInfo_SVS = new Button();
            SuspendLayout();
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonInfoRazrab_SVS
            // 
            buttonInfoRazrab_SVS.Cursor = Cursors.Hand;
            buttonInfoRazrab_SVS.Location = new Point(14, 14);
            buttonInfoRazrab_SVS.Margin = new Padding(4, 3, 4, 3);
            buttonInfoRazrab_SVS.Name = "buttonInfoRazrab_SVS";
            buttonInfoRazrab_SVS.Size = new Size(128, 122);
            buttonInfoRazrab_SVS.TabIndex = 5;
            toolTip.SetToolTip(buttonInfoRazrab_SVS, "Информация о программе");
            buttonInfoRazrab_SVS.UseVisualStyleBackColor = true;
            buttonInfoRazrab_SVS.Click += buttonInfoRazrab_SVS_Click;
            // 
            // buttonPatients_SVS
            // 
            buttonPatients_SVS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPatients_SVS.Cursor = Cursors.Hand;
            buttonPatients_SVS.Location = new Point(289, 14);
            buttonPatients_SVS.Margin = new Padding(4, 3, 4, 3);
            buttonPatients_SVS.Name = "buttonPatients_SVS";
            buttonPatients_SVS.Size = new Size(1116, 752);
            buttonPatients_SVS.TabIndex = 3;
            toolTip.SetToolTip(buttonPatients_SVS, "Переход к инструментальному окну");
            buttonPatients_SVS.UseVisualStyleBackColor = true;
            buttonPatients_SVS.Click += buttonPatients_SVS_Click;
            // 
            // buttonInfo_SVS
            // 
            buttonInfo_SVS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonInfo_SVS.Cursor = Cursors.Hand;
            buttonInfo_SVS.Location = new Point(14, 644);
            buttonInfo_SVS.Margin = new Padding(4, 3, 4, 3);
            buttonInfo_SVS.Name = "buttonInfo_SVS";
            buttonInfo_SVS.Size = new Size(128, 122);
            buttonInfo_SVS.TabIndex = 2;
            toolTip.SetToolTip(buttonInfo_SVS, "Руководство");
            buttonInfo_SVS.UseVisualStyleBackColor = true;
            buttonInfo_SVS.Click += buttonInfo_SVS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 780);
            Controls.Add(buttonInfoRazrab_SVS);
            Controls.Add(buttonPatients_SVS);
            Controls.Add(buttonInfo_SVS);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Информация о пациентах Городской поликлиники";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInfo_SVS;
        private System.Windows.Forms.Button buttonPatients_SVS;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonInfoRazrab_SVS;
    }
}
