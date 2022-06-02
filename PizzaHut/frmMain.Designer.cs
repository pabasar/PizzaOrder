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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lstChoice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.rdoTakeOut = new System.Windows.Forms.RadioButton();
            this.rdoDeliver = new System.Windows.Forms.RadioButton();
            this.rdoPark = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(92, 26);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(159, 24);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lstChoice
            // 
            this.lstChoice.FormattingEnabled = true;
            this.lstChoice.ItemHeight = 16;
            this.lstChoice.Location = new System.Drawing.Point(92, 69);
            this.lstChoice.Name = "lstChoice";
            this.lstChoice.Size = new System.Drawing.Size(159, 84);
            this.lstChoice.Sorted = true;
            this.lstChoice.TabIndex = 1;
            this.lstChoice.SelectedIndexChanged += new System.EventHandler(this.lstChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLarge);
            this.groupBox2.Controls.Add(this.rdoMedium);
            this.groupBox2.Controls.Add(this.rdoSmall);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(298, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(18, 30);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(60, 20);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(90, 30);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(74, 20);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(175, 30);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(61, 20);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoThick);
            this.groupBox3.Controls.Add(this.rdoThin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(298, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(30, 45);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(85, 20);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin Crust";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(125, 45);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(92, 20);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick Crust";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
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
            this.groupBox4.Location = new System.Drawing.Point(13, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toppings";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(18, 27);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(107, 20);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(18, 54);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(97, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Muchrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.Location = new System.Drawing.Point(18, 81);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(102, 20);
            this.chkBlack.TabIndex = 2;
            this.chkBlack.Text = "Black Olives";
            this.chkBlack.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(139, 27);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(69, 20);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(139, 54);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(119, 20);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(139, 81);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(89, 20);
            this.chkTomatoes.TabIndex = 5;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoPark);
            this.groupBox5.Controls.Add(this.rdoDeliver);
            this.groupBox5.Controls.Add(this.rdoTakeOut);
            this.groupBox5.Controls.Add(this.rdoEatIn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(298, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 111);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Where to Eat";
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(19, 35);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(59, 20);
            this.rdoEatIn.TabIndex = 0;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // rdoTakeOut
            // 
            this.rdoTakeOut.AutoSize = true;
            this.rdoTakeOut.Location = new System.Drawing.Point(19, 62);
            this.rdoTakeOut.Name = "rdoTakeOut";
            this.rdoTakeOut.Size = new System.Drawing.Size(81, 20);
            this.rdoTakeOut.TabIndex = 1;
            this.rdoTakeOut.TabStop = true;
            this.rdoTakeOut.Text = "Take Out";
            this.rdoTakeOut.UseVisualStyleBackColor = true;
            this.rdoTakeOut.CheckedChanged += new System.EventHandler(this.rdoTakeOut_CheckedChanged);
            // 
            // rdoDeliver
            // 
            this.rdoDeliver.AutoSize = true;
            this.rdoDeliver.Location = new System.Drawing.Point(125, 62);
            this.rdoDeliver.Name = "rdoDeliver";
            this.rdoDeliver.Size = new System.Drawing.Size(69, 20);
            this.rdoDeliver.TabIndex = 2;
            this.rdoDeliver.TabStop = true;
            this.rdoDeliver.Text = "Deliver";
            this.rdoDeliver.UseVisualStyleBackColor = true;
            this.rdoDeliver.CheckedChanged += new System.EventHandler(this.rdoDeliver_CheckedChanged);
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(125, 35);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(109, 20);
            this.rdoPark.TabIndex = 3;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Park and Pick";
            this.rdoPark.UseVisualStyleBackColor = true;
            this.rdoPark.CheckedChanged += new System.EventHandler(this.rdoPark_CheckedChanged);
            // 
            // btnTake
            // 
            this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.Location = new System.Drawing.Point(174, 327);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(108, 31);
            this.btnTake.TabIndex = 5;
            this.btnTake.Text = "Order";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(298, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 390);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "PizzaHut Order";
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

