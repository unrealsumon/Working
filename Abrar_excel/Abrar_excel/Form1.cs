using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Abrar_excel
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string serial,task,details,cname,cdetails,attendees,sdate,edate,stime,etime;

            serial = lbl_serial.Text.Replace(',','-');


            task = tbx_task.Text.Replace(',', '-');
            details = rtbx_details.Text.Replace(',', '-');
            cname = tbx_cname.Text.Replace(',', '-');
            cdetails = rtbx_contact_details.Text.Replace(',', '-');
            attendees = rtbx_attendees.Text.Replace(',', '-');
            sdate = dateTimePicker1.Text.Replace(',', '-');
            edate = dateTimePicker2.Text.Replace(',','-');
            stime = (combo_st_hh.Text + ":" + combo_st_mm.Text + combo_st_ampm.Text).Replace(',', '-'); 
            etime = (combo_et_hh.Text + ":" + combo_et_mm.Text +  combo_et_ampm.Text).Replace(',','-');


            int i = dgv_display.Rows.Count;
          string data = i.ToString()+","+task + "," + details + "," + cname + "," + cdetails + "," + attendees + "," + sdate + "," + edate + "," + stime + "," + etime +Environment.NewLine;
          File.AppendAllText(@"docs\daily_agenda.csv","");

            File.AppendAllText(@"docs\daily_agenda.csv",data );


            dgv_display.Rows.Clear();
            dgv_display.Columns.Clear();
            dgv_display.DataSource = null;
            dgv_display.Refresh();
            dgv_populate();
           
        
           dgv_display.Refresh();



           lbl_serial.Text = dgv_display.Rows.Count.ToString();


           dgv_display.Refresh();
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*
            dgv_display.Columns.Add("c1","Serial");
            dgv_display.Columns.Add("c2", "Task");
            dgv_display.Columns.Add("c3", "Details");
            dgv_display.Columns.Add("c4", "CompanyName");
            dgv_display.Columns.Add("c5", "ContactDetails");
            dgv_display.Columns.Add("c6", "Attendees");
            dgv_display.Columns.Add("c7", "StartDate");
            dgv_display.Columns.Add("c8", "EndDate");
            dgv_display.Columns.Add("c9", "StartTime");
            dgv_display.Columns.Add("c10", "EndTime");
            */
           
            string check = File.ReadAllText(@"docs\daily_agenda.csv");


            dgv_populate();

            lbl_serial.Text = dgv_display.Rows.Count.ToString();
        }


        void dgv_populate()
        {


            //if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {

                String sLine = "";

                try
                {
                    //Pass the file you selected with the OpenFileDialog control to
                    //the StreamReader Constructor.
                    System.IO.StreamReader FileStream = new System.IO.StreamReader(@"docs\daily_agenda.csv");
                    //You must set the value to false when you are programatically adding rows to
                    //a DataGridView.  If you need to allow the user to add rows, you
                    //can set the value back to true after you have populated the DataGridView
                    //  string FileStream = File.ReadAllText("d:/a.txt");
                    dgv_display.AllowUserToAddRows = false;

                    //Read the first line of the text file
                    sLine = FileStream.ReadLine();
                    //The Split Command splits a string into an array, based on the delimiter you pass.
                    //I chose to use a semi-colon for the text delimiter.
                    //Any character can be used as a delimeter in the split command.
                    string[] s = sLine.Split(',');

                    //In this example, I placed the field names in the first row.
                    //The for loop below is used to create the columns and use the text values in
                    //the first row for the column headings.
                    for (int i = 0; i <= s.Count() - 1; i++)
                    {
                        DataGridViewColumn colHold = new DataGridViewTextBoxColumn();
                        colHold.Name = "col" + System.Convert.ToString(i);
                        colHold.HeaderText = s[i].ToString();
                        dgv_display.Columns.Add(colHold);
                    }

                    //Read the next line in the text file in order to pass it to the
                    //while loop below
                    sLine = FileStream.ReadLine();
                    //The while loop reads each line of text.
                    while (sLine != null)
                    {
                        //Adds a new row to the DataGridView for each line of text.
                        dgv_display.Rows.Add();

                        //This for loop loops through the array in order to retrieve each
                        //line of text.
                        for (int i = 0; i <= s.Count() - 1; i++)
                        {
                            //Splits each line in the text file into a string array
                            s = sLine.Split(',');
                            //Sets the value of the cell to the value of the text retreived from the text file.
                            dgv_display.Rows[dgv_display.Rows.Count - 1].Cells[i].Value = s[i].ToString();
                        }
                        sLine = FileStream.ReadLine();
                    }
                    //Close the selected text file.
                    FileStream.Close();
                }
                catch (Exception err)
                {
                    //Display any errors in a Message Box.
                    System.Windows.Forms.MessageBox.Show("Error:  " + err.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void lbl_serial_Click(object sender, EventArgs e)
        {

        }

        private void rtbx_attendees_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void rtbx_attendees_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

    }



}
