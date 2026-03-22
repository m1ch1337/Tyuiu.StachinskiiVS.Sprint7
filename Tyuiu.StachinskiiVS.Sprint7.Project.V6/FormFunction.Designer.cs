namespace Tyuiu.StachinskiiVS.Sprint7.Project.V6
{
    partial class FormFunction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_SVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelNiz_SVS = new System.Windows.Forms.Panel();
            this.buttonBack_SVS = new System.Windows.Forms.Button();
            this.buttonSaveGraph_SVS = new System.Windows.Forms.Button();
            this.panelMiddle_SVS = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецДиагнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.амбулаторноеЛечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipGraph_SVS = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVS)).BeginInit();
            this.panelNiz_SVS.SuspendLayout();
            this.panelMiddle_SVS.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_SVS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SVS.ChartAreas.Add(chartArea1);
            this.chartFunction_SVS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            this.chartFunction_SVS.Legends.Add(legend1);
            this.chartFunction_SVS.Location = new System.Drawing.Point(0, 24);
            this.chartFunction_SVS.Name = "chartFunction_SVS";
            this.chartFunction_SVS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkSlateGray;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SVS.Series.Add(series1);
            this.chartFunction_SVS.Size = new System.Drawing.Size(1364, 605);
            this.chartFunction_SVS.TabIndex = 0;
            // 
            // panelNiz_SVS
            // 
            this.panelNiz_SVS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNiz_SVS.Controls.Add(this.buttonBack_SVS);
            this.panelNiz_SVS.Controls.Add(this.buttonSaveGraph_SVS);
            this.panelNiz_SVS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNiz_SVS.Location = new System.Drawing.Point(0, 629);
            this.panelNiz_SVS.Name = "panelNiz_SVS";
            this.panelNiz_SVS.Size = new System.Drawing.Size(1364, 83);
            this.panelNiz_SVS.TabIndex = 1;
            // 
            // buttonBack_SVS
            // 
            this.buttonBack_SVS.Location = new System.Drawing.Point(12, 12);
            this.buttonBack_SVS.Name = "buttonBack_SVS";
            this.buttonBack_SVS.Size = new System.Drawing.Size(72, 61);
            this.buttonBack_SVS.TabIndex = 2;
            this.buttonBack_SVS.Text = "Ок";
            this.buttonBack_SVS.UseVisualStyleBackColor = true;
            this.buttonBack_SVS.Click += new System.EventHandler(this.buttonBack_SVS_Click);
            // 
            // buttonSaveGraph_SVS
            // 
            this.buttonSaveGraph_SVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            
            this.buttonSaveGraph_SVS.Location = new System.Drawing.Point(1280, 12);
            this.buttonSaveGraph_SVS.Name = "buttonSaveGraph_SVS";
            this.buttonSaveGraph_SVS.Size = new System.Drawing.Size(72, 61);
            this.buttonSaveGraph_SVS.TabIndex = 1;
            this.toolTipGraph_SVS.SetToolTip(this.buttonSaveGraph_SVS, "Сохраняет диаграмму");
            this.buttonSaveGraph_SVS.UseVisualStyleBackColor = true;
            this.buttonSaveGraph_SVS.Click += new System.EventHandler(this.buttonSaveGraph_SVS_Click);
            // 
            // panelMiddle_SVS
            // 
            this.panelMiddle_SVS.Controls.Add(this.chartFunction_SVS);
            this.panelMiddle_SVS.Controls.Add(this.menuStrip1);
            this.panelMiddle_SVS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_SVS.Location = new System.Drawing.Point(0, 0);
            this.panelMiddle_SVS.Name = "panelMiddle_SVS";
            this.panelMiddle_SVS.Size = new System.Drawing.Size(1364, 629);
            this.panelMiddle_SVS.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem
            // 
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецДиагнозToolStripMenuItem,
            this.столбецToolStripMenuItem,
            this.амбулаторноеЛечениеToolStripMenuItem,
            this.должностьВрачаToolStripMenuItem});
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Name = "выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem";
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Size = new System.Drawing.Size(279, 20);
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Text = "Выбирите столбец для построения диаграммы";
            // 
            // столбецДиагнозToolStripMenuItem
            // 
            this.столбецДиагнозToolStripMenuItem.Name = "столбецДиагнозToolStripMenuItem";
            this.столбецДиагнозToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.столбецДиагнозToolStripMenuItem.Text = "Столбец \"Диагноз\"";
            this.столбецДиагнозToolStripMenuItem.Click += new System.EventHandler(this.столбецДиагнозToolStripMenuItem_Click);
            // 
            // столбецToolStripMenuItem
            // 
            this.столбецToolStripMenuItem.Name = "столбецToolStripMenuItem";
            this.столбецToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.столбецToolStripMenuItem.Text = "Столбец \"На диспансерном учете\"";
            this.столбецToolStripMenuItem.Click += new System.EventHandler(this.столбецToolStripMenuItem_Click);
            // 
            // амбулаторноеЛечениеToolStripMenuItem
            // 
            this.амбулаторноеЛечениеToolStripMenuItem.Name = "амбулаторноеЛечениеToolStripMenuItem";
            this.амбулаторноеЛечениеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.амбулаторноеЛечениеToolStripMenuItem.Text = "Столбец \"Амбулаторное лечение\"";
            this.амбулаторноеЛечениеToolStripMenuItem.Click += new System.EventHandler(this.амбулаторноеЛечениеToolStripMenuItem_Click);
            // 
            // должностьВрачаToolStripMenuItem
            // 
            this.должностьВрачаToolStripMenuItem.Name = "должностьВрачаToolStripMenuItem";
            this.должностьВрачаToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.должностьВрачаToolStripMenuItem.Text = "Столбец \"Должность врача\"";
            this.должностьВрачаToolStripMenuItem.Click += new System.EventHandler(this.должностьВрачаToolStripMenuItem_Click);
            // 
            // toolTipGraph_SVS
            // 
            this.toolTipGraph_SVS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGraph_SVS.ToolTipTitle = "Подсказка";
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 712);
            this.Controls.Add(this.panelMiddle_SVS);
            this.Controls.Add(this.panelNiz_SVS);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График функции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVS)).EndInit();
            this.panelNiz_SVS.ResumeLayout(false);
            this.panelMiddle_SVS.ResumeLayout(false);
            this.panelMiddle_SVS.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVS;
        private System.Windows.Forms.Panel panelNiz_SVS;
        private System.Windows.Forms.Panel panelMiddle_SVS;
        private System.Windows.Forms.Button buttonSaveGraph_SVS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецДиагнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem амбулаторноеЛечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьВрачаToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack_SVS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTipGraph_SVS;
    }
}
