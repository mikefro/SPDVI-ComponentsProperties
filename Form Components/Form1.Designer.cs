namespace Form_Components
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
            this.targetButton = new System.Windows.Forms.Button();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.GoRightButton = new System.Windows.Forms.Button();
            this.GoLeftButton = new System.Windows.Forms.Button();
            this.GoDownButton = new System.Windows.Forms.Button();
            this.GoUpButton = new System.Windows.Forms.Button();
            this.CenterTargetButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.VisibleTargetButton = new System.Windows.Forms.Button();
            this.BorderStyleListBox = new System.Windows.Forms.ListBox();
            this.formBorderLabel = new System.Windows.Forms.Label();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.ControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.UseVisualStyleBackColor = true;
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsGroupBox.Controls.Add(this.GoRightButton);
            this.ControlsGroupBox.Controls.Add(this.GoLeftButton);
            this.ControlsGroupBox.Controls.Add(this.GoDownButton);
            this.ControlsGroupBox.Controls.Add(this.GoUpButton);
            this.ControlsGroupBox.Controls.Add(this.CenterTargetButton);
            this.ControlsGroupBox.Controls.Add(this.button2);
            this.ControlsGroupBox.Controls.Add(this.VisibleTargetButton);
            this.ControlsGroupBox.Controls.Add(this.BorderStyleListBox);
            this.ControlsGroupBox.Controls.Add(this.formBorderLabel);
            this.ControlsGroupBox.Location = new System.Drawing.Point(570, 15);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(200, 500);
            this.ControlsGroupBox.TabIndex = 1;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Controls";
            // 
            // GoRightButton
            // 
            this.GoRightButton.Location = new System.Drawing.Point(128, 322);
            this.GoRightButton.Name = "GoRightButton";
            this.GoRightButton.Size = new System.Drawing.Size(38, 38);
            this.GoRightButton.TabIndex = 8;
            this.GoRightButton.Text = ">";
            this.GoRightButton.UseVisualStyleBackColor = true;
            // 
            // GoLeftButton
            // 
            this.GoLeftButton.Location = new System.Drawing.Point(40, 322);
            this.GoLeftButton.Name = "GoLeftButton";
            this.GoLeftButton.Size = new System.Drawing.Size(38, 38);
            this.GoLeftButton.TabIndex = 7;
            this.GoLeftButton.Text = "<";
            this.GoLeftButton.UseVisualStyleBackColor = true;
            // 
            // GoDownButton
            // 
            this.GoDownButton.Location = new System.Drawing.Point(84, 339);
            this.GoDownButton.Name = "GoDownButton";
            this.GoDownButton.Size = new System.Drawing.Size(38, 38);
            this.GoDownButton.TabIndex = 6;
            this.GoDownButton.Text = "V";
            this.GoDownButton.UseVisualStyleBackColor = true;
            // 
            // GoUpButton
            // 
            this.GoUpButton.Location = new System.Drawing.Point(84, 296);
            this.GoUpButton.Name = "GoUpButton";
            this.GoUpButton.Size = new System.Drawing.Size(38, 38);
            this.GoUpButton.TabIndex = 5;
            this.GoUpButton.Text = "^";
            this.GoUpButton.UseVisualStyleBackColor = true;
            // 
            // CenterTargetButton
            // 
            this.CenterTargetButton.Location = new System.Drawing.Point(29, 214);
            this.CenterTargetButton.Name = "CenterTargetButton";
            this.CenterTargetButton.Size = new System.Drawing.Size(154, 45);
            this.CenterTargetButton.TabIndex = 4;
            this.CenterTargetButton.Text = "CenterTarget";
            this.CenterTargetButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enabled = True";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VisibleTargetButton
            // 
            this.VisibleTargetButton.Location = new System.Drawing.Point(29, 118);
            this.VisibleTargetButton.Name = "VisibleTargetButton";
            this.VisibleTargetButton.Size = new System.Drawing.Size(154, 38);
            this.VisibleTargetButton.TabIndex = 2;
            this.VisibleTargetButton.Text = "Visible = True";
            this.VisibleTargetButton.UseVisualStyleBackColor = true;
            this.VisibleTargetButton.Click += new System.EventHandler(this.VisibleTarget_Click);
            // 
            // BorderStyleListBox
            // 
            this.BorderStyleListBox.FormattingEnabled = true;
            this.BorderStyleListBox.Location = new System.Drawing.Point(26, 45);
            this.BorderStyleListBox.Name = "BorderStyleListBox";
            this.BorderStyleListBox.Size = new System.Drawing.Size(158, 17);
            this.BorderStyleListBox.TabIndex = 1;
            // 
            // formBorderLabel
            // 
            this.formBorderLabel.AutoSize = true;
            this.formBorderLabel.Location = new System.Drawing.Point(23, 29);
            this.formBorderLabel.Name = "formBorderLabel";
            this.formBorderLabel.Size = new System.Drawing.Size(87, 13);
            this.formBorderLabel.TabIndex = 0;
            this.formBorderLabel.Text = "FormBorder Style";
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(37, 15);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.targetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.Button GoRightButton;
        private System.Windows.Forms.Button GoLeftButton;
        private System.Windows.Forms.Button GoDownButton;
        private System.Windows.Forms.Button GoUpButton;
        private System.Windows.Forms.Button CenterTargetButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button VisibleTargetButton;
        private System.Windows.Forms.ListBox BorderStyleListBox;
        private System.Windows.Forms.Label formBorderLabel;
        private System.Windows.Forms.Label formSizeLabel;
    }
}

