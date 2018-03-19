namespace Store
{
    partial class petStore
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
            this.totalButton = new System.Windows.Forms.Button();
            this.dogInput = new System.Windows.Forms.TextBox();
            this.catInput = new System.Windows.Forms.TextBox();
            this.fishInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.catchLabel = new System.Windows.Forms.Label();
            this.dogsLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.fishLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.subTotalOutPut = new System.Windows.Forms.Label();
            this.taxOutPut = new System.Windows.Forms.Label();
            this.totalOutPut = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeOutPut = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(52, 185);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(206, 31);
            this.totalButton.TabIndex = 0;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dogInput
            // 
            this.dogInput.Location = new System.Drawing.Point(158, 67);
            this.dogInput.Name = "dogInput";
            this.dogInput.Size = new System.Drawing.Size(100, 22);
            this.dogInput.TabIndex = 1;
            // 
            // catInput
            // 
            this.catInput.Location = new System.Drawing.Point(158, 104);
            this.catInput.Name = "catInput";
            this.catInput.Size = new System.Drawing.Size(100, 22);
            this.catInput.TabIndex = 2;
            // 
            // fishInput
            // 
            this.fishInput.Location = new System.Drawing.Point(158, 145);
            this.fishInput.Name = "fishInput";
            this.fishInput.Size = new System.Drawing.Size(100, 22);
            this.fishInput.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(231, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 49);
            this.title.TabIndex = 4;
            this.title.Text = "Pet Store";
            // 
            // catchLabel
            // 
            this.catchLabel.AutoSize = true;
            this.catchLabel.Location = new System.Drawing.Point(300, 72);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(0, 17);
            this.catchLabel.TabIndex = 6;
            // 
            // dogsLabel
            // 
            this.dogsLabel.AutoSize = true;
            this.dogsLabel.Font = new System.Drawing.Font("ParkAvenue BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsLabel.Location = new System.Drawing.Point(45, 58);
            this.dogsLabel.Name = "dogsLabel";
            this.dogsLabel.Size = new System.Drawing.Size(84, 37);
            this.dogsLabel.TabIndex = 7;
            this.dogsLabel.Text = "Dogs:";
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("ParkAvenue BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.Location = new System.Drawing.Point(45, 95);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(68, 37);
            this.catLabel.TabIndex = 8;
            this.catLabel.Text = "Cats:";
            // 
            // fishLabel
            // 
            this.fishLabel.AutoSize = true;
            this.fishLabel.Font = new System.Drawing.Font("ParkAvenue BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishLabel.Location = new System.Drawing.Point(45, 134);
            this.fishLabel.Name = "fishLabel";
            this.fishLabel.Size = new System.Drawing.Size(74, 37);
            this.fishLabel.TabIndex = 9;
            this.fishLabel.Text = "Fish:";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(49, 231);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(73, 17);
            this.subTotalLabel.TabIndex = 10;
            this.subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(49, 311);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(49, 268);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(35, 17);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(49, 370);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(74, 17);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(52, 413);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(206, 34);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // subTotalOutPut
            // 
            this.subTotalOutPut.BackColor = System.Drawing.Color.White;
            this.subTotalOutPut.Location = new System.Drawing.Point(158, 231);
            this.subTotalOutPut.Name = "subTotalOutPut";
            this.subTotalOutPut.Size = new System.Drawing.Size(100, 23);
            this.subTotalOutPut.TabIndex = 15;
            // 
            // taxOutPut
            // 
            this.taxOutPut.BackColor = System.Drawing.Color.White;
            this.taxOutPut.Location = new System.Drawing.Point(157, 266);
            this.taxOutPut.Name = "taxOutPut";
            this.taxOutPut.Size = new System.Drawing.Size(102, 26);
            this.taxOutPut.TabIndex = 16;
            // 
            // totalOutPut
            // 
            this.totalOutPut.BackColor = System.Drawing.Color.White;
            this.totalOutPut.Location = new System.Drawing.Point(157, 311);
            this.totalOutPut.Name = "totalOutPut";
            this.totalOutPut.Size = new System.Drawing.Size(102, 23);
            this.totalOutPut.TabIndex = 17;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(158, 365);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 18;
            // 
            // changeOutPut
            // 
            this.changeOutPut.BackColor = System.Drawing.Color.White;
            this.changeOutPut.Location = new System.Drawing.Point(158, 476);
            this.changeOutPut.Name = "changeOutPut";
            this.changeOutPut.Size = new System.Drawing.Size(100, 23);
            this.changeOutPut.TabIndex = 19;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(49, 476);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(61, 17);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change:";
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Location = new System.Drawing.Point(52, 533);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(207, 37);
            this.ReceiptButton.TabIndex = 21;
            this.ReceiptButton.Text = "Print Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(329, 370);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(211, 40);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // petStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(650, 659);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeOutPut);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutPut);
            this.Controls.Add(this.taxOutPut);
            this.Controls.Add(this.subTotalOutPut);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.fishLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.dogsLabel);
            this.Controls.Add(this.catchLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fishInput);
            this.Controls.Add(this.catInput);
            this.Controls.Add(this.dogInput);
            this.Controls.Add(this.totalButton);
            this.Name = "petStore";
            this.Text = "Pet Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox dogInput;
        private System.Windows.Forms.TextBox catInput;
        private System.Windows.Forms.TextBox fishInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label catchLabel;
        private System.Windows.Forms.Label dogsLabel;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label fishLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label subTotalOutPut;
        private System.Windows.Forms.Label taxOutPut;
        private System.Windows.Forms.Label totalOutPut;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeOutPut;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Button newOrderButton;
    }
}

