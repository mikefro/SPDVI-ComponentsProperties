using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Components
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.targetButton.Text = $"Target\n X = {targetButton.Location.X}\n" +
                                              $"Y = {targetButton.Location.Y}";
            this.formSizeLabel.Text = $" Form Size: {this.Size.Height},{this.Size.Width}";
            this.VisibleTargetButton.Text = $" Visible = {this.targetButton.Visible.ToString()} ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VisibleTarget_Click(object sender, EventArgs e)
        {
         //   bool oposite = targetButton.Visible;

            targetButton.Visible = !targetButton.Visible;
            
        }
    }
}
