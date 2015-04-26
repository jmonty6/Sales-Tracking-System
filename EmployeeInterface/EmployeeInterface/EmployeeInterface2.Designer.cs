namespace EmployeeInterface
{
    partial class EmployeeInterface2
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.quoteSearchButton = new System.Windows.Forms.Button();
            this.quoteSearchBox = new System.Windows.Forms.TextBox();
            this.selectQuoteButton = new System.Windows.Forms.Button();
            this.quoteSearchLabel = new System.Windows.Forms.Label();
            this.customerSearchLabel = new System.Windows.Forms.Label();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.selectQuoteBox = new System.Windows.Forms.ListBox();
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.orLabel);
            this.searchGroupBox.Controls.Add(this.quoteSearchButton);
            this.searchGroupBox.Controls.Add(this.quoteSearchBox);
            this.searchGroupBox.Controls.Add(this.selectQuoteButton);
            this.searchGroupBox.Controls.Add(this.quoteSearchLabel);
            this.searchGroupBox.Controls.Add(this.customerSearchLabel);
            this.searchGroupBox.Controls.Add(this.customerSearchButton);
            this.searchGroupBox.Controls.Add(this.selectQuoteBox);
            this.searchGroupBox.Controls.Add(this.customerSearchBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(379, 373);
            this.searchGroupBox.TabIndex = 14;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search for a sanctioned Quote";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(172, 72);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(35, 13);
            this.orLabel.TabIndex = 10;
            this.orLabel.Text = "- OR -";
            // 
            // quoteSearchButton
            // 
            this.quoteSearchButton.Location = new System.Drawing.Point(285, 100);
            this.quoteSearchButton.Name = "quoteSearchButton";
            this.quoteSearchButton.Size = new System.Drawing.Size(75, 23);
            this.quoteSearchButton.TabIndex = 9;
            this.quoteSearchButton.Text = "Search";
            this.quoteSearchButton.UseVisualStyleBackColor = true;
            // 
            // quoteSearchBox
            // 
            this.quoteSearchBox.Location = new System.Drawing.Point(19, 100);
            this.quoteSearchBox.Name = "quoteSearchBox";
            this.quoteSearchBox.Size = new System.Drawing.Size(260, 20);
            this.quoteSearchBox.TabIndex = 8;
            // 
            // selectQuoteButton
            // 
            this.selectQuoteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectQuoteButton.Location = new System.Drawing.Point(285, 334);
            this.selectQuoteButton.Name = "selectQuoteButton";
            this.selectQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.selectQuoteButton.TabIndex = 5;
            this.selectQuoteButton.Text = "Select";
            this.selectQuoteButton.UseVisualStyleBackColor = true;
            // 
            // quoteSearchLabel
            // 
            this.quoteSearchLabel.AutoSize = true;
            this.quoteSearchLabel.Location = new System.Drawing.Point(16, 84);
            this.quoteSearchLabel.Name = "quoteSearchLabel";
            this.quoteSearchLabel.Size = new System.Drawing.Size(67, 13);
            this.quoteSearchLabel.TabIndex = 7;
            this.quoteSearchLabel.Text = "Quote Name";
            // 
            // customerSearchLabel
            // 
            this.customerSearchLabel.AutoSize = true;
            this.customerSearchLabel.Location = new System.Drawing.Point(16, 24);
            this.customerSearchLabel.Name = "customerSearchLabel";
            this.customerSearchLabel.Size = new System.Drawing.Size(82, 13);
            this.customerSearchLabel.TabIndex = 6;
            this.customerSearchLabel.Text = "Customer Name";
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchButton.Location = new System.Drawing.Point(285, 38);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 22);
            this.customerSearchButton.TabIndex = 0;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            // 
            // selectQuoteBox
            // 
            this.selectQuoteBox.BackColor = System.Drawing.SystemColors.Window;
            this.selectQuoteBox.FormattingEnabled = true;
            this.selectQuoteBox.Location = new System.Drawing.Point(19, 155);
            this.selectQuoteBox.Name = "selectQuoteBox";
            this.selectQuoteBox.Size = new System.Drawing.Size(341, 173);
            this.selectQuoteBox.TabIndex = 3;
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBox.Location = new System.Drawing.Point(19, 40);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.Size = new System.Drawing.Size(260, 20);
            this.customerSearchBox.TabIndex = 2;
            // 
            // EmployeeInterface2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 402);
            this.Controls.Add(this.searchGroupBox);
            this.Name = "EmployeeInterface2";
            this.Text = "EmployeeInterface2";
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button quoteSearchButton;
        private System.Windows.Forms.TextBox quoteSearchBox;
        private System.Windows.Forms.Button selectQuoteButton;
        private System.Windows.Forms.Label quoteSearchLabel;
        private System.Windows.Forms.Label customerSearchLabel;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.ListBox selectQuoteBox;
        private System.Windows.Forms.TextBox customerSearchBox;
    }
}