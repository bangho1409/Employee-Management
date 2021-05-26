namespace WindowsFormsApp2___bang_thong_tin_remake
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.job = new System.Windows.Forms.ComboBox();
            this.shift = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.job);
            this.groupBox1.Controls.Add(this.shift);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pay
            // 
            this.pay.FormattingEnabled = true;
            this.pay.Items.AddRange(new object[] {
            "15$/hour",
            "25$/hour",
            "30$/hour",
            "50$/hour"});
            this.pay.Location = new System.Drawing.Point(534, 76);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(164, 24);
            this.pay.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payrate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(444, 135);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(155, 23);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // job
            // 
            this.job.FormattingEnabled = true;
            this.job.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.job.Location = new System.Drawing.Point(534, 46);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(164, 24);
            this.job.TabIndex = 9;
            // 
            // shift
            // 
            this.shift.FormattingEnabled = true;
            this.shift.Items.AddRange(new object[] {
            "08:00 AM - 12:00 PM",
            "12:00 PM - 04:00 PM",
            "04:00 PM -  06:00 PM",
            "06:00 PM - 09:00 PM",
            "Full-Time 08:00 AM - 05:00 PM"});
            this.shift.Location = new System.Drawing.Point(534, 16);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(164, 24);
            this.shift.TabIndex = 8;
            this.shift.SelectedIndexChanged += new System.EventHandler(this.room_SelectedIndexChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(105, 135);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(254, 22);
            this.address.TabIndex = 7;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(105, 76);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(89, 22);
            this.age.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(105, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(254, 22);
            this.name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employees List";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(24, 259);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(265, 180);
            this.listbox.TabIndex = 8;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(348, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(434, 180);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox job;
        private System.Windows.Forms.ComboBox shift;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox pay;
        private System.Windows.Forms.Label label7;
    }
}

