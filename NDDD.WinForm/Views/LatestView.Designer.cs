﻿
namespace NDDD.WinForm.Views
{
    partial class LatestView
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
            this.label1 = new System.Windows.Forms.Label();
            this.AreaIDTextBox = new System.Windows.Forms.TextBox();
            this.MeasureDateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MeasureValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "エリアID";
            // 
            // AreaIDTextBox
            // 
            this.AreaIDTextBox.Location = new System.Drawing.Point(90, 21);
            this.AreaIDTextBox.Name = "AreaIDTextBox";
            this.AreaIDTextBox.ReadOnly = true;
            this.AreaIDTextBox.Size = new System.Drawing.Size(162, 19);
            this.AreaIDTextBox.TabIndex = 1;
            // 
            // MeasureDateTextBox
            // 
            this.MeasureDateTextBox.Location = new System.Drawing.Point(90, 49);
            this.MeasureDateTextBox.Name = "MeasureDateTextBox";
            this.MeasureDateTextBox.ReadOnly = true;
            this.MeasureDateTextBox.Size = new System.Drawing.Size(162, 19);
            this.MeasureDateTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "計測日時";
            // 
            // MeasureValueTextBox
            // 
            this.MeasureValueTextBox.Location = new System.Drawing.Point(90, 77);
            this.MeasureValueTextBox.Name = "MeasureValueTextBox";
            this.MeasureValueTextBox.ReadOnly = true;
            this.MeasureValueTextBox.Size = new System.Drawing.Size(162, 19);
            this.MeasureValueTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "計測値";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(26, 114);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(226, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 139);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "デバッグモード";
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MeasureValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeasureDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreaIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AreaIDTextBox;
        private System.Windows.Forms.TextBox MeasureDateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MeasureValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}