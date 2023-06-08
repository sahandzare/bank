namespace transfer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.transferbutton = new System.Windows.Forms.Button();
            this.senderr = new System.Windows.Forms.TextBox();
            this.reciever = new System.Windows.Forms.TextBox();
            this.amountmm = new System.Windows.Forms.TextBox();
            this.senderuser = new System.Windows.Forms.Label();
            this.recieveruser = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.transferHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.historybutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transferHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transferbutton
            // 
            this.transferbutton.Location = new System.Drawing.Point(38, 343);
            this.transferbutton.Name = "transferbutton";
            this.transferbutton.Size = new System.Drawing.Size(125, 29);
            this.transferbutton.TabIndex = 0;
            this.transferbutton.Text = "trasnfer";
            this.transferbutton.UseVisualStyleBackColor = true;
            this.transferbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // senderr
            // 
            this.senderr.Location = new System.Drawing.Point(34, 69);
            this.senderr.Name = "senderr";
            this.senderr.Size = new System.Drawing.Size(125, 27);
            this.senderr.TabIndex = 1;
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(34, 163);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(125, 27);
            this.reciever.TabIndex = 4;
            // 
            // amountmm
            // 
            this.amountmm.Location = new System.Drawing.Point(34, 248);
            this.amountmm.Name = "amountmm";
            this.amountmm.Size = new System.Drawing.Size(125, 27);
            this.amountmm.TabIndex = 5;
            // 
            // senderuser
            // 
            this.senderuser.AutoSize = true;
            this.senderuser.Location = new System.Drawing.Point(38, 36);
            this.senderuser.Name = "senderuser";
            this.senderuser.Size = new System.Drawing.Size(121, 20);
            this.senderuser.TabIndex = 6;
            this.senderuser.Text = "sender username";
            this.senderuser.Click += new System.EventHandler(this.label1_Click);
            // 
            // recieveruser
            // 
            this.recieveruser.AutoSize = true;
            this.recieveruser.Location = new System.Drawing.Point(34, 140);
            this.recieveruser.Name = "recieveruser";
            this.recieveruser.Size = new System.Drawing.Size(129, 20);
            this.recieveruser.TabIndex = 7;
            this.recieveruser.Text = "reciever username";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(61, 225);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(60, 20);
            this.amount.TabIndex = 10;
            this.amount.Text = "amount";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // transferHistoryDataGridView
            // 
            this.transferHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferHistoryDataGridView.Location = new System.Drawing.Point(504, 27);
            this.transferHistoryDataGridView.Name = "transferHistoryDataGridView";
            this.transferHistoryDataGridView.RowHeadersWidth = 51;
            this.transferHistoryDataGridView.RowTemplate.Height = 29;
            this.transferHistoryDataGridView.Size = new System.Drawing.Size(300, 188);
            this.transferHistoryDataGridView.TabIndex = 11;
            // 
            // historybutton
            // 
            this.historybutton.Location = new System.Drawing.Point(540, 229);
            this.historybutton.Name = "historybutton";
            this.historybutton.Size = new System.Drawing.Size(248, 29);
            this.historybutton.TabIndex = 12;
            this.historybutton.Text = "see history";
            this.historybutton.UseVisualStyleBackColor = true;
            this.historybutton.Click += new System.EventHandler(this.historybutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historybutton);
            this.Controls.Add(this.transferHistoryDataGridView);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.recieveruser);
            this.Controls.Add(this.senderuser);
            this.Controls.Add(this.amountmm);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.senderr);
            this.Controls.Add(this.transferbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button transferbutton;
        private TextBox senderr;
        private TextBox reciever;
        private TextBox amountmm;
        private Label senderuser;
        private Label recieveruser;
        private Label amount;
        private System.Windows.Forms.Timer timer;
        private DataGridView transferHistoryDataGridView;
        private Button historybutton;
        private Button button1;
    }
}