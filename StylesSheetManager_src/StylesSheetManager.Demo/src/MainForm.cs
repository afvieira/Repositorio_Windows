using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;


namespace Demo
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtTexteAFormater2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAddress;
		private System.Windows.Forms.ComboBox cboJob;
		private System.Windows.Forms.Button btnSelectStyle;
		private System.Windows.Forms.LinkLabel lnkMail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNo;
		private System.Windows.Forms.TabPage tabPageCommunications;
		private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblPhone;
        private Label label2;
        private TextBox txtStreet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label lblMail;
        private TextBox txtPhone;
        private Label lblWebSite;
        private LinkLabel lnkWebSite;
        private TextBox txtFax;
        private Label lblFax;
        private DataGridViewTextBoxColumn dgRate;
        private DataGridViewTextBoxColumn dgColor;
        private DataGridView dgType1;
        private TabPage tabPageOthers;
        private Label lblJob;
        private Label label7;
        private Button btnChildForm1;
        private Button btnChildForm2;
        private Button btnTabControlInformation;
        private Button btnChildForm3;
		private System.ComponentModel.IContainer components;

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}

			base.Dispose( disposing );
		}

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtTexteAFormater2 = new System.Windows.Forms.TextBox();
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
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.btnSelectStyle = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.btnChildForm1 = new System.Windows.Forms.Button();
            this.stylesSheetManager = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            this.btnChildForm2 = new System.Windows.Forms.Button();
            this.btnTabControlInformation = new System.Windows.Forms.Button();
            this.btnChildForm3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tabPageCommunications.SuspendLayout();
            this.tabPageOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AccessibleDescription = null;
            this.lblLastName.AccessibleName = null;
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLastName.Name = "lblLastName";
            this.stylesSheetManager.SetStyle(this.lblLastName, "LabelType1");
            // 
            // txtTexteAFormater2
            // 
            this.txtTexteAFormater2.AccessibleDescription = null;
            this.txtTexteAFormater2.AccessibleName = null;
            resources.ApplyResources(this.txtTexteAFormater2, "txtTexteAFormater2");
            this.txtTexteAFormater2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtTexteAFormater2.BackgroundImage = null;
            this.txtTexteAFormater2.Name = "txtTexteAFormater2";
            this.stylesSheetManager.SetStyle(this.txtTexteAFormater2, "TextBoxType1");
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = null;
            this.tabControl1.AccessibleName = null;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BackgroundImage = null;
            this.tabControl1.Controls.Add(this.tabPageAddress);
            this.tabControl1.Controls.Add(this.tabPageCommunications);
            this.tabControl1.Controls.Add(this.tabPageOthers);
            this.tabControl1.Font = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.stylesSheetManager.SetStyle(this.tabControl1, "TabControlType1");
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.AccessibleDescription = null;
            this.tabPageAddress.AccessibleName = null;
            resources.ApplyResources(this.tabPageAddress, "tabPageAddress");
            this.tabPageAddress.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPageAddress.BackgroundImage = null;
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
            this.tabPageAddress.Font = null;
            this.tabPageAddress.Name = "tabPageAddress";
            this.stylesSheetManager.SetStyle(this.tabPageAddress, "");
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = null;
            this.textBox3.AccessibleName = null;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox3.BackgroundImage = null;
            this.textBox3.Name = "textBox3";
            this.stylesSheetManager.SetStyle(this.textBox3, "TextBoxType1");
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = null;
            this.textBox1.AccessibleName = null;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox1.BackgroundImage = null;
            this.textBox1.Name = "textBox1";
            this.stylesSheetManager.SetStyle(this.textBox1, "TextBoxType1");
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = null;
            this.textBox2.AccessibleName = null;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.textBox2.BackgroundImage = null;
            this.textBox2.Name = "textBox2";
            this.stylesSheetManager.SetStyle(this.textBox2, "TextBoxType1");
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleDescription = null;
            this.txtStreet.AccessibleName = null;
            resources.ApplyResources(this.txtStreet, "txtStreet");
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtStreet.BackgroundImage = null;
            this.txtStreet.Name = "txtStreet";
            this.stylesSheetManager.SetStyle(this.txtStreet, "TextBoxType1");
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Name = "label6";
            this.stylesSheetManager.SetStyle(this.label6, "LabelType1");
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Name = "label5";
            this.stylesSheetManager.SetStyle(this.label5, "LabelType1");
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Name = "label4";
            this.stylesSheetManager.SetStyle(this.label4, "LabelType1");
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Name = "label3";
            this.stylesSheetManager.SetStyle(this.label3, "LabelType1");
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            this.stylesSheetManager.SetStyle(this.label1, "LabelType1");
            // 
            // txtNo
            // 
            this.txtNo.AccessibleDescription = null;
            this.txtNo.AccessibleName = null;
            resources.ApplyResources(this.txtNo, "txtNo");
            this.txtNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtNo.BackgroundImage = null;
            this.txtNo.Name = "txtNo";
            this.stylesSheetManager.SetStyle(this.txtNo, "TextBoxType1");
            // 
            // tabPageCommunications
            // 
            this.tabPageCommunications.AccessibleDescription = null;
            this.tabPageCommunications.AccessibleName = null;
            resources.ApplyResources(this.tabPageCommunications, "tabPageCommunications");
            this.tabPageCommunications.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPageCommunications.BackgroundImage = null;
            this.tabPageCommunications.Controls.Add(this.lblWebSite);
            this.tabPageCommunications.Controls.Add(this.lnkWebSite);
            this.tabPageCommunications.Controls.Add(this.txtFax);
            this.tabPageCommunications.Controls.Add(this.lblFax);
            this.tabPageCommunications.Controls.Add(this.txtPhone);
            this.tabPageCommunications.Controls.Add(this.lblMail);
            this.tabPageCommunications.Controls.Add(this.lnkMail);
            this.tabPageCommunications.Controls.Add(this.lblPhone);
            this.tabPageCommunications.Font = null;
            this.tabPageCommunications.Name = "tabPageCommunications";
            this.stylesSheetManager.SetStyle(this.tabPageCommunications, "");
            // 
            // lblWebSite
            // 
            this.lblWebSite.AccessibleDescription = null;
            this.lblWebSite.AccessibleName = null;
            resources.ApplyResources(this.lblWebSite, "lblWebSite");
            this.lblWebSite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblWebSite.Name = "lblWebSite";
            this.stylesSheetManager.SetStyle(this.lblWebSite, "LabelType1");
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.AccessibleDescription = null;
            this.lnkWebSite.AccessibleName = null;
            resources.ApplyResources(this.lnkWebSite, "lnkWebSite");
            this.lnkWebSite.ForeColor = System.Drawing.Color.Blue;
            this.lnkWebSite.Name = "lnkWebSite";
            this.stylesSheetManager.SetStyle(this.lnkWebSite, "HyperLinkType1");
            this.lnkWebSite.TabStop = true;
            this.lnkWebSite.UseCompatibleTextRendering = true;
            // 
            // txtFax
            // 
            this.txtFax.AccessibleDescription = null;
            this.txtFax.AccessibleName = null;
            resources.ApplyResources(this.txtFax, "txtFax");
            this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtFax.BackgroundImage = null;
            this.txtFax.Name = "txtFax";
            this.stylesSheetManager.SetStyle(this.txtFax, "TextBoxType1");
            // 
            // lblFax
            // 
            this.lblFax.AccessibleDescription = null;
            this.lblFax.AccessibleName = null;
            resources.ApplyResources(this.lblFax, "lblFax");
            this.lblFax.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFax.Name = "lblFax";
            this.stylesSheetManager.SetStyle(this.lblFax, "LabelType1");
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleDescription = null;
            this.txtPhone.AccessibleName = null;
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtPhone.BackgroundImage = null;
            this.txtPhone.Name = "txtPhone";
            this.stylesSheetManager.SetStyle(this.txtPhone, "TextBoxType1");
            // 
            // lblMail
            // 
            this.lblMail.AccessibleDescription = null;
            this.lblMail.AccessibleName = null;
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMail.Name = "lblMail";
            this.stylesSheetManager.SetStyle(this.lblMail, "LabelType1");
            // 
            // lnkMail
            // 
            this.lnkMail.AccessibleDescription = null;
            this.lnkMail.AccessibleName = null;
            resources.ApplyResources(this.lnkMail, "lnkMail");
            this.lnkMail.ForeColor = System.Drawing.Color.Blue;
            this.lnkMail.Name = "lnkMail";
            this.stylesSheetManager.SetStyle(this.lnkMail, "HyperLinkType1");
            this.lnkMail.TabStop = true;
            this.lnkMail.UseCompatibleTextRendering = true;
            // 
            // lblPhone
            // 
            this.lblPhone.AccessibleDescription = null;
            this.lblPhone.AccessibleName = null;
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPhone.Name = "lblPhone";
            this.stylesSheetManager.SetStyle(this.lblPhone, "LabelType1");
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.AccessibleDescription = null;
            this.tabPageOthers.AccessibleName = null;
            resources.ApplyResources(this.tabPageOthers, "tabPageOthers");
            this.tabPageOthers.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPageOthers.BackgroundImage = null;
            this.tabPageOthers.Controls.Add(this.label7);
            this.tabPageOthers.Controls.Add(this.dgType1);
            this.tabPageOthers.Font = null;
            this.tabPageOthers.Name = "tabPageOthers";
            this.stylesSheetManager.SetStyle(this.tabPageOthers, "");
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Name = "label7";
            this.stylesSheetManager.SetStyle(this.label7, "LabelType1");
            // 
            // dgType1
            // 
            this.dgType1.AccessibleDescription = null;
            this.dgType1.AccessibleName = null;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.dgType1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgType1, "dgType1");
            this.dgType1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgType1.BackgroundImage = null;
            this.dgType1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgType1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgColor,
            this.dgRate});
            this.dgType1.Font = null;
            this.dgType1.Name = "dgType1";
            this.dgType1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgType1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.stylesSheetManager.SetStyle(this.dgType1, "DataGridType1");
            // 
            // dgColor
            // 
            this.dgColor.DataPropertyName = "ColorName";
            resources.ApplyResources(this.dgColor, "dgColor");
            this.dgColor.Name = "dgColor";
            // 
            // dgRate
            // 
            this.dgRate.DataPropertyName = "Rate";
            resources.ApplyResources(this.dgRate, "dgRate");
            this.dgRate.Name = "dgRate";
            // 
            // cboJob
            // 
            this.cboJob.AccessibleDescription = null;
            this.cboJob.AccessibleName = null;
            resources.ApplyResources(this.cboJob, "cboJob");
            this.cboJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cboJob.BackgroundImage = null;
            this.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJob.Items.AddRange(new object[] {
            resources.GetString("cboJob.Items"),
            resources.GetString("cboJob.Items1")});
            this.cboJob.Name = "cboJob";
            this.stylesSheetManager.SetStyle(this.cboJob, "ComboBoxType1");
            // 
            // btnSelectStyle
            // 
            this.btnSelectStyle.AccessibleDescription = null;
            this.btnSelectStyle.AccessibleName = null;
            resources.ApplyResources(this.btnSelectStyle, "btnSelectStyle");
            this.btnSelectStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnSelectStyle.BackgroundImage = null;
            this.btnSelectStyle.ForeColor = System.Drawing.Color.Black;
            this.btnSelectStyle.Name = "btnSelectStyle";
            this.stylesSheetManager.SetStyle(this.btnSelectStyle, "ButtonType1");
            this.btnSelectStyle.UseVisualStyleBackColor = false;
            this.btnSelectStyle.Click += new System.EventHandler(this.btnSelectStyle_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleDescription = null;
            this.radioButton2.AccessibleName = null;
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.BackgroundImage = null;
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Name = "radioButton2";
            this.stylesSheetManager.SetStyle(this.radioButton2, "RadioButtonType1");
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleDescription = null;
            this.radioButton1.AccessibleName = null;
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.BackgroundImage = null;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Name = "radioButton1";
            this.stylesSheetManager.SetStyle(this.radioButton1, "RadioButtonType1");
            this.radioButton1.TabStop = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleDescription = null;
            this.txtFirstName.AccessibleName = null;
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.txtFirstName.BackgroundImage = null;
            this.txtFirstName.Name = "txtFirstName";
            this.stylesSheetManager.SetStyle(this.txtFirstName, "TextBoxType1");
            // 
            // lblFirstName
            // 
            this.lblFirstName.AccessibleDescription = null;
            this.lblFirstName.AccessibleName = null;
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFirstName.Name = "lblFirstName";
            this.stylesSheetManager.SetStyle(this.lblFirstName, "LabelType1");
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Name = "label2";
            this.stylesSheetManager.SetStyle(this.label2, "LabelType1");
            // 
            // lblJob
            // 
            this.lblJob.AccessibleDescription = null;
            this.lblJob.AccessibleName = null;
            resources.ApplyResources(this.lblJob, "lblJob");
            this.lblJob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblJob.Name = "lblJob";
            this.stylesSheetManager.SetStyle(this.lblJob, "LabelType1");
            // 
            // btnChildForm1
            // 
            this.btnChildForm1.AccessibleDescription = null;
            this.btnChildForm1.AccessibleName = null;
            resources.ApplyResources(this.btnChildForm1, "btnChildForm1");
            this.btnChildForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnChildForm1.BackgroundImage = null;
            this.btnChildForm1.ForeColor = System.Drawing.Color.Black;
            this.btnChildForm1.Name = "btnChildForm1";
            this.stylesSheetManager.SetStyle(this.btnChildForm1, "ButtonType1");
            this.btnChildForm1.UseVisualStyleBackColor = false;
            this.btnChildForm1.Click += new System.EventHandler(this.btnChildForm1_Click);
            // 
            // btnChildForm2
            // 
            this.btnChildForm2.AccessibleDescription = null;
            this.btnChildForm2.AccessibleName = null;
            resources.ApplyResources(this.btnChildForm2, "btnChildForm2");
            this.btnChildForm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnChildForm2.BackgroundImage = null;
            this.btnChildForm2.ForeColor = System.Drawing.Color.Black;
            this.btnChildForm2.Name = "btnChildForm2";
            this.stylesSheetManager.SetStyle(this.btnChildForm2, "ButtonType1");
            this.btnChildForm2.UseVisualStyleBackColor = false;
            this.btnChildForm2.Click += new System.EventHandler(this.btnChildForm2_Click);
            // 
            // btnTabControlInformation
            // 
            this.btnTabControlInformation.AccessibleDescription = null;
            this.btnTabControlInformation.AccessibleName = null;
            resources.ApplyResources(this.btnTabControlInformation, "btnTabControlInformation");
            this.btnTabControlInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnTabControlInformation.BackgroundImage = null;
            this.btnTabControlInformation.ForeColor = System.Drawing.Color.Black;
            this.btnTabControlInformation.Name = "btnTabControlInformation";
            this.stylesSheetManager.SetStyle(this.btnTabControlInformation, "ButtonType1");
            this.btnTabControlInformation.UseVisualStyleBackColor = false;
            this.btnTabControlInformation.Click += new System.EventHandler(this.btnTabControlInformation_Click);
            // 
            // btnChildForm3
            // 
            this.btnChildForm3.AccessibleDescription = null;
            this.btnChildForm3.AccessibleName = null;
            resources.ApplyResources(this.btnChildForm3, "btnChildForm3");
            this.btnChildForm3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.btnChildForm3.BackgroundImage = null;
            this.btnChildForm3.ForeColor = System.Drawing.Color.Black;
            this.btnChildForm3.Name = "btnChildForm3";
            this.stylesSheetManager.SetStyle(this.btnChildForm3, "ButtonType1");
            this.btnChildForm3.UseVisualStyleBackColor = false;
            this.btnChildForm3.Click += new System.EventHandler(this.btnChildForm3_Click);
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.btnChildForm3);
            this.Controls.Add(this.btnTabControlInformation);
            this.Controls.Add(this.btnChildForm2);
            this.Controls.Add(this.btnChildForm1);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSelectStyle);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTexteAFormater2);
            this.Controls.Add(this.lblLastName);
            this.Font = null;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.stylesSheetManager.SetStyle(this, "FormType1");
            this.Load += new System.EventHandler(this.FormTests_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.tabPageCommunications.ResumeLayout(false);
            this.tabPageCommunications.PerformLayout();
            this.tabPageOthers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MainForm"/> class.
        /// </summary>
		public MainForm()
		{
    		InitializeComponent();
		}

        /// <summary>
        /// Handles the Load event of the FormTests control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
		private void FormTests_Load(object sender, System.EventArgs e)
		{
            stylesSheetManager.ApplyStyles();

            List<MyColor> list = new List<MyColor>();
            list.Add(new MyColor("Green", 50));
            list.Add(new MyColor("Blue", 98));
            list.Add(new MyColor("Red", 59));
            dgType1.AutoGenerateColumns = false;
            dgType1.DataSource = list;
        }

        /// <summary>
        /// Handles the Click event of the btnSelectStyle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnSelectStyle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConfigurationManager.AppSettings["StylesSheetFilename"] = dlg.FileName;
                this.stylesSheetManager.ApplyStyles();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnChildForm1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnChildForm1_Click(object sender, EventArgs e)
        {
            ChildForm1 dlg = new ChildForm1();
            dlg.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnChildForm2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnChildForm2_Click(object sender, EventArgs e)
        {
            ChildForm2 dlg = new ChildForm2();
            dlg.ShowDialog();
        }

        private void btnChildForm3_Click(object sender, EventArgs e)
        {
            ChildForm3_Dynamic dlg = new ChildForm3_Dynamic();
            dlg.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnTabControlInformation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnTabControlInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Windows forms, there is no way to set the background color of a TabControl (TabControl.BackColor does nothing). If really wanted, you must override the DrawItem method() and paint the background manually.");
        }

        #region MyColor class
        private class MyColor
        {
            private string colorName;
            private int rate;

            public MyColor(string colorName, int rate)
            {
                this.colorName = colorName;
                this.rate = rate;
            }

            public string ColorName
            {
                get { return colorName; }
                set { colorName = value; }
            }

            public int Rate
            {
                get { return rate; }
                set { rate = value; }
            }
        }
        #endregion


    }
}
