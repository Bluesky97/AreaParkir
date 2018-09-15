using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrianAlexanderPutraCodingTest2
{
    public partial class frmAreaParkir : Form
    {
        AreaParkir[] areaParkirs; //declare an array for the class of AreaParkir
        int count = 0; //initialize count start from 0
        public frmAreaParkir()
        {
            InitializeComponent();
            areaParkirs = new AreaParkir[100]; //set the array of 100 (size)
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string jenis = tbxJenis.Text; //initialize "jenis" into the textbox -- userinput

            for (int n = 0; n < count; n++) //use for loop to check the data from the classes
            {
                if (areaParkirs[n].JenisKendaraan == jenis) //if "jenis kendaraan" is matched to the textbox (userinput)
                {
                    if (jenis == "motor") //if motor, can parks in motor/bus/car area
                    {
                        tbxOutput.AppendText("Lot Parkir yang diperbolehkan: " + jenis + Environment.NewLine + "- Area Parkir motor" + Environment.NewLine + "- Area Parkir mobil" + Environment.NewLine + "- Area parkir bus" + Environment.NewLine); //to show the output
                        return;
                    }
                    else if (jenis == "mobil") //if mobil, can parks in bus/car area
                    {
                        tbxOutput.AppendText("Lot Parkir yang diperbolehkan: " + jenis + Environment.NewLine + "- Area Parkir mobil" + Environment.NewLine + "- Area parkir bus" + Environment.NewLine); //to show the output
                        return;
                    }
                    else if (jenis == "bus") //if bus, can parks in bus area only
                    {
                        tbxOutput.AppendText("Lot Parkir yang diperbolehkan: " + jenis + Environment.NewLine + "- Area parkir bus" + Environment.NewLine); //to show the output
                        return;
                    }
                }
            }
            tbxOutput.AppendText("Not Found!" + Environment.NewLine); //if the data cannot find


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            pnlHomepage.Visible = false; //make panel invisible
        }

        private void btnAddK_Click(object sender, EventArgs e)
        {
            pnlHomepage.Visible = true; //make panel visible
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count == 100) //if count already 100
            {
                tbxOutput.AppendText("Array is full!" + Environment.NewLine); //show the message
                return;
            }
            Random random = new Random(); //initialize random number generator
            int num = random.Next(1, 1000); //set num from 1-1000
            AreaParkir areaParkir = new AreaParkir //call the "areaparkir" class
            (
                num,
                tbxJenisK.Text,
                chkbxBus.Checked.ToString() + chkbxMobil.Checked.ToString() + chkbxMotor.Checked.ToString()
            );
            if (tbxJenisK.Text == "") //to check whether the input cannot be blanks
            {
                tbxOutput.AppendText("Input cannot be blanks!" + Environment.NewLine); //show the error message
            }
            else
            {
                if (tbxJenisK.Text == "motor") //to check if the userinput of "jenis kendaraan" is motor and make it auto-checked of the checkbox
                {
                    chkbxBus.Checked = true;
                    chkbxMobil.Checked = true;
                    chkbxMotor.Checked = true;
                }
                else if (tbxJenisK.Text == "mobil") //to check if the userinput of "jenis kendaraan" is mobil and make it auto-checked of the checkbox
                {
                    chkbxBus.Checked = true;
                    chkbxMobil.Checked = true;
                    chkbxMotor.Checked = false;
                }
                else if (tbxJenisK.Text == "bus") //to check if the userinput of "jenis kendaraan" is bus and make it auto-checked of the checkbox
                {
                    chkbxBus.Checked = true;
                    chkbxMobil.Checked = false;
                    chkbxMotor.Checked = false;
                }
                areaParkirs[count] = areaParkir; //add into the count
                count++; //increment by 1
                tbxOutput.AppendText("Added Successfully!" + Environment.NewLine); //show the message
            }
        }
    }
}
