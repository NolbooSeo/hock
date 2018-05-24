using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TeeChart;
using System.Runtime.InteropServices;   //[DLLImport("xxx.dll")] 시 선언
using System.Reflection;


// DUMMY COMMENT FOR GIT TEST
// TEST 2

namespace WF_App1
{
    public partial class MainForm : Form
    {
        int ROI_Mode = 0; //  0. Basic mouse pointer  1. Rectangle   2. Ellipse   3. Polygon   4. Line   5. Tempurature Pointer
                          //  6. Show Label   7. Show max   8. Show min 
        int ROI_count = 0;

        uint m_nNumDetectDevices = 0;   // Number of Device

        ushort pSizeX = 0, pSizeY = 0;      // Total pixel size of camera 

        IntPtr hIRDX = new IntPtr();       // IRDX handle

        uint bufSize = 0;

        float pFrameBuffer = 0;

        uint img_step = 0;

        public MainForm()
        {
            InitializeComponent();

            Property property = new Property();
            PyroProperty.PropertySort = PropertySort.Categorized;
            PyroProperty.ToolbarVisible = false;
            PyroProperty.Text = "Parameters";
            
            PyroProperty.SelectedObject = property;
        }
        public static int DDAQ_MAX_DEVICES()
        {
            return 32;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.RemoveAt(1);

            list.Insert(1, 2.3f);
            list.Add("ABC");
            
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.BorderStyle = BorderStyle.None;

            TChart axTChart1 = new TChart();

            this.axTChart1.Series(0).Clear();

            for (int i = 0; i < 100; i++)
            {
                //chart.Series(0).AddXY(i, i * 10, "", Color.Red);
                this.axTChart1.Series(0).AddNullXY(i, i * 10, "");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            e.Graphics.DrawEllipse(pen, new Rectangle(0, 0, 100, 100));
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(105, 0, 100, 100));

        }


        private void axTChart1_OnAfterDraw(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //UseWaitCursor();
            Cursor.Current = Cursors.WaitCursor;


            m_nNumDetectDevices = DIASDAQ.DDAQ_DEVICE_DO_DETECTION();

            if (m_nNumDetectDevices <= 0 || m_nNumDetectDevices > 32 || DIASDAQ.DDAQ_DEVICE_DO_OPEN(m_nNumDetectDevices, null) != DIASDAQ.DDAQ_ERROR.NO_ERROR)
                return;

            Cursor.Current = Cursors.Default;

            if (m_nNumDetectDevices > 0)
            {
                MessageBox.Show("디바이스 연결 성공");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (m_nNumDetectDevices > 0)
            //{
            //    textBox1.Text = getIDString(1);
            //}


            //-----------------------------------------
            //DIASDAQ.DDAQ_SET_TEMPPRECISION();

            //DIASDAQ.DDAQ_IRDX_OBJECT_SET_EMISSIVITY();
            //DIASDAQ.DDAQ_IRDX_OBJECT_SET_TRANSMISSION();
            //DIASDAQ.DDAQ_IRDX_PALLET_SET_BAR();
            //DIASDAQ.DDAQ_IRDX_SCALE_SET_MINMAX();
            //DIASDAQ.DDAQ_IRDX_PALLET_SET_ISOTHERM();

            //DIASDAQ.DDAQ_IRDX_FILE_GET_NUMDATASETS();
            //DIASDAQ.DDAQ_IRDX_FILE_GET_CURDATASET();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_IDSTRING();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_ID();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_DETECTORTEMP();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_CAMERATEMP();
            //DIASDAQ.DDAQ_IRDX_PIXEL_GET_SIZE();
            //DIASDAQ.DDAQ_IRDX_ACQUISITION_GET_TIMESTAMP();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_MRANGEMINMAX();
            //DIASDAQ.DDAQ_IRDX_DEVICE_GET_INTERNALFPS();
            //DIASDAQ.DDAQ_IRDX_ACQUISITION_GET_AVERAGING();


            //-----------------------------------------







            DIASDAQ.DDAQ_ERROR error = DIASDAQ.DDAQ_DEVICE_DO_UPDATEDATA(m_nNumDetectDevices);

            if ( error != DIASDAQ.DDAQ_ERROR.NO_ERROR)
                return;
            
            if(DIASDAQ.DDAQ_IRDX_PIXEL_GET_DATA(hIRDX, ref pFrameBuffer, bufSize) != 0)
            {
                Bitmap bmp = GET_BITMAP(hIRDX);
                //bmp = new Bitmap((Image)bmp, new Size(picBox.Width, picBox.Height));
                pictureBox1.Image = (Image)bmp;
            }
            

        }
        private string getIDString(uint DevNo)
        {
            uint nResult;

            byte[] pBuf = new byte[64];
            char[] pID = new char[64];

            nResult = DIASDAQ.DDAQ_DEVICE_GET_IDSTRING(1, pBuf, 64);

            for (int i = 0; i < 64; i++)
            {
                pID[i] = (char)pBuf[i];
            }

            return new string(pID);
        }

        private void ThrowArray(int[] arr1, int[] arr2)
        {
            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        private void ThrowCArray(char[] arr1, char[] arr2)
        {
            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
           if( DIASDAQ.DDAQ_DEVICE_GET_IRDX(m_nNumDetectDevices, ref hIRDX) != DIASDAQ.DDAQ_ERROR.NO_ERROR)
                return;


            if (DIASDAQ.DDAQ_IRDX_PIXEL_GET_SIZE(hIRDX, ref pSizeX, ref pSizeY) != DIASDAQ.DDAQ_ERROR.NO_ERROR)
                return;


            //ushort numpi = pSizeX;
            uint numPix = (uint)pSizeX * pSizeY;
            bufSize = (uint)numPix * sizeof(float);

            pFrameBuffer = new float();
            //Marshal.FreeHGlobal(handle);

            //-------------------------------------------------------------------
            //IntPtr hirdx = new IntPtr();

            //string str = "H:\\PyroSoftM\\PyroSoftM\\POSCO\\saving_1.irdx";

            //DIASDAQ.DDAQ_IRDX_FILE_OPEN_READ(str, false, ref hIRDX);
            //Bitmap bmp = GET_BITMAP(hIRDX);
            //bmp = new Bitmap((Image)bmp, new Size(pictureBox1.Width, pictureBox1.Height));
            //pictureBox1.Image = (Image)bmp;
            //----------------------------------------------------------------------
        }

        private static void swap(ref uint a, ref uint b)
        {
            uint i = a; a = b; b = i;
        }

        private static Bitmap GET_BITMAP(IntPtr hIRDX)
        {
            IntPtr pbitsImage = new IntPtr();
            IntPtr bmiImage = new IntPtr();
            ushort width = 0, height = 0;
            if (DIASDAQ.DDAQ_IRDX_IMAGE_GET_BITMAP(hIRDX, ref width, ref height, out pbitsImage, out bmiImage) != DIASDAQ.DDAQ_ERROR.NO_ERROR)
            {
                return null; // failure
            }

            MethodInfo mi = typeof(Bitmap).GetMethod("FromGDIplus", BindingFlags.Static | BindingFlags.NonPublic);

            if (mi == null)
            {
                return null; // permission problem 
            }

            IntPtr pBmp = IntPtr.Zero;
            int status = DIASDAQ.GDIPLUS_GdipCreateBitmapFromGdiDib(bmiImage, pbitsImage, out pBmp);

            if ((status == 0) && (pBmp != IntPtr.Zero))
            {
                return (Bitmap)mi.Invoke(null, new object[] { pBmp }); // success 
            }
            else
            {
                return null; // failure
            }

        }

        private void toolB_addRect_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.Rectangle, toolB_addRect);
        }

        private void toolB_addEllipse_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.Ellipse, toolB_addEllipse);
        }

        private void toolB_addPolygon_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.Polygon, toolB_addPolygon);
        }

        private void toolB_addLine_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.Line, toolB_addLine);
        }

        private void toolB_addPointer_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.TempuraturePointer, toolB_addPointer);
        }

        private void toolB_showLabel_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.ShowLabel, toolB_showLabel);
        }

        private void toolB_showMaxTemp_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.ShowMax, toolB_showMaxTemp);
        }

        private void toolB_showMinTemp_Click(object sender, EventArgs e)
        {
            toolB_Check(ref ROI_Mode, Constants.ShowMin, toolB_showMinTemp);
        }
        
        private void toolB_Check(ref int ROI_Mode, int modeValue, ToolStripButton toolButton)   //툴바버튼 check 설정 및 해제
        {
            if (ROI_Mode != modeValue)
            {
                ROIModeUncheck(ROI_Mode);

                ROI_Mode = modeValue;
            }
            else
                ROI_Mode = Constants.BasicMPointer;
                

            if (toolButton.Checked == true)
            {
                toolButton.Checked = false;
            }
            else
            {
                toolButton.Checked = true;
            }
        }

        private void ROIModeUncheck(int ROI_Mode)   //선택되어질 버튼외에 타 버튼의 check를 해제
        {
            switch (ROI_Mode)
            {
                case Constants.Rectangle:
                    toolB_addRect.Checked = false;
                    break;
                case Constants.Ellipse:
                    toolB_addEllipse.Checked = false;
                    break;
                case Constants.Polygon:
                    toolB_addPolygon.Checked = false;
                    break;
                case Constants.Line:
                    toolB_addLine.Checked = false;
                    break;
                case Constants.TempuraturePointer:
                    toolB_addPointer.Checked = false;
                    break;
                case Constants.ShowLabel:
                    toolB_showLabel.Checked = false;
                    break;
                case Constants.ShowMax:
                    toolB_showMaxTemp.Checked = false;
                    break;
                case Constants.ShowMin:
                    toolB_showMinTemp.Checked = false;
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ROIListView.ColumnCount = Constants.columnCount;
            //ROIListView.RowCount =

            //ROIListView.Columns[0].Name = "Idx";
            //ROIListView.Columns[1].Name = "Value";
            //ROIListView.Columns[2].Name = "Minimum";
            //ROIListView.Columns[3].Name = "Maximum";
            //ROIListView.Columns[4].Name = "Average";

            
            string[] row0 = {"" + (++ROI_count), "333", "23.5", "45.3", "30.2" };
            if(ROIListView.Rows.Count > 0)
                ROIListView.Rows.Insert(0,row0);
            //ROIListView.Rows.Add(row0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DIASDAQ.DDAQ_ERROR error =  DIASDAQ.DDAQ_IRDX_FILE_SET_CURDATASET(hIRDX, img_step);
            img_step++;
        }

        private void toolB_ROIDataDelete_Click(object sender, EventArgs e)
        {
            if (this.ROIListView.SelectedRows.Count > 0 &&
                this.ROIListView.SelectedRows[0].Index !=
                this.ROIListView.Rows.Count - 1)
            {
                this.ROIListView.Rows.RemoveAt(
                    this.ROIListView.SelectedRows[0].Index);
            }
        }

        //public static unsafe bool DDAQ_DEVICE_GET_IRDXHandle(uint nDevNo, void** handle)
        //{
        //    if (DDAQ_DEVICE_GET_IRDX(nDevNo, handle) != 0)
        //        return false;

        //    return true;
        //}
    }
}
