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
            this.chrtPower = new LiveCharts.WinForms.CartesianChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chrtTorque = new LiveCharts.WinForms.CartesianChart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chrtConsumption = new LiveCharts.WinForms.CartesianChart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(568, 418);
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
            this.tabPage2.ForeColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График мощности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chrtPower
            // 
            this.chrtPower.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chrtPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtPower.Location = new System.Drawing.Point(3, 3);
            this.chrtPower.Name = "chrtPower";
            this.chrtPower.Size = new System.Drawing.Size(562, 412);
            this.chrtPower.TabIndex = 0;
            this.chrtPower.Text = "cartesianChart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chrtTorque);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "График момента";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chrtTorque
            // 
            this.chrtTorque.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chrtTorque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtTorque.Location = new System.Drawing.Point(3, 3);
            this.chrtTorque.Name = "chrtTorque";
            this.chrtTorque.Size = new System.Drawing.Size(562, 412);
            this.chrtTorque.TabIndex = 0;
            this.chrtTorque.Text = "cartesianChart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chrtConsumption);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(568, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "График удельного расхода топлива";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chrtConsumption
            // 
            this.chrtConsumption.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chrtConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtConsumption.Location = new System.Drawing.Point(3, 3);
            this.chrtConsumption.Name = "chrtConsumption";
            this.chrtConsumption.Size = new System.Drawing.Size(562, 412);
            this.chrtConsumption.TabIndex = 0;
            this.chrtConsumption.Text = "cartesianChart1";
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
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты расчёта";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.Results_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
        private LiveCharts.WinForms.CartesianChart chrtPower;
        private LiveCharts.WinForms.CartesianChart chrtTorque;
        private LiveCharts.WinForms.CartesianChart chrtConsumption;
    }
}