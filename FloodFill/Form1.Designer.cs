namespace FloodFill
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPoints = new System.Windows.Forms.Button();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.cbPointsHeader = new System.Windows.Forms.ComboBox();
            this.btnRaster = new System.Windows.Forms.Button();
            this.tbRaster = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.cbUL = new System.Windows.Forms.CheckBox();
            this.DirectionsBox = new System.Windows.Forms.GroupBox();
            this.cbDR = new System.Windows.Forms.CheckBox();
            this.cbDM = new System.Windows.Forms.CheckBox();
            this.cbDL = new System.Windows.Forms.CheckBox();
            this.cbMR = new System.Windows.Forms.CheckBox();
            this.cbML = new System.Windows.Forms.CheckBox();
            this.cbUR = new System.Windows.Forms.CheckBox();
            this.cbUM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lMaxDistance = new System.Windows.Forms.Label();
            this.numericUpDownMaxDistance = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DirectionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(5, 6);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(137, 23);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Select Points";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.Click_btnPoints);
            // 
            // tbPoints
            // 
            this.tbPoints.Location = new System.Drawing.Point(147, 9);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.ReadOnly = true;
            this.tbPoints.Size = new System.Drawing.Size(543, 20);
            this.tbPoints.TabIndex = 1;
            // 
            // cbPointsHeader
            // 
            this.cbPointsHeader.FormattingEnabled = true;
            this.cbPointsHeader.Location = new System.Drawing.Point(694, 9);
            this.cbPointsHeader.Name = "cbPointsHeader";
            this.cbPointsHeader.Size = new System.Drawing.Size(121, 21);
            this.cbPointsHeader.TabIndex = 2;
            // 
            // btnRaster
            // 
            this.btnRaster.Location = new System.Drawing.Point(5, 38);
            this.btnRaster.Name = "btnRaster";
            this.btnRaster.Size = new System.Drawing.Size(137, 23);
            this.btnRaster.TabIndex = 3;
            this.btnRaster.Text = "Select Raster";
            this.btnRaster.UseVisualStyleBackColor = true;
            this.btnRaster.Click += new System.EventHandler(this.Click_btnRaster);
            // 
            // tbRaster
            // 
            this.tbRaster.Location = new System.Drawing.Point(147, 41);
            this.tbRaster.Name = "tbRaster";
            this.tbRaster.ReadOnly = true;
            this.tbRaster.Size = new System.Drawing.Size(543, 20);
            this.tbRaster.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.AutoSize = true;
            this.btnRun.Location = new System.Drawing.Point(9, 250);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(112, 23);
            this.btnRun.TabIndex = 16;
            this.btnRun.Text = "Calculate";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.Click_btnRun);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(5, 70);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(137, 23);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Select Output folder";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.Click_btnOutput);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(147, 75);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(543, 20);
            this.tbOutput.TabIndex = 7;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb.Location = new System.Drawing.Point(9, 283);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(783, 23);
            this.pb.TabIndex = 8;
            // 
            // cbUL
            // 
            this.cbUL.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUL.Location = new System.Drawing.Point(4, 16);
            this.cbUL.Margin = new System.Windows.Forms.Padding(2);
            this.cbUL.Name = "cbUL";
            this.cbUL.Size = new System.Drawing.Size(33, 32);
            this.cbUL.TabIndex = 8;
            this.cbUL.Text = "↖";
            this.cbUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUL.UseVisualStyleBackColor = true;
            // 
            // DirectionsBox
            // 
            this.DirectionsBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DirectionsBox.Controls.Add(this.cbDR);
            this.DirectionsBox.Controls.Add(this.cbDM);
            this.DirectionsBox.Controls.Add(this.cbDL);
            this.DirectionsBox.Controls.Add(this.cbMR);
            this.DirectionsBox.Controls.Add(this.cbML);
            this.DirectionsBox.Controls.Add(this.cbUR);
            this.DirectionsBox.Controls.Add(this.cbUM);
            this.DirectionsBox.Controls.Add(this.cbUL);
            this.DirectionsBox.Location = new System.Drawing.Point(5, 106);
            this.DirectionsBox.Margin = new System.Windows.Forms.Padding(2);
            this.DirectionsBox.Name = "DirectionsBox";
            this.DirectionsBox.Padding = new System.Windows.Forms.Padding(2);
            this.DirectionsBox.Size = new System.Drawing.Size(118, 135);
            this.DirectionsBox.TabIndex = 10;
            this.DirectionsBox.TabStop = false;
            this.DirectionsBox.Text = "Directions";
            // 
            // cbDR
            // 
            this.cbDR.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDR.Location = new System.Drawing.Point(79, 89);
            this.cbDR.Margin = new System.Windows.Forms.Padding(2);
            this.cbDR.Name = "cbDR";
            this.cbDR.Size = new System.Drawing.Size(33, 32);
            this.cbDR.TabIndex = 15;
            this.cbDR.Text = "↘";
            this.cbDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDR.UseVisualStyleBackColor = true;
            // 
            // cbDM
            // 
            this.cbDM.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDM.Checked = true;
            this.cbDM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDM.Location = new System.Drawing.Point(41, 89);
            this.cbDM.Margin = new System.Windows.Forms.Padding(2);
            this.cbDM.Name = "cbDM";
            this.cbDM.Size = new System.Drawing.Size(33, 32);
            this.cbDM.TabIndex = 14;
            this.cbDM.Text = "↓";
            this.cbDM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDM.UseVisualStyleBackColor = true;
            // 
            // cbDL
            // 
            this.cbDL.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDL.Location = new System.Drawing.Point(4, 89);
            this.cbDL.Margin = new System.Windows.Forms.Padding(2);
            this.cbDL.Name = "cbDL";
            this.cbDL.Size = new System.Drawing.Size(33, 32);
            this.cbDL.TabIndex = 13;
            this.cbDL.Text = "↙";
            this.cbDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDL.UseVisualStyleBackColor = true;
            // 
            // cbMR
            // 
            this.cbMR.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMR.Checked = true;
            this.cbMR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMR.Location = new System.Drawing.Point(79, 53);
            this.cbMR.Margin = new System.Windows.Forms.Padding(2);
            this.cbMR.Name = "cbMR";
            this.cbMR.Size = new System.Drawing.Size(33, 32);
            this.cbMR.TabIndex = 12;
            this.cbMR.Text = "→";
            this.cbMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMR.UseVisualStyleBackColor = true;
            // 
            // cbML
            // 
            this.cbML.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbML.Checked = true;
            this.cbML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbML.Location = new System.Drawing.Point(4, 53);
            this.cbML.Margin = new System.Windows.Forms.Padding(2);
            this.cbML.Name = "cbML";
            this.cbML.Size = new System.Drawing.Size(33, 32);
            this.cbML.TabIndex = 11;
            this.cbML.Text = "←";
            this.cbML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbML.UseVisualStyleBackColor = true;
            // 
            // cbUR
            // 
            this.cbUR.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUR.Location = new System.Drawing.Point(79, 16);
            this.cbUR.Margin = new System.Windows.Forms.Padding(2);
            this.cbUR.Name = "cbUR";
            this.cbUR.Size = new System.Drawing.Size(33, 32);
            this.cbUR.TabIndex = 10;
            this.cbUR.Text = "↗";
            this.cbUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUR.UseVisualStyleBackColor = true;
            // 
            // cbUM
            // 
            this.cbUM.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUM.Checked = true;
            this.cbUM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUM.Location = new System.Drawing.Point(41, 16);
            this.cbUM.Margin = new System.Windows.Forms.Padding(2);
            this.cbUM.Name = "cbUM";
            this.cbUM.Size = new System.Drawing.Size(33, 32);
            this.cbUM.TabIndex = 9;
            this.cbUM.Text = "↑";
            this.cbUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "FloodFill V1.0 - Julian Hoogvorst";
            // 
            // lMaxDistance
            // 
            this.lMaxDistance.AutoSize = true;
            this.lMaxDistance.Location = new System.Drawing.Point(145, 106);
            this.lMaxDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMaxDistance.Name = "lMaxDistance";
            this.lMaxDistance.Size = new System.Drawing.Size(135, 13);
            this.lMaxDistance.TabIndex = 19;
            this.lMaxDistance.Text = "MaxDistance (0 for disable)";
            // 
            // numericUpDownMaxDistance
            // 
            this.numericUpDownMaxDistance.Location = new System.Drawing.Point(147, 121);
            this.numericUpDownMaxDistance.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMaxDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMaxDistance.Name = "numericUpDownMaxDistance";
            this.numericUpDownMaxDistance.Size = new System.Drawing.Size(113, 20);
            this.numericUpDownMaxDistance.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 335);
            this.Controls.Add(this.numericUpDownMaxDistance);
            this.Controls.Add(this.lMaxDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectionsBox);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbRaster);
            this.Controls.Add(this.btnRaster);
            this.Controls.Add(this.cbPointsHeader);
            this.Controls.Add(this.tbPoints);
            this.Controls.Add(this.btnPoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(861, 374);
            this.MinimumSize = new System.Drawing.Size(861, 374);
            this.Name = "FormMain";
            this.Text = "RasterFlow";
            this.DirectionsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.ComboBox cbPointsHeader;
        private System.Windows.Forms.Button btnRaster;
        private System.Windows.Forms.TextBox tbRaster;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.CheckBox cbUL;
        private System.Windows.Forms.GroupBox DirectionsBox;
        private System.Windows.Forms.CheckBox cbUM;
        private System.Windows.Forms.CheckBox cbDR;
        private System.Windows.Forms.CheckBox cbDM;
        private System.Windows.Forms.CheckBox cbDL;
        private System.Windows.Forms.CheckBox cbMR;
        private System.Windows.Forms.CheckBox cbML;
        private System.Windows.Forms.CheckBox cbUR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMaxDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxDistance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

