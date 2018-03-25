namespace Abrar_excel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbx_task = new System.Windows.Forms.TextBox();
            this.tbx_cname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.combo_st_hh = new System.Windows.Forms.ComboBox();
            this.combo_st_mm = new System.Windows.Forms.ComboBox();
            this.combo_st_ampm = new System.Windows.Forms.ComboBox();
            this.combo_et_ampm = new System.Windows.Forms.ComboBox();
            this.combo_et_mm = new System.Windows.Forms.ComboBox();
            this.combo_et_hh = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.rtbx_details = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbx_attendees = new System.Windows.Forms.TextBox();
            this.rtbx_contact_details = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dgv_display = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_task
            // 
            this.tbx_task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_task.Location = new System.Drawing.Point(111, 56);
            this.tbx_task.Name = "tbx_task";
            this.tbx_task.Size = new System.Drawing.Size(202, 20);
            this.tbx_task.TabIndex = 2;
            // 
            // tbx_cname
            // 
            this.tbx_cname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_cname.Location = new System.Drawing.Point(138, 27);
            this.tbx_cname.Name = "tbx_cname";
            this.tbx_cname.Size = new System.Drawing.Size(202, 20);
            this.tbx_cname.TabIndex = 4;
            this.tbx_cname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // combo_st_hh
            // 
            this.combo_st_hh.FormattingEnabled = true;
            this.combo_st_hh.Items.AddRange(new object[] {
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
            "12"});
            this.combo_st_hh.Location = new System.Drawing.Point(104, 111);
            this.combo_st_hh.Name = "combo_st_hh";
            this.combo_st_hh.Size = new System.Drawing.Size(50, 21);
            this.combo_st_hh.TabIndex = 9;
            // 
            // combo_st_mm
            // 
            this.combo_st_mm.FormattingEnabled = true;
            this.combo_st_mm.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "59"});
            this.combo_st_mm.Location = new System.Drawing.Point(160, 111);
            this.combo_st_mm.Name = "combo_st_mm";
            this.combo_st_mm.Size = new System.Drawing.Size(49, 21);
            this.combo_st_mm.TabIndex = 10;
            // 
            // combo_st_ampm
            // 
            this.combo_st_ampm.FormattingEnabled = true;
            this.combo_st_ampm.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.combo_st_ampm.Location = new System.Drawing.Point(215, 111);
            this.combo_st_ampm.Name = "combo_st_ampm";
            this.combo_st_ampm.Size = new System.Drawing.Size(54, 21);
            this.combo_st_ampm.TabIndex = 11;
            // 
            // combo_et_ampm
            // 
            this.combo_et_ampm.FormattingEnabled = true;
            this.combo_et_ampm.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.combo_et_ampm.Location = new System.Drawing.Point(215, 138);
            this.combo_et_ampm.Name = "combo_et_ampm";
            this.combo_et_ampm.Size = new System.Drawing.Size(54, 21);
            this.combo_et_ampm.TabIndex = 15;
            // 
            // combo_et_mm
            // 
            this.combo_et_mm.FormattingEnabled = true;
            this.combo_et_mm.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "59"});
            this.combo_et_mm.Location = new System.Drawing.Point(160, 138);
            this.combo_et_mm.Name = "combo_et_mm";
            this.combo_et_mm.Size = new System.Drawing.Size(49, 21);
            this.combo_et_mm.TabIndex = 13;
            // 
            // combo_et_hh
            // 
            this.combo_et_hh.FormattingEnabled = true;
            this.combo_et_hh.Items.AddRange(new object[] {
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
            "12"});
            this.combo_et_hh.Location = new System.Drawing.Point(104, 138);
            this.combo_et_hh.Name = "combo_et_hh";
            this.combo_et_hh.Size = new System.Drawing.Size(50, 21);
            this.combo_et_hh.TabIndex = 12;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(795, 569);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(365, 36);
            this.btn_submit.TabIndex = 27;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_serial);
            this.groupBox1.Controls.Add(this.tbx_task);
            this.groupBox1.Controls.Add(this.rtbx_details);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(22, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 171);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.Location = new System.Drawing.Point(108, 31);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(35, 13);
            this.lbl_serial.TabIndex = 36;
            this.lbl_serial.Text = "label1";
            this.lbl_serial.Click += new System.EventHandler(this.lbl_serial_Click);
            // 
            // rtbx_details
            // 
            this.rtbx_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbx_details.Location = new System.Drawing.Point(111, 88);
            this.rtbx_details.Multiline = true;
            this.rtbx_details.Name = "rtbx_details";
            this.rtbx_details.Size = new System.Drawing.Size(202, 71);
            this.rtbx_details.TabIndex = 33;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(16, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Details";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(16, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Serial no";
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(16, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Task";
            this.metroLabel2.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbx_attendees);
            this.groupBox2.Controls.Add(this.rtbx_contact_details);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.tbx_cname);
            this.groupBox2.Location = new System.Drawing.Point(402, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 171);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // rtbx_attendees
            // 
            this.rtbx_attendees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbx_attendees.Location = new System.Drawing.Point(138, 112);
            this.rtbx_attendees.Multiline = true;
            this.rtbx_attendees.Name = "rtbx_attendees";
            this.rtbx_attendees.Size = new System.Drawing.Size(202, 43);
            this.rtbx_attendees.TabIndex = 40;
            this.rtbx_attendees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbx_attendees_KeyDown);
            this.rtbx_attendees.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rtbx_attendees_PreviewKeyDown);
            // 
            // rtbx_contact_details
            // 
            this.rtbx_contact_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbx_contact_details.Location = new System.Drawing.Point(138, 59);
            this.rtbx_contact_details.Multiline = true;
            this.rtbx_contact_details.Name = "rtbx_contact_details";
            this.rtbx_contact_details.Size = new System.Drawing.Size(202, 43);
            this.rtbx_contact_details.TabIndex = 39;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(9, 119);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(76, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Attendees";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Company Name";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(9, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Contact Details";
            this.metroLabel5.UseStyleColors = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.combo_et_ampm);
            this.groupBox3.Controls.Add(this.combo_et_mm);
            this.groupBox3.Controls.Add(this.combo_et_hh);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.combo_st_ampm);
            this.groupBox3.Controls.Add(this.combo_st_hh);
            this.groupBox3.Controls.Add(this.combo_st_mm);
            this.groupBox3.Location = new System.Drawing.Point(795, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 171);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(8, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Start Date";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(6, 111);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(78, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Start Time";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(6, 140);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel9.TabIndex = 41;
            this.metroLabel9.Text = "End Time";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(6, 59);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "End Date";
            this.metroLabel7.UseStyleColors = true;
            // 
            // dgv_display
            // 
            this.dgv_display.AllowUserToAddRows = false;
            this.dgv_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_display.ColumnHeadersHeight = 30;
            this.dgv_display.Location = new System.Drawing.Point(23, 272);
            this.dgv_display.Name = "dgv_display";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_display.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.dgv_display.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_display.Size = new System.Drawing.Size(1137, 264);
            this.dgv_display.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 644);
            this.Controls.Add(this.dgv_display);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Daily Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_task;
        private System.Windows.Forms.TextBox tbx_cname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox combo_st_hh;
        private System.Windows.Forms.ComboBox combo_st_mm;
        private System.Windows.Forms.ComboBox combo_st_ampm;
        private System.Windows.Forms.ComboBox combo_et_ampm;
        private System.Windows.Forms.ComboBox combo_et_mm;
        private System.Windows.Forms.ComboBox combo_et_hh;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox rtbx_details;
        private System.Windows.Forms.TextBox rtbx_attendees;
        private System.Windows.Forms.TextBox rtbx_contact_details;
        private System.Windows.Forms.DataGridView dgv_display;
        private System.Windows.Forms.Label lbl_serial;
    }
}

