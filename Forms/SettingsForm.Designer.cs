namespace StocksEnjoyer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBox_filter = new System.Windows.Forms.CheckBox();
            this.panel_filter = new System.Windows.Forms.Panel();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.comboBox_csvList = new System.Windows.Forms.ComboBox();
            this.button_reload = new System.Windows.Forms.Button();
            this.toolTip_reload = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_filter
            // 
            this.checkBox_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_filter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.checkBox_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.checkBox_filter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_filter.Location = new System.Drawing.Point(37, 77);
            this.checkBox_filter.Name = "checkBox_filter";
            this.checkBox_filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_filter.Size = new System.Drawing.Size(186, 33);
            this.checkBox_filter.TabIndex = 6;
            this.checkBox_filter.Text = "Filter by frequency";
            this.checkBox_filter.UseVisualStyleBackColor = true;
            this.checkBox_filter.CheckedChanged += new System.EventHandler(this.checkBox_filter_CheckedChanged);
            // 
            // panel_filter
            // 
            this.panel_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_filter.AutoSize = true;
            this.panel_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_filter.Controls.Add(this.radioButton_daily);
            this.panel_filter.Controls.Add(this.radioButton_weekly);
            this.panel_filter.Controls.Add(this.radioButton_monthly);
            this.panel_filter.Enabled = false;
            this.panel_filter.Location = new System.Drawing.Point(229, 77);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.Size = new System.Drawing.Size(287, 33);
            this.panel_filter.TabIndex = 7;
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_daily.Location = new System.Drawing.Point(3, 3);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.Size = new System.Drawing.Size(76, 27);
            this.radioButton_daily.TabIndex = 3;
            this.radioButton_daily.TabStop = true;
            this.radioButton_daily.Text = "Daily";
            this.radioButton_daily.UseVisualStyleBackColor = true;
            this.radioButton_daily.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_weekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_weekly.Location = new System.Drawing.Point(85, 3);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(95, 27);
            this.radioButton_weekly.TabIndex = 4;
            this.radioButton_weekly.TabStop = true;
            this.radioButton_weekly.Text = "Weekly";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            this.radioButton_weekly.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_monthly.Location = new System.Drawing.Point(186, 3);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(98, 27);
            this.radioButton_monthly.TabIndex = 5;
            this.radioButton_monthly.TabStop = true;
            this.radioButton_monthly.Text = "Monthly";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            this.radioButton_monthly.CheckedChanged += new System.EventHandler(this.UpdateCsvListComboBox);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(33, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_load
            // 
            this.button_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_load.AutoSize = true;
            this.button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.button_load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_load.FlatAppearance.BorderSize = 0;
            this.button_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.button_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(194)))), ((int)(((byte)(226)))));
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.ForeColor = System.Drawing.Color.White;
            this.button_load.Image = ((System.Drawing.Image)(resources.GetObject("button_load.Image")));
            this.button_load.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_load.Location = new System.Drawing.Point(37, 198);
            this.button_load.Name = "button_load";
            this.button_load.Padding = new System.Windows.Forms.Padding(10);
            this.button_load.Size = new System.Drawing.Size(476, 51);
            this.button_load.TabIndex = 8;
            this.button_load.Text = "Show Chart";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // comboBox_csvList
            // 
            this.comboBox_csvList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_csvList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_csvList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_csvList.FormattingEnabled = true;
            this.comboBox_csvList.Location = new System.Drawing.Point(37, 162);
            this.comboBox_csvList.Name = "comboBox_csvList";
            this.comboBox_csvList.Size = new System.Drawing.Size(339, 30);
            this.comboBox_csvList.TabIndex = 0;
            this.comboBox_csvList.SelectedIndexChanged += new System.EventHandler(this.comboBox_csvList_Changed);
            // 
            // button_reload
            // 
            this.button_reload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_reload.AutoSize = true;
            this.button_reload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.button_reload.FlatAppearance.BorderSize = 0;
            this.button_reload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.button_reload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reload.ForeColor = System.Drawing.Color.White;
            this.button_reload.Image = ((System.Drawing.Image)(resources.GetObject("button_reload.Image")));
            this.button_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reload.Location = new System.Drawing.Point(382, 162);
            this.button_reload.Name = "button_reload";
            this.button_reload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_reload.Size = new System.Drawing.Size(131, 30);
            this.button_reload.TabIndex = 10;
            this.button_reload.Text = "Reload Folder";
            this.button_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip_reload.SetToolTip(this.button_reload, "Reload Stock Data");
            this.button_reload.UseVisualStyleBackColor = false;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Options";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.checkBox_filter);
            this.Controls.Add(this.panel_filter);
            this.Controls.Add(this.comboBox_csvList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "StocksEnjoyer 3.0 - Settings";
            this.panel_filter.ResumeLayout(false);
            this.panel_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_filter;
        private System.Windows.Forms.Panel panel_filter;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ComboBox comboBox_csvList;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.ToolTip toolTip_reload;
        private System.Windows.Forms.Label label2;
    }
}

