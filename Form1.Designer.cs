namespace Learning_GUI
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
            this.addExpense = new System.Windows.Forms.Button();
            this.expenseBox = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addExpense
            // 
            this.addExpense.Location = new System.Drawing.Point(534, 103);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(89, 29);
            this.addExpense.TabIndex = 0;
            this.addExpense.Text = "add";
            this.addExpense.UseVisualStyleBackColor = true;
            this.addExpense.Click += new System.EventHandler(this.button1_Click);
            // 
            // expenseBox
            // 
            this.expenseBox.Location = new System.Drawing.Point(109, 102);
            this.expenseBox.Name = "expenseBox";
            this.expenseBox.Size = new System.Drawing.Size(151, 20);
            this.expenseBox.TabIndex = 1;
            this.expenseBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(292, 103);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(53, 20);
            this.quantity.TabIndex = 2;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(172, 177);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(35, 13);
            this.total.TabIndex = 3;
            this.total.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(656, 284);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.clearAll.Location = new System.Drawing.Point(567, 155);
            this.clearAll.Name = "button1";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 6;
            this.clearAll.Text = "clear all";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_btn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.expenseBox);
            this.Controls.Add(this.addExpense);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addExpense;
        private System.Windows.Forms.TextBox expenseBox;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearAll;
    }
}

