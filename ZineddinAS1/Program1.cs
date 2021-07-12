/* Date created:    September 8, 2020
 * Date modified:   September 13, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Program1
 * Description:     Code responsible for correctly displaying the information stored by the Movie class on the Form
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
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void btnLeadActor_Click(object sender, EventArgs e)
        {
            //Instantiate movie object
            Movie movie1 = new Movie();
            //Call ShowLeadActor method and display returned value in the label
            lblResult.Text = movie1.ShowLeadActor();
        }

        private void btnLeadActress_Click(object sender, EventArgs e)
        {
            //Instantiate movie object
            Movie movie2 = new Movie();
            //Call ShowLeadActress method and display returned value in the label
            lblResult.Text = movie2.ShowLeadActress();
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            //Instantiate movie object
            Movie movie3 = new Movie();
            //Call ShowDirector method and display returned value in the label
            lblResult.Text = movie3.ShowDirector();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
