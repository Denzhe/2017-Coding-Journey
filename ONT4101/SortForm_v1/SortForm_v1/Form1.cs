using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            for (int i = 0; i < myNewaray.Length; i++)

            { 
                lstSorted.Items.Add(myNewaray[i]);


            }

           
            lstSorted.Items.Add(mySorter.ElementAt(pos).TimeElpased());
            lstSorted.Items.Add(" ");


        }

        private void btnData_Click(object sender, EventArgs e)
        {
            lstSorted.Items.Clear();

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myUnsortList.Clear();
            lstUnsorted.Items.Clear();
            lstSorted.Items.Clear();
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

            mySorter.Add(new InsertionSorter(myUnsortList.ToArray()));
            mySorter.Add(new SelectionSort(myUnsortList.ToArray()));
            mySorter.Add(new MergeSorter(myUnsortList.ToArray()));

        }
    }
}
