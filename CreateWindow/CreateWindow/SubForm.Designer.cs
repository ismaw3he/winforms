namespace CreateWindow
{
    partial class SubForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUD = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(15, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(309, 22);
            this.titleTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 147);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(12, 54);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(54, 17);
            this.vendorLabel.TabIndex = 4;
            this.vendorLabel.Text = "Vendor";
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.Location = new System.Drawing.Point(15, 74);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(309, 22);
            this.vendorTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // priceNumericUD
            // 
            this.priceNumericUD.Location = new System.Drawing.Point(15, 119);
            this.priceNumericUD.Name = "priceNumericUD";
            this.priceNumericUD.Size = new System.Drawing.Size(309, 22);
            this.priceNumericUD.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(199, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 183);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.priceNumericUD);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.vendorTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubForm";
            this.Text = "SubForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUD;
        private System.Windows.Forms.Button cancelButton;
    }
}