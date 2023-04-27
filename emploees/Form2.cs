using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sobran
{
    public partial class Form2 : Form
    {
        DataTable table2 = new DataTable("");
        string dirPath2 = @"C:\Users\public\data\callouts\";
        DateTime time;
        DateTime now = DateTime.Now;
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
             
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int month = now.Month;
            int day = now.Day;


            table2.Columns.Add("Name", Type.GetType("System.String"));
            table2.Columns.Add("Date", Type.GetType("System.String"));

            dataGridView2.DataSource = table2;
              
            string[] csvLines = System.IO.File.ReadAllLines($"C:\\Users\\public\\data\\callouts\\callouts_({strReplace(dateTimePicker2.Text)}).csv");

            //populate the combobox
            foreach (string name in form1.getEmployees())
            {
                cmbEmps.Items.Add(name);
            }

            //populate the Grid Rows from csv file
            for (int i = 1; i < csvLines.Length; i++)
            {
                table2.Rows.Add(csvLines[i].Split(',')[0], csvLines[i].Split(',')[1]);
            }
        }

        private void cmbEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int yearNow = now.Year;
            int month = now.Month;
            int day = now.Day;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (cmbEmps.Text.Equals(dataGridView2.Rows[i].Cells[0].Value.ToString()))
                {
                    MessageBox.Show($"employee already marked for {month}/{day}/{yearNow}");
                    return;
                }
            }
            table2.Rows.Add(cmbEmps.Text, DateTime.Now.ToString("M/dd/yyyy"));
            exportCsvForm2();
        }

        public void exportCsvForm2()
        {
            int month = now.Month;
            int day = now.Day;

            if (dataGridView2.Rows.Count > -1)
            {

                string path = $"C:\\Users\\public\\data\\callouts\\callouts_({DateTime.Now.ToString("M_dd_yyyy")}).csv";
                bool fileError = false;

                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView2.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView2.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView2.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dataGridView2.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[i] += dataGridView2.Rows[i - 1].Cells[j].Value.ToString() + ",";
                            }
                        }

                        File.WriteAllLines(path, outputCsv, Encoding.UTF8);

                        //MessageBox.Show("Data Exported Successfully !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }

        }

        private void btnRecords2_Click(object sender, EventArgs e)
        {
            /*dateTimePicker1.Format = DateTimePickerFormat.Custom;
           Console.WriteLine(dateTimePicker1.Text);
           dateTimePicker1.CustomFormat = "MM/dd/yyyy";*/
            Console.WriteLine(dateTimePicker2.Text);
            string path = dirPath2;

            //creates an array of files ending with .csv
            var files = Directory.EnumerateFiles(path, "*.csv");

            string result = "";

            //loop through array of files 
            foreach (string file in files)
            {
                string[] csvLines = System.IO.File.ReadAllLines(file);
                for (int i = 1; i < csvLines.Length; i++)
                {

                    if (csvLines[i].Split(',')[1].Equals(dateTimePicker2.Text))
                    {
                        result += csvLines[i].Split(',')[0] + " , " + csvLines[i].Split(',')[1] + " , " + csvLines[i].Split(',')[2] + "\n\n";
                    }

                }
            }
            MessageBox.Show($"========= Records for {dateTimePicker2.Text} ==========\n\n" + result);
        }

        private void btnGenerateAll2_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "MM/dd/yyyy";



            string path = dirPath2;

            //creates an array of files ending with .csv
            var files = Directory.EnumerateFiles(dirPath2, "*.csv");

            //clear contents of csv file before populating
            System.IO.File.WriteAllText($"{dirPath2}\\all\\callouts_all.csv", string.Empty);

            //loop through array of files 
            foreach (string file in files)
            {
                string[] csvLines = System.IO.File.ReadAllLines(file);
                for (int i = 1; i < csvLines.Length; i++)
                {
                    using (System.IO.StreamWriter file2 = new StreamWriter($"{dirPath2}\\all\\callouts_all.csv", true))
                    {

                        file2.Write(csvLines[i] + "\n");

                    }

                }
            }
            //opens the file
            System.Diagnostics.Process.Start($"{dirPath2}\\all\\callouts_all.csv");
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("Nothing to delete");
                return;
            }
            int currentSelectionUser = dataGridView2.CurrentCell.RowIndex;

            DialogResult dialogResult = MessageBox.Show($"Are you sure to you want to delete {dataGridView2.Rows[currentSelectionUser].Cells[0].Value}?", "Confirm", MessageBoxButtons.YesNo);


            int index = 0;
            Console.WriteLine(dataGridView2.ColumnCount);
            if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("There are no more items");
            }
            else
            {
                if (dialogResult == DialogResult.Yes)
                {
                    index = dataGridView2.CurrentCell.RowIndex;
                    dataGridView2.Rows.RemoveAt(index);
                    exportCsvForm2();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnTardy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            int month = now.Month;
            int day = now.Day;
            System.Diagnostics.Process.Start($"{dirPath2}\\callouts_({DateTime.Now.ToString("M_dd_yyyy")}).csv");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            /*dateTimePicker1.Format = DateTimePickerFormat.Custom;
          Console.WriteLine(dateTimePicker1.Text);
          dateTimePicker1.CustomFormat = "MM/dd/yyyy";*/
            Console.WriteLine(dateTimePicker2.Text);
            string path = dirPath2;

            //creates an array of files ending with .csv
            var files = Directory.EnumerateFiles(path, "*.csv");

            string result = "";

            //loop through array of files 
            foreach (string file in files)
            {
                string[] csvLines = System.IO.File.ReadAllLines(file);
                for (int i = 1; i < csvLines.Length; i++)
                {

                    if (csvLines[i].Split(',')[1].Equals(dateTimePicker2.Text))
                    {
                        result += csvLines[i].Split(',')[0] + " , " + csvLines[i].Split(',')[1] + " , " + csvLines[i].Split(',')[2] + "\n\n";
                    }

                }
            }
            MessageBox.Show($"========= Records for {dateTimePicker2.Text} ==========\n\n" + result);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            /*dateTimePicker1.Format = DateTimePickerFormat.Custom;
            Console.WriteLine(dateTimePicker1.Text);
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";*/

            if (!File.Exists($"{dirPath2}\\callouts_({strReplace(dateTimePicker2.Text)}).csv"))
            {
                MessageBox.Show($"No reports found for {dateTimePicker2.Text}");
            }
            else
            {
                System.Diagnostics.Process.Start($"{dirPath2}\\callouts_({strReplace(dateTimePicker2.Text)}).csv");
            }
          
        }
    
        public string strReplace(string str)
        {
            return str.Replace('/', '_');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportCsvForm2();
            MessageBox.Show("Updated");
        }
    }
}
