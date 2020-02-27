namespace EngineCharacteristics
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinFConsumption = new System.Windows.Forms.TextBox();
            this.txtTorqueMaxPower = new System.Windows.Forms.TextBox();
            this.txtMaxTorque = new System.Windows.Forms.TextBox();
            this.txtMaxFrequency = new System.Windows.Forms.TextBox();
            this.txtMinFrequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrequencyMaxPower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrequencyMaxTorque = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.16268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83732F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMinFConsumption, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTorqueMaxPower, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxTorque, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxFrequency, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMinFrequency, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFrequencyMaxPower, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxPower, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFrequencyMaxTorque, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.78224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная частота вращения коленвала ДВС, об/мин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимальная частота вращения коленвала ДВС, об/мин:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Минимальный расход топлива, г/кВтч:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Момент при при максимальной мощности ДВС, Нм:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Максимальный момент ДВС, Нм:";
            // 
            // txtMinFConsumption
            // 
            this.txtMinFConsumption.Location = new System.Drawing.Point(318, 205);
            this.txtMinFConsumption.Name = "txtMinFConsumption";
            this.txtMinFConsumption.Size = new System.Drawing.Size(100, 20);
            this.txtMinFConsumption.TabIndex = 13;
            this.txtMinFConsumption.Text = "326";
            // 
            // txtTorqueMaxPower
            // 
            this.txtTorqueMaxPower.Location = new System.Drawing.Point(318, 177);
            this.txtTorqueMaxPower.Name = "txtTorqueMaxPower";
            this.txtTorqueMaxPower.Size = new System.Drawing.Size(100, 20);
            this.txtTorqueMaxPower.TabIndex = 12;
            this.txtTorqueMaxPower.Text = "328";
            // 
            // txtMaxTorque
            // 
            this.txtMaxTorque.Location = new System.Drawing.Point(318, 149);
            this.txtMaxTorque.Name = "txtMaxTorque";
            this.txtMaxTorque.Size = new System.Drawing.Size(100, 20);
            this.txtMaxTorque.TabIndex = 11;
            this.txtMaxTorque.Text = "402";
            // 
            // txtMaxFrequency
            // 
            this.txtMaxFrequency.Location = new System.Drawing.Point(318, 3);
            this.txtMaxFrequency.Name = "txtMaxFrequency";
            this.txtMaxFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtMaxFrequency.TabIndex = 7;
            this.txtMaxFrequency.Text = "3200";
            // 
            // txtMinFrequency
            // 
            this.txtMinFrequency.Location = new System.Drawing.Point(318, 31);
            this.txtMinFrequency.Name = "txtMinFrequency";
            this.txtMinFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtMinFrequency.TabIndex = 8;
            this.txtMinFrequency.Text = "850";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Частота вращения коленвала ДВС при максимальной мощности, об/мин:";
            // 
            // txtFrequencyMaxPower
            // 
            this.txtFrequencyMaxPower.Location = new System.Drawing.Point(318, 87);
            this.txtFrequencyMaxPower.Name = "txtFrequencyMaxPower";
            this.txtFrequencyMaxPower.Size = new System.Drawing.Size(100, 20);
            this.txtFrequencyMaxPower.TabIndex = 10;
            this.txtFrequencyMaxPower.Text = "3200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальная мощность ДВС, кВт:";
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Location = new System.Drawing.Point(318, 121);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPower.TabIndex = 9;
            this.txtMaxPower.Text = "110";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Частота вращения коленвала ДВС при максимальном моменте, об/мин:";
            // 
            // txtFrequencyMaxTorque
            // 
            this.txtFrequencyMaxTorque.Location = new System.Drawing.Point(318, 59);
            this.txtFrequencyMaxTorque.Name = "txtFrequencyMaxTorque";
            this.txtFrequencyMaxTorque.Size = new System.Drawing.Size(100, 20);
            this.txtFrequencyMaxTorque.TabIndex = 15;
            this.txtFrequencyMaxTorque.Text = "1800";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Location = new System.Drawing.Point(183, 266);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 47);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(490, 326);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внешняя скоростная характеристика ДВС";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.TextBox txtMaxFrequency;
        public System.Windows.Forms.TextBox txtMinFrequency;
        public System.Windows.Forms.TextBox txtMaxPower;
        public System.Windows.Forms.TextBox txtFrequencyMaxPower;
        public System.Windows.Forms.TextBox txtMaxTorque;
        public System.Windows.Forms.TextBox txtTorqueMaxPower;
        public System.Windows.Forms.TextBox txtMinFConsumption;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtFrequencyMaxTorque;
    }
}

