using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortForm_v1
{
    public partial class frmSort : Form
    {
        List<String> myUnsortList = new List<String>();
        List<Sorter> mySorter;

        public frmSort()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            SortingMethod();

            string[] myNewaray = new string[mySorter.Count];

            //Matches the positon of the checkbox to that position of the array
            int pos = cmbSort.SelectedIndex;

            try
            {
                lstSorted.Items.Add(mySorter.ElementAt(pos).GetType().Name);
                lstSorted.Items.Add("=".PadRight(mySorter.ElementAt(pos).GetType().Name.ToString().Length, '='));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            foreach (Sorter item in mySorter)
            {
                if (mySorter[pos] == mySorter.ElementAt(pos))
                {
                    item.Sort();

                    myNewaray = item.Output();
                }

            }

            if (rdAsc.Checked)
            {
                for (int i = myNewaray.Length - 1; i >= 0; i--)
                {
                    lstSorted.Items.Add(myNewaray[i]);
                }
            }

            if (rdDsc.Checked)
            { 
                for (int i = 0; i < myNewaray.Length; i++)
                {
                    lstSorted.Items.Add(myNewaray[i]);
                }
            }




            lstSorted.Items.Add(mySorter.ElementAt(pos).TimeElpased());
            lstSorted.Items.Add(" ");
            toolStripProgressBar1.Value = 100;
        }

        private void btnData_Click(object sender, EventArgs e)
        {


            if (txtData.Text != "")
            {
                try
                {
                    lstUnsorted.Items.Add(txtData.Text);

                    myUnsortList.Add(txtData.Text);

                    txtData.Clear();


                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
            else
            {

                MessageBox.Show("Please input a value ");
            }
            btnDone.Enabled = true;
            toolStripStatusLabel1.Text = lstUnsorted.Items.Count.ToString() + " Items ";
            toolStripProgressBar1.Value = lstUnsorted.Items.Count;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                toolStripStatusLabel1.Text = "Lincoln Gachagua";
                toolStripProgressBar1.Value = 0;
                myUnsortList.Clear();
                lstUnsorted.DataSource = null;
                lstUnsorted.Items.Clear();
                lstSorted.Items.Clear();
                btnDone.Enabled = false;
            }
          
        }

        private void frmSort_Load(object sender, EventArgs e)
        {

            SortingMethod();


            foreach (Sorter item in mySorter)
            {
                cmbSort.Items.Add(item.GetType().Name.ToString());

            }

            cmbSort.SelectedIndex = 0;
        }

        private void SortingMethod()
        {
            mySorter = new List<Sorter>();

            mySorter.Add(new BubbleSorter(myUnsortList.ToArray()));
            mySorter.Add(new BuiltInSorter(myUnsortList.ToArray()));
            mySorter.Add(new InsertionSorter(myUnsortList.ToArray()));
            mySorter.Add(new SelectionSort(myUnsortList.ToArray()));
            mySorter.Add(new MergeSorter(myUnsortList.ToArray()));
            mySorter.Add(new ShellSorter(myUnsortList.ToArray()));

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string[] myFileArray = File.ReadAllLines(file);
                    myUnsortList = new List<string>();



                    lstUnsorted.DataSource = myFileArray;


                    for (int i = 0; i < lstUnsorted.Items.Count; i++)
                    {
                        myUnsortList.Add(lstUnsorted.Items[i].ToString());
                    }
                }
                catch (IOException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            toolStripStatusLabel1.Text = lstUnsorted.Items.Count.ToString() + " Items ";
            toolStripProgressBar1.Value = 50;
            btnDone.Enabled = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
