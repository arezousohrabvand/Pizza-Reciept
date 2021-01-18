using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Pizza C# sharp application
/// Author:Arezou Sohrabvand
/// Student Id:200387480
/// Date;19/02/2020
/// This application is for pizza price calculate the price of pizza with diffrent toppings and drinks 
/// </summary>
namespace Midterm_ArezouSohrabvand_200387480
{
    public partial class CSharpPizza_Form1 : Form
    {
        public CSharpPizza_Form1()
        {
            InitializeComponent();
        }
        //Clear Button if clicl on clear button every text boxes empty and checked boxes  are cleaned
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            //all checkbox checked getting false in order to inactivate them
            Pepperonni_checkBox.Checked = false;
            Pepperonni1_checkBox.Checked = false;
            Cheese_checkBox.Checked = false;
            Mushroom_checkBox.Checked = false;
            Coke_checkBox.Checked= false;
            //all Radion Button checked getting false in order to inactivate them
            PickUp_radioButton.Checked = false;
            Delivery_radioButton.Checked = false;
            //all Textboxes are getting null in order to erase them
            Qty1_textBox.Text = null;
            Qty2_textBox.Text = null;
            SubTotal_textBox.Text = null;
            AdditionalItems_textBox.Text = null;
            Taxes_textBox.Text = null;
            Total_textBox.Text = null; ;
            

        }

        private void CalculateTotal_btn_Click(object sender, EventArgs e)
        {

            //instance variables.
            double Sub_Total;
            double additional_price = 0;
            double Additional_Items;
            double Tax;
            double Total;
            double Qty1=0;
            double Qty2=0;
            double Pick_up = 0;
            double Delivery = 5;
            double Pizza = 20;
            double Coke = 1.5;
            double Drink_price;
            double Pizza_Price;
            //extra toppings (each$0.5)
            double Extra_Topping = 0.5;
            double pepperoni = 0.5;
            double cheese = 0.5;
            double mushroom = 0.5;
            additional_price = 0;
            Pizza_Price = Qty1 * Pizza;//it means the number of pizza *$20
            //the quantity of pizza multiply by Pizza price
            Qty1 = Convert.ToDouble(Qty1_textBox.Text);
            Qty2 = Convert.ToDouble(Qty2_textBox.Text);
            Drink_price = Qty2 * Coke;//it means the number of coke*$1.5
            //the quantity of Coke multiply by drink price
            Sub_Total =  (Qty1*20)+(Qty2*1.5)+additional_price;
            SubTotal_textBox.Text = Convert.ToString(Sub_Total);
            //Tax=0.13*Sub_Total
            Tax = 0.13 * Sub_Total;
            Taxes_textBox.Text = Convert.ToString(Tax);
            //Total=Subtotl+Tax
            Total = Sub_Total + Tax ;
            Total_textBox.Text = Convert.ToString(Total);
            
            
            if (Pepperonni1_checkBox.Checked== true)
            {
                additional_price = additional_price + (pepperoni*Qty1);
                AdditionalItems_textBox.Text = Convert.ToString(additional_price);
            }
            if (Cheese_checkBox.Checked == true)
            {
                additional_price = additional_price + (cheese*Qty1);
                AdditionalItems_textBox.Text = Convert.ToString(additional_price);
            }
            if (Mushroom_checkBox.Checked == true)
            {
                additional_price = additional_price + (mushroom*Qty1);
                AdditionalItems_textBox.Text = Convert.ToString(additional_price);
            }
             if (Delivery_radioButton.Checked == true)
            {
                additional_price = additional_price + Delivery;
                AdditionalItems_textBox.Text = Convert.ToString(additional_price);
            }
            if (PickUp_radioButton.Checked == true)
            {
                additional_price = additional_price + Pick_up;
                AdditionalItems_textBox.Text = Convert.ToString(additional_price);
            }
            if(Pepperonni_checkBox.Checked==false)
            {
                MessageBox.Show("Please put checkmark in pepperoni");
            }
            if (Coke_checkBox.Checked == false)
            {
                MessageBox.Show("Please put checkmark in coke");
            }

        }
        //confirmation of order button
        //message box shows the Here is Here is your order Confirming your price?
        //Then you can confirm your price is the same or not

        private void ConfirmationOrder_btn_Click(object sender, EventArgs e)
        {
            string box_msg = "Here is your order Confirming your price?";
            MessageBox.Show(Total_textBox.Text,box_msg,MessageBoxButtons.YesNo);
            
        }
    }
}
