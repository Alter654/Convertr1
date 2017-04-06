using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp

{
    public partial class frm_Main : Form
    {
        public frm_Main()                                                   // this is where the calculations happen
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;                                       // created variables and constants
        double dbl_UoMf;
        const double CM_TO_INCH = 0.3937;
        const double M_TO_FEET = 3.28084;
        const double K_TO_MILES = 0.621371;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();                                             // exit button
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)      // Centermeters to inches button convertor
        {
           


            // validate user entry and convert to a double

            if (double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))          
            {

                if (double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))            // Centermeters to inches button calcultion
                    dbl_Convert = dbl_UofM * CM_TO_INCH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";

               
            }
            else
            {
               
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";

            } 
            
            

            
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_KILO_TO_MILES_Click(object sender, EventArgs e)
        {
            const double K_TO_Miles = 0.621371;
            if (double.TryParse(txt_UnitOfMeasure.Text, out dbl_UoMf))
            {
                dbl_Convert = dbl_UoMf * K_TO_Miles;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometers is converted to ";
                lbl_Convert.Text = " Miles.";

            }
        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FEET = 3.28084;
            if (double.TryParse(txt_UnitOfMeasure.Text, out dbl_UoMf))                  // meters to feet calculation
                
            {
                dbl_Convert = dbl_UoMf * M_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Meters is converted to ";
                lbl_Convert.Text = " Feet.";
                
            }
        }
    }
}
        
    
