namespace TabControlColoredTextBox
{
    partial class NotepadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeTabButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.mainFastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.newTabButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFastColoredTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.Controls.Add(this.closeTabButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.newTabButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.compileButton, 2, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(582, 353);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // closeTabButton
            // 
            this.closeTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeTabButton.Location = new System.Drawing.Point(197, 315);
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(188, 35);
            this.closeTabButton.TabIndex = 3;
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.UseVisualStyleBackColor = true;
            this.closeTabButton.Click += new System.EventHandler(this.CloseTabButtonClick);
            // 
            // mainTabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.mainTabControl, 3);
            this.mainTabControl.Controls.Add(this.mainTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTableLayoutPanel.SetRowSpan(this.mainTabControl, 2);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(576, 306);
            this.mainTabControl.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.mainFastColoredTextBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 25);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(568, 277);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // mainFastColoredTextBox
            // 
            this.mainFastColoredTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.mainFastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.mainFastColoredTextBox.BackBrush = null;
            this.mainFastColoredTextBox.CharHeight = 18;
            this.mainFastColoredTextBox.CharWidth = 10;
            this.mainFastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainFastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainFastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFastColoredTextBox.IsReplaceMode = false;
            this.mainFastColoredTextBox.Location = new System.Drawing.Point(3, 3);
            this.mainFastColoredTextBox.Name = "mainFastColoredTextBox";
            this.mainFastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.mainFastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainFastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainFastColoredTextBox.ServiceColors")));
            this.mainFastColoredTextBox.Size = new System.Drawing.Size(562, 271);
            this.mainFastColoredTextBox.TabIndex = 0;
            this.mainFastColoredTextBox.Zoom = 100;
            // 
            // newTabButton
            // 
            this.newTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTabButton.Location = new System.Drawing.Point(3, 315);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(188, 35);
            this.newTabButton.TabIndex = 1;
            this.newTabButton.Text = "New Tab";
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.NewTabButtonClick);
            // 
            // compileButton
            // 
            this.compileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compileButton.Location = new System.Drawing.Point(391, 315);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(188, 35);
            this.compileButton.TabIndex = 2;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.CompileButtonClick);
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "NotepadForm";
            this.Text = "NotepadForm";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFastColoredTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private FastColoredTextBoxNS.FastColoredTextBox mainFastColoredTextBox;
        private System.Windows.Forms.Button newTabButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.Button closeTabButton;
    }
}