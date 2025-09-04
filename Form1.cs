using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void Label_MakeYourPizza_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_Size_Enter(object sender, EventArgs e)
        {
        }

        private void RadioButton_SizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
           
        }

        private void RadioButton_SizeMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void RadioButton_SizeLarge_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSummary(); 
        }

        private void GroupBox_Toppings_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox_ToppingsExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void CheckBox_ToppingsMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void CheckBox_ToppingsTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void CheckBox_ToppingsOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void CheckBox_ToppingsGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void RadioButton_CrustThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton_CrustThinCrust.Checked)
            {
                TextBox_OrderSummaryCrust.Text = "Thin";
            }
        }

        private void GroupBox_Crust_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox_WhereToEat_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton_WhereToEatEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton_WhereToEatEatIn.Checked)
            {
                TextBox_OrderSummaryWhereToEat.Text = "Eat In";
            }
        }

        private void RadioButton_WhereToEatTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_WhereToEatTakeaway.Checked)
            {
                TextBox_OrderSummaryWhereToEat.Text = "Takeaway";
            }
        }

        private void GroupBox_OrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void Label_OrderSummarySize_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_OrderSummarySize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_OrderSummaryToppings_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox_OrderSummaryToppings_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_OrderSummaryCrust_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_OrderSummaryCrust_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_OrderSummaryWhereToEat_Click(object sender, EventArgs e)
        {

        }

        private void Label_OrderSummaryPrice_Click(object sender, EventArgs e)
        {

        }

        private void Label_TotalPrice_Click(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void Button_OrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Confirmed successfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GroupBox_Size.Enabled = false;
                GroupBox_Crust.Enabled = false;
                GroupBox_WhereToEat.Enabled = false;
                GroupBox_Toppings.Enabled = false;
            }
        }

        private void Button_ResetForm_Click(object sender, EventArgs e)
        {
            GroupBox_Size.Enabled = true;
            GroupBox_Crust.Enabled = true;
            GroupBox_WhereToEat.Enabled = true;
            GroupBox_Toppings.Enabled = true;

            RadioButton_SizeMeduim.Checked = false;
            RadioButton_SizeLarge.Checked = false;

            CheckBox_ToppingsExtraCheese.Checked = false;
            CheckBox_ToppingsGreenPeppers.Checked = false;
            CheckBox_ToppingsMushrooms.Checked = false;
            CheckBox_ToppingsOlives.Checked = false;
            CheckBox_ToppingsTomatoes.Checked = false;
            CheckBox_ToppingsOnions.Checked = false;

            RadioButton_CrustThickCrust.Checked = false;
            RadioButton_CrustThinCrust.Checked = false;
            
            
        }

        private void UpdateSummary()
        {
            List<string> Toppings = new List<string>();
            int TotalPrice = 0;

            if (CheckBox_ToppingsExtraCheese.Checked)
            {
                Toppings.Add("Extra Cheese");
                TotalPrice += 1;
            }

            if (CheckBox_ToppingsGreenPeppers.Checked)
            {
                Toppings.Add("Green Peppers");
                TotalPrice += 1;

            }

            if (CheckBox_ToppingsMushrooms.Checked)
            {
                Toppings.Add("Mushrooms");
                TotalPrice += 1;

            }

            if (CheckBox_ToppingsTomatoes.Checked)
            {
                Toppings.Add("Tomatoes");
                TotalPrice += 1;

            }

            if (CheckBox_ToppingsOnions.Checked)
            {
                Toppings.Add("Onions");
                TotalPrice += 1;

            }

            if (CheckBox_ToppingsOlives.Checked)
            {
                Toppings.Add("Olives");
                TotalPrice += 1;

            }

            if (RadioButton_SizeSmall.Checked)
            {
                TextBox_OrderSummarySize.Text = "Small";
                TotalPrice += 10;
            }

            if (RadioButton_SizeMeduim.Checked)
            {
                TextBox_OrderSummarySize.Text = "Meduim";
                TotalPrice += 15;   
            }
            if (RadioButton_SizeLarge.Checked)
            {
                TextBox_OrderSummarySize.Text = "Large";
                TotalPrice += 20;
            }

            RichTextBox_OrderSummaryToppings.Text = String.Join(", ", Toppings);
            Label_TotalPrice.Text = TotalPrice.ToString() + "$";


            //Another way by using only string:
            //string Toppings = "";

            //if(CheckBox_ToppingsOlives.Checked)
            //{
            //    Toppings += "Olives, ";
            //}

            //if(CheckBox_ToppingsExtraCheese.Checked)
            //{
            //    Toppings += "Extra Cheese, ";
            //}

            //if(CheckBox_ToppingsGreenPeppers.Checked)
            //{
            //    Toppings += "Green Peppers, ";
            //}

            //if(CheckBox_ToppingsMushrooms.Checked)
            //{
            //    Toppings += "Mushrooms, ";
            //}

            //if(CheckBox_ToppingsGreenPeppers.Checked)
            //{
            //    Toppings += "Tomatoes, ";
            //}

            //if(CheckBox_ToppingsOnions.Checked)
            //{
            //    Toppings += "Onions, ";
            //}

            //if(Toppings.EndsWith(", "))
            //{
            //    Toppings = Toppings.Substring(0, Toppings.Length - 2);
            //}

            //RichTextBox_OrderSummaryToppings.Text = Toppings;
        }

        private void RadioButton_CrustThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_CrustThickCrust.Checked)
            {
                TextBox_OrderSummaryCrust.Text = "Thick";
            }
        }


    }

}
