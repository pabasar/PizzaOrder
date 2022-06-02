namespace PizzaHut
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstChoice = new System.Windows.Forms.ListBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoPark = new System.Windows.Forms.RadioButton();
            this.rdoDeliver = new System.Windows.Forms.RadioButton();
            this.rdoTakeOut = new System.Windows.Forms.RadioButton();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstChoice);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(357, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // lstChoice
            // 
            this.lstChoice.FormattingEnabled = true;
            this.lstChoice.ItemHeight = 20;
            this.lstChoice.Location = new System.Drawing.Point(123, 85);
            this.lstChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstChoice.Name = "lstChoice";
            this.lstChoice.Size = new System.Drawing.Size(211, 84);
            this.lstChoice.Sorted = true;
            this.lstChoice.TabIndex = 1;
            this.lstChoice.SelectedIndexChanged += new System.EventHandler(this.lstChoice_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(123, 32);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 28);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLarge);
            this.groupBox2.Controls.Add(this.rdoMedium);
            this.groupBox2.Controls.Add(this.rdoSmall);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(397, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(337, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(233, 37);
            this.rdoLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(73, 24);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(120, 37);
            this.rdoMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(89, 24);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(24, 37);
            this.rdoSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(72, 24);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoThick);
            this.groupBox3.Controls.Add(this.rdoThin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(397, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(337, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(167, 55);
            this.rdoThick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(116, 24);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick Crust";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(40, 55);
            this.rdoThin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(108, 24);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin Crust";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkTomatoes);
            this.groupBox4.Controls.Add(this.chkPeppers);
            this.groupBox4.Controls.Add(this.chkOnions);
            this.groupBox4.Controls.Add(this.chkBlack);
            this.groupBox4.Controls.Add(this.chkMushrooms);
            this.groupBox4.Controls.Add(this.chkCheese);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 233);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(357, 143);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toppings";
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(185, 100);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(105, 24);
            this.chkTomatoes.TabIndex = 5;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(185, 66);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(144, 24);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(185, 33);
            this.chkOnions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(84, 24);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.Location = new System.Drawing.Point(24, 100);
            this.chkBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(125, 24);
            this.chkBlack.TabIndex = 2;
            this.chkBlack.Text = "Black Olives";
            this.chkBlack.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(24, 66);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(119, 24);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Muchrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(24, 33);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(132, 24);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoPark);
            this.groupBox5.Controls.Add(this.rdoDeliver);
            this.groupBox5.Controls.Add(this.rdoTakeOut);
            this.groupBox5.Controls.Add(this.rdoEatIn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(397, 239);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(337, 137);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Where to Eat";
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(167, 43);
            this.rdoPark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(133, 24);
            this.rdoPark.TabIndex = 3;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Park and Pick";
            this.rdoPark.UseVisualStyleBackColor = true;
            this.rdoPark.CheckedChanged += new System.EventHandler(this.rdoPark_CheckedChanged);
            // 
            // rdoDeliver
            // 
            this.rdoDeliver.AutoSize = true;
            this.rdoDeliver.Location = new System.Drawing.Point(167, 76);
            this.rdoDeliver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDeliver.Name = "rdoDeliver";
            this.rdoDeliver.Size = new System.Drawing.Size(83, 24);
            this.rdoDeliver.TabIndex = 2;
            this.rdoDeliver.TabStop = true;
            this.rdoDeliver.Text = "Deliver";
            this.rdoDeliver.UseVisualStyleBackColor = true;
            this.rdoDeliver.CheckedChanged += new System.EventHandler(this.rdoDeliver_CheckedChanged);
            // 
            // rdoTakeOut
            // 
            this.rdoTakeOut.AutoSize = true;
            this.rdoTakeOut.Location = new System.Drawing.Point(25, 76);
            this.rdoTakeOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTakeOut.Name = "rdoTakeOut";
            this.rdoTakeOut.Size = new System.Drawing.Size(98, 24);
            this.rdoTakeOut.TabIndex = 1;
            this.rdoTakeOut.TabStop = true;
            this.rdoTakeOut.Text = "Take Out";
            this.rdoTakeOut.UseVisualStyleBackColor = true;
            this.rdoTakeOut.CheckedChanged += new System.EventHandler(this.rdoTakeOut_CheckedChanged);
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(25, 43);
            this.rdoEatIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(73, 24);
            this.rdoEatIn.TabIndex = 0;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // btnTake
            // 
            this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.Location = new System.Drawing.Point(232, 402);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(144, 38);
            this.btnTake.TabIndex = 5;
            this.btnTake.Text = "Order";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(397, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 480);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstChoice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkBlack;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoPark;
        private System.Windows.Forms.RadioButton rdoDeliver;
        private System.Windows.Forms.RadioButton rdoTakeOut;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnExit;
    }
}

