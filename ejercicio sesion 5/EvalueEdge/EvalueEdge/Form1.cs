using EvalueAge.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalueEdge
{
    public partial class EvalueAge : Form
    {
        public EvalueAge()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToUInt16(tbAge.Text);
                evaluate evalue = new evaluate();
                IblAnswer.Text = "Tienes " + age + "años. " + evalue.EvalAge(age);
                tbAge.text = "";
                tbAge.Focus();
            }
            catch (Exception ex)
            {
                IblAnswer.Text = ex.Message;

            }
            
        }
    }
}
