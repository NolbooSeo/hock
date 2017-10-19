using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_App1
{
    static class Constants
    {
        // ROI Mode
        public const int BasicMPointer = 0;
        public const int Rectangle = 1;
        public const int Ellipse = 2;
        public const int Polygon = 3;
        public const int Line = 4;
        public const int TempuraturePointer = 5;
        public const int ShowLabel = 6;
        public const int ShowMax = 7;
        public const int ShowMin = 8;

        // ROIListView 세로 및 가로 속성 개수
        public const int columnCount = 5;
        //public const int ROIListView_RowCount

        // Type of Device
        public const int DDAQ_DEVICE_TYPE_VIEW_100 = 1;
        public const int DDAQ_DEVICE_TYPE_VIEW_256 = 2;
        public const int DDAQ_DEVICE_TYPE_VIEW_320 = 3;
        public const int DDAQ_DEVICE_TYPE_MIDAS = 4;
        public const int DDAQ_DEVICE_TYPE_MODULE_128 = 10;
        public const int DDAQ_DEVICE_TYPE_LINE_128 = 11;
        public const int DDAQ_DEVICE_TYPE_LINE_256 = 12;
        public const int DDAQ_DEVICE_TYPE_HZK_160 = 13;
        public const int DDAQ_DEVICE_TYPE_HZK_256 = 14;
    }
}
