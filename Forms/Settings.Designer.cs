namespace Stocks
{
    partial class Settings
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
            this.comboBox_csvList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.checkBox_filter = new System.Windows.Forms.CheckBox();
            this.panel_filter = new System.Windows.Forms.Panel();
            this.button_load = new System.Windows.Forms.Button();
            this.panel_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_csvList
            // 
            this.comboBox_csvList.FormattingEnabled = true;
            this.comboBox_csvList.Location = new System.Drawing.Point(142, 170);
            this.comboBox_csvList.Name = "comboBox_csvList";
            this.comboBox_csvList.Size = new System.Drawing.Size(121, 21);
            this.comboBox_csvList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV File";
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.Location = new System.Drawing.Point(3, 3);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.Size = new System.Drawing.Size(48, 17);
            this.radioButton_daily.TabIndex = 3;
            this.radioButton_daily.TabStop = true;
            this.radioButton_daily.Text = "Daily";
            this.radioButton_daily.UseVisualStyleBackColor = true;
            this.radioButton_daily.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.Location = new System.Drawing.Point(57, 3);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(61, 17);
            this.radioButton_weekly.TabIndex = 4;
            this.radioButton_weekly.TabStop = true;
            this.radioButton_weekly.Text = "Weekly";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            this.radioButton_weekly.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.Location = new System.Drawing.Point(124, 3);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(62, 17);
            this.radioButton_monthly.TabIndex = 5;
            this.radioButton_monthly.TabStop = true;
            this.radioButton_monthly.Text = "Monthly";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            this.radioButton_monthly.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // checkBox_filter
            // 
            this.checkBox_filter.AutoSize = true;
            this.checkBox_filter.Location = new System.Drawing.Point(142, 72);
            this.checkBox_filter.Name = "checkBox_filter";
            this.checkBox_filter.Size = new System.Drawing.Size(48, 17);
            this.checkBox_filter.TabIndex = 6;
            this.checkBox_filter.Text = "Filter";
            this.checkBox_filter.UseVisualStyleBackColor = true;
            this.checkBox_filter.CheckedChanged += new System.EventHandler(this.checkBox_filter_CheckedChanged);
            // 
            // panel_filter
            // 
            this.panel_filter.Controls.Add(this.radioButton_daily);
            this.panel_filter.Controls.Add(this.radioButton_weekly);
            this.panel_filter.Controls.Add(this.radioButton_monthly);
            this.panel_filter.Enabled = false;
            this.panel_filter.Location = new System.Drawing.Point(142, 95);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.Size = new System.Drawing.Size(190, 30);
            this.panel_filter.TabIndex = 7;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(142, 213);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 8;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.panel_filter);
            this.Controls.Add(this.checkBox_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_csvList);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel_filter.ResumeLayout(false);
            this.panel_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_csvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.CheckBox checkBox_filter;
        private System.Windows.Forms.Panel panel_filter;
        private System.Windows.Forms.Button button_load;
    }
}

