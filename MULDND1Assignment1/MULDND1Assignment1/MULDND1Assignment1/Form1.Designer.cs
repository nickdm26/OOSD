namespace MULDND1Assignment1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnConvolution = new System.Windows.Forms.RadioButton();
            this.rbtnDelta_Means = new System.Windows.Forms.RadioButton();
            this.rbtnPerpendicularNeighbours = new System.Windows.Forms.RadioButton();
            this.groupBoxLaplacianFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxShadingAlgorithm = new System.Windows.Forms.GroupBox();
            this.rbtnYellowToRed = new System.Windows.Forms.RadioButton();
            this.rbtnLongRainbow = new System.Windows.Forms.RadioButton();
            this.rbtnShortRainbow = new System.Windows.Forms.RadioButton();
            this.rbtnGrayScale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxDisplayGrid = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.numericUpDownIncrementValues = new System.Windows.Forms.NumericUpDown();
            this.groupBoxReRunSim = new System.Windows.Forms.GroupBox();
            this.labelReRun = new System.Windows.Forms.Label();
            this.labelTimes = new System.Windows.Forms.Label();
            this.numericUpDownTimes = new System.Windows.Forms.NumericUpDown();
            this.rbtnReRunNo = new System.Windows.Forms.RadioButton();
            this.rbtnReRunYes = new System.Windows.Forms.RadioButton();
            this.Values = new System.Windows.Forms.Label();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.groupBoxSimulationValues = new System.Windows.Forms.GroupBox();
            this.numericUpDownGridHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCycles = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKillRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFeedRate = new System.Windows.Forms.NumericUpDown();
            this.labelGridHeight = new System.Windows.Forms.Label();
            this.labelCycles = new System.Windows.Forms.Label();
            this.labelKillRate = new System.Windows.Forms.Label();
            this.labelFeedRate = new System.Windows.Forms.Label();
            this.groupBoxLaplacianFunctions.SuspendLayout();
            this.groupBoxShadingAlgorithm.SuspendLayout();
            this.groupBoxDisplayGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementValues)).BeginInit();
            this.groupBoxReRunSim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).BeginInit();
            this.groupBoxSimulationValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKillRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeedRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 591);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(97, 591);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 38);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rbtnConvolution
            // 
            this.rbtnConvolution.AutoSize = true;
            this.rbtnConvolution.Checked = true;
            this.rbtnConvolution.Location = new System.Drawing.Point(6, 19);
            this.rbtnConvolution.Name = "rbtnConvolution";
            this.rbtnConvolution.Size = new System.Drawing.Size(81, 17);
            this.rbtnConvolution.TabIndex = 2;
            this.rbtnConvolution.TabStop = true;
            this.rbtnConvolution.Text = "Convolution";
            this.rbtnConvolution.UseVisualStyleBackColor = true;
            // 
            // rbtnDelta_Means
            // 
            this.rbtnDelta_Means.AutoSize = true;
            this.rbtnDelta_Means.Location = new System.Drawing.Point(6, 42);
            this.rbtnDelta_Means.Name = "rbtnDelta_Means";
            this.rbtnDelta_Means.Size = new System.Drawing.Size(85, 17);
            this.rbtnDelta_Means.TabIndex = 3;
            this.rbtnDelta_Means.Text = "Delta Means";
            this.rbtnDelta_Means.UseVisualStyleBackColor = true;
            // 
            // rbtnPerpendicularNeighbours
            // 
            this.rbtnPerpendicularNeighbours.AutoSize = true;
            this.rbtnPerpendicularNeighbours.Location = new System.Drawing.Point(6, 65);
            this.rbtnPerpendicularNeighbours.Name = "rbtnPerpendicularNeighbours";
            this.rbtnPerpendicularNeighbours.Size = new System.Drawing.Size(147, 17);
            this.rbtnPerpendicularNeighbours.TabIndex = 4;
            this.rbtnPerpendicularNeighbours.Text = "Perpendicular Neighbours";
            this.rbtnPerpendicularNeighbours.UseVisualStyleBackColor = true;
            // 
            // groupBoxLaplacianFunctions
            // 
            this.groupBoxLaplacianFunctions.Controls.Add(this.rbtnConvolution);
            this.groupBoxLaplacianFunctions.Controls.Add(this.rbtnDelta_Means);
            this.groupBoxLaplacianFunctions.Controls.Add(this.rbtnPerpendicularNeighbours);
            this.groupBoxLaplacianFunctions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLaplacianFunctions.Name = "groupBoxLaplacianFunctions";
            this.groupBoxLaplacianFunctions.Size = new System.Drawing.Size(156, 91);
            this.groupBoxLaplacianFunctions.TabIndex = 6;
            this.groupBoxLaplacianFunctions.TabStop = false;
            this.groupBoxLaplacianFunctions.Text = "Laplacian Function";
            // 
            // groupBoxShadingAlgorithm
            // 
            this.groupBoxShadingAlgorithm.Controls.Add(this.rbtnYellowToRed);
            this.groupBoxShadingAlgorithm.Controls.Add(this.rbtnLongRainbow);
            this.groupBoxShadingAlgorithm.Controls.Add(this.rbtnShortRainbow);
            this.groupBoxShadingAlgorithm.Controls.Add(this.rbtnGrayScale);
            this.groupBoxShadingAlgorithm.Location = new System.Drawing.Point(12, 109);
            this.groupBoxShadingAlgorithm.Name = "groupBoxShadingAlgorithm";
            this.groupBoxShadingAlgorithm.Size = new System.Drawing.Size(156, 113);
            this.groupBoxShadingAlgorithm.TabIndex = 7;
            this.groupBoxShadingAlgorithm.TabStop = false;
            this.groupBoxShadingAlgorithm.Text = "Shading Algorithms";
            // 
            // rbtnYellowToRed
            // 
            this.rbtnYellowToRed.AutoSize = true;
            this.rbtnYellowToRed.Location = new System.Drawing.Point(6, 88);
            this.rbtnYellowToRed.Name = "rbtnYellowToRed";
            this.rbtnYellowToRed.Size = new System.Drawing.Size(95, 17);
            this.rbtnYellowToRed.TabIndex = 3;
            this.rbtnYellowToRed.Text = "Yellow To Red";
            this.rbtnYellowToRed.UseVisualStyleBackColor = true;
            // 
            // rbtnLongRainbow
            // 
            this.rbtnLongRainbow.AutoSize = true;
            this.rbtnLongRainbow.Location = new System.Drawing.Point(6, 65);
            this.rbtnLongRainbow.Name = "rbtnLongRainbow";
            this.rbtnLongRainbow.Size = new System.Drawing.Size(94, 17);
            this.rbtnLongRainbow.TabIndex = 2;
            this.rbtnLongRainbow.Text = "Long Rainbow";
            this.rbtnLongRainbow.UseVisualStyleBackColor = true;
            // 
            // rbtnShortRainbow
            // 
            this.rbtnShortRainbow.AutoSize = true;
            this.rbtnShortRainbow.Location = new System.Drawing.Point(6, 42);
            this.rbtnShortRainbow.Name = "rbtnShortRainbow";
            this.rbtnShortRainbow.Size = new System.Drawing.Size(95, 17);
            this.rbtnShortRainbow.TabIndex = 1;
            this.rbtnShortRainbow.Text = "Short Rainbow";
            this.rbtnShortRainbow.UseVisualStyleBackColor = true;
            // 
            // rbtnGrayScale
            // 
            this.rbtnGrayScale.AutoSize = true;
            this.rbtnGrayScale.Checked = true;
            this.rbtnGrayScale.Location = new System.Drawing.Point(6, 19);
            this.rbtnGrayScale.Name = "rbtnGrayScale";
            this.rbtnGrayScale.Size = new System.Drawing.Size(74, 17);
            this.rbtnGrayScale.TabIndex = 0;
            this.rbtnGrayScale.TabStop = true;
            this.rbtnGrayScale.Text = "GrayScale";
            this.rbtnGrayScale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(190, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 810);
            this.panel1.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 12);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(810, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 23;
            // 
            // groupBoxDisplayGrid
            // 
            this.groupBoxDisplayGrid.Controls.Add(this.rbtnNo);
            this.groupBoxDisplayGrid.Controls.Add(this.rbtnYes);
            this.groupBoxDisplayGrid.Location = new System.Drawing.Point(12, 516);
            this.groupBoxDisplayGrid.Name = "groupBoxDisplayGrid";
            this.groupBoxDisplayGrid.Size = new System.Drawing.Size(156, 69);
            this.groupBoxDisplayGrid.TabIndex = 27;
            this.groupBoxDisplayGrid.TabStop = false;
            this.groupBoxDisplayGrid.Text = "Display Grid";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Checked = true;
            this.rbtnNo.Location = new System.Drawing.Point(6, 42);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(6, 19);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(43, 17);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIncrementValues
            // 
            this.numericUpDownIncrementValues.DecimalPlaces = 6;
            this.numericUpDownIncrementValues.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownIncrementValues.Location = new System.Drawing.Point(69, 32);
            this.numericUpDownIncrementValues.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIncrementValues.Name = "numericUpDownIncrementValues";
            this.numericUpDownIncrementValues.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownIncrementValues.TabIndex = 28;
            this.numericUpDownIncrementValues.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // groupBoxReRunSim
            // 
            this.groupBoxReRunSim.Controls.Add(this.labelReRun);
            this.groupBoxReRunSim.Controls.Add(this.labelTimes);
            this.groupBoxReRunSim.Controls.Add(this.numericUpDownTimes);
            this.groupBoxReRunSim.Controls.Add(this.rbtnReRunNo);
            this.groupBoxReRunSim.Controls.Add(this.rbtnReRunYes);
            this.groupBoxReRunSim.Controls.Add(this.Values);
            this.groupBoxReRunSim.Controls.Add(this.labelIncrement);
            this.groupBoxReRunSim.Controls.Add(this.numericUpDownIncrementValues);
            this.groupBoxReRunSim.Location = new System.Drawing.Point(12, 364);
            this.groupBoxReRunSim.Name = "groupBoxReRunSim";
            this.groupBoxReRunSim.Size = new System.Drawing.Size(156, 146);
            this.groupBoxReRunSim.TabIndex = 29;
            this.groupBoxReRunSim.TabStop = false;
            this.groupBoxReRunSim.Text = "ReRun Simulation";
            // 
            // labelReRun
            // 
            this.labelReRun.AutoSize = true;
            this.labelReRun.Location = new System.Drawing.Point(0, 98);
            this.labelReRun.Name = "labelReRun";
            this.labelReRun.Size = new System.Drawing.Size(47, 13);
            this.labelReRun.TabIndex = 34;
            this.labelReRun.Text = "ReRun?";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(-3, 61);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(35, 13);
            this.labelTimes.TabIndex = 33;
            this.labelTimes.Text = "Times";
            // 
            // numericUpDownTimes
            // 
            this.numericUpDownTimes.Location = new System.Drawing.Point(69, 59);
            this.numericUpDownTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimes.Name = "numericUpDownTimes";
            this.numericUpDownTimes.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownTimes.TabIndex = 30;
            this.numericUpDownTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnReRunNo
            // 
            this.rbtnReRunNo.AutoSize = true;
            this.rbtnReRunNo.Checked = true;
            this.rbtnReRunNo.Location = new System.Drawing.Point(69, 119);
            this.rbtnReRunNo.Name = "rbtnReRunNo";
            this.rbtnReRunNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnReRunNo.TabIndex = 32;
            this.rbtnReRunNo.TabStop = true;
            this.rbtnReRunNo.Text = "No";
            this.rbtnReRunNo.UseVisualStyleBackColor = true;
            // 
            // rbtnReRunYes
            // 
            this.rbtnReRunYes.AutoSize = true;
            this.rbtnReRunYes.Location = new System.Drawing.Point(69, 96);
            this.rbtnReRunYes.Name = "rbtnReRunYes";
            this.rbtnReRunYes.Size = new System.Drawing.Size(43, 17);
            this.rbtnReRunYes.TabIndex = 31;
            this.rbtnReRunYes.Text = "Yes";
            this.rbtnReRunYes.UseVisualStyleBackColor = true;
            // 
            // Values
            // 
            this.Values.AutoSize = true;
            this.Values.Location = new System.Drawing.Point(0, 34);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(39, 13);
            this.Values.TabIndex = 30;
            this.Values.Text = "Values";
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Location = new System.Drawing.Point(0, 16);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(54, 13);
            this.labelIncrement.TabIndex = 29;
            this.labelIncrement.Text = "Increment";
            // 
            // groupBoxSimulationValues
            // 
            this.groupBoxSimulationValues.Controls.Add(this.numericUpDownGridHeight);
            this.groupBoxSimulationValues.Controls.Add(this.numericUpDownCycles);
            this.groupBoxSimulationValues.Controls.Add(this.numericUpDownKillRate);
            this.groupBoxSimulationValues.Controls.Add(this.numericUpDownFeedRate);
            this.groupBoxSimulationValues.Controls.Add(this.labelGridHeight);
            this.groupBoxSimulationValues.Controls.Add(this.labelCycles);
            this.groupBoxSimulationValues.Controls.Add(this.labelKillRate);
            this.groupBoxSimulationValues.Controls.Add(this.labelFeedRate);
            this.groupBoxSimulationValues.Location = new System.Drawing.Point(12, 228);
            this.groupBoxSimulationValues.Name = "groupBoxSimulationValues";
            this.groupBoxSimulationValues.Size = new System.Drawing.Size(156, 130);
            this.groupBoxSimulationValues.TabIndex = 0;
            this.groupBoxSimulationValues.TabStop = false;
            this.groupBoxSimulationValues.Text = "Simulation Values";
            // 
            // numericUpDownGridHeight
            // 
            this.numericUpDownGridHeight.Location = new System.Drawing.Point(69, 102);
            this.numericUpDownGridHeight.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDownGridHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownGridHeight.Name = "numericUpDownGridHeight";
            this.numericUpDownGridHeight.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownGridHeight.TabIndex = 33;
            this.numericUpDownGridHeight.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // numericUpDownCycles
            // 
            this.numericUpDownCycles.Location = new System.Drawing.Point(69, 76);
            this.numericUpDownCycles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCycles.Name = "numericUpDownCycles";
            this.numericUpDownCycles.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownCycles.TabIndex = 32;
            this.numericUpDownCycles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKillRate
            // 
            this.numericUpDownKillRate.DecimalPlaces = 6;
            this.numericUpDownKillRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKillRate.Location = new System.Drawing.Point(69, 50);
            this.numericUpDownKillRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKillRate.Name = "numericUpDownKillRate";
            this.numericUpDownKillRate.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownKillRate.TabIndex = 31;
            this.numericUpDownKillRate.Value = new decimal(new int[] {
            56,
            0,
            0,
            196608});
            // 
            // numericUpDownFeedRate
            // 
            this.numericUpDownFeedRate.DecimalPlaces = 6;
            this.numericUpDownFeedRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownFeedRate.Location = new System.Drawing.Point(69, 22);
            this.numericUpDownFeedRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFeedRate.Name = "numericUpDownFeedRate";
            this.numericUpDownFeedRate.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownFeedRate.TabIndex = 30;
            this.numericUpDownFeedRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            // 
            // labelGridHeight
            // 
            this.labelGridHeight.AutoSize = true;
            this.labelGridHeight.Location = new System.Drawing.Point(-3, 104);
            this.labelGridHeight.Name = "labelGridHeight";
            this.labelGridHeight.Size = new System.Drawing.Size(49, 13);
            this.labelGridHeight.TabIndex = 29;
            this.labelGridHeight.Text = "Grid Size";
            // 
            // labelCycles
            // 
            this.labelCycles.AutoSize = true;
            this.labelCycles.Location = new System.Drawing.Point(-3, 78);
            this.labelCycles.Name = "labelCycles";
            this.labelCycles.Size = new System.Drawing.Size(38, 13);
            this.labelCycles.TabIndex = 28;
            this.labelCycles.Text = "Cycles";
            // 
            // labelKillRate
            // 
            this.labelKillRate.AutoSize = true;
            this.labelKillRate.Location = new System.Drawing.Point(-3, 52);
            this.labelKillRate.Name = "labelKillRate";
            this.labelKillRate.Size = new System.Drawing.Size(46, 13);
            this.labelKillRate.TabIndex = 27;
            this.labelKillRate.Text = "Kill Rate";
            // 
            // labelFeedRate
            // 
            this.labelFeedRate.AutoSize = true;
            this.labelFeedRate.Location = new System.Drawing.Point(-3, 24);
            this.labelFeedRate.Name = "labelFeedRate";
            this.labelFeedRate.Size = new System.Drawing.Size(57, 13);
            this.labelFeedRate.TabIndex = 9;
            this.labelFeedRate.Text = "Feed Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 858);
            this.Controls.Add(this.groupBoxSimulationValues);
            this.Controls.Add(this.groupBoxReRunSim);
            this.Controls.Add(this.groupBoxDisplayGrid);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxShadingAlgorithm);
            this.Controls.Add(this.groupBoxLaplacianFunctions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLaplacianFunctions.ResumeLayout(false);
            this.groupBoxLaplacianFunctions.PerformLayout();
            this.groupBoxShadingAlgorithm.ResumeLayout(false);
            this.groupBoxShadingAlgorithm.PerformLayout();
            this.groupBoxDisplayGrid.ResumeLayout(false);
            this.groupBoxDisplayGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementValues)).EndInit();
            this.groupBoxReRunSim.ResumeLayout(false);
            this.groupBoxReRunSim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).EndInit();
            this.groupBoxSimulationValues.ResumeLayout(false);
            this.groupBoxSimulationValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKillRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeedRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnConvolution;
        private System.Windows.Forms.RadioButton rbtnDelta_Means;
        private System.Windows.Forms.RadioButton rbtnPerpendicularNeighbours;
        private System.Windows.Forms.GroupBox groupBoxLaplacianFunctions;
        private System.Windows.Forms.GroupBox groupBoxShadingAlgorithm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbtnGrayScale;
        private System.Windows.Forms.RadioButton rbtnYellowToRed;
        private System.Windows.Forms.RadioButton rbtnLongRainbow;
        private System.Windows.Forms.RadioButton rbtnShortRainbow;
        private System.Windows.Forms.GroupBox groupBoxDisplayGrid;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrementValues;
        private System.Windows.Forms.GroupBox groupBoxReRunSim;
        private System.Windows.Forms.Label labelReRun;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.NumericUpDown numericUpDownTimes;
        private System.Windows.Forms.RadioButton rbtnReRunNo;
        private System.Windows.Forms.RadioButton rbtnReRunYes;
        private System.Windows.Forms.Label Values;
        private System.Windows.Forms.Label labelIncrement;
        private System.Windows.Forms.GroupBox groupBoxSimulationValues;
        private System.Windows.Forms.NumericUpDown numericUpDownGridHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownCycles;
        private System.Windows.Forms.NumericUpDown numericUpDownKillRate;
        private System.Windows.Forms.NumericUpDown numericUpDownFeedRate;
        private System.Windows.Forms.Label labelGridHeight;
        private System.Windows.Forms.Label labelCycles;
        private System.Windows.Forms.Label labelKillRate;
        private System.Windows.Forms.Label labelFeedRate;
    }
}

