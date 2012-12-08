namespace Demo
{
    partial class ChildForm1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtTexteAFormater2 = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.stylesSheetManager = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(117, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.txtFirstName, "");
            this.txtFirstName.TabIndex = 20;
            this.txtFirstName.Text = "Sylvain";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFirstName.Location = new System.Drawing.Point(12, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 20);
            this.stylesSheetManager.SetStyle(this.lblFirstName, "");
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "FirstName :";
            // 
            // txtTexteAFormater2
            // 
            this.txtTexteAFormater2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtTexteAFormater2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTexteAFormater2.Location = new System.Drawing.Point(117, 9);
            this.txtTexteAFormater2.Name = "txtTexteAFormater2";
            this.txtTexteAFormater2.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.txtTexteAFormater2, "");
            this.txtTexteAFormater2.TabIndex = 18;
            this.txtTexteAFormater2.Text = "BLANCHARD";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLastName.Location = new System.Drawing.Point(12, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.stylesSheetManager.SetStyle(this.lblLastName, "");
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "LastName :";
            // 
            // ChildForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 73);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtTexteAFormater2);
            this.Controls.Add(this.lblLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.stylesSheetManager.SetStyle(this, "FormType1");
            this.Text = "ChildForm1";
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtTexteAFormater2;
        private System.Windows.Forms.Label lblLastName;
        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager;
    }
}