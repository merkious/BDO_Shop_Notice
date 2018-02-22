namespace ShopNoticeTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_notice = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox_msgBox = new System.Windows.Forms.CheckBox();
            this.comboBox_item_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown_time = new System.Windows.Forms.NumericUpDown();
            this.checkBox_enchant = new System.Windows.Forms.CheckBox();
            this.checkedListBox_enchant_lvl = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_lock = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_wycisz = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_notice
            // 
            this.button_notice.Location = new System.Drawing.Point(12, 64);
            this.button_notice.Name = "button_notice";
            this.button_notice.Size = new System.Drawing.Size(141, 57);
            this.button_notice.TabIndex = 0;
            this.button_notice.Text = "Notice ";
            this.button_notice.UseVisualStyleBackColor = true;
            this.button_notice.Click += new System.EventHandler(this.button_notice_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 186);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // checkBox_msgBox
            // 
            this.checkBox_msgBox.AutoSize = true;
            this.checkBox_msgBox.Location = new System.Drawing.Point(12, 127);
            this.checkBox_msgBox.Name = "checkBox_msgBox";
            this.checkBox_msgBox.Size = new System.Drawing.Size(100, 17);
            this.checkBox_msgBox.TabIndex = 2;
            this.checkBox_msgBox.Text = "Okno z powiad.";
            this.checkBox_msgBox.UseVisualStyleBackColor = true;
            // 
            // comboBox_item_list
            // 
            this.comboBox_item_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_item_list.FormattingEnabled = true;
            this.comboBox_item_list.Location = new System.Drawing.Point(12, 13);
            this.comboBox_item_list.Name = "comboBox_item_list";
            this.comboBox_item_list.Size = new System.Drawing.Size(141, 21);
            this.comboBox_item_list.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zm.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "usuń";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // numericUpDown_time
            // 
            this.numericUpDown_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_time.Location = new System.Drawing.Point(159, 64);
            this.numericUpDown_time.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_time.Name = "numericUpDown_time";
            this.numericUpDown_time.Size = new System.Drawing.Size(36, 24);
            this.numericUpDown_time.TabIndex = 6;
            this.numericUpDown_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_enchant
            // 
            this.checkBox_enchant.AutoSize = true;
            this.checkBox_enchant.Location = new System.Drawing.Point(13, 41);
            this.checkBox_enchant.Name = "checkBox_enchant";
            this.checkBox_enchant.Size = new System.Drawing.Size(97, 17);
            this.checkBox_enchant.TabIndex = 7;
            this.checkBox_enchant.Text = "Enchantowany";
            this.checkBox_enchant.UseVisualStyleBackColor = true;
            this.checkBox_enchant.CheckedChanged += new System.EventHandler(this.checkBox_enchant_CheckedChanged);
            // 
            // checkedListBox_enchant_lvl
            // 
            this.checkedListBox_enchant_lvl.CheckOnClick = true;
            this.checkedListBox_enchant_lvl.FormattingEnabled = true;
            this.checkedListBox_enchant_lvl.Items.AddRange(new object[] {
            "+0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10",
            "+11",
            "+12",
            "+13",
            "+14",
            "+15",
            "PRI",
            "DUO",
            "TRI",
            "TET",
            "PEN"});
            this.checkedListBox_enchant_lvl.Location = new System.Drawing.Point(209, 16);
            this.checkedListBox_enchant_lvl.Name = "checkedListBox_enchant_lvl";
            this.checkedListBox_enchant_lvl.Size = new System.Drawing.Size(90, 319);
            this.checkedListBox_enchant_lvl.TabIndex = 8;
            this.checkedListBox_enchant_lvl.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_enchant_lvl_ItemCheck);
            this.checkedListBox_enchant_lvl.Click += new System.EventHandler(this.checkedListBox_enchant_lvl_Click);
            this.checkedListBox_enchant_lvl.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_enchant_lvl_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(209, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Created by Merkious";
            // 
            // checkBox_lock
            // 
            this.checkBox_lock.AutoSize = true;
            this.checkBox_lock.Location = new System.Drawing.Point(177, 97);
            this.checkBox_lock.Name = "checkBox_lock";
            this.checkBox_lock.Size = new System.Drawing.Size(15, 14);
            this.checkBox_lock.TabIndex = 10;
            this.checkBox_lock.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_wycisz
            // 
            this.checkBox_wycisz.AutoSize = true;
            this.checkBox_wycisz.Location = new System.Drawing.Point(119, 128);
            this.checkBox_wycisz.Name = "checkBox_wycisz";
            this.checkBox_wycisz.Size = new System.Drawing.Size(60, 17);
            this.checkBox_wycisz.TabIndex = 12;
            this.checkBox_wycisz.Text = "Wycisz";
            this.checkBox_wycisz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 360);
            this.Controls.Add(this.checkBox_wycisz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_lock);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkedListBox_enchant_lvl);
            this.Controls.Add(this.checkBox_enchant);
            this.Controls.Add(this.numericUpDown_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_item_list);
            this.Controls.Add(this.checkBox_msgBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Notice alert";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_notice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox_msgBox;
        private System.Windows.Forms.ComboBox comboBox_item_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown numericUpDown_time;
        private System.Windows.Forms.CheckBox checkBox_enchant;
        private System.Windows.Forms.CheckedListBox checkedListBox_enchant_lvl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox_lock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_wycisz;
    }
}

