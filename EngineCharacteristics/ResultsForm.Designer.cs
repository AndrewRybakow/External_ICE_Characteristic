namespace EngineCharacteristics
{
    partial class ResultsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Torque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCoefFrequency = new System.Windows.Forms.Label();
            this.lblCoefTorque = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCoefSum = new System.Windows.Forms.Label();
            this.lblCoefC = new System.Windows.Forms.Label();
            this.lblCoefB = new System.Windows.Forms.Label();
            this.lblCoefA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chrtPower = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chrtTorque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chrtConsumption = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPower)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTorque)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица результатов";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(413, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frequency,
            this.Power,
            this.Torque,
            this.Consumption});
            this.dataGridView1.Location = new System.Drawing.Point(60, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 270);
            this.dataGridView1.TabIndex = 2;
            // 
            // Frequency
            // 
            this.Frequency.DataPropertyName = "Frequency";
            this.Frequency.HeaderText = "Частота коленвала ДВС, об/мин";
            this.Frequency.Name = "Frequency";
            // 
            // Power
            // 
            this.Power.DataPropertyName = "Power";
            this.Power.HeaderText = "Мощность, кВт";
            this.Power.Name = "Power";
            // 
            // Torque
            // 
            this.Torque.DataPropertyName = "Torque";
            this.Torque.HeaderText = "Момент, Нм";
            this.Torque.Name = "Torque";
            // 
            // Consumption
            // 
            this.Consumption.DataPropertyName = "Consumption";
            this.Consumption.HeaderText = "Удельный расход топлива, г/кВтч";
            this.Consumption.Name = "Consumption";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.lblCoefFrequency);
            this.groupBox2.Controls.Add(this.lblCoefTorque);
            this.groupBox2.Location = new System.Drawing.Point(304, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коэффициенты приспособляемости:";
            // 
            // lblCoefFrequency
            // 
            this.lblCoefFrequency.AutoSize = true;
            this.lblCoefFrequency.Location = new System.Drawing.Point(7, 36);
            this.lblCoefFrequency.Name = "lblCoefFrequency";
            this.lblCoefFrequency.Size = new System.Drawing.Size(66, 13);
            this.lblCoefFrequency.TabIndex = 1;
            this.lblCoefFrequency.Text = "По частоте:";
            // 
            // lblCoefTorque
            // 
            this.lblCoefTorque.AutoSize = true;
            this.lblCoefTorque.Location = new System.Drawing.Point(7, 19);
            this.lblCoefTorque.Name = "lblCoefTorque";
            this.lblCoefTorque.Size = new System.Drawing.Size(71, 13);
            this.lblCoefTorque.TabIndex = 0;
            this.lblCoefTorque.Text = "По моменту:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblCoefSum);
            this.groupBox1.Controls.Add(this.lblCoefC);
            this.groupBox1.Controls.Add(this.lblCoefB);
            this.groupBox1.Controls.Add(this.lblCoefA);
            this.groupBox1.Location = new System.Drawing.Point(60, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэффициенты:";
            // 
            // lblCoefSum
            // 
            this.lblCoefSum.AutoSize = true;
            this.lblCoefSum.Location = new System.Drawing.Point(7, 71);
            this.lblCoefSum.Name = "lblCoefSum";
            this.lblCoefSum.Size = new System.Drawing.Size(44, 13);
            this.lblCoefSum.TabIndex = 3;
            this.lblCoefSum.Text = "Сумма:";
            // 
            // lblCoefC
            // 
            this.lblCoefC.AutoSize = true;
            this.lblCoefC.Location = new System.Drawing.Point(7, 54);
            this.lblCoefC.Name = "lblCoefC";
            this.lblCoefC.Size = new System.Drawing.Size(19, 13);
            this.lblCoefC.TabIndex = 2;
            this.lblCoefC.Text = "c=";
            // 
            // lblCoefB
            // 
            this.lblCoefB.AutoSize = true;
            this.lblCoefB.Location = new System.Drawing.Point(7, 37);
            this.lblCoefB.Name = "lblCoefB";
            this.lblCoefB.Size = new System.Drawing.Size(19, 13);
            this.lblCoefB.TabIndex = 1;
            this.lblCoefB.Text = "b=";
            // 
            // lblCoefA
            // 
            this.lblCoefA.AutoSize = true;
            this.lblCoefA.Location = new System.Drawing.Point(7, 20);
            this.lblCoefA.Name = "lblCoefA";
            this.lblCoefA.Size = new System.Drawing.Size(19, 13);
            this.lblCoefA.TabIndex = 0;
            this.lblCoefA.Text = "a=";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chrtPower);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График мощности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chrtPower
            // 
            this.chrtPower.BackColor = System.Drawing.Color.Cornsilk;
            this.chrtPower.BackImageTransparentColor = System.Drawing.Color.White;
            this.chrtPower.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.SeaShell;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chrtPower.ChartAreas.Add(chartArea1);
            this.chrtPower.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrtPower.Legends.Add(legend1);
            this.chrtPower.Location = new System.Drawing.Point(3, 3);
            this.chrtPower.Name = "chrtPower";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtPower.Series.Add(series1);
            this.chrtPower.Size = new System.Drawing.Size(568, 418);
            this.chrtPower.TabIndex = 0;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Обороты ДВС, об/мин";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title2";
            title2.Text = "Мощность, кВт";
            this.chrtPower.Titles.Add(title1);
            this.chrtPower.Titles.Add(title2);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chrtTorque);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "График момента";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chrtTorque
            // 
            this.chrtTorque.BackColor = System.Drawing.Color.Cornsilk;
            chartArea2.BackColor = System.Drawing.Color.SeaShell;
            chartArea2.Name = "ChartArea1";
            this.chrtTorque.ChartAreas.Add(chartArea2);
            this.chrtTorque.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrtTorque.Legends.Add(legend2);
            this.chrtTorque.Location = new System.Drawing.Point(3, 3);
            this.chrtTorque.Name = "chrtTorque";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtTorque.Series.Add(series2);
            this.chrtTorque.Size = new System.Drawing.Size(568, 418);
            this.chrtTorque.TabIndex = 0;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Обороты ДВС, об/мин";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title2";
            title4.Text = "Момент, Нм";
            this.chrtTorque.Titles.Add(title3);
            this.chrtTorque.Titles.Add(title4);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chrtConsumption);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(574, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "График удельного расхода топлива";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chrtConsumption
            // 
            this.chrtConsumption.BackColor = System.Drawing.Color.Cornsilk;
            chartArea3.BackColor = System.Drawing.Color.SeaShell;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chrtConsumption.ChartAreas.Add(chartArea3);
            this.chrtConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chrtConsumption.Legends.Add(legend3);
            this.chrtConsumption.Location = new System.Drawing.Point(3, 3);
            this.chrtConsumption.Name = "chrtConsumption";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtConsumption.Series.Add(series3);
            this.chrtConsumption.Size = new System.Drawing.Size(568, 418);
            this.chrtConsumption.TabIndex = 0;
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title1";
            title5.Text = "Обороты ДВС, об/мин";
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "Title2";
            title6.Text = "Расход топлива, г/кВтч";
            this.chrtConsumption.Titles.Add(title5);
            this.chrtConsumption.Titles.Add(title6);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты расчёта";
            this.Load += new System.EventHandler(this.Results_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPower)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtTorque)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtConsumption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCoefFrequency;
        private System.Windows.Forms.Label lblCoefTorque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCoefSum;
        private System.Windows.Forms.Label lblCoefC;
        private System.Windows.Forms.Label lblCoefB;
        private System.Windows.Forms.Label lblCoefA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Torque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumption;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPower;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTorque;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtConsumption;
    }
}