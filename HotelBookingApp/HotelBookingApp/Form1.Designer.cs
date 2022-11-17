namespace HotelBookingApp
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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddToFile = new System.Windows.Forms.Button();
            this.buttonRemoveFromFile = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxClients = new System.Windows.Forms.TextBox();
            this.textBoxOccupancies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonDoorPrizes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(12, 105);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(142, 55);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Read in Hotel System";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1224, 388);
            this.listBox1.TabIndex = 1;
            // 
            // buttonAddToFile
            // 
            this.buttonAddToFile.Location = new System.Drawing.Point(150, 255);
            this.buttonAddToFile.Name = "buttonAddToFile";
            this.buttonAddToFile.Size = new System.Drawing.Size(162, 55);
            this.buttonAddToFile.TabIndex = 2;
            this.buttonAddToFile.Text = "Add To System";
            this.buttonAddToFile.UseVisualStyleBackColor = true;
            this.buttonAddToFile.Click += new System.EventHandler(this.buttonAddToFile_Click);
            // 
            // buttonRemoveFromFile
            // 
            this.buttonRemoveFromFile.Location = new System.Drawing.Point(504, 255);
            this.buttonRemoveFromFile.Name = "buttonRemoveFromFile";
            this.buttonRemoveFromFile.Size = new System.Drawing.Size(160, 55);
            this.buttonRemoveFromFile.TabIndex = 3;
            this.buttonRemoveFromFile.Text = "Remove From System";
            this.buttonRemoveFromFile.UseVisualStyleBackColor = true;
            this.buttonRemoveFromFile.Click += new System.EventHandler(this.buttonRemoveFromFile_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(12, 168);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(142, 55);
            this.buttonDisplay.TabIndex = 4;
            this.buttonDisplay.Text = "Display Hotel System";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(150, 229);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(170, 20);
            this.textBoxRooms.TabIndex = 5;
            // 
            // textBoxClients
            // 
            this.textBoxClients.Location = new System.Drawing.Point(505, 229);
            this.textBoxClients.Name = "textBoxClients";
            this.textBoxClients.Size = new System.Drawing.Size(208, 20);
            this.textBoxClients.TabIndex = 6;
            // 
            // textBoxOccupancies
            // 
            this.textBoxOccupancies.Location = new System.Drawing.Point(868, 229);
            this.textBoxOccupancies.Name = "textBoxOccupancies";
            this.textBoxOccupancies.Size = new System.Drawing.Size(210, 20);
            this.textBoxOccupancies.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Occupants";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 38);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(142, 61);
            this.buttonLoadFile.TabIndex = 11;
            this.buttonLoadFile.Text = "Load Hotel System File";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonDoorPrizes
            // 
            this.buttonDoorPrizes.Location = new System.Drawing.Point(868, 255);
            this.buttonDoorPrizes.Name = "buttonDoorPrizes";
            this.buttonDoorPrizes.Size = new System.Drawing.Size(159, 55);
            this.buttonDoorPrizes.TabIndex = 12;
            this.buttonDoorPrizes.Text = "Show Door Prize Winners";
            this.buttonDoorPrizes.UseVisualStyleBackColor = true;
            this.buttonDoorPrizes.Click += new System.EventHandler(this.buttonDoorPrizes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1007, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "The Continental at Lake Tahoe, Hotel Room Booking System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1248, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDoorPrizes);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOccupancies);
            this.Controls.Add(this.textBoxClients);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonRemoveFromFile);
            this.Controls.Add(this.buttonAddToFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddToFile;
        private System.Windows.Forms.Button buttonRemoveFromFile;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxClients;
        private System.Windows.Forms.TextBox textBoxOccupancies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonDoorPrizes;
        private System.Windows.Forms.Label label4;
    }
}

