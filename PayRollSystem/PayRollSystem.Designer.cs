namespace PayRollSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DependentsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.NetPayTextLabel = new System.Windows.Forms.Label();
            this.TotalDeductionsTextLabel = new System.Windows.Forms.Label();
            this.MembershipTextLabel = new System.Windows.Forms.Label();
            this.UIFTextLabel = new System.Windows.Forms.Label();
            this.PAYETextLabel = new System.Windows.Forms.Label();
            this.GrossPayTextLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mzani Tech Contractors";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(65, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 32);
            this.panel1.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(171, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(123, 23);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contractor Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HoursTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(65, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 32);
            this.panel2.TabIndex = 3;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTextBox.Location = new System.Drawing.Point(171, 3);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(123, 23);
            this.HoursTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours Worked:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DependentsTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(65, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 32);
            this.panel3.TabIndex = 4;
            // 
            // DependentsTextBox
            // 
            this.DependentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DependentsTextBox.Location = new System.Drawing.Point(171, 3);
            this.DependentsTextBox.Name = "DependentsTextBox";
            this.DependentsTextBox.Size = new System.Drawing.Size(123, 23);
            this.DependentsTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Dependents:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(65, 246);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(140, 37);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate Net Pay";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(219, 246);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(73, 37);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(306, 246);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 37);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Results";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.NetPayTextLabel);
            this.ResultsPanel.Controls.Add(this.TotalDeductionsTextLabel);
            this.ResultsPanel.Controls.Add(this.MembershipTextLabel);
            this.ResultsPanel.Controls.Add(this.UIFTextLabel);
            this.ResultsPanel.Controls.Add(this.PAYETextLabel);
            this.ResultsPanel.Controls.Add(this.GrossPayTextLabel);
            this.ResultsPanel.Controls.Add(this.label5);
            this.ResultsPanel.Enabled = false;
            this.ResultsPanel.Location = new System.Drawing.Point(438, 28);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(346, 255);
            this.ResultsPanel.TabIndex = 3;
            // 
            // NetPayTextLabel
            // 
            this.NetPayTextLabel.AutoSize = true;
            this.NetPayTextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPayTextLabel.Location = new System.Drawing.Point(68, 227);
            this.NetPayTextLabel.Name = "NetPayTextLabel";
            this.NetPayTextLabel.Size = new System.Drawing.Size(72, 28);
            this.NetPayTextLabel.TabIndex = 14;
            this.NetPayTextLabel.Text = "Net Pay:";
            this.NetPayTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalDeductionsTextLabel
            // 
            this.TotalDeductionsTextLabel.AutoSize = true;
            this.TotalDeductionsTextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDeductionsTextLabel.Location = new System.Drawing.Point(68, 177);
            this.TotalDeductionsTextLabel.Name = "TotalDeductionsTextLabel";
            this.TotalDeductionsTextLabel.Size = new System.Drawing.Size(141, 28);
            this.TotalDeductionsTextLabel.TabIndex = 13;
            this.TotalDeductionsTextLabel.Text = "Total Deductions:";
            this.TotalDeductionsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MembershipTextLabel
            // 
            this.MembershipTextLabel.AutoSize = true;
            this.MembershipTextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipTextLabel.Location = new System.Drawing.Point(68, 149);
            this.MembershipTextLabel.Name = "MembershipTextLabel";
            this.MembershipTextLabel.Size = new System.Drawing.Size(140, 28);
            this.MembershipTextLabel.TabIndex = 12;
            this.MembershipTextLabel.Text = "Membership Fee:";
            this.MembershipTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UIFTextLabel
            // 
            this.UIFTextLabel.AutoSize = true;
            this.UIFTextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIFTextLabel.Location = new System.Drawing.Point(68, 121);
            this.UIFTextLabel.Name = "UIFTextLabel";
            this.UIFTextLabel.Size = new System.Drawing.Size(118, 28);
            this.UIFTextLabel.TabIndex = 11;
            this.UIFTextLabel.Text = "UIF Deduction:";
            this.UIFTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UIFTextLabel.Click += new System.EventHandler(this.UIFTextLabel_Click);
            // 
            // PAYETextLabel
            // 
            this.PAYETextLabel.AutoSize = true;
            this.PAYETextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAYETextLabel.Location = new System.Drawing.Point(68, 93);
            this.PAYETextLabel.Name = "PAYETextLabel";
            this.PAYETextLabel.Size = new System.Drawing.Size(132, 28);
            this.PAYETextLabel.TabIndex = 10;
            this.PAYETextLabel.Text = "PAYE Deduction:";
            this.PAYETextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GrossPayTextLabel
            // 
            this.GrossPayTextLabel.AutoSize = true;
            this.GrossPayTextLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossPayTextLabel.Location = new System.Drawing.Point(68, 65);
            this.GrossPayTextLabel.Name = "GrossPayTextLabel";
            this.GrossPayTextLabel.Size = new System.Drawing.Size(150, 28);
            this.GrossPayTextLabel.TabIndex = 9;
            this.GrossPayTextLabel.Text = "Gross Pay: R10000";
            this.GrossPayTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GrossPayTextLabel.Click += new System.EventHandler(this.GrossPayTextLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 363);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DependentsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GrossPayTextLabel;
        private System.Windows.Forms.Label MembershipTextLabel;
        private System.Windows.Forms.Label UIFTextLabel;
        private System.Windows.Forms.Label PAYETextLabel;
        private System.Windows.Forms.Label NetPayTextLabel;
        private System.Windows.Forms.Label TotalDeductionsTextLabel;
        private System.Windows.Forms.Panel ResultsPanel;
    }
}

