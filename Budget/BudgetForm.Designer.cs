namespace Budget
{
    partial class BudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetForm));
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.debit = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            this.lblmain = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbldebitcredit = new System.Windows.Forms.Label();
            this.debitcredit = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.incomeview = new System.Windows.Forms.ListView();
            this.description1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensesview = new System.Windows.Forms.ListView();
            this.description2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomelbl = new System.Windows.Forms.Label();
            this.expenseslbl = new System.Windows.Forms.Label();
            this.viewdetailsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(260, 300);
            this.amount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(140, 26);
            this.amount.TabIndex = 22;
            // 
            // debit
            // 
            this.debit.AutoSize = true;
            this.debit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit.ForeColor = System.Drawing.Color.White;
            this.debit.Location = new System.Drawing.Point(353, 190);
            this.debit.Name = "debit";
            this.debit.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.debit.Size = new System.Drawing.Size(20, 30);
            this.debit.TabIndex = 21;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.White;
            this.credit.Location = new System.Drawing.Point(353, 150);
            this.credit.Name = "credit";
            this.credit.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.credit.Size = new System.Drawing.Size(20, 30);
            this.credit.TabIndex = 20;
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.budget.Location = new System.Drawing.Point(368, 110);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(0, 24);
            this.budget.TabIndex = 19;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblmain.Location = new System.Drawing.Point(234, 70);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(333, 26);
            this.lblmain.TabIndex = 18;
            this.lblmain.Text = "Available budget in this month";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblamount.Location = new System.Drawing.Point(260, 270);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(56, 17);
            this.lblamount.TabIndex = 17;
            this.lblamount.Text = "Amount";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lbldescription.Location = new System.Drawing.Point(60, 270);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(108, 17);
            this.lbldescription.TabIndex = 16;
            this.lbldescription.Text = "Add Description";
            // 
            // lbldebitcredit
            // 
            this.lbldebitcredit.AutoSize = true;
            this.lbldebitcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebitcredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lbldebitcredit.Location = new System.Drawing.Point(460, 270);
            this.lbldebitcredit.Name = "lbldebitcredit";
            this.lbldebitcredit.Size = new System.Drawing.Size(125, 17);
            this.lbldebitcredit.TabIndex = 15;
            this.lbldebitcredit.Text = "Select Debit Credit";
            // 
            // debitcredit
            // 
            this.debitcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitcredit.FormattingEnabled = true;
            this.debitcredit.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.debitcredit.Location = new System.Drawing.Point(460, 300);
            this.debitcredit.Name = "debitcredit";
            this.debitcredit.Size = new System.Drawing.Size(140, 28);
            this.debitcredit.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(660, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(60, 300);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(140, 26);
            this.description.TabIndex = 12;
            // 
            // incomeview
            // 
            this.incomeview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.description1,
            this.amount1});
            this.incomeview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeview.HideSelection = false;
            this.incomeview.Location = new System.Drawing.Point(60, 425);
            this.incomeview.Name = "incomeview";
            this.incomeview.Size = new System.Drawing.Size(310, 200);
            this.incomeview.TabIndex = 23;
            this.incomeview.UseCompatibleStateImageBehavior = false;
            this.incomeview.View = System.Windows.Forms.View.Details;
            // 
            // description1
            // 
            this.description1.Text = "Description";
            this.description1.Width = 180;
            // 
            // amount1
            // 
            this.amount1.Text = "Amount";
            this.amount1.Width = 126;
            // 
            // expensesview
            // 
            this.expensesview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.description2,
            this.amount2});
            this.expensesview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesview.HideSelection = false;
            this.expensesview.Location = new System.Drawing.Point(430, 425);
            this.expensesview.Name = "expensesview";
            this.expensesview.Size = new System.Drawing.Size(310, 200);
            this.expensesview.TabIndex = 24;
            this.expensesview.UseCompatibleStateImageBehavior = false;
            this.expensesview.View = System.Windows.Forms.View.Details;
            // 
            // description2
            // 
            this.description2.Text = "Description";
            this.description2.Width = 180;
            // 
            // amount2
            // 
            this.amount2.Text = "Amount";
            this.amount2.Width = 126;
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.incomelbl.Location = new System.Drawing.Point(60, 385);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(53, 17);
            this.incomelbl.TabIndex = 25;
            this.incomelbl.Text = "Income";
            // 
            // expenseslbl
            // 
            this.expenseslbl.AutoSize = true;
            this.expenseslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expenseslbl.Location = new System.Drawing.Point(430, 385);
            this.expenseslbl.Name = "expenseslbl";
            this.expenseslbl.Size = new System.Drawing.Size(69, 17);
            this.expenseslbl.TabIndex = 26;
            this.expenseslbl.Text = "Expenses";
            // 
            // viewdetailsbtn
            // 
            this.viewdetailsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.viewdetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdetailsbtn.ForeColor = System.Drawing.Color.White;
            this.viewdetailsbtn.Location = new System.Drawing.Point(620, 655);
            this.viewdetailsbtn.Name = "viewdetailsbtn";
            this.viewdetailsbtn.Size = new System.Drawing.Size(120, 30);
            this.viewdetailsbtn.TabIndex = 27;
            this.viewdetailsbtn.Text = "View Details";
            this.viewdetailsbtn.UseVisualStyleBackColor = false;
            this.viewdetailsbtn.Click += new System.EventHandler(this.viewdetailsbtn_Click);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.viewdetailsbtn);
            this.Controls.Add(this.expenseslbl);
            this.Controls.Add(this.incomelbl);
            this.Controls.Add(this.expensesview);
            this.Controls.Add(this.incomeview);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.debit);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lbldebitcredit);
            this.Controls.Add(this.debitcredit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label debit;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbldebitcredit;
        private System.Windows.Forms.ComboBox debitcredit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ListView incomeview;
        private System.Windows.Forms.ColumnHeader description1;
        private System.Windows.Forms.ColumnHeader amount1;
        private System.Windows.Forms.ListView expensesview;
        private System.Windows.Forms.ColumnHeader description2;
        private System.Windows.Forms.ColumnHeader amount2;
        private System.Windows.Forms.Label incomelbl;
        private System.Windows.Forms.Label expenseslbl;
        private System.Windows.Forms.Button viewdetailsbtn;
    }
}