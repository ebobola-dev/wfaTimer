namespace wfaTimer
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.reverseTimerLabel = new System.Windows.Forms.Label();
            this.reverseProgressBar = new System.Windows.Forms.ProgressBar();
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.selectHoursLabel = new System.Windows.Forms.Label();
            this.selectMinLabel = new System.Windows.Forms.Label();
            this.selectSecLabel = new System.Windows.Forms.Label();
            this.comboMinutes = new System.Windows.Forms.ComboBox();
            this.comboSeconds = new System.Windows.Forms.ComboBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startButton.Location = new System.Drawing.Point(463, 40);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(218, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(145, 158);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 32);
            this.progressBar.TabIndex = 3;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(9, 158);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(133, 32);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00:00.00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(463, 93);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(218, 35);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // reverseTimerLabel
            // 
            this.reverseTimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reverseTimerLabel.AutoSize = true;
            this.reverseTimerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reverseTimerLabel.Location = new System.Drawing.Point(9, 202);
            this.reverseTimerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.reverseTimerLabel.Name = "reverseTimerLabel";
            this.reverseTimerLabel.Size = new System.Drawing.Size(133, 32);
            this.reverseTimerLabel.TabIndex = 4;
            this.reverseTimerLabel.Text = "00:00:00.00";
            this.reverseTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reverseProgressBar
            // 
            this.reverseProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reverseProgressBar.Location = new System.Drawing.Point(145, 202);
            this.reverseProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reverseProgressBar.Name = "reverseProgressBar";
            this.reverseProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reverseProgressBar.RightToLeftLayout = true;
            this.reverseProgressBar.Size = new System.Drawing.Size(543, 32);
            this.reverseProgressBar.TabIndex = 3;
            // 
            // comboHours
            // 
            this.comboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHours.FormattingEnabled = true;
            this.comboHours.Location = new System.Drawing.Point(52, 52);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(75, 23);
            this.comboHours.TabIndex = 8;
            this.comboHours.SelectedIndexChanged += new System.EventHandler(this.comboHours_SelectedIndexChanged);
            // 
            // selectHoursLabel
            // 
            this.selectHoursLabel.AutoSize = true;
            this.selectHoursLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectHoursLabel.Location = new System.Drawing.Point(67, 28);
            this.selectHoursLabel.Name = "selectHoursLabel";
            this.selectHoursLabel.Size = new System.Drawing.Size(47, 21);
            this.selectHoursLabel.TabIndex = 11;
            this.selectHoursLabel.Text = "Часы";
            // 
            // selectMinLabel
            // 
            this.selectMinLabel.AutoSize = true;
            this.selectMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectMinLabel.Location = new System.Drawing.Point(166, 28);
            this.selectMinLabel.Name = "selectMinLabel";
            this.selectMinLabel.Size = new System.Drawing.Size(68, 21);
            this.selectMinLabel.TabIndex = 12;
            this.selectMinLabel.Text = "Минуты";
            // 
            // selectSecLabel
            // 
            this.selectSecLabel.AutoSize = true;
            this.selectSecLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectSecLabel.Location = new System.Drawing.Point(272, 28);
            this.selectSecLabel.Name = "selectSecLabel";
            this.selectSecLabel.Size = new System.Drawing.Size(73, 21);
            this.selectSecLabel.TabIndex = 13;
            this.selectSecLabel.Text = "Секунды";
            // 
            // comboMinutes
            // 
            this.comboMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinutes.FormattingEnabled = true;
            this.comboMinutes.Location = new System.Drawing.Point(159, 52);
            this.comboMinutes.Name = "comboMinutes";
            this.comboMinutes.Size = new System.Drawing.Size(75, 23);
            this.comboMinutes.TabIndex = 14;
            this.comboMinutes.SelectedIndexChanged += new System.EventHandler(this.comboMinutes_SelectedIndexChanged);
            // 
            // comboSeconds
            // 
            this.comboSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeconds.FormattingEnabled = true;
            this.comboSeconds.Location = new System.Drawing.Point(270, 52);
            this.comboSeconds.Name = "comboSeconds";
            this.comboSeconds.Size = new System.Drawing.Size(75, 23);
            this.comboSeconds.TabIndex = 15;
            this.comboSeconds.SelectedIndexChanged += new System.EventHandler(this.comboSeconds_SelectedIndexChanged);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentLabel.Location = new System.Drawing.Point(9, 113);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(47, 32);
            this.percentLabel.TabIndex = 16;
            this.percentLabel.Text = "0%";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 247);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.comboSeconds);
            this.Controls.Add(this.comboMinutes);
            this.Controls.Add(this.selectSecLabel);
            this.Controls.Add(this.selectMinLabel);
            this.Controls.Add(this.selectHoursLabel);
            this.Controls.Add(this.comboHours);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reverseProgressBar);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.reverseTimerLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar progressBar;
        private Label timerLabel;
        private Label label1;
        private Button resetButton;
        private Button startButton;
        private Label reverseTimerLabel;
        private ProgressBar reverseProgressBar;
        private ComboBox comboHours;
        private Label selectHoursLabel;
        private Label selectMinLabel;
        private Label selectSecLabel;
        private ComboBox comboMinutes;
        private ComboBox comboSeconds;
        private Label percentLabel;
    }
}