namespace softpro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxIdCus = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxIdCus
            // 
            this.textBoxIdCus.Location = new System.Drawing.Point(403, 24);
            this.textBoxIdCus.Name = "textBoxIdCus";
            this.textBoxIdCus.Size = new System.Drawing.Size(75, 20);
            this.textBoxIdCus.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(403, 217);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(403, 62);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirst.TabIndex = 3;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(403, 102);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 20);
            this.textBoxLast.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FistName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName";
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Location = new System.Drawing.Point(403, 188);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpDate.TabIndex = 8;
            this.buttonUpDate.Text = "Update";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(403, 129);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(13, 221);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(162, 147);
            this.dataGridViewRoom.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 378);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxIdCus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxIdCus;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
    }
}

