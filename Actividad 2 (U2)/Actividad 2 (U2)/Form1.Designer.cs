﻿namespace Actividad_2__U2_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblActualizacion1 = new MetroFramework.Controls.MetroLabel();
            this.lblActualizacion2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 86);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1113, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1168, 86);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // lblActualizacion1
            // 
            this.lblActualizacion1.AutoSize = true;
            this.lblActualizacion1.Location = new System.Drawing.Point(90, 421);
            this.lblActualizacion1.Name = "lblActualizacion1";
            this.lblActualizacion1.Size = new System.Drawing.Size(12, 20);
            this.lblActualizacion1.TabIndex = 2;
            this.lblActualizacion1.Text = ".";
            // 
            // lblActualizacion2
            // 
            this.lblActualizacion2.AutoSize = true;
            this.lblActualizacion2.Location = new System.Drawing.Point(1242, 410);
            this.lblActualizacion2.Name = "lblActualizacion2";
            this.lblActualizacion2.Size = new System.Drawing.Size(12, 20);
            this.lblActualizacion2.TabIndex = 3;
            this.lblActualizacion2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 489);
            this.Controls.Add(this.lblActualizacion2);
            this.Controls.Add(this.lblActualizacion1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1587, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1587, 489);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Actividad 2 (U2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MetroFramework.Controls.MetroLabel lblActualizacion1;
        private MetroFramework.Controls.MetroLabel lblActualizacion2;
    }
}

