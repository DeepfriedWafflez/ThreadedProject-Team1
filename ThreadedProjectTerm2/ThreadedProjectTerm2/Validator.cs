﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectTerm2
{
    /**
     * Threaded project 2 - Team 1
     * Purpose: Validate user data
     * Made by: Brent Ward
     * Date: March 19th 2019
     * **/
    public class Validator
    {
        public static bool IsPresent(TextBox tb)//checks the field is filled
        {
            bool result = true;
            if(tb.Text == "") result = false;

            return result;
        }

        public static bool isNonNegative(TextBox tb, string name)//checks the number is positive
        {
            if(Convert.ToDouble(tb.Text) > 0)
            {
                Convert.ToDouble(tb.Text);
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a positive number for " + name + "!", "Input Error");
                tb.Focus();
                return false;
            }
        }

        public static bool isWholeNumber(TextBox tb, string name)//checks the number is whole
        {
            try
            {
                Convert.ToInt32(tb.Text);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a whole number for " + name + "!", "InputError");
                tb.Focus();
                return false;
            }
        }

        public static bool IsCompare(TextBox tb1,TextBox tb2)
        {
            decimal basePrice = Convert.ToDecimal(tb1.Text);
            decimal agencyCommission = Convert.ToDecimal(tb2.Text);
           
            try
            {
                if (tb2.Text != null)
                {
                    if (basePrice > agencyCommission)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Agency Commission has to be less than Package Price");
                        return false;
                    }
                }
                return true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
          
        }


    }
}
