namespace NumberApp
{
    partial class NumberUI
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(161, 35);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(97, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(92, 38);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(310, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(95, 83);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(290, 212);
            this.numberListBox.TabIndex = 3;
            this.numberListBox.Click += new System.EventHandler(this.numberListBox_Click);
            // 
            // NumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 420);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Name = "NumberUI";
            this.Text = "Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox numberListBox;
    }
}

