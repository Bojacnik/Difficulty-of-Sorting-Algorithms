using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; //Odkazy - Přidat odkaz - Microsoft Excel 16.0 Object Library

namespace SamostatnaPrace
{
    public partial class Form1 : Form
    {
        Excel.Application mujExcel;
        Excel.Workbooks sesityExcel;
        Excel.Workbook sesitExcel;
        Excel.Worksheet listExcel;
        Excel.Range oblastBunek;
        Excel.Chart listGraf;

        List<Data> DataBubble = new List<Data>();
        List<Data> DataQuick = new List<Data>();
        List<Data> DataInsertion = new List<Data>();
        List<Data> DataImprovedBubble = new List<Data>();
        List<Data> DataMergesort = new List<Data>();
        List<Data> DataMinMax = new List<Data>();


        public Form1()
        {
            InitializeComponent();
        }

        
        /*
        private void KillExcel()
        {
            this.mujExcel.Quit();
        }
        */

        private void btnLaunchExcel_Click(object sender, EventArgs e)
        {
            mujExcel = new Excel.Application(); //spustí se jako proces
            mujExcel.Visible = true;
            sesityExcel = mujExcel.Workbooks;
            sesitExcel = mujExcel.Workbooks.Add(Type.Missing); //přidám mezi sešity

            btnDrawGraphDifficulty.Enabled = true;
            btnLaunchExcel.Enabled = false;
        }

        private void btnDrawGraphDifficulty_Click(object sender, EventArgs e)
        {
            btnDrawGraphDifficulty.Enabled = false;

            testBubble();
            testQuick();
            testImprovedBubble();
            testInsertionSort();
            testMinMax();
            testMergesort();

            //Nastav data
            listExcel = sesitExcel.Sheets[1]; //Listováno od nuly

            //------------------------------------------------------------------------
            listExcel.Cells[1, 1] = "length"; 
            
            listExcel.Cells[1, 2] = "Bubblesort"; 
            for (int r = 1; r <= DataBubble.Count; r++)
            {
                listExcel.Cells[r + 1, 1] = DataBubble[r - 1].Length;
                listExcel.Cells[r + 1, 2] = DataBubble[r - 1].Time.ElapsedMilliseconds; 
            }

            listExcel.Cells[1, 3] = "ImpBubble";
            for (int r = 1; r <= DataImprovedBubble.Count; r++)
            {
                listExcel.Cells[r + 1, 3] = DataImprovedBubble[r - 1].Time.ElapsedMilliseconds;
            }

            listExcel.Cells[1, 4] = "Insertion"; 
            for (int r = 1; r <= DataInsertion.Count; r++)
            {
                listExcel.Cells[r + 1, 4] = DataInsertion[r - 1].Time.ElapsedMilliseconds;
            }

            listExcel.Cells[1, 5] = "MinMax";
            for (int r = 1; r <= DataMinMax.Count; r++)
            {
                listExcel.Cells[r + 1, 5] = DataMinMax[r - 1].Time.ElapsedMilliseconds;
            }

            listExcel.Cells[1, 6] = "MergeSort";
            for (int r = 1; r <= DataMergesort.Count; r++)
            {
                listExcel.Cells[r + 1, 6] = DataMergesort[r - 1].Time.ElapsedMilliseconds;
            }

            listExcel.Cells[1, 7] = "Quicksort";
            for (int r = 1; r <= DataQuick.Count; r++)
            {
                listExcel.Cells[r + 1, 7] = DataQuick[r - 1].Time.ElapsedMilliseconds;
            }

            //---------------------------------------------------------------------
            listGraf = (Excel.Chart)sesitExcel.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            listGraf.ChartType = Excel.XlChartType.xlXYScatterSmoothNoMarkers;
            listGraf.SetSourceData(listExcel.get_Range("A1", "G11"), Excel.XlRowCol.xlColumns);
           

            listGraf.HasTitle = true;
            listGraf.ChartTitle.Text = "Graf slozitosti";
            listGraf.ChartTitle.Font.Size = 20;   
        }

        private void testBubble()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataBubble.Add(Bubblesort.Sort(pole));
            }
        }

        private void testQuick()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataQuick.Add(Quicksort.Sort(pole));
            }
        }

        private void testInsertionSort()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataInsertion.Add(InsertionSort.Sort(pole));
            }
        }

        private void testImprovedBubble()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataImprovedBubble.Add(ImprovedBubblesort.Sort(pole));
            }
        }

        private void testMergesort()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataMergesort.Add(Mergesort.Sort(pole));
            }
        }

        private void testMinMax()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] pole = new int[10 * i * 10 * i];
                Fill.Array(pole);
                DataMinMax.Add(MinMax.Sort(pole));
            }
        }



    }
}
