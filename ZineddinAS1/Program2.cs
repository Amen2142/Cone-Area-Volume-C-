/* Date created:    September 8, 2020
 * Date modified:   September 13, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Program2
 * Description:     Form code responsible for converting the calculations made in the Cone class to the String data type, then displaying them correctly on the Form.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZineddinProgram1
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Cone Cone1 = new Cone();
            lblResult.Text = Cone1.CalculateArea(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString("N4");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            Cone Cone2 = new Cone();
            double Solution = Cone2.CalculateVolume(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text));
            lblResult.Text = Solution.ToString("N4");
        }
    }
}
