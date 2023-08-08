namespace WorkshopSelector_BagwellS
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
            this.typeOfWorkshopListBox = new System.Windows.Forms.ListBox();
            this.typeOfWorkshopLabel = new System.Windows.Forms.Label();
            this.workshopLocationLabel = new System.Windows.Forms.Label();
            this.workshopLocationListBox = new System.Windows.Forms.ListBox();
            this.costOutputLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.registrationCostOutputLabel = new System.Windows.Forms.Label();
            this.lodgingCostOutputLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeOfWorkshopListBox
            // 
            this.typeOfWorkshopListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfWorkshopListBox.FormattingEnabled = true;
            this.typeOfWorkshopListBox.ItemHeight = 20;
            this.typeOfWorkshopListBox.Items.AddRange(new object[] {
            "Handling Stress\t3 days\t$1,000",
            "Time Management\t3 days\t$800",
            "Supervision Skills\t3 days\t$1,500",
            "Negotiation\t5 days\t$1,300",
            "How to Interview\t1 days\t$500"});
            this.typeOfWorkshopListBox.Location = new System.Drawing.Point(24, 32);
            this.typeOfWorkshopListBox.Name = "typeOfWorkshopListBox";
            this.typeOfWorkshopListBox.ScrollAlwaysVisible = true;
            this.typeOfWorkshopListBox.Size = new System.Drawing.Size(294, 84);
            this.typeOfWorkshopListBox.TabIndex = 0;
            // 
            // typeOfWorkshopLabel
            // 
            this.typeOfWorkshopLabel.AutoSize = true;
            this.typeOfWorkshopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfWorkshopLabel.Location = new System.Drawing.Point(21, 9);
            this.typeOfWorkshopLabel.Name = "typeOfWorkshopLabel";
            this.typeOfWorkshopLabel.Size = new System.Drawing.Size(301, 20);
            this.typeOfWorkshopLabel.TabIndex = 1;
            this.typeOfWorkshopLabel.Text = "Workshop/ No. of Days / Registration Fee";
            // 
            // workshopLocationLabel
            // 
            this.workshopLocationLabel.AutoSize = true;
            this.workshopLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopLocationLabel.Location = new System.Drawing.Point(378, 9);
            this.workshopLocationLabel.Name = "workshopLocationLabel";
            this.workshopLocationLabel.Size = new System.Drawing.Size(175, 20);
            this.workshopLocationLabel.TabIndex = 2;
            this.workshopLocationLabel.Text = "Location/ Lodging Fees";
            // 
            // workshopLocationListBox
            // 
            this.workshopLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopLocationListBox.FormattingEnabled = true;
            this.workshopLocationListBox.ItemHeight = 20;
            this.workshopLocationListBox.Items.AddRange(new object[] {
            "Austin\t$150",
            "Chicago\t$225",
            "Dallas\t$175",
            "Orlando\t$300",
            "Phoenix\t$175",
            "Raliegh\t$150"});
            this.workshopLocationListBox.Location = new System.Drawing.Point(382, 32);
            this.workshopLocationListBox.Name = "workshopLocationListBox";
            this.workshopLocationListBox.Size = new System.Drawing.Size(139, 84);
            this.workshopLocationListBox.TabIndex = 3;
            // 
            // costOutputLabel
            // 
            this.costOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costOutputLabel.Location = new System.Drawing.Point(24, 136);
            this.costOutputLabel.Name = "costOutputLabel";
            this.costOutputLabel.Size = new System.Drawing.Size(294, 95);
            this.costOutputLabel.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(401, 131);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(91, 33);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(401, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registrationCostOutputLabel
            // 
            this.registrationCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationCostOutputLabel.Location = new System.Drawing.Point(31, 147);
            this.registrationCostOutputLabel.Name = "registrationCostOutputLabel";
            this.registrationCostOutputLabel.Size = new System.Drawing.Size(276, 24);
            this.registrationCostOutputLabel.TabIndex = 7;
            // 
            // lodgingCostOutputLabel
            // 
            this.lodgingCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingCostOutputLabel.Location = new System.Drawing.Point(31, 172);
            this.lodgingCostOutputLabel.Name = "lodgingCostOutputLabel";
            this.lodgingCostOutputLabel.Size = new System.Drawing.Size(276, 24);
            this.lodgingCostOutputLabel.TabIndex = 8;
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLabel.Location = new System.Drawing.Point(31, 196);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(276, 24);
            this.totalCostOutputLabel.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(401, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 33);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 262);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.lodgingCostOutputLabel);
            this.Controls.Add(this.registrationCostOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.costOutputLabel);
            this.Controls.Add(this.workshopLocationListBox);
            this.Controls.Add(this.workshopLocationLabel);
            this.Controls.Add(this.typeOfWorkshopLabel);
            this.Controls.Add(this.typeOfWorkshopListBox);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox typeOfWorkshopListBox;
        private System.Windows.Forms.Label typeOfWorkshopLabel;
        private System.Windows.Forms.Label workshopLocationLabel;
        private System.Windows.Forms.ListBox workshopLocationListBox;
        private System.Windows.Forms.Label costOutputLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label registrationCostOutputLabel;
        private System.Windows.Forms.Label lodgingCostOutputLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

