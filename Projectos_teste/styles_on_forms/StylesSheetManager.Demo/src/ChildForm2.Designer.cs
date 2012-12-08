namespace Demo
{
    partial class ChildForm2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.tabPageCommunications = new System.Windows.Forms.TabPage();
            this.lblWebSite = new System.Windows.Forms.Label();
            this.lnkWebSite = new System.Windows.Forms.LinkLabel();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lnkMail = new System.Windows.Forms.LinkLabel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dgType1 = new System.Windows.Forms.DataGridView();
            this.dgColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylesSheetManager = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tabPageCommunications.SuspendLayout();
            this.tabPageOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddress);
            this.tabControl1.Controls.Add(this.tabPageCommunications);
            this.tabControl1.Controls.Add(this.tabPageOthers);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(52, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 178);
            this.stylesSheetManager.SetStyle(this.tabControl1, "TabControlType1");
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.BackColor = System.Drawing.Color.White;
            this.tabPageAddress.Controls.Add(this.textBox3);
            this.tabPageAddress.Controls.Add(this.textBox1);
            this.tabPageAddress.Controls.Add(this.textBox2);
            this.tabPageAddress.Controls.Add(this.txtStreet);
            this.tabPageAddress.Controls.Add(this.label6);
            this.tabPageAddress.Controls.Add(this.label5);
            this.tabPageAddress.Controls.Add(this.label4);
            this.tabPageAddress.Controls.Add(this.label3);
            this.tabPageAddress.Controls.Add(this.label1);
            this.tabPageAddress.Controls.Add(this.txtNo);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Size = new System.Drawing.Size(408, 152);
            this.stylesSheetManager.SetStyle(this.tabPageAddress, "");
            this.tabPageAddress.TabIndex = 0;
            this.tabPageAddress.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox3.Location = new System.Drawing.Point(98, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.textBox3, "");
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "England";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox1.Location = new System.Drawing.Point(98, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.textBox1, "");
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "London";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox2.Location = new System.Drawing.Point(98, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.textBox2, "");
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "21845";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtStreet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtStreet.Location = new System.Drawing.Point(98, 41);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.txtStreet, "");
            this.txtStreet.TabIndex = 21;
            this.txtStreet.Text = "Baker Street";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.stylesSheetManager.SetStyle(this.label6, "");
            this.label6.TabIndex = 20;
            this.label6.Text = "Country :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.stylesSheetManager.SetStyle(this.label5, "");
            this.label5.TabIndex = 19;
            this.label5.Text = "Town :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.stylesSheetManager.SetStyle(this.label4, "");
            this.label4.TabIndex = 18;
            this.label4.Text = "Postal code :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.stylesSheetManager.SetStyle(this.label3, "");
            this.label3.TabIndex = 17;
            this.label3.Text = "Street :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.stylesSheetManager.SetStyle(this.label1, "");
            this.label1.TabIndex = 11;
            this.label1.Text = "No :";
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtNo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNo.Location = new System.Drawing.Point(98, 16);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.txtNo, "");
            this.txtNo.TabIndex = 12;
            this.txtNo.Text = "10";
            // 
            // tabPageCommunications
            // 
            this.tabPageCommunications.BackColor = System.Drawing.Color.White;
            this.tabPageCommunications.Controls.Add(this.lblWebSite);
            this.tabPageCommunications.Controls.Add(this.lnkWebSite);
            this.tabPageCommunications.Controls.Add(this.txtFax);
            this.tabPageCommunications.Controls.Add(this.lblFax);
            this.tabPageCommunications.Controls.Add(this.txtPhone);
            this.tabPageCommunications.Controls.Add(this.lblMail);
            this.tabPageCommunications.Controls.Add(this.lnkMail);
            this.tabPageCommunications.Controls.Add(this.lblPhone);
            this.tabPageCommunications.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommunications.Name = "tabPageCommunications";
            this.tabPageCommunications.Size = new System.Drawing.Size(408, 152);
            this.stylesSheetManager.SetStyle(this.tabPageCommunications, "");
            this.tabPageCommunications.TabIndex = 1;
            this.tabPageCommunications.Text = "Communications";
            this.tabPageCommunications.Visible = false;
            // 
            // lblWebSite
            // 
            this.lblWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWebSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.lblWebSite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWebSite.Location = new System.Drawing.Point(19, 88);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(73, 20);
            this.stylesSheetManager.SetStyle(this.lblWebSite, "");
            this.lblWebSite.TabIndex = 24;
            this.lblWebSite.Text = "Web site :";
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lnkWebSite.ForeColor = System.Drawing.Color.Blue;
            this.lnkWebSite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkWebSite.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.lnkWebSite.Location = new System.Drawing.Point(98, 88);
            this.lnkWebSite.Name = "lnkWebSite";
            this.lnkWebSite.Size = new System.Drawing.Size(200, 30);
            this.stylesSheetManager.SetStyle(this.lnkWebSite, "");
            this.lnkWebSite.TabIndex = 23;
            this.lnkWebSite.TabStop = true;
            this.lnkWebSite.Text = "sbcomponents.free.fr";
            this.lnkWebSite.UseCompatibleTextRendering = true;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtFax.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFax.Location = new System.Drawing.Point(98, 41);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(200, 24);
            this.stylesSheetManager.SetStyle(this.txtFax, "");
            this.txtFax.TabIndex = 22;
            this.txtFax.Text = "02 88 77 44 54";
            // 
            // lblFax
            // 
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.lblFax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFax.Location = new System.Drawing.Point(19, 42);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(73, 20);
            this.stylesSheetManager.SetStyle(this.lblFax, "");
            this.lblFax.TabIndex = 21;
            this.lblFax.Text = "Fax :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 16);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(90, 20);
            this.stylesSheetManager.SetStyle(this.txtPhone, "");
            this.txtPhone.TabIndex = 20;
            this.txtPhone.Text = "02 88 77 44 55";
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.lblMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMail.Location = new System.Drawing.Point(19, 65);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(73, 20);
            this.stylesSheetManager.SetStyle(this.lblMail, "");
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "Mail :";
            // 
            // lnkMail
            // 
            this.lnkMail.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lnkMail.ForeColor = System.Drawing.Color.Blue;
            this.lnkMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkMail.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.lnkMail.Location = new System.Drawing.Point(98, 65);
            this.lnkMail.Name = "lnkMail";
            this.lnkMail.Size = new System.Drawing.Size(200, 30);
            this.stylesSheetManager.SetStyle(this.lnkMail, "");
            this.lnkMail.TabIndex = 15;
            this.lnkMail.TabStop = true;
            this.lnkMail.Text = "sbcomponents@free.fr";
            this.lnkMail.UseCompatibleTextRendering = true;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.lblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone.Location = new System.Drawing.Point(16, 16);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 20);
            this.stylesSheetManager.SetStyle(this.lblPhone, "");
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone :";
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.BackColor = System.Drawing.Color.White;
            this.tabPageOthers.Controls.Add(this.label7);
            this.tabPageOthers.Controls.Add(this.dgType1);
            this.tabPageOthers.Location = new System.Drawing.Point(4, 22);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Size = new System.Drawing.Size(408, 152);
            this.stylesSheetManager.SetStyle(this.tabPageOthers, "");
            this.tabPageOthers.TabIndex = 2;
            this.tabPageOthers.Text = "Others";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(158)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.stylesSheetManager.SetStyle(this.label7, "LabelType1");
            this.label7.TabIndex = 21;
            this.label7.Text = "Preferred colors :";
            // 
            // dgType1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.dgType1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgType1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgType1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgType1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgColor,
            this.dgRate});
            this.dgType1.Location = new System.Drawing.Point(17, 39);
            this.dgType1.Name = "dgType1";
            this.dgType1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgType1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgType1.Size = new System.Drawing.Size(378, 99);
            this.stylesSheetManager.SetStyle(this.dgType1, "DataGridType1");
            this.dgType1.TabIndex = 2;
            // 
            // dgColor
            // 
            this.dgColor.DataPropertyName = "ColorName";
            this.dgColor.HeaderText = "Color name";
            this.dgColor.Name = "dgColor";
            // 
            // dgRate
            // 
            this.dgRate.DataPropertyName = "Rate";
            this.dgRate.HeaderText = "My rate";
            this.dgRate.Name = "dgRate";
            // 
            // ChildForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 199);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChildForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.stylesSheetManager.SetStyle(this, "FormType1");
            this.Text = "ChildForm2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.tabPageCommunications.ResumeLayout(false);
            this.tabPageCommunications.PerformLayout();
            this.tabPageOthers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TabPage tabPageCommunications;
        private System.Windows.Forms.Label lblWebSite;
        private System.Windows.Forms.LinkLabel lnkWebSite;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.LinkLabel lnkMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRate;
        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager;
    }
}