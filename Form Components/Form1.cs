using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Components
{


    public partial class mainForm : Form
    {
        public mainForm()
        {

            InitializeComponent();

        }
        //Pointing the center of form with the center of targetButton
        private void centerTarget()
        {
            targetButton.Location = new Point((this.Size.Width / 2) - (this.targetButton.Size.Width / 2),
                                              (this.Size.Height / 2) - (this.targetButton.Size.Height / 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"({this.Location.X}, {this.Location.Y}) Winforms Components -Common Controls";
            this.targetButton.Text = $"Target\n X = {targetButton.Location.X}\n" +
                                              $"Y = {targetButton.Location.Y}";
            this.formSizeLabel.Text = $" Form Size: {this.Size.Width},{this.Size.Height}";
            this.VisibleTargetButton.Text = $" Visible = {this.targetButton.Visible.ToString()} ";
            this.EnabledTargetButton.Text = $" Enabled = {this.targetButton.Enabled.ToString()} ";
        }

        //Do visible or invisible the targetButton
        private void VisibleTarget_Click(object sender, EventArgs e)
        {
            targetButton.Visible = !targetButton.Visible;
            this.VisibleTargetButton.Text = $" Visible = {this.targetButton.Visible.ToString()} ";
        }


        private void CenterTargetButton_Click(object sender, EventArgs e)
        {
            centerTarget();
        }

        //Setting the new location on every move of the mainForm
        private void mainForm_Move(object sender, EventArgs e)
        {
            this.Text = $"({this.Location.X}, {this.Location.Y}) Winforms Components -Common Controls";
        }


        //Target Button goes 5 pixels down on click
        private void GoDownButton_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X, targetButton.Location.Y
                + 5);
        }

        //TargetButton goes up 5pixels on click
        private void GoUpButton_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X, targetButton.Location.Y
                - 5);
        }

        //TargetButton goes to the left 5pixels on click
        private void GoLeftButton_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X - 5, targetButton.Location.Y);
        }

        //TargetButton goes to the right 5 pixels on click
        private void GoRightButton_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X + 5, targetButton.Location.Y);
        }

        //Set the new TargetButtonLocation on its textButton
        private void targetButton_Move(object sender, EventArgs e)
        {
            this.targetButton.Text = $"Target\n X = {targetButton.Location.X}\n" +
                                              $"Y = {targetButton.Location.Y}";
        }

        //Do enabled or disabled the targetButton
        private void EnableButton_Click(object sender, EventArgs e)
        {
            targetButton.Enabled = !targetButton.Enabled;
            this.EnabledTargetButton.Text = $" Enabled = {this.targetButton.Enabled.ToString()} ";
        }

        //set the new size on the SizeFormLabel
        private void mainForm_Resize(object sender, EventArgs e)
        {
            this.formSizeLabel.Text = $" Form Size: {this.Size.Width},{this.Size.Height}";
        }

        //set the choosen FormBorderStyle on the combobox
        private void BorderStyleCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            FormBorderStyle selectedIndex = (FormBorderStyle) BorderStyleCombobox.SelectedIndex;
            FormBorderStyle = selectedIndex;

        }
    }
}
