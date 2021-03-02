
namespace FlightWithoutAtmosphere
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.areaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.massNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.areaLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.outputTimeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.angelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.angelLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.areaNumericUpDown);
            this.panel1.Controls.Add(this.massNumericUpDown);
            this.panel1.Controls.Add(this.areaLabel);
            this.panel1.Controls.Add(this.massLabel);
            this.panel1.Controls.Add(this.outputTimeLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.heightNumericUpDown);
            this.panel1.Controls.Add(this.speedNumericUpDown);
            this.panel1.Controls.Add(this.angelNumericUpDown);
            this.panel1.Controls.Add(this.heightLabel);
            this.panel1.Controls.Add(this.speedLabel);
            this.panel1.Controls.Add(this.angelLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 590);
            this.panel1.TabIndex = 0;
            // 
            // areaNumericUpDown
            // 
            this.areaNumericUpDown.Location = new System.Drawing.Point(16, 299);
            this.areaNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.areaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.areaNumericUpDown.Name = "areaNumericUpDown";
            this.areaNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.areaNumericUpDown.TabIndex = 13;
            this.areaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // massNumericUpDown
            // 
            this.massNumericUpDown.Location = new System.Drawing.Point(16, 235);
            this.massNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.massNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumericUpDown.Name = "massNumericUpDown";
            this.massNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.massNumericUpDown.TabIndex = 12;
            this.massNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaLabel.Location = new System.Drawing.Point(12, 276);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(117, 20);
            this.areaLabel.TabIndex = 11;
            this.areaLabel.Text = "Area (cm*cm)";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massLabel.Location = new System.Drawing.Point(12, 212);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(51, 20);
            this.massLabel.TabIndex = 10;
            this.massLabel.Text = "Mass";
            // 
            // outputTimeLabel
            // 
            this.outputTimeLabel.AutoSize = true;
            this.outputTimeLabel.Location = new System.Drawing.Point(61, 368);
            this.outputTimeLabel.Name = "outputTimeLabel";
            this.outputTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.outputTimeLabel.TabIndex = 9;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(12, 368);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 20);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time:";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(16, 472);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 52);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(16, 413);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 53);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(16, 166);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.heightNumericUpDown.TabIndex = 5;
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Location = new System.Drawing.Point(16, 101);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            300000000,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.speedNumericUpDown.TabIndex = 4;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // angelNumericUpDown
            // 
            this.angelNumericUpDown.Location = new System.Drawing.Point(16, 43);
            this.angelNumericUpDown.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.angelNumericUpDown.Name = "angelNumericUpDown";
            this.angelNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.angelNumericUpDown.TabIndex = 3;
            this.angelNumericUpDown.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(12, 143);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(62, 20);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(12, 78);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(61, 20);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Speed";
            // 
            // angelLabel
            // 
            this.angelLabel.AutoSize = true;
            this.angelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angelLabel.Location = new System.Drawing.Point(12, 20);
            this.angelLabel.Name = "angelLabel";
            this.angelLabel.Size = new System.Drawing.Size(55, 20);
            this.angelLabel.TabIndex = 0;
            this.angelLabel.Text = "Angel";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(172, 0);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(838, 590);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 590);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label angelLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.NumericUpDown angelNumericUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label outputTimeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown areaNumericUpDown;
        private System.Windows.Forms.NumericUpDown massNumericUpDown;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label massLabel;
    }
}

