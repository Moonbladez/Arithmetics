
namespace Arithmetics
{
    partial class arithmeticOperations
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
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondLabelNumber = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondNumberTextBox.Location = new System.Drawing.Point(179, 198);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(190, 21);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNumberTextBox.Location = new System.Drawing.Point(179, 135);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(190, 21);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(181, 271);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(190, 21);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLabel.Location = new System.Drawing.Point(174, 105);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(205, 27);
            this.firstNumberLabel.TabIndex = 3;
            this.firstNumberLabel.Text = "Enter First Number";
            // 
            // secondLabelNumber
            // 
            this.secondLabelNumber.AutoSize = true;
            this.secondLabelNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabelNumber.Location = new System.Drawing.Point(176, 168);
            this.secondLabelNumber.Name = "secondLabelNumber";
            this.secondLabelNumber.Size = new System.Drawing.Size(233, 27);
            this.secondLabelNumber.TabIndex = 4;
            this.secondLabelNumber.Text = "Enter Second Number";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(182, 241);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(76, 27);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Aquamarine;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(564, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.Aquamarine;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.Location = new System.Drawing.Point(564, 168);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.Aquamarine;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Location = new System.Drawing.Point(564, 213);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 8;
            this.divisionButton.Text = "Division";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Aquamarine;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Location = new System.Drawing.Point(564, 256);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(181, 332);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(190, 27);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // arithmeticOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondLabelNumber);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "arithmeticOperations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondLabelNumber;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button clearButton;
    }
}

