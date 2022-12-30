using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HappyNewYear
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botton1_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtuser.Text.Equals("Isitchas") && txtpass.Text.Equals("12345"))
                {
                     
                    var menu = new receba();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("mds mulher errou",
                        "PQP q lenda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtuser.Focus();
                    txtpass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry.",
                           ex.Message,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);

            } 

        }
    }
}