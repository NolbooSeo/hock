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




namespace WF_App1
{
    public partial class MainForm : Form
    {
        int ROI_Mode = 0; //  0. Basic mouse pointer  1. Rectangle   2. Ellipse   3. Polygon   4. Line   5. Tempurature Pointer
                          //  6. Show Label   7. Show max   8. Show min 
        int ROI_count = 0;

        uint m_nNumDetectDevices = 0;   // Number of Device

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
        
        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern uint DDAQ_DEVICE_DO_DETECTION();

        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint DDAQ_DEVICE_GET_IDSTRING(uint nDevNo, byte[] pBuf, int nBufSize);

        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint DDAQ_DEVICE_DO_UPDATEDATA(uint nDevNo);

        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint DDAQ_IRDX_PIXEL_GET_DATA(int hIRDX, float[] pData, uint BufSize);

        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern uint DDAQ_IRDX_PIXEL_GET_SIZE(IntPtr hIRDX, uint pSizex, uint pSizeY);

        [DllImport("DIASDAQ.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe uint DDAQ_DEVICE_GET_IRDX(uint nDevNo, out IntPtr handle);

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

            m_nNumDetectDevices = DDAQ_DEVICE_DO_DETECTION();

            Cursor.Current = Cursors.Default;

            if(m_nNumDetectDevices > 0)
            {
                MessageBox.Show("디바이스 연결 성공");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_nNumDetectDevices > 0)
            {
                textBox1.Text = getIDString(1);
            }
        }
        private string getIDString(uint DevNo)
        {
            uint nResult;

            byte[] pBuf = new byte[64];
            char[] pID = new char[64];

            nResult = DDAQ_DEVICE_GET_IDSTRING(1, pBuf, 64);
            /*
            unsafe
            {
                fixed (char* _pBuf = pBuf)
                    nResult = DDAQ_DEVICE_GET_IDSTRING(1, pBuf, 64);
            }
            */
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
            if (m_nNumDetectDevices <= 0)
                return;

            if (DDAQ_DEVICE_DO_UPDATEDATA(m_nNumDetectDevices) == 0)
                return;

            uint pSizeX = 0, pSizeY = 0;

            IntPtr handle;

            if (DDAQ_DEVICE_GET_IRDX(m_nNumDetectDevices, out handle) != 0)
                return;

            unsafe
            {
                IntPtr tmp = Marshal.AllocHGlobal(sizeof(long));

                void* handle2 = tmp.ToPointer();

                //if (!DDAQ_DEVICE_GET_IRDXHandle(m_nNumDetectDevices, &handle2))
                //    return;

                if (DDAQ_IRDX_PIXEL_GET_SIZE(handle, pSizeX, pSizeY) == 0)
                return;

                //Marshal.FreeHGlobal(handle);
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
            ROIListView.ColumnCount = Constants.ROIListView_ColumnCount;
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
