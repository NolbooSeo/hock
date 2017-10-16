using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WF_App1
{
    [DefaultPropertyAttribute("SaveOnClose")]

    public class Property
    {


        // [File]
        private uint file_numberOfDataRecord = 0;
        private uint file_currentDataRecord = 0;

        // [Camera]
        private string cam_cameraType = "";
        private string cam_serialNumber = "";
        private string cam_detectorTmeperature = "";
        private string cam_cameraTemperature = "";

        // [Document Size]
        private string docSize_pixel = "";

        // [Data Acquisition]
        private string dataAcq_date = "";
        private string dataAcq_time = "";
        private uint dataAcq_index = 0;
        private string dataAcq_measurementRange = "";
        private string dataAcq_acquisitionFrequency = "";

        // [Measurement Object]
        private float measuerObj_emissivity = 0.0f;
        private float measuerObj_transmission = 0.0f;
        private float measuerObj_ambientTemperature = 0.0f;

        // [Scaling]
        //private 
        private uint scale_numberOfColor = 0;
        private float scale_maximum = 0.0f;
        private float scale_minimun = 0.0f;
        private float scale_isoTherm = 0.0f;

        // [Measuerment]
        private float measuer_HFOV = 0.0f;
        private float measuer_VFOV = 0.0f;
        private float measuer_incidnetAngle = 0.0f;
        private float measuer_distance = 0.0f;

        // [Data Logging]
        private string dataLog_rawDataLocation = "";
        private string dataLog_resultDataLocation = "";

        [CategoryAttribute("File"),
        DefaultValueAttribute("0"),
        ReadOnlyAttribute(true)]
        public uint NumberOfDataRecord
        {
            get { return file_numberOfDataRecord; }
            set { file_numberOfDataRecord = value; }
        }

        [CategoryAttribute("File"),
        DefaultValueAttribute("0"),
        ReadOnlyAttribute(true)]
        public uint CurrentDataRecord
        {
            get { return file_currentDataRecord; }
            set { file_currentDataRecord = value; }
        }

        [CategoryAttribute("Camera"),
        ReadOnlyAttribute(true)]
        public string CameraType
        {
            get { return cam_cameraType; }
            set { cam_cameraType = value; }
        }

        [CategoryAttribute("Camera"),
        ReadOnlyAttribute(true)]
        public string SerialNumber
        {
            get { return cam_serialNumber; }
            set { cam_serialNumber = value; }
        }

        [CategoryAttribute("Camera"),
        ReadOnlyAttribute(true)]
        public string DetectorTemperature
        {
            get { return cam_detectorTmeperature; }
            set { cam_detectorTmeperature = value; }
        }

        [CategoryAttribute("Camera"),
        ReadOnlyAttribute(true)]
        public string CameraTemperature
        {
            get { return cam_cameraTemperature; }
            set { cam_cameraTemperature = value; }
        }

        [CategoryAttribute("Document Size"),
        ReadOnlyAttribute(true)]
        public string Pixel
        {
            get { return docSize_pixel; }
            set { docSize_pixel = value; }
        }

        [CategoryAttribute("Data Acquisition"),
        ReadOnlyAttribute(true)]
        public string Date
        {
            get { return dataAcq_date; }
            set { dataAcq_date = value; }
        }

        [CategoryAttribute("Data Acquisition"),
        ReadOnlyAttribute(true)]
        public string Time
        {
            get { return dataAcq_time; }
            set { dataAcq_time = value; }
        }
       
        [CategoryAttribute("Data Acquisition"),
        DefaultValueAttribute("0"),
        ReadOnlyAttribute(true)]
        public uint Index
        {
            get { return dataAcq_index; }
            set { dataAcq_index = value; }
        }

        [CategoryAttribute("Data Acquisition"),
        ReadOnlyAttribute(true)]
        public string MeasurementRange
        {
            get { return dataAcq_measurementRange; }
            set { dataAcq_measurementRange = value; }
        }

        public class NameConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return true;
            }

            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(ComboData._datas);
            }
        }

        private string _cbData = "2,4,8,16,32,64,128,256,512";

        private void initCombo()
        {
            string[] data = "김,이,박,최,정,윤,장,비,방".Split(',');

            ComboData._datas = _cbData.Split(',');
        }
        

        [CategoryAttribute("Data Acquisition")]
        [Browsable(true)]
        [TypeConverter(typeof(NameConverter))]
        public string AcquisitionFrequency
        {
            get
            {
                string tmpstr = string.Empty;

                initCombo();

                if (dataAcq_acquisitionFrequency != "")
                    tmpstr = dataAcq_acquisitionFrequency;
                else
                {
                    Array.Sort(ComboData._datas);
                    tmpstr = ComboData._datas[0];
                }

                return tmpstr;
            }
            set
            {
                dataAcq_acquisitionFrequency = value;
            }
        }

        [CategoryAttribute("Measuerment Object")]
        public float Emissivity
        {
            get { return measuerObj_emissivity; }
            set { measuerObj_emissivity = value; }
        }

        [CategoryAttribute("Measuerment Object")]
        public float Transmission
        {
            get { return measuerObj_transmission; }
            set { measuerObj_transmission = value; }
        }

        [CategoryAttribute("Measuerment Object")]
        public float AmbientTemperature
        {
            get { return measuerObj_ambientTemperature; }
            set { measuerObj_ambientTemperature = value; }
        }

        //[CategoryAttribute("Scaling")]
        //public 

        [CategoryAttribute("Scaling")]
        public uint NumberOfColors
        {
            get { return scale_numberOfColor; }
            set { scale_numberOfColor = value; }
        }

        [CategoryAttribute("Scaling")]
        public float Maximum
        {
            get { return scale_maximum; }
            set { scale_maximum = value; }
        }

        [CategoryAttribute("Scaling")]
        public float Minimun
        {
            get { return scale_minimun; }
            set { scale_minimun = value; }
        }

        [CategoryAttribute("Scaling")]
        public float Iso_Therm
        {
            get { return scale_isoTherm; }
            set { scale_isoTherm = value; }
        }

        [CategoryAttribute("Measurement")]
        public float HFOV
        {
            get { return measuer_HFOV; }
            set { measuer_HFOV = value; }
        }

        [CategoryAttribute("Measurement")]
        public float VFOV
        {
            get { return measuer_VFOV; }
            set { measuer_VFOV = value; }
        }

        [CategoryAttribute("Measurement")]
        public float IncidentAngle
        {
            get { return measuer_incidnetAngle; }
            set { measuer_incidnetAngle = value; }
        }

        [CategoryAttribute("Measurement")]
        public float Distance
        {
            get { return measuer_distance; }
            set { measuer_distance = value; }
        }

        [CategoryAttribute("Data Logging")]
        public string RawData_Location
        {
            get { return dataLog_rawDataLocation; }
            set { dataLog_rawDataLocation = value; }
        }

        [CategoryAttribute("Data Logging")]
        public string ResultData_Location
        {
            get { return dataLog_resultDataLocation; }
            set { dataLog_resultDataLocation = value; }
        }


        public void println()
        {
            MessageBox.Show("클래스 연결 성공");
            
        }
    }

    internal class ComboData
    {
        internal static string[] _datas;
    }
}
