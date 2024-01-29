using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System
{
    public partial class Form1 : Form
    {
        const double Price_CCS = 9.99;  // PRICES FOR EVERYTHING
        const double Price_CNCS = 8.99;
        const double Price_SCS = 14.99;
        const double Price_PT = 9.99;
        const double Price_PC = 8.99;
        const double Price_LAS = 8.99;
        const double Price_RIZZ = 9.99;
        const double Price_CUR = 10.99;
        const double Price_CB = 4.99;
        const double Price_APIC = 4.99;
        const double Price_FS = 3.99;
        const double Price_IC = 3.99;
        const double Price_CC = 4.99;
        const double Price_COLA = 1.99;
        const double Price_PEPSI = 1.99;
        const double Price_LEM = 1.99;
        const double Price_FAN = 1.99;
        const double Price_OAS = 2.50;
        const double Price_MILSH = 3.99;
        const double Price_APPJ = 1.50;
        const double Price_WAT = 1.50;
        const double Price_TC = 1.75;
        const double Price_TAX = 3.9;

        double iTax, isubTotal, iTotal;  

        public Form1()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // exit button
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit the system", "Ordering", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }        
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";

                    else
                        func(control.Controls);
            };
            func (Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;

                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;

                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button2_Click(object sender, EventArgs e) // Reset Button
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" "); // Payment Method
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card ");

            EnableTextBoxes();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = " ";
                textBox9.Focus();
            }

            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = " ";
                textBox1.Focus();
            }

            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = " ";
                textBox6.Focus();
            }

            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = " ";
                textBox7.Focus();
            }

            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = " ";
                textBox8.Focus();
            }

            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = " ";
                textBox2.Focus();
            }

            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = " ";
                textBox3.Focus();
            }

            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = " ";
                textBox4.Focus();
            }

            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = " ";
                textBox11.Focus();
            }

            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = " ";
                textBox13.Focus();
            }

            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = " ";
                textBox12.Focus();
            }

            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = " ";
                textBox14.Focus();
            }

            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = " ";
                textBox15.Focus();
            }

            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = " ";
                textBox16.Focus();
            }

            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = " ";
                textBox18.Focus();
            }

            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = " ";
                textBox17.Focus();
            }

            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = " ";
                textBox19.Focus();
            }

            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = " ";
                textBox20.Focus();
            }

            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = " ";
                textBox21.Focus();
            }

            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = " ";
                textBox22.Focus();
            }

            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                textBox26.Enabled = true;
                textBox26.Text = "";
                textBox26.Focus();
            }
            else
            {
                textBox26.Enabled = false ;
                textBox26.Text = "0";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[22];
            itemcost[0] = Convert.ToDouble(textBox9.Text) * Price_CCS;
            itemcost[1] = Convert.ToDouble(textBox1.Text) * Price_CNCS;
            itemcost[2] = Convert.ToDouble(textBox6.Text) * Price_SCS;
            itemcost[3] = Convert.ToDouble(textBox7.Text) * Price_PT;
            itemcost[4] = Convert.ToDouble(textBox8.Text) * Price_PC;
            itemcost[5] = Convert.ToDouble(textBox2.Text) * Price_LAS;
            itemcost[6] = Convert.ToDouble(textBox3.Text) * Price_RIZZ;
            itemcost[7] = Convert.ToDouble(textBox4.Text) * Price_CUR;
            itemcost[8] = Convert.ToDouble(textBox11.Text) * Price_CB;
            itemcost[9] = Convert.ToDouble(textBox13.Text) * Price_APIC;
            itemcost[10] = Convert.ToDouble(textBox12.Text) * Price_FS;
            itemcost[11] = Convert.ToDouble(textBox14.Text) * Price_IC;
            itemcost[12] = Convert.ToDouble(textBox15.Text) * Price_CC;
            itemcost[13] = Convert.ToDouble(textBox16.Text) * Price_COLA;
            itemcost[14] = Convert.ToDouble(textBox18.Text) * Price_PEPSI;
            itemcost[15] = Convert.ToDouble(textBox17.Text) * Price_LEM;
            itemcost[16] = Convert.ToDouble(textBox19.Text) * Price_FAN;
            itemcost[17] = Convert.ToDouble(textBox20.Text) * Price_OAS;
            itemcost[18] = Convert.ToDouble(textBox21.Text) * Price_MILSH;
            itemcost[19] = Convert.ToDouble(textBox22.Text) * Price_APPJ;
            itemcost[20] = Convert.ToDouble(textBox23.Text) * Price_WAT;
            itemcost[21] = Convert.ToDouble(textBox24.Text) * Price_TC;

            double cost, ichange;


            if (comboBox1.Text =="Cash")
            {
                isubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                    + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13]
                    + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];

                textBox10.Text = isubTotal.ToString();
                iTax = (isubTotal * Price_TAX)/100;
                textBox5.Text = iTax.ToString();
                iTotal = (isubTotal + iTax);
                textBox27.Text = Convert.ToString(iTotal);
                
                ichange = Convert.ToDouble(textBox26.Text);
                cost = ichange - (iTax + iTotal);
                textBox26.Text = cost.ToString();

            }
            else
            {
                isubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                   + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13]
                   + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];

                textBox10.Text = isubTotal.ToString();
                iTax = (isubTotal * Price_TAX) / 100;
                textBox5.Text = iTax.ToString();
                iTotal = (isubTotal + iTax);
                textBox27.Text = Convert.ToString(iTotal);
            }


        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox23.Enabled = true;
                textBox23.Text = " ";
                textBox23.Focus();
            }

            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                textBox24.Enabled = true;
                textBox24.Text = " ";
                textBox24.Focus();
            }

            else
            {
                textBox24.Enabled = false;
                textBox24.Text = "0";
            }
        }
    }
}
