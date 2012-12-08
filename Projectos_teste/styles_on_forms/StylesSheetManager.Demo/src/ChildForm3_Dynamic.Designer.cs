namespace Demo
{
    partial class ChildForm3_Dynamic
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
            this.controlsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateLabels = new System.Windows.Forms.Button();
            this.btnCreateTextBoxes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.ColumnCount = 1;
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.controlsPanel.Location = new System.Drawing.Point(12, 79);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.RowCount = 5;
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.Size = new System.Drawing.Size(331, 103);
            this.controlsPanel.TabIndex = 0;
            // 
            // btnCreateLabels
            // 
            this.btnCreateLabels.Location = new System.Drawing.Point(12, 12);
            this.btnCreateLabels.Name = "btnCreateLabels";
            this.btnCreateLabels.Size = new System.Drawing.Size(182, 23);
            this.btnCreateLabels.TabIndex = 1;
            this.btnCreateLabels.Text = "Create dynamic Label controls";
            this.btnCreateLabels.UseVisualStyleBackColor = true;
            this.btnCreateLabels.Click += new System.EventHandler(this.btnCreateLabels_Click);
            // 
            // btnCreateTextBoxes
            // 
            this.btnCreateTextBoxes.Location = new System.Drawing.Point(12, 41);
            this.btnCreateTextBoxes.Name = "btnCreateTextBoxes";
            this.btnCreateTextBoxes.Size = new System.Drawing.Size(182, 23);
            this.btnCreateTextBoxes.TabIndex = 2;
            this.btnCreateTextBoxes.Text = "Create dynamic TextBox controls";
            this.btnCreateTextBoxes.UseVisualStyleBackColor = true;
            this.btnCreateTextBoxes.Click += new System.EventHandler(this.btnCreateTextBoxes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChildForm3_Dynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 228);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateTextBoxes);
            this.Controls.Add(this.btnCreateLabels);
            this.Controls.Add(this.controlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildForm3_Dynamic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChildlForm3_Dynamic";
            this.Load += new System.EventHandler(this.ChildForm3_Dynamic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlsPanel;
        private System.Windows.Forms.Button btnCreateLabels;
        private System.Windows.Forms.Button btnCreateTextBoxes;
        private System.Windows.Forms.Button btnClose;
    }
}