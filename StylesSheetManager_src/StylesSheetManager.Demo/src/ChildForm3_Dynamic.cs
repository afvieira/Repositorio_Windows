using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Demo
{
    public partial class ChildForm3_Dynamic : Form
    {

        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager = new Sb.Windows.Forms.StylesSheet.StylesSheetManager();

        #region Initialization
        public ChildForm3_Dynamic()
        {
            InitializeComponent();
        }

        private void ChildForm3_Dynamic_Load(object sender, EventArgs e)
        {
            stylesSheetManager.SetStyle(btnClose, "ButtonType1");
            stylesSheetManager.SetStyle(btnCreateLabels, "ButtonType1");
            stylesSheetManager.SetStyle(btnCreateTextBoxes, "ButtonType1");
            stylesSheetManager.SetStyle(this, "FormType2");
            stylesSheetManager.ApplyStyles();
        }
        #endregion

        #region Dynamic Label creation
        /// <summary>
        /// Handles the Click event of the btnCreateLabels control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnCreateLabels_Click(object sender, EventArgs e)
        {
            ClearControls();
            AddLabels();
            stylesSheetManager.ApplyStyles();
        }

        /// <summary>
        /// Adds the labels.
        /// </summary>
        private void AddLabels()
        {
            for (int i = 0; i < 5; i++)
            {
                Label lblLabel = CreateLabel("Dynamic Label " + (i + 1));
                this.controlsPanel.Controls.Add(lblLabel);
                stylesSheetManager.SetStyle(lblLabel, "LabelType1");
            }
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        private Label CreateLabel(string text)
        {
            Label lblLabel = (Label)(Activator.CreateInstance(typeof(Label)));
            lblLabel.Text = text;
            lblLabel.Visible = true;
            lblLabel.Dock = DockStyle.Fill;
            return lblLabel;
        }
        #endregion

        #region Dynamic TextBox creation
        /// <summary>
        /// Handles the Click event of the btnCreateTextBoxes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnCreateTextBoxes_Click(object sender, EventArgs e)
        {
            ClearControls();
            AddTextBoxes();
            stylesSheetManager.ApplyStyles();
        }

        /// <summary>
        /// Adds the text boxes.
        /// </summary>
        private void AddTextBoxes()
        {
            for (int i = 0; i < 5; i++)
            {
                TextBox txtTextBox = CreateTextBox("Dynamic TextBox " + (i + 1));
                this.controlsPanel.Controls.Add(txtTextBox);
                stylesSheetManager.SetStyle(txtTextBox, "TextBoxType1");
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        private TextBox CreateTextBox(string text)
        {
            TextBox txtTextBox = (TextBox)(Activator.CreateInstance(typeof(TextBox)));
            txtTextBox.Text = text;
            txtTextBox.Visible = true;
            txtTextBox.Dock = DockStyle.Fill;
            return txtTextBox;
        }
        #endregion

        #region Common
        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears the controls.
        /// </summary>
        private void ClearControls()
        {
            foreach (Control c in this.controlsPanel.Controls)
            {
                stylesSheetManager.RemoveStyle(c);
            }
            this.controlsPanel.Controls.Clear();
        }
        #endregion
    }
}