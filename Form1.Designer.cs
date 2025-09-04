namespace Pizza_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label_MakeYourPizza = new System.Windows.Forms.Label();
            this.GroupBox_Size = new System.Windows.Forms.GroupBox();
            this.RadioButton_SizeLarge = new System.Windows.Forms.RadioButton();
            this.RadioButton_SizeMeduim = new System.Windows.Forms.RadioButton();
            this.RadioButton_SizeSmall = new System.Windows.Forms.RadioButton();
            this.GroupBox_Toppings = new System.Windows.Forms.GroupBox();
            this.CheckBox_ToppingsGreenPeppers = new System.Windows.Forms.CheckBox();
            this.CheckBox_ToppingsOlives = new System.Windows.Forms.CheckBox();
            this.CheckBox_ToppingsOnions = new System.Windows.Forms.CheckBox();
            this.CheckBox_ToppingsTomatoes = new System.Windows.Forms.CheckBox();
            this.CheckBox_ToppingsMushrooms = new System.Windows.Forms.CheckBox();
            this.CheckBox_ToppingsExtraCheese = new System.Windows.Forms.CheckBox();
            this.GroupBox_Crust = new System.Windows.Forms.GroupBox();
            this.RadioButton_CrustThickCrust = new System.Windows.Forms.RadioButton();
            this.RadioButton_CrustThinCrust = new System.Windows.Forms.RadioButton();
            this.GroupBox_WhereToEat = new System.Windows.Forms.GroupBox();
            this.RadioButton_WhereToEatTakeaway = new System.Windows.Forms.RadioButton();
            this.RadioButton_WhereToEatEatIn = new System.Windows.Forms.RadioButton();
            this.GroupBox_OrderSummary = new System.Windows.Forms.GroupBox();
            this.Label_TotalPrice = new System.Windows.Forms.Label();
            this.Label_OrderSummaryPrice = new System.Windows.Forms.Label();
            this.TextBox_OrderSummaryWhereToEat = new System.Windows.Forms.TextBox();
            this.Label_OrderSummaryWhereToEat = new System.Windows.Forms.Label();
            this.TextBox_OrderSummaryCrust = new System.Windows.Forms.TextBox();
            this.Label_OrderSummaryCrust = new System.Windows.Forms.Label();
            this.RichTextBox_OrderSummaryToppings = new System.Windows.Forms.RichTextBox();
            this.Label_OrderSummaryToppings = new System.Windows.Forms.Label();
            this.TextBox_OrderSummarySize = new System.Windows.Forms.TextBox();
            this.Label_OrderSummarySize = new System.Windows.Forms.Label();
            this.Button_OrderPizza = new System.Windows.Forms.Button();
            this.Button_ResetForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox_Size.SuspendLayout();
            this.GroupBox_Toppings.SuspendLayout();
            this.GroupBox_Crust.SuspendLayout();
            this.GroupBox_WhereToEat.SuspendLayout();
            this.GroupBox_OrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_MakeYourPizza
            // 
            this.Label_MakeYourPizza.AutoSize = true;
            this.Label_MakeYourPizza.Font = new System.Drawing.Font("Goudy Stout", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MakeYourPizza.ForeColor = System.Drawing.Color.Firebrick;
            this.Label_MakeYourPizza.Location = new System.Drawing.Point(135, 37);
            this.Label_MakeYourPizza.Name = "Label_MakeYourPizza";
            this.Label_MakeYourPizza.Size = new System.Drawing.Size(625, 46);
            this.Label_MakeYourPizza.TabIndex = 0;
            this.Label_MakeYourPizza.Text = "Make Your Pizza";
            this.Label_MakeYourPizza.Click += new System.EventHandler(this.Label_MakeYourPizza_Click);
            // 
            // GroupBox_Size
            // 
            this.GroupBox_Size.Controls.Add(this.RadioButton_SizeLarge);
            this.GroupBox_Size.Controls.Add(this.RadioButton_SizeMeduim);
            this.GroupBox_Size.Controls.Add(this.RadioButton_SizeSmall);
            this.GroupBox_Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Size.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_Size.Location = new System.Drawing.Point(40, 109);
            this.GroupBox_Size.Name = "GroupBox_Size";
            this.GroupBox_Size.Size = new System.Drawing.Size(124, 105);
            this.GroupBox_Size.TabIndex = 1;
            this.GroupBox_Size.TabStop = false;
            this.GroupBox_Size.Text = "Size:";
            this.GroupBox_Size.Enter += new System.EventHandler(this.GroupBox_Size_Enter);
            // 
            // RadioButton_SizeLarge
            // 
            this.RadioButton_SizeLarge.AutoSize = true;
            this.RadioButton_SizeLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_SizeLarge.Location = new System.Drawing.Point(34, 84);
            this.RadioButton_SizeLarge.Name = "RadioButton_SizeLarge";
            this.RadioButton_SizeLarge.Size = new System.Drawing.Size(63, 20);
            this.RadioButton_SizeLarge.TabIndex = 2;
            this.RadioButton_SizeLarge.Text = "Large";
            this.RadioButton_SizeLarge.UseVisualStyleBackColor = true;
            this.RadioButton_SizeLarge.CheckedChanged += new System.EventHandler(this.RadioButton_SizeLarge_CheckedChanged);
            // 
            // RadioButton_SizeMeduim
            // 
            this.RadioButton_SizeMeduim.AutoSize = true;
            this.RadioButton_SizeMeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_SizeMeduim.Location = new System.Drawing.Point(34, 58);
            this.RadioButton_SizeMeduim.Name = "RadioButton_SizeMeduim";
            this.RadioButton_SizeMeduim.Size = new System.Drawing.Size(76, 20);
            this.RadioButton_SizeMeduim.TabIndex = 1;
            this.RadioButton_SizeMeduim.Text = "Meduim";
            this.RadioButton_SizeMeduim.UseVisualStyleBackColor = true;
            this.RadioButton_SizeMeduim.CheckedChanged += new System.EventHandler(this.RadioButton_SizeMeduim_CheckedChanged);
            // 
            // RadioButton_SizeSmall
            // 
            this.RadioButton_SizeSmall.AutoSize = true;
            this.RadioButton_SizeSmall.Checked = true;
            this.RadioButton_SizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_SizeSmall.Location = new System.Drawing.Point(34, 32);
            this.RadioButton_SizeSmall.Name = "RadioButton_SizeSmall";
            this.RadioButton_SizeSmall.Size = new System.Drawing.Size(62, 20);
            this.RadioButton_SizeSmall.TabIndex = 0;
            this.RadioButton_SizeSmall.TabStop = true;
            this.RadioButton_SizeSmall.Text = "Small";
            this.RadioButton_SizeSmall.UseVisualStyleBackColor = true;
            this.RadioButton_SizeSmall.CheckedChanged += new System.EventHandler(this.RadioButton_SizeSmall_CheckedChanged);
            // 
            // GroupBox_Toppings
            // 
            this.GroupBox_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsGreenPeppers);
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsOlives);
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsOnions);
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsTomatoes);
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsMushrooms);
            this.GroupBox_Toppings.Controls.Add(this.CheckBox_ToppingsExtraCheese);
            this.GroupBox_Toppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Toppings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_Toppings.Location = new System.Drawing.Point(343, 102);
            this.GroupBox_Toppings.Name = "GroupBox_Toppings";
            this.GroupBox_Toppings.Size = new System.Drawing.Size(285, 121);
            this.GroupBox_Toppings.TabIndex = 2;
            this.GroupBox_Toppings.TabStop = false;
            this.GroupBox_Toppings.Text = "Toppings:";
            this.GroupBox_Toppings.Enter += new System.EventHandler(this.GroupBox_Toppings_Enter);
            // 
            // CheckBox_ToppingsGreenPeppers
            // 
            this.CheckBox_ToppingsGreenPeppers.AutoSize = true;
            this.CheckBox_ToppingsGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsGreenPeppers.Location = new System.Drawing.Point(144, 85);
            this.CheckBox_ToppingsGreenPeppers.Name = "CheckBox_ToppingsGreenPeppers";
            this.CheckBox_ToppingsGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.CheckBox_ToppingsGreenPeppers.TabIndex = 5;
            this.CheckBox_ToppingsGreenPeppers.Text = "Green Peppers";
            this.CheckBox_ToppingsGreenPeppers.UseVisualStyleBackColor = true;
            this.CheckBox_ToppingsGreenPeppers.CheckedChanged += new System.EventHandler(this.CheckBox_ToppingsGreenPeppers_CheckedChanged);
            // 
            // CheckBox_ToppingsOlives
            // 
            this.CheckBox_ToppingsOlives.AutoSize = true;
            this.CheckBox_ToppingsOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsOlives.Location = new System.Drawing.Point(144, 59);
            this.CheckBox_ToppingsOlives.Name = "CheckBox_ToppingsOlives";
            this.CheckBox_ToppingsOlives.Size = new System.Drawing.Size(67, 20);
            this.CheckBox_ToppingsOlives.TabIndex = 4;
            this.CheckBox_ToppingsOlives.Text = "Olives";
            this.CheckBox_ToppingsOlives.UseVisualStyleBackColor = true;
            this.CheckBox_ToppingsOlives.CheckedChanged += new System.EventHandler(this.CheckBox_ToppingsOlives_CheckedChanged);
            // 
            // CheckBox_ToppingsOnions
            // 
            this.CheckBox_ToppingsOnions.AutoSize = true;
            this.CheckBox_ToppingsOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsOnions.Location = new System.Drawing.Point(144, 33);
            this.CheckBox_ToppingsOnions.Name = "CheckBox_ToppingsOnions";
            this.CheckBox_ToppingsOnions.Size = new System.Drawing.Size(71, 20);
            this.CheckBox_ToppingsOnions.TabIndex = 3;
            this.CheckBox_ToppingsOnions.Text = "Onions";
            this.CheckBox_ToppingsOnions.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ToppingsTomatoes
            // 
            this.CheckBox_ToppingsTomatoes.AutoSize = true;
            this.CheckBox_ToppingsTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsTomatoes.Location = new System.Drawing.Point(16, 84);
            this.CheckBox_ToppingsTomatoes.Name = "CheckBox_ToppingsTomatoes";
            this.CheckBox_ToppingsTomatoes.Size = new System.Drawing.Size(91, 20);
            this.CheckBox_ToppingsTomatoes.TabIndex = 2;
            this.CheckBox_ToppingsTomatoes.Text = "Tomatoes";
            this.CheckBox_ToppingsTomatoes.UseVisualStyleBackColor = true;
            this.CheckBox_ToppingsTomatoes.CheckedChanged += new System.EventHandler(this.CheckBox_ToppingsTomatoes_CheckedChanged);
            // 
            // CheckBox_ToppingsMushrooms
            // 
            this.CheckBox_ToppingsMushrooms.AutoSize = true;
            this.CheckBox_ToppingsMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsMushrooms.Location = new System.Drawing.Point(16, 58);
            this.CheckBox_ToppingsMushrooms.Name = "CheckBox_ToppingsMushrooms";
            this.CheckBox_ToppingsMushrooms.Size = new System.Drawing.Size(99, 20);
            this.CheckBox_ToppingsMushrooms.TabIndex = 1;
            this.CheckBox_ToppingsMushrooms.Text = "Mushrooms";
            this.CheckBox_ToppingsMushrooms.UseVisualStyleBackColor = true;
            this.CheckBox_ToppingsMushrooms.CheckedChanged += new System.EventHandler(this.CheckBox_ToppingsMushrooms_CheckedChanged);
            // 
            // CheckBox_ToppingsExtraCheese
            // 
            this.CheckBox_ToppingsExtraCheese.AutoSize = true;
            this.CheckBox_ToppingsExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ToppingsExtraCheese.Location = new System.Drawing.Point(16, 32);
            this.CheckBox_ToppingsExtraCheese.Name = "CheckBox_ToppingsExtraCheese";
            this.CheckBox_ToppingsExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.CheckBox_ToppingsExtraCheese.TabIndex = 0;
            this.CheckBox_ToppingsExtraCheese.Text = "Extra Cheese";
            this.CheckBox_ToppingsExtraCheese.UseVisualStyleBackColor = true;
            this.CheckBox_ToppingsExtraCheese.CheckedChanged += new System.EventHandler(this.CheckBox_ToppingsExtraCheese_CheckedChanged);
            // 
            // GroupBox_Crust
            // 
            this.GroupBox_Crust.Controls.Add(this.RadioButton_CrustThickCrust);
            this.GroupBox_Crust.Controls.Add(this.RadioButton_CrustThinCrust);
            this.GroupBox_Crust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Crust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_Crust.Location = new System.Drawing.Point(181, 109);
            this.GroupBox_Crust.Name = "GroupBox_Crust";
            this.GroupBox_Crust.Size = new System.Drawing.Size(144, 98);
            this.GroupBox_Crust.TabIndex = 3;
            this.GroupBox_Crust.TabStop = false;
            this.GroupBox_Crust.Text = "Crust Type:";
            this.GroupBox_Crust.Enter += new System.EventHandler(this.GroupBox_Crust_Enter);
            // 
            // RadioButton_CrustThickCrust
            // 
            this.RadioButton_CrustThickCrust.AutoSize = true;
            this.RadioButton_CrustThickCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_CrustThickCrust.Location = new System.Drawing.Point(34, 58);
            this.RadioButton_CrustThickCrust.Name = "RadioButton_CrustThickCrust";
            this.RadioButton_CrustThickCrust.Size = new System.Drawing.Size(94, 20);
            this.RadioButton_CrustThickCrust.TabIndex = 1;
            this.RadioButton_CrustThickCrust.Text = "Thick Crust";
            this.RadioButton_CrustThickCrust.UseVisualStyleBackColor = true;
            this.RadioButton_CrustThickCrust.CheckedChanged += new System.EventHandler(this.RadioButton_CrustThickCrust_CheckedChanged);
            // 
            // RadioButton_CrustThinCrust
            // 
            this.RadioButton_CrustThinCrust.AutoSize = true;
            this.RadioButton_CrustThinCrust.Checked = true;
            this.RadioButton_CrustThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_CrustThinCrust.Location = new System.Drawing.Point(34, 32);
            this.RadioButton_CrustThinCrust.Name = "RadioButton_CrustThinCrust";
            this.RadioButton_CrustThinCrust.Size = new System.Drawing.Size(87, 20);
            this.RadioButton_CrustThinCrust.TabIndex = 0;
            this.RadioButton_CrustThinCrust.TabStop = true;
            this.RadioButton_CrustThinCrust.Text = "Thin Crust";
            this.RadioButton_CrustThinCrust.UseVisualStyleBackColor = true;
            this.RadioButton_CrustThinCrust.CheckedChanged += new System.EventHandler(this.RadioButton_CrustThinCrust_CheckedChanged);
            // 
            // GroupBox_WhereToEat
            // 
            this.GroupBox_WhereToEat.Controls.Add(this.RadioButton_WhereToEatTakeaway);
            this.GroupBox_WhereToEat.Controls.Add(this.RadioButton_WhereToEatEatIn);
            this.GroupBox_WhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_WhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_WhereToEat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_WhereToEat.Location = new System.Drawing.Point(274, 260);
            this.GroupBox_WhereToEat.Name = "GroupBox_WhereToEat";
            this.GroupBox_WhereToEat.Size = new System.Drawing.Size(284, 78);
            this.GroupBox_WhereToEat.TabIndex = 4;
            this.GroupBox_WhereToEat.TabStop = false;
            this.GroupBox_WhereToEat.Text = "Where To Eat:";
            this.GroupBox_WhereToEat.Enter += new System.EventHandler(this.GroupBox_WhereToEat_Enter);
            // 
            // RadioButton_WhereToEatTakeaway
            // 
            this.RadioButton_WhereToEatTakeaway.AutoSize = true;
            this.RadioButton_WhereToEatTakeaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_WhereToEatTakeaway.Location = new System.Drawing.Point(151, 32);
            this.RadioButton_WhereToEatTakeaway.Name = "RadioButton_WhereToEatTakeaway";
            this.RadioButton_WhereToEatTakeaway.Size = new System.Drawing.Size(92, 20);
            this.RadioButton_WhereToEatTakeaway.TabIndex = 1;
            this.RadioButton_WhereToEatTakeaway.Text = "Takeaway";
            this.RadioButton_WhereToEatTakeaway.UseVisualStyleBackColor = true;
            this.RadioButton_WhereToEatTakeaway.CheckedChanged += new System.EventHandler(this.RadioButton_WhereToEatTakeaway_CheckedChanged);
            // 
            // RadioButton_WhereToEatEatIn
            // 
            this.RadioButton_WhereToEatEatIn.AutoSize = true;
            this.RadioButton_WhereToEatEatIn.Checked = true;
            this.RadioButton_WhereToEatEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_WhereToEatEatIn.Location = new System.Drawing.Point(34, 32);
            this.RadioButton_WhereToEatEatIn.Name = "RadioButton_WhereToEatEatIn";
            this.RadioButton_WhereToEatEatIn.Size = new System.Drawing.Size(61, 20);
            this.RadioButton_WhereToEatEatIn.TabIndex = 0;
            this.RadioButton_WhereToEatEatIn.TabStop = true;
            this.RadioButton_WhereToEatEatIn.Text = "Eat In";
            this.RadioButton_WhereToEatEatIn.UseVisualStyleBackColor = true;
            this.RadioButton_WhereToEatEatIn.CheckedChanged += new System.EventHandler(this.RadioButton_WhereToEatEatIn_CheckedChanged);
            // 
            // GroupBox_OrderSummary
            // 
            this.GroupBox_OrderSummary.Controls.Add(this.Label_TotalPrice);
            this.GroupBox_OrderSummary.Controls.Add(this.Label_OrderSummaryPrice);
            this.GroupBox_OrderSummary.Controls.Add(this.TextBox_OrderSummaryWhereToEat);
            this.GroupBox_OrderSummary.Controls.Add(this.Label_OrderSummaryWhereToEat);
            this.GroupBox_OrderSummary.Controls.Add(this.TextBox_OrderSummaryCrust);
            this.GroupBox_OrderSummary.Controls.Add(this.Label_OrderSummaryCrust);
            this.GroupBox_OrderSummary.Controls.Add(this.RichTextBox_OrderSummaryToppings);
            this.GroupBox_OrderSummary.Controls.Add(this.Label_OrderSummaryToppings);
            this.GroupBox_OrderSummary.Controls.Add(this.TextBox_OrderSummarySize);
            this.GroupBox_OrderSummary.Controls.Add(this.Label_OrderSummarySize);
            this.GroupBox_OrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_OrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_OrderSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_OrderSummary.Location = new System.Drawing.Point(647, 102);
            this.GroupBox_OrderSummary.Name = "GroupBox_OrderSummary";
            this.GroupBox_OrderSummary.Size = new System.Drawing.Size(226, 349);
            this.GroupBox_OrderSummary.TabIndex = 5;
            this.GroupBox_OrderSummary.TabStop = false;
            this.GroupBox_OrderSummary.Text = "Order Summary";
            this.GroupBox_OrderSummary.Enter += new System.EventHandler(this.GroupBox_OrderSummary_Enter);
            // 
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.AutoSize = true;
            this.Label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Label_TotalPrice.Location = new System.Drawing.Point(136, 300);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(31, 32);
            this.Label_TotalPrice.TabIndex = 9;
            this.Label_TotalPrice.Text = "0";
            this.Label_TotalPrice.Click += new System.EventHandler(this.Label_TotalPrice_Click);
            // 
            // Label_OrderSummaryPrice
            // 
            this.Label_OrderSummaryPrice.AutoSize = true;
            this.Label_OrderSummaryPrice.Location = new System.Drawing.Point(23, 268);
            this.Label_OrderSummaryPrice.Name = "Label_OrderSummaryPrice";
            this.Label_OrderSummaryPrice.Size = new System.Drawing.Size(95, 18);
            this.Label_OrderSummaryPrice.TabIndex = 8;
            this.Label_OrderSummaryPrice.Text = "Total Price:";
            this.Label_OrderSummaryPrice.Click += new System.EventHandler(this.Label_OrderSummaryPrice_Click);
            // 
            // TextBox_OrderSummaryWhereToEat
            // 
            this.TextBox_OrderSummaryWhereToEat.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBox_OrderSummaryWhereToEat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OrderSummaryWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OrderSummaryWhereToEat.Location = new System.Drawing.Point(142, 227);
            this.TextBox_OrderSummaryWhereToEat.Name = "TextBox_OrderSummaryWhereToEat";
            this.TextBox_OrderSummaryWhereToEat.Size = new System.Drawing.Size(78, 17);
            this.TextBox_OrderSummaryWhereToEat.TabIndex = 7;
            // 
            // Label_OrderSummaryWhereToEat
            // 
            this.Label_OrderSummaryWhereToEat.AutoSize = true;
            this.Label_OrderSummaryWhereToEat.Location = new System.Drawing.Point(6, 226);
            this.Label_OrderSummaryWhereToEat.Name = "Label_OrderSummaryWhereToEat";
            this.Label_OrderSummaryWhereToEat.Size = new System.Drawing.Size(117, 18);
            this.Label_OrderSummaryWhereToEat.TabIndex = 6;
            this.Label_OrderSummaryWhereToEat.Text = "Where To Eat:";
            this.Label_OrderSummaryWhereToEat.Click += new System.EventHandler(this.Label_OrderSummaryWhereToEat_Click);
            // 
            // TextBox_OrderSummaryCrust
            // 
            this.TextBox_OrderSummaryCrust.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBox_OrderSummaryCrust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OrderSummaryCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OrderSummaryCrust.Location = new System.Drawing.Point(83, 191);
            this.TextBox_OrderSummaryCrust.Name = "TextBox_OrderSummaryCrust";
            this.TextBox_OrderSummaryCrust.Size = new System.Drawing.Size(115, 17);
            this.TextBox_OrderSummaryCrust.TabIndex = 5;
            this.TextBox_OrderSummaryCrust.TextChanged += new System.EventHandler(this.TextBox_OrderSummaryCrust_TextChanged);
            // 
            // Label_OrderSummaryCrust
            // 
            this.Label_OrderSummaryCrust.AutoSize = true;
            this.Label_OrderSummaryCrust.Location = new System.Drawing.Point(23, 190);
            this.Label_OrderSummaryCrust.Name = "Label_OrderSummaryCrust";
            this.Label_OrderSummaryCrust.Size = new System.Drawing.Size(54, 18);
            this.Label_OrderSummaryCrust.TabIndex = 4;
            this.Label_OrderSummaryCrust.Text = "Crust:";
            this.Label_OrderSummaryCrust.Click += new System.EventHandler(this.Label_OrderSummaryCrust_Click);
            // 
            // RichTextBox_OrderSummaryToppings
            // 
            this.RichTextBox_OrderSummaryToppings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RichTextBox_OrderSummaryToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_OrderSummaryToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox_OrderSummaryToppings.Location = new System.Drawing.Point(34, 118);
            this.RichTextBox_OrderSummaryToppings.Name = "RichTextBox_OrderSummaryToppings";
            this.RichTextBox_OrderSummaryToppings.Size = new System.Drawing.Size(172, 58);
            this.RichTextBox_OrderSummaryToppings.TabIndex = 3;
            this.RichTextBox_OrderSummaryToppings.Text = "";
            this.RichTextBox_OrderSummaryToppings.TextChanged += new System.EventHandler(this.RichTextBox_OrderSummaryToppings_TextChanged);
            // 
            // Label_OrderSummaryToppings
            // 
            this.Label_OrderSummaryToppings.AutoSize = true;
            this.Label_OrderSummaryToppings.Location = new System.Drawing.Point(31, 87);
            this.Label_OrderSummaryToppings.Name = "Label_OrderSummaryToppings";
            this.Label_OrderSummaryToppings.Size = new System.Drawing.Size(82, 18);
            this.Label_OrderSummaryToppings.TabIndex = 2;
            this.Label_OrderSummaryToppings.Text = "Toppings:";
            this.Label_OrderSummaryToppings.Click += new System.EventHandler(this.Label_OrderSummaryToppings_Click);
            // 
            // TextBox_OrderSummarySize
            // 
            this.TextBox_OrderSummarySize.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBox_OrderSummarySize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OrderSummarySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OrderSummarySize.Location = new System.Drawing.Point(83, 46);
            this.TextBox_OrderSummarySize.Name = "TextBox_OrderSummarySize";
            this.TextBox_OrderSummarySize.Size = new System.Drawing.Size(64, 17);
            this.TextBox_OrderSummarySize.TabIndex = 1;
            this.TextBox_OrderSummarySize.TextChanged += new System.EventHandler(this.TextBox_OrderSummarySize_TextChanged);
            // 
            // Label_OrderSummarySize
            // 
            this.Label_OrderSummarySize.AutoSize = true;
            this.Label_OrderSummarySize.Location = new System.Drawing.Point(31, 46);
            this.Label_OrderSummarySize.Name = "Label_OrderSummarySize";
            this.Label_OrderSummarySize.Size = new System.Drawing.Size(46, 18);
            this.Label_OrderSummarySize.TabIndex = 0;
            this.Label_OrderSummarySize.Text = "Size:";
            this.Label_OrderSummarySize.Click += new System.EventHandler(this.Label_OrderSummarySize_Click);
            // 
            // Button_OrderPizza
            // 
            this.Button_OrderPizza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_OrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Button_OrderPizza.FlatAppearance.BorderSize = 2;
            this.Button_OrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OrderPizza.Location = new System.Drawing.Point(268, 383);
            this.Button_OrderPizza.Name = "Button_OrderPizza";
            this.Button_OrderPizza.Size = new System.Drawing.Size(124, 40);
            this.Button_OrderPizza.TabIndex = 6;
            this.Button_OrderPizza.Text = "Order Pizza";
            this.Button_OrderPizza.UseVisualStyleBackColor = false;
            this.Button_OrderPizza.Click += new System.EventHandler(this.Button_OrderPizza_Click);
            // 
            // Button_ResetForm
            // 
            this.Button_ResetForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_ResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Button_ResetForm.FlatAppearance.BorderSize = 2;
            this.Button_ResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ResetForm.Location = new System.Drawing.Point(448, 383);
            this.Button_ResetForm.Name = "Button_ResetForm";
            this.Button_ResetForm.Size = new System.Drawing.Size(124, 40);
            this.Button_ResetForm.TabIndex = 7;
            this.Button_ResetForm.Text = "Reset Form";
            this.Button_ResetForm.UseVisualStyleBackColor = false;
            this.Button_ResetForm.Click += new System.EventHandler(this.Button_ResetForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 251);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_ResetForm);
            this.Controls.Add(this.Button_OrderPizza);
            this.Controls.Add(this.GroupBox_OrderSummary);
            this.Controls.Add(this.GroupBox_WhereToEat);
            this.Controls.Add(this.GroupBox_Crust);
            this.Controls.Add(this.GroupBox_Toppings);
            this.Controls.Add(this.GroupBox_Size);
            this.Controls.Add(this.Label_MakeYourPizza);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Size.ResumeLayout(false);
            this.GroupBox_Size.PerformLayout();
            this.GroupBox_Toppings.ResumeLayout(false);
            this.GroupBox_Toppings.PerformLayout();
            this.GroupBox_Crust.ResumeLayout(false);
            this.GroupBox_Crust.PerformLayout();
            this.GroupBox_WhereToEat.ResumeLayout(false);
            this.GroupBox_WhereToEat.PerformLayout();
            this.GroupBox_OrderSummary.ResumeLayout(false);
            this.GroupBox_OrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_MakeYourPizza;
        private System.Windows.Forms.GroupBox GroupBox_Size;
        private System.Windows.Forms.RadioButton RadioButton_SizeSmall;
        private System.Windows.Forms.RadioButton RadioButton_SizeLarge;
        private System.Windows.Forms.RadioButton RadioButton_SizeMeduim;
        private System.Windows.Forms.GroupBox GroupBox_Toppings;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsExtraCheese;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsMushrooms;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsOnions;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsTomatoes;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsOlives;
        private System.Windows.Forms.CheckBox CheckBox_ToppingsGreenPeppers;
        private System.Windows.Forms.GroupBox GroupBox_Crust;
        private System.Windows.Forms.RadioButton RadioButton_CrustThickCrust;
        private System.Windows.Forms.RadioButton RadioButton_CrustThinCrust;
        private System.Windows.Forms.GroupBox GroupBox_WhereToEat;
        private System.Windows.Forms.RadioButton RadioButton_WhereToEatTakeaway;
        private System.Windows.Forms.RadioButton RadioButton_WhereToEatEatIn;
        private System.Windows.Forms.GroupBox GroupBox_OrderSummary;
        private System.Windows.Forms.Label Label_OrderSummarySize;
        private System.Windows.Forms.TextBox TextBox_OrderSummarySize;
        private System.Windows.Forms.Label Label_OrderSummaryToppings;
        private System.Windows.Forms.RichTextBox RichTextBox_OrderSummaryToppings;
        private System.Windows.Forms.Label Label_OrderSummaryCrust;
        private System.Windows.Forms.TextBox TextBox_OrderSummaryCrust;
        private System.Windows.Forms.Label Label_OrderSummaryWhereToEat;
        private System.Windows.Forms.TextBox TextBox_OrderSummaryWhereToEat;
        private System.Windows.Forms.Label Label_OrderSummaryPrice;
        private System.Windows.Forms.Label Label_TotalPrice;
        private System.Windows.Forms.Button Button_OrderPizza;
        private System.Windows.Forms.Button Button_ResetForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

