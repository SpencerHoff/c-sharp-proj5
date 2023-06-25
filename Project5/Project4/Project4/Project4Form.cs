using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Project4Form : Form
    {
        //calling the variables//
        string name;
        decimal small_price;
        decimal medium_price;
        int quantity;
        string drink_type;
        decimal large_price;
        decimal order_amount;
        decimal discount;
        decimal total_amount;
        string filevalue;
        
        int random_num;
        Random rand = new Random();
        //this starts the form, displays a welcome message, then fills the coffee list box with strings from the txt file//
        public Project4Form()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to our ordering application!");
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("drinktypes.txt");
                while (inputFile.EndOfStream == false)
                {
                    drinklist.Items.Add(inputFile.ReadLine());
                }
            }
            catch
            {
                MessageBox.Show("Could not find the file");
            }
            


        }
        //this does nothing and was an accident//
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //this calculates the total//
        private void calculatebutton_Click(object sender, EventArgs e)
        {
            //checks to see if there is a name, if so, the value is placed into the "name" variable, if not, an error message is displayed//
            if (nameinput.Text != "")
            {
                name = nameinput.Text;
                //attempts to turn the quantity input into an integer, if it can't a message is displayed//
                if (int.TryParse(quantityinput.Text, out quantity))
                {
                    //checks what type of drink is selected//
                if (drinklist.SelectedIndex != -1)
                {
                    drink_type = drinklist.SelectedItem.ToString();
                }
                else
                {
                    drink_type = "";
                }
                //checks the size of order to determine the drink price//
                if (smallbutton.Checked)
                {
                    small_price = 2.5m;
                    order_amount = small_price;
                }
                else
                {
                    if (mediumbutton.Checked)
                    {
                        medium_price = 3.25m;
                        order_amount = medium_price;
                    }
                    else
                    {
                        if (largebutton.Checked)
                        {
                            large_price = 4.75m;
                            order_amount = large_price;
                        }
                        else { }
                    }
                }
                //this determines the discount amount//
                if (employeecheckbox.Checked && quantity > 2)
                {
                    discount = 0.09m;
                }
                else
                {
                    if (employeecheckbox.Checked && quantity <= 2)
                    {
                        discount = 0.06m;
                    }
                    else
                    {
                        if (!employeecheckbox.Checked && quantity > 4)
                        {
                            discount = 0.04m;
                        }
                    }
                }
                    //determines the base amount and puts it into a text box//
                    orderamount();
                    /*order_amount = order_amount * quantity;
                    amountbox.Text = order_amount.ToString("c2");*/

                    //determines the discount and puts it into a text box//
                    discountamount();
                    /*discount = order_amount * discount;
                    discountbox.Text = discount.ToString("c2");*/

                    //determines the total amount and puts it into a text box//
                    totalamount();
                    /*total_amount = order_amount - discount;
                    totalbox.Text = total_amount.ToString("c2");*/

                    random_num = rand.Next(50 + 1);

                //this outputs a message based on the number of items ordered//
                switch (order_amount)
                {
                    case 0:
                        thankyoubox.Text = "Why are you here " + name + " if you won't order a " + drink_type + " drink?" + " Also, your lucky number is " + random_num;
                        break;
                    case 1:
                        thankyoubox.Text = "Thank you " + name + " enjoy your " + drink_type + " drink!" + " Also, your lucky number is " + random_num;
                        break;
                    case 2:
                        thankyoubox.Text = "Thank you " + name + " for ordering " + order_amount + drink_type + "'s" + " Also, your lucky number is " + random_num;
                        break;
                    default:
                        thankyoubox.Text = "Wow! Thank you, " + name + ". Come back to buy some more " + drink_type + "!" + " Also, your lucky number is " + random_num;
                        break;

                }
                }
                else
                {
                    MessageBox.Show("Please enter a numeric quantity");
                    quantityinput.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Must enter a Customer Name before placing an order");
                nameinput.Focus();
            }

            
        }
        //this clears everything//
        private void newcustomerbutton_Click(object sender, EventArgs e)
        {
            nameinput.Text = string.Empty;
            quantityinput.Text = string.Empty;
            amountbox.Text = string.Empty;
            discountbox.Text = string.Empty;
            totalbox.Text= string.Empty;   
            thankyoubox.Text = string.Empty;
            smallbutton.Checked = true;
            drinklist.ClearSelected();
            employeecheckbox.Checked = false;
            quantityinput.Focus();
            coffeeflavorcombo.SelectedIndex = -1;
        }
        //this closes the program//
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void coffeeflavorcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //this clears the drinks list box//
        private void cleardrinksbutton_Click(object sender, EventArgs e)
        {
            drinklist.Items.Clear();
        }
        //this adds the selected flavor to the combo box and clears the text property//
        private void addcoffeebutton_Click(object sender, EventArgs e)
        {
            if (coffeeflavorcombo.SelectedIndex != -1)
            {
                coffeeflavorcombo.Items.Add(coffeeflavorcombo.SelectedItem);
                coffeeflavorcombo.Text = "";
            }
            else 
            {
                MessageBox.Show("Please re-enter a value");
                coffeeflavorcombo.Focus();
            }        
        }
        private void orderamount()
        {
            order_amount = order_amount * quantity;
            amountbox.Text = order_amount.ToString("c2");
        }
        private void discountamount()
        {
            discount = order_amount * discount;
            discountbox.Text = discount.ToString("c2");
        }
        private void totalamount()
        {
            total_amount = order_amount - discount;
            totalbox.Text = total_amount.ToString("c2");
        }
    }
}
