namespace Budget
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.detailslbl = new System.Windows.Forms.Label();
            this.daybox = new System.Windows.Forms.ComboBox();
            this.monthbox = new System.Windows.Forms.ComboBox();
            this.yearbox = new System.Windows.Forms.ComboBox();
            this.fetchbtn = new System.Windows.Forms.Button();
            this.recordsview = new System.Windows.Forms.ListView();
            this.description1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditdebit1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainscreenbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detailslbl
            // 
            this.detailslbl.AutoSize = true;
            this.detailslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.detailslbl.Location = new System.Drawing.Point(357, 70);
            this.detailslbl.Name = "detailslbl";
            this.detailslbl.Size = new System.Drawing.Size(86, 26);
            this.detailslbl.TabIndex = 0;
            this.detailslbl.Text = "Details";
            // 
            // daybox
            // 
            this.daybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daybox.FormattingEnabled = true;
            this.daybox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.daybox.Location = new System.Drawing.Point(50, 180);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(140, 28);
            this.daybox.TabIndex = 1;
            // 
            // monthbox
            // 
            this.monthbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthbox.FormattingEnabled = true;
            this.monthbox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthbox.Location = new System.Drawing.Point(240, 180);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(140, 28);
            this.monthbox.TabIndex = 2;
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearbox.FormattingEnabled = true;
            this.yearbox.Location = new System.Drawing.Point(430, 180);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(140, 28);
            this.yearbox.TabIndex = 3;
            // 
            // fetchbtn
            // 
            this.fetchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.fetchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchbtn.ForeColor = System.Drawing.Color.White;
            this.fetchbtn.Location = new System.Drawing.Point(620, 180);
            this.fetchbtn.Name = "fetchbtn";
            this.fetchbtn.Size = new System.Drawing.Size(130, 30);
            this.fetchbtn.TabIndex = 4;
            this.fetchbtn.Text = "Fetch Records";
            this.fetchbtn.UseVisualStyleBackColor = false;
            this.fetchbtn.Click += new System.EventHandler(this.fetchbtn_Click);
            // 
            // recordsview
            // 
            this.recordsview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.description1,
            this.amount1,
            this.creditdebit1,
            this.date1});
            this.recordsview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsview.HideSelection = false;
            this.recordsview.Location = new System.Drawing.Point(50, 250);
            this.recordsview.Name = "recordsview";
            this.recordsview.Size = new System.Drawing.Size(700, 420);
            this.recordsview.TabIndex = 5;
            this.recordsview.UseCompatibleStateImageBehavior = false;
            this.recordsview.View = System.Windows.Forms.View.Details;
            // 
            // description1
            // 
            this.description1.Text = "Description";
            this.description1.Width = 174;
            // 
            // amount1
            // 
            this.amount1.Text = "Amount";
            this.amount1.Width = 174;
            // 
            // creditdebit1
            // 
            this.creditdebit1.Text = "Credit or Debit";
            this.creditdebit1.Width = 174;
            // 
            // date1
            // 
            this.date1.Text = "Date";
            this.date1.Width = 174;
            // 
            // mainscreenbtn
            // 
            this.mainscreenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mainscreenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainscreenbtn.ForeColor = System.Drawing.Color.White;
            this.mainscreenbtn.Location = new System.Drawing.Point(590, 690);
            this.mainscreenbtn.Name = "mainscreenbtn";
            this.mainscreenbtn.Size = new System.Drawing.Size(160, 30);
            this.mainscreenbtn.TabIndex = 6;
            this.mainscreenbtn.Text = "Goto Main Screen";
            this.mainscreenbtn.UseVisualStyleBackColor = false;
            this.mainscreenbtn.Click += new System.EventHandler(this.mainscreenbtn_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.mainscreenbtn);
            this.Controls.Add(this.recordsview);
            this.Controls.Add(this.fetchbtn);
            this.Controls.Add(this.yearbox);
            this.Controls.Add(this.monthbox);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.detailslbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailslbl;
        private System.Windows.Forms.ComboBox daybox;
        private System.Windows.Forms.ComboBox monthbox;
        private System.Windows.Forms.ComboBox yearbox;
        private System.Windows.Forms.Button fetchbtn;
        private System.Windows.Forms.ListView recordsview;
        private System.Windows.Forms.ColumnHeader description1;
        private System.Windows.Forms.ColumnHeader amount1;
        private System.Windows.Forms.ColumnHeader creditdebit1;
        private System.Windows.Forms.ColumnHeader date1;
        private System.Windows.Forms.Button mainscreenbtn;
    }
}