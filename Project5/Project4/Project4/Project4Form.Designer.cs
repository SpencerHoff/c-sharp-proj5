namespace Project4
{
    partial class Project4Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sizebox = new System.Windows.Forms.GroupBox();
            this.largebutton = new System.Windows.Forms.RadioButton();
            this.mediumbutton = new System.Windows.Forms.RadioButton();
            this.smallbutton = new System.Windows.Forms.RadioButton();
            this.employeecheckbox = new System.Windows.Forms.CheckBox();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.drinktypelabel = new System.Windows.Forms.Label();
            this.drinklist = new System.Windows.Forms.ListBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.ordertotalbox = new System.Windows.Forms.GroupBox();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.discountbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.totallabel = new System.Windows.Forms.Label();
            this.discountlabel = new System.Windows.Forms.Label();
            this.orderamountlabel = new System.Windows.Forms.Label();
            this.thankyoubox = new System.Windows.Forms.TextBox();
            this.newcustomerbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.quantityinput = new System.Windows.Forms.TextBox();
            this.coffeeflavorlabel = new System.Windows.Forms.Label();
            this.addcoffeebutton = new System.Windows.Forms.Button();
            this.coffeeflavorcombo = new System.Windows.Forms.ComboBox();
            this.cleardrinksbutton = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.sizebox.SuspendLayout();
            this.ordertotalbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizebox
            // 
            this.sizebox.Controls.Add(this.largebutton);
            this.sizebox.Controls.Add(this.mediumbutton);
            this.sizebox.Controls.Add(this.smallbutton);
            this.sizebox.Location = new System.Drawing.Point(105, 53);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(200, 149);
            this.sizebox.TabIndex = 0;
            this.sizebox.TabStop = false;
            this.sizebox.Text = "Size:";
            // 
            // largebutton
            // 
            this.largebutton.AutoSize = true;
            this.largebutton.Location = new System.Drawing.Point(17, 104);
            this.largebutton.Name = "largebutton";
            this.largebutton.Size = new System.Drawing.Size(52, 17);
            this.largebutton.TabIndex = 2;
            this.largebutton.TabStop = true;
            this.largebutton.Text = "&Large";
            this.largebutton.UseVisualStyleBackColor = true;
            // 
            // mediumbutton
            // 
            this.mediumbutton.AutoSize = true;
            this.mediumbutton.Location = new System.Drawing.Point(17, 67);
            this.mediumbutton.Name = "mediumbutton";
            this.mediumbutton.Size = new System.Drawing.Size(62, 17);
            this.mediumbutton.TabIndex = 1;
            this.mediumbutton.TabStop = true;
            this.mediumbutton.Text = "&Medium";
            this.mediumbutton.UseVisualStyleBackColor = true;
            // 
            // smallbutton
            // 
            this.smallbutton.AutoSize = true;
            this.smallbutton.Location = new System.Drawing.Point(17, 31);
            this.smallbutton.Name = "smallbutton";
            this.smallbutton.Size = new System.Drawing.Size(50, 17);
            this.smallbutton.TabIndex = 0;
            this.smallbutton.TabStop = true;
            this.smallbutton.Text = "&Small";
            this.smallbutton.UseVisualStyleBackColor = true;
            // 
            // employeecheckbox
            // 
            this.employeecheckbox.AutoSize = true;
            this.employeecheckbox.Location = new System.Drawing.Point(560, 293);
            this.employeecheckbox.Name = "employeecheckbox";
            this.employeecheckbox.Size = new System.Drawing.Size(78, 17);
            this.employeecheckbox.TabIndex = 5;
            this.employeecheckbox.Text = "Employee?";
            this.employeecheckbox.UseVisualStyleBackColor = true;
            // 
            // nameinput
            // 
            this.nameinput.Location = new System.Drawing.Point(560, 245);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(178, 20);
            this.nameinput.TabIndex = 4;
            this.tooltip.SetToolTip(this.nameinput, "Enter your name here");
            this.nameinput.TextChanged += new System.EventHandler(this.nameinput_TextChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(469, 249);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(85, 13);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "&Customer Name:";
            // 
            // drinktypelabel
            // 
            this.drinktypelabel.AutoSize = true;
            this.drinktypelabel.Location = new System.Drawing.Point(615, 27);
            this.drinktypelabel.Name = "drinktypelabel";
            this.drinktypelabel.Size = new System.Drawing.Size(62, 13);
            this.drinktypelabel.TabIndex = 4;
            this.drinktypelabel.Text = "Drink Type:";
            // 
            // drinklist
            // 
            this.drinklist.FormattingEnabled = true;
            this.drinklist.Location = new System.Drawing.Point(569, 53);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(169, 134);
            this.drinklist.Sorted = true;
            this.drinklist.TabIndex = 2;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(527, 371);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(111, 86);
            this.calculatebutton.TabIndex = 6;
            this.calculatebutton.Text = "Calculate Order &Amount";
            this.tooltip.SetToolTip(this.calculatebutton, "Clicking this will calculate the order amount");
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // ordertotalbox
            // 
            this.ordertotalbox.Controls.Add(this.totalbox);
            this.ordertotalbox.Controls.Add(this.discountbox);
            this.ordertotalbox.Controls.Add(this.amountbox);
            this.ordertotalbox.Controls.Add(this.totallabel);
            this.ordertotalbox.Controls.Add(this.discountlabel);
            this.ordertotalbox.Controls.Add(this.orderamountlabel);
            this.ordertotalbox.Location = new System.Drawing.Point(108, 326);
            this.ordertotalbox.Name = "ordertotalbox";
            this.ordertotalbox.Size = new System.Drawing.Size(262, 170);
            this.ordertotalbox.TabIndex = 7;
            this.ordertotalbox.TabStop = false;
            this.ordertotalbox.Text = "groupBox1";
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(113, 128);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(100, 20);
            this.totalbox.TabIndex = 5;
            this.totalbox.TabStop = false;
            this.tooltip.SetToolTip(this.totalbox, "This displays your total amount after the discount");
            // 
            // discountbox
            // 
            this.discountbox.Location = new System.Drawing.Point(113, 82);
            this.discountbox.Name = "discountbox";
            this.discountbox.Size = new System.Drawing.Size(100, 20);
            this.discountbox.TabIndex = 4;
            this.discountbox.TabStop = false;
            this.tooltip.SetToolTip(this.discountbox, "This displays your discount");
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(113, 36);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(100, 20);
            this.amountbox.TabIndex = 3;
            this.amountbox.TabStop = false;
            this.tooltip.SetToolTip(this.amountbox, "This displays the initial order amount");
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(17, 128);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(34, 13);
            this.totallabel.TabIndex = 2;
            this.totallabel.Text = "Total:";
            // 
            // discountlabel
            // 
            this.discountlabel.AutoSize = true;
            this.discountlabel.Location = new System.Drawing.Point(17, 82);
            this.discountlabel.Name = "discountlabel";
            this.discountlabel.Size = new System.Drawing.Size(52, 13);
            this.discountlabel.TabIndex = 1;
            this.discountlabel.Text = "Discount:";
            this.discountlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // orderamountlabel
            // 
            this.orderamountlabel.AutoSize = true;
            this.orderamountlabel.Location = new System.Drawing.Point(17, 36);
            this.orderamountlabel.Name = "orderamountlabel";
            this.orderamountlabel.Size = new System.Drawing.Size(75, 13);
            this.orderamountlabel.TabIndex = 0;
            this.orderamountlabel.Text = "Order Amount:";
            // 
            // thankyoubox
            // 
            this.thankyoubox.Location = new System.Drawing.Point(110, 550);
            this.thankyoubox.Name = "thankyoubox";
            this.thankyoubox.Size = new System.Drawing.Size(567, 20);
            this.thankyoubox.TabIndex = 8;
            this.thankyoubox.TabStop = false;
            this.tooltip.SetToolTip(this.thankyoubox, "This displays a thank you message");
            // 
            // newcustomerbutton
            // 
            this.newcustomerbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newcustomerbutton.Location = new System.Drawing.Point(202, 596);
            this.newcustomerbutton.Name = "newcustomerbutton";
            this.newcustomerbutton.Size = new System.Drawing.Size(103, 77);
            this.newcustomerbutton.TabIndex = 7;
            this.newcustomerbutton.Text = "&New Customer";
            this.tooltip.SetToolTip(this.newcustomerbutton, "Clickling this will clear the form");
            this.newcustomerbutton.UseVisualStyleBackColor = true;
            this.newcustomerbutton.Click += new System.EventHandler(this.newcustomerbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(460, 596);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(107, 77);
            this.exitbutton.TabIndex = 8;
            this.exitbutton.Text = "E&xit";
            this.tooltip.SetToolTip(this.exitbutton, "Clicking this will close the application");
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(105, 252);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(49, 13);
            this.quantitylabel.TabIndex = 2;
            this.quantitylabel.Text = "&Quantity:";
            // 
            // quantityinput
            // 
            this.quantityinput.Location = new System.Drawing.Point(160, 249);
            this.quantityinput.Name = "quantityinput";
            this.quantityinput.Size = new System.Drawing.Size(100, 20);
            this.quantityinput.TabIndex = 3;
            this.tooltip.SetToolTip(this.quantityinput, "Enter the quantity of drinks here");
            // 
            // coffeeflavorlabel
            // 
            this.coffeeflavorlabel.AutoSize = true;
            this.coffeeflavorlabel.Location = new System.Drawing.Point(391, 27);
            this.coffeeflavorlabel.Name = "coffeeflavorlabel";
            this.coffeeflavorlabel.Size = new System.Drawing.Size(70, 13);
            this.coffeeflavorlabel.TabIndex = 9;
            this.coffeeflavorlabel.Text = "Coffee Flavor";
            this.coffeeflavorlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addcoffeebutton
            // 
            this.addcoffeebutton.Location = new System.Drawing.Point(382, 134);
            this.addcoffeebutton.Name = "addcoffeebutton";
            this.addcoffeebutton.Size = new System.Drawing.Size(93, 23);
            this.addcoffeebutton.TabIndex = 10;
            this.addcoffeebutton.TabStop = false;
            this.addcoffeebutton.Text = "Add Coffee";
            this.tooltip.SetToolTip(this.addcoffeebutton, "Click this to add the coffee flavor to the selection\r\n");
            this.addcoffeebutton.UseVisualStyleBackColor = true;
            this.addcoffeebutton.Click += new System.EventHandler(this.addcoffeebutton_Click);
            // 
            // coffeeflavorcombo
            // 
            this.coffeeflavorcombo.FormattingEnabled = true;
            this.coffeeflavorcombo.Items.AddRange(new object[] {
            "Chocolate Almond",
            "French Roast",
            "Hazelnut",
            "Kona Blend",
            "Regular Decaf",
            "Regular Roast"});
            this.coffeeflavorcombo.Location = new System.Drawing.Point(366, 53);
            this.coffeeflavorcombo.Name = "coffeeflavorcombo";
            this.coffeeflavorcombo.Size = new System.Drawing.Size(121, 21);
            this.coffeeflavorcombo.Sorted = true;
            this.coffeeflavorcombo.TabIndex = 1;
            this.coffeeflavorcombo.SelectedIndexChanged += new System.EventHandler(this.coffeeflavorcombo_SelectedIndexChanged);
            // 
            // cleardrinksbutton
            // 
            this.cleardrinksbutton.Location = new System.Drawing.Point(599, 193);
            this.cleardrinksbutton.Name = "cleardrinksbutton";
            this.cleardrinksbutton.Size = new System.Drawing.Size(104, 23);
            this.cleardrinksbutton.TabIndex = 12;
            this.cleardrinksbutton.TabStop = false;
            this.cleardrinksbutton.Text = "Clear Drink Types";
            this.tooltip.SetToolTip(this.cleardrinksbutton, "Click this to clear the drink type list");
            this.cleardrinksbutton.UseVisualStyleBackColor = true;
            this.cleardrinksbutton.Click += new System.EventHandler(this.cleardrinksbutton_Click);
            // 
            // Project4Form
            // 
            this.AcceptButton = this.calculatebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.newcustomerbutton;
            this.ClientSize = new System.Drawing.Size(780, 685);
            this.Controls.Add(this.cleardrinksbutton);
            this.Controls.Add(this.coffeeflavorcombo);
            this.Controls.Add(this.addcoffeebutton);
            this.Controls.Add(this.coffeeflavorlabel);
            this.Controls.Add(this.quantityinput);
            this.Controls.Add(this.quantitylabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.newcustomerbutton);
            this.Controls.Add(this.thankyoubox);
            this.Controls.Add(this.ordertotalbox);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.drinktypelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.employeecheckbox);
            this.Controls.Add(this.sizebox);
            this.Name = "Project4Form";
            this.Text = "Spencer Hoff";
            this.sizebox.ResumeLayout(false);
            this.sizebox.PerformLayout();
            this.ordertotalbox.ResumeLayout(false);
            this.ordertotalbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sizebox;
        private System.Windows.Forms.RadioButton largebutton;
        private System.Windows.Forms.RadioButton mediumbutton;
        private System.Windows.Forms.RadioButton smallbutton;
        private System.Windows.Forms.CheckBox employeecheckbox;
        private System.Windows.Forms.TextBox nameinput;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label drinktypelabel;
        private System.Windows.Forms.ListBox drinklist;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.GroupBox ordertotalbox;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label discountlabel;
        private System.Windows.Forms.Label orderamountlabel;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.TextBox discountbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.TextBox thankyoubox;
        private System.Windows.Forms.Button newcustomerbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.TextBox quantityinput;
        private System.Windows.Forms.Label coffeeflavorlabel;
        private System.Windows.Forms.Button addcoffeebutton;
        private System.Windows.Forms.ComboBox coffeeflavorcombo;
        private System.Windows.Forms.Button cleardrinksbutton;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

