namespace WF_App1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_chrtCreate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.menu_PyroSoft = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openIRDXOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.최근사용파일ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showMinMaxPointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rOIREFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOI그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEF그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.이동모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rOI지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEF지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToNearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveOnStepToNearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveOneStepToFarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToFarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구모음및도킹창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자리선택자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitC_generalView = new System.Windows.Forms.SplitContainer();
            this.PyroProperty = new System.Windows.Forms.PropertyGrid();
            this.splitC_display = new System.Windows.Forms.SplitContainer();
            this.splitC_view = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_startAcq = new System.Windows.Forms.Button();
            this.btn_camConnect = new System.Windows.Forms.Button();
            this.btn_arrFW = new System.Windows.Forms.Button();
            this.axTChart1 = new AxTeeChart.AxTChart();
            this.toolS_ROI = new System.Windows.Forms.ToolStrip();
            this.toolB_addRect = new System.Windows.Forms.ToolStripButton();
            this.toolB_addEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolB_addPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolB_addLine = new System.Windows.Forms.ToolStripButton();
            this.toolB_addPointer = new System.Windows.Forms.ToolStripButton();
            this.toolSeperator_ROI = new System.Windows.Forms.ToolStripSeparator();
            this.toolB_showLabel = new System.Windows.Forms.ToolStripButton();
            this.toolB_showMaxTemp = new System.Windows.Forms.ToolStripButton();
            this.toolB_showMinTemp = new System.Windows.Forms.ToolStripButton();
            this.ROIListView = new System.Windows.Forms.DataGridView();
            this.tools_mainFrm = new System.Windows.Forms.ToolStrip();
            this.toolB_online = new System.Windows.Forms.ToolStripButton();
            this.toolB_open = new System.Windows.Forms.ToolStripButton();
            this.toolB_save = new System.Windows.Forms.ToolStripButton();
            this.toolB_help = new System.Windows.Forms.ToolStripButton();
            this.toolS_dataAcq = new System.Windows.Forms.ToolStrip();
            this.toolB_Acq = new System.Windows.Forms.ToolStripButton();
            this.toolB_stop = new System.Windows.Forms.ToolStripButton();
            this.toolS_DataPlayer = new System.Windows.Forms.ToolStrip();
            this.toolB_previous = new System.Windows.Forms.ToolStripButton();
            this.toolB_next = new System.Windows.Forms.ToolStripButton();
            this.toolB_play = new System.Windows.Forms.ToolStripButton();
            this.toolS_camFocus = new System.Windows.Forms.ToolStrip();
            this.toolB_zeroFocus = new System.Windows.Forms.ToolStripButton();
            this.toolB_prevFocus = new System.Windows.Forms.ToolStripButton();
            this.toolB_nextFocus = new System.Windows.Forms.ToolStripButton();
            this.toolB_endFocus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolB_ROIDataOpen = new System.Windows.Forms.ToolStripButton();
            this.toolB_ROIDataSave = new System.Windows.Forms.ToolStripButton();
            this.toolB_ROIDataDelete = new System.Windows.Forms.ToolStripButton();
            this.menu_PyroSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_generalView)).BeginInit();
            this.splitC_generalView.Panel1.SuspendLayout();
            this.splitC_generalView.Panel2.SuspendLayout();
            this.splitC_generalView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_display)).BeginInit();
            this.splitC_display.Panel1.SuspendLayout();
            this.splitC_display.Panel2.SuspendLayout();
            this.splitC_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_view)).BeginInit();
            this.splitC_view.Panel1.SuspendLayout();
            this.splitC_view.Panel2.SuspendLayout();
            this.splitC_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).BeginInit();
            this.toolS_ROI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ROIListView)).BeginInit();
            this.tools_mainFrm.SuspendLayout();
            this.toolS_dataAcq.SuspendLayout();
            this.toolS_DataPlayer.SuspendLayout();
            this.toolS_camFocus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chrtCreate
            // 
            this.btn_chrtCreate.Location = new System.Drawing.Point(3, 3);
            this.btn_chrtCreate.Name = "btn_chrtCreate";
            this.btn_chrtCreate.Size = new System.Drawing.Size(140, 44);
            this.btn_chrtCreate.TabIndex = 0;
            this.btn_chrtCreate.Text = "TChart 생성";
            this.btn_chrtCreate.UseVisualStyleBackColor = true;
            this.btn_chrtCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(3, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "label1";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // menu_PyroSoft
            // 
            this.menu_PyroSoft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataLoggingToolStripMenuItem,
            this.dataPlayerToolStripMenuItem,
            this.rOIREFToolStripMenuItem,
            this.focusToolStripMenuItem,
            this.viewVToolStripMenuItem,
            this.windowWToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menu_PyroSoft.Location = new System.Drawing.Point(0, 0);
            this.menu_PyroSoft.Name = "menu_PyroSoft";
            this.menu_PyroSoft.Size = new System.Drawing.Size(1263, 24);
            this.menu_PyroSoft.TabIndex = 3;
            this.menu_PyroSoft.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOnlineToolStripMenuItem,
            this.newSimulationToolStripMenuItem,
            this.openIRDXOToolStripMenuItem,
            this.closeCToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.saveAsAToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.최근사용파일ToolStripMenuItem,
            this.exitXToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newOnlineToolStripMenuItem
            // 
            this.newOnlineToolStripMenuItem.Name = "newOnlineToolStripMenuItem";
            this.newOnlineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newOnlineToolStripMenuItem.Text = "New : Online";
            // 
            // newSimulationToolStripMenuItem
            // 
            this.newSimulationToolStripMenuItem.Name = "newSimulationToolStripMenuItem";
            this.newSimulationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newSimulationToolStripMenuItem.Text = "New : Simulation";
            // 
            // openIRDXOToolStripMenuItem
            // 
            this.openIRDXOToolStripMenuItem.Name = "openIRDXOToolStripMenuItem";
            this.openIRDXOToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openIRDXOToolStripMenuItem.Text = "Open IRDX(&O)";
            // 
            // closeCToolStripMenuItem
            // 
            this.closeCToolStripMenuItem.Name = "closeCToolStripMenuItem";
            this.closeCToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeCToolStripMenuItem.Text = "Close(&C)";
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveSToolStripMenuItem.Text = "Save(&S)";
            // 
            // saveAsAToolStripMenuItem
            // 
            this.saveAsAToolStripMenuItem.Name = "saveAsAToolStripMenuItem";
            this.saveAsAToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsAToolStripMenuItem.Text = "Save As(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "최근 사용 파일";
            // 
            // 최근사용파일ToolStripMenuItem
            // 
            this.최근사용파일ToolStripMenuItem.Name = "최근사용파일ToolStripMenuItem";
            this.최근사용파일ToolStripMenuItem.Size = new System.Drawing.Size(164, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            // 
            // dataLoggingToolStripMenuItem
            // 
            this.dataLoggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator2,
            this.showMinMaxPointerToolStripMenuItem});
            this.dataLoggingToolStripMenuItem.Name = "dataLoggingToolStripMenuItem";
            this.dataLoggingToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.dataLoggingToolStripMenuItem.Text = "Data &Logging";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // showMinMaxPointerToolStripMenuItem
            // 
            this.showMinMaxPointerToolStripMenuItem.Name = "showMinMaxPointerToolStripMenuItem";
            this.showMinMaxPointerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showMinMaxPointerToolStripMenuItem.Text = "Show Min/Max Pointer";
            // 
            // dataPlayerToolStripMenuItem
            // 
            this.dataPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousRecordToolStripMenuItem,
            this.nextRecordToolStripMenuItem,
            this.toolStripSeparator3,
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem1});
            this.dataPlayerToolStripMenuItem.Name = "dataPlayerToolStripMenuItem";
            this.dataPlayerToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dataPlayerToolStripMenuItem.Text = "Data &Player";
            // 
            // previousRecordToolStripMenuItem
            // 
            this.previousRecordToolStripMenuItem.Name = "previousRecordToolStripMenuItem";
            this.previousRecordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.previousRecordToolStripMenuItem.Text = "&Previous Record";
            // 
            // nextRecordToolStripMenuItem
            // 
            this.nextRecordToolStripMenuItem.Name = "nextRecordToolStripMenuItem";
            this.nextRecordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nextRecordToolStripMenuItem.Text = "&Next Record";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.stopToolStripMenuItem1.Text = "&Stop";
            // 
            // rOIREFToolStripMenuItem
            // 
            this.rOIREFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rOI그리기ToolStripMenuItem,
            this.rEF그리기ToolStripMenuItem,
            this.toolStripSeparator5,
            this.이동모드ToolStripMenuItem,
            this.회전모드ToolStripMenuItem,
            this.toolStripSeparator4,
            this.rOI지우기ToolStripMenuItem,
            this.rEF지우기ToolStripMenuItem});
            this.rOIREFToolStripMenuItem.Name = "rOIREFToolStripMenuItem";
            this.rOIREFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.rOIREFToolStripMenuItem.Text = "ROI / REF";
            // 
            // rOI그리기ToolStripMenuItem
            // 
            this.rOI그리기ToolStripMenuItem.Name = "rOI그리기ToolStripMenuItem";
            this.rOI그리기ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rOI그리기ToolStripMenuItem.Text = "ROI 그리기";
            // 
            // rEF그리기ToolStripMenuItem
            // 
            this.rEF그리기ToolStripMenuItem.Name = "rEF그리기ToolStripMenuItem";
            this.rEF그리기ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rEF그리기ToolStripMenuItem.Text = "REF 그리기";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // 이동모드ToolStripMenuItem
            // 
            this.이동모드ToolStripMenuItem.Name = "이동모드ToolStripMenuItem";
            this.이동모드ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.이동모드ToolStripMenuItem.Text = "이동모드";
            // 
            // 회전모드ToolStripMenuItem
            // 
            this.회전모드ToolStripMenuItem.Name = "회전모드ToolStripMenuItem";
            this.회전모드ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.회전모드ToolStripMenuItem.Text = "회전모드";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(130, 6);
            // 
            // rOI지우기ToolStripMenuItem
            // 
            this.rOI지우기ToolStripMenuItem.Name = "rOI지우기ToolStripMenuItem";
            this.rOI지우기ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rOI지우기ToolStripMenuItem.Text = "ROI 지우기";
            // 
            // rEF지우기ToolStripMenuItem
            // 
            this.rEF지우기ToolStripMenuItem.Name = "rEF지우기ToolStripMenuItem";
            this.rEF지우기ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rEF지우기ToolStripMenuItem.Text = "REF 지우기";
            // 
            // focusToolStripMenuItem
            // 
            this.focusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToNearToolStripMenuItem,
            this.moveOnStepToNearToolStripMenuItem,
            this.moveOneStepToFarToolStripMenuItem,
            this.moveToFarToolStripMenuItem});
            this.focusToolStripMenuItem.Name = "focusToolStripMenuItem";
            this.focusToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.focusToolStripMenuItem.Text = "Focus";
            // 
            // moveToNearToolStripMenuItem
            // 
            this.moveToNearToolStripMenuItem.Name = "moveToNearToolStripMenuItem";
            this.moveToNearToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moveToNearToolStripMenuItem.Text = "Move to near";
            // 
            // moveOnStepToNearToolStripMenuItem
            // 
            this.moveOnStepToNearToolStripMenuItem.Name = "moveOnStepToNearToolStripMenuItem";
            this.moveOnStepToNearToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moveOnStepToNearToolStripMenuItem.Text = "Move one step to near";
            // 
            // moveOneStepToFarToolStripMenuItem
            // 
            this.moveOneStepToFarToolStripMenuItem.Name = "moveOneStepToFarToolStripMenuItem";
            this.moveOneStepToFarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moveOneStepToFarToolStripMenuItem.Text = "Move one step to far";
            // 
            // moveToFarToolStripMenuItem
            // 
            this.moveToFarToolStripMenuItem.Name = "moveToFarToolStripMenuItem";
            this.moveToFarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moveToFarToolStripMenuItem.Text = "Move to far";
            // 
            // viewVToolStripMenuItem
            // 
            this.viewVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도구모음및도킹창ToolStripMenuItem,
            this.상태표시줄SToolStripMenuItem});
            this.viewVToolStripMenuItem.Name = "viewVToolStripMenuItem";
            this.viewVToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.viewVToolStripMenuItem.Text = "View(&V)";
            // 
            // 도구모음및도킹창ToolStripMenuItem
            // 
            this.도구모음및도킹창ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자리선택자ToolStripMenuItem});
            this.도구모음및도킹창ToolStripMenuItem.Name = "도구모음및도킹창ToolStripMenuItem";
            this.도구모음및도킹창ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.도구모음및도킹창ToolStripMenuItem.Text = "도구 모음 및 도킹 창";
            // 
            // 자리선택자ToolStripMenuItem
            // 
            this.자리선택자ToolStripMenuItem.Name = "자리선택자ToolStripMenuItem";
            this.자리선택자ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.자리선택자ToolStripMenuItem.Text = "< 자리 선택 자>";
            // 
            // 상태표시줄SToolStripMenuItem
            // 
            this.상태표시줄SToolStripMenuItem.Name = "상태표시줄SToolStripMenuItem";
            this.상태표시줄SToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.상태표시줄SToolStripMenuItem.Text = "상태 표시줄(&S)";
            // 
            // windowWToolStripMenuItem
            // 
            this.windowWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새창ToolStripMenuItem});
            this.windowWToolStripMenuItem.Name = "windowWToolStripMenuItem";
            this.windowWToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.windowWToolStripMenuItem.Text = "Window(&W)";
            // 
            // 새창ToolStripMenuItem
            // 
            this.새창ToolStripMenuItem.Name = "새창ToolStripMenuItem";
            this.새창ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.새창ToolStripMenuItem.Text = "새창";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // splitC_generalView
            // 
            this.splitC_generalView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitC_generalView.Location = new System.Drawing.Point(0, 52);
            this.splitC_generalView.Name = "splitC_generalView";
            // 
            // splitC_generalView.Panel1
            // 
            this.splitC_generalView.Panel1.Controls.Add(this.PyroProperty);
            this.splitC_generalView.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            // 
            // splitC_generalView.Panel2
            // 
            this.splitC_generalView.Panel2.Controls.Add(this.splitC_display);
            this.splitC_generalView.Size = new System.Drawing.Size(1263, 519);
            this.splitC_generalView.SplitterDistance = 210;
            this.splitC_generalView.TabIndex = 4;
            // 
            // PyroProperty
            // 
            this.PyroProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PyroProperty.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PyroProperty.CommandsBackColor = System.Drawing.Color.Gray;
            this.PyroProperty.CommandsBorderColor = System.Drawing.Color.Gray;
            this.PyroProperty.CommandsDisabledLinkColor = System.Drawing.Color.DarkRed;
            this.PyroProperty.DisabledItemForeColor = System.Drawing.SystemColors.ControlDark;
            this.PyroProperty.Font = new System.Drawing.Font("굴림", 9F);
            this.PyroProperty.LineColor = System.Drawing.SystemColors.ButtonFace;
            this.PyroProperty.Location = new System.Drawing.Point(3, 5);
            this.PyroProperty.Name = "PyroProperty";
            this.PyroProperty.Size = new System.Drawing.Size(204, 511);
            this.PyroProperty.TabIndex = 0;
            // 
            // splitC_display
            // 
            this.splitC_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitC_display.Location = new System.Drawing.Point(-1, 0);
            this.splitC_display.Name = "splitC_display";
            this.splitC_display.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC_display.Panel1
            // 
            this.splitC_display.Panel1.Controls.Add(this.splitC_view);
            // 
            // splitC_display.Panel2
            // 
            this.splitC_display.Panel2.Controls.Add(this.toolS_ROI);
            this.splitC_display.Panel2.Controls.Add(this.ROIListView);
            this.splitC_display.Size = new System.Drawing.Size(1050, 519);
            this.splitC_display.SplitterDistance = 409;
            this.splitC_display.TabIndex = 4;
            // 
            // splitC_view
            // 
            this.splitC_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitC_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitC_view.Location = new System.Drawing.Point(0, 0);
            this.splitC_view.Name = "splitC_view";
            // 
            // splitC_view.Panel1
            // 
            this.splitC_view.Panel1.Controls.Add(this.pictureBox1);
            this.splitC_view.Panel1.Controls.Add(this.textBox1);
            this.splitC_view.Panel1.Controls.Add(this.btn_startAcq);
            this.splitC_view.Panel1.Controls.Add(this.btn_camConnect);
            this.splitC_view.Panel1.Controls.Add(this.btn_arrFW);
            this.splitC_view.Panel1.Controls.Add(this.Label1);
            // 
            // splitC_view.Panel2
            // 
            this.splitC_view.Panel2.Controls.Add(this.axTChart1);
            this.splitC_view.Panel2.Controls.Add(this.btn_chrtCreate);
            this.splitC_view.Size = new System.Drawing.Size(1050, 406);
            this.splitC_view.SplitterDistance = 731;
            this.splitC_view.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 243);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btn_startAcq
            // 
            this.btn_startAcq.Location = new System.Drawing.Point(249, 92);
            this.btn_startAcq.Name = "btn_startAcq";
            this.btn_startAcq.Size = new System.Drawing.Size(138, 42);
            this.btn_startAcq.TabIndex = 7;
            this.btn_startAcq.Text = "Start ACQ";
            this.btn_startAcq.UseVisualStyleBackColor = true;
            this.btn_startAcq.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_camConnect
            // 
            this.btn_camConnect.Location = new System.Drawing.Point(80, 92);
            this.btn_camConnect.Name = "btn_camConnect";
            this.btn_camConnect.Size = new System.Drawing.Size(140, 42);
            this.btn_camConnect.TabIndex = 4;
            this.btn_camConnect.Text = "Camera 연결";
            this.btn_camConnect.UseVisualStyleBackColor = true;
            this.btn_camConnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_arrFW
            // 
            this.btn_arrFW.Location = new System.Drawing.Point(415, 92);
            this.btn_arrFW.Name = "btn_arrFW";
            this.btn_arrFW.Size = new System.Drawing.Size(129, 42);
            this.btn_arrFW.TabIndex = 5;
            this.btn_arrFW.Text = "배열 전달";
            this.btn_arrFW.UseVisualStyleBackColor = true;
            this.btn_arrFW.Click += new System.EventHandler(this.button3_Click);
            // 
            // axTChart1
            // 
            this.axTChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axTChart1.Enabled = true;
            this.axTChart1.Location = new System.Drawing.Point(3, 253);
            this.axTChart1.Name = "axTChart1";
            this.axTChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTChart1.OcxState")));
            this.axTChart1.Size = new System.Drawing.Size(305, 146);
            this.axTChart1.TabIndex = 3;
            this.axTChart1.OnAfterDraw += new System.EventHandler(this.axTChart1_OnAfterDraw);
            // 
            // toolS_ROI
            // 
            this.toolS_ROI.BackColor = System.Drawing.Color.Transparent;
            this.toolS_ROI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolB_addRect,
            this.toolB_addEllipse,
            this.toolB_addPolygon,
            this.toolB_addLine,
            this.toolB_addPointer,
            this.toolSeperator_ROI,
            this.toolB_showLabel,
            this.toolB_showMaxTemp,
            this.toolB_showMinTemp,
            this.toolStripSeparator6,
            this.toolB_ROIDataOpen,
            this.toolB_ROIDataSave,
            this.toolB_ROIDataDelete});
            this.toolS_ROI.Location = new System.Drawing.Point(0, 0);
            this.toolS_ROI.Name = "toolS_ROI";
            this.toolS_ROI.Size = new System.Drawing.Size(1050, 25);
            this.toolS_ROI.TabIndex = 1;
            this.toolS_ROI.Text = "toolStrip1";
            // 
            // toolB_addRect
            // 
            this.toolB_addRect.BackColor = System.Drawing.Color.LightGray;
            this.toolB_addRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolB_addRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_addRect.Image = ((System.Drawing.Image)(resources.GetObject("toolB_addRect.Image")));
            this.toolB_addRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_addRect.Name = "toolB_addRect";
            this.toolB_addRect.Size = new System.Drawing.Size(23, 22);
            this.toolB_addRect.Text = "toolStripButton1";
            this.toolB_addRect.Click += new System.EventHandler(this.toolB_addRect_Click);
            // 
            // toolB_addEllipse
            // 
            this.toolB_addEllipse.BackColor = System.Drawing.Color.LightGray;
            this.toolB_addEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_addEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolB_addEllipse.Image")));
            this.toolB_addEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_addEllipse.Name = "toolB_addEllipse";
            this.toolB_addEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolB_addEllipse.Text = "toolStripButton2";
            this.toolB_addEllipse.Click += new System.EventHandler(this.toolB_addEllipse_Click);
            // 
            // toolB_addPolygon
            // 
            this.toolB_addPolygon.BackColor = System.Drawing.Color.LightGray;
            this.toolB_addPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_addPolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolB_addPolygon.Image")));
            this.toolB_addPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_addPolygon.Name = "toolB_addPolygon";
            this.toolB_addPolygon.Size = new System.Drawing.Size(23, 22);
            this.toolB_addPolygon.Text = "toolStripButton3";
            this.toolB_addPolygon.Click += new System.EventHandler(this.toolB_addPolygon_Click);
            // 
            // toolB_addLine
            // 
            this.toolB_addLine.BackColor = System.Drawing.Color.LightGray;
            this.toolB_addLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_addLine.Image = ((System.Drawing.Image)(resources.GetObject("toolB_addLine.Image")));
            this.toolB_addLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_addLine.Name = "toolB_addLine";
            this.toolB_addLine.Size = new System.Drawing.Size(23, 22);
            this.toolB_addLine.Text = "toolStripButton4";
            this.toolB_addLine.Click += new System.EventHandler(this.toolB_addLine_Click);
            // 
            // toolB_addPointer
            // 
            this.toolB_addPointer.BackColor = System.Drawing.Color.LightGray;
            this.toolB_addPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_addPointer.Image = ((System.Drawing.Image)(resources.GetObject("toolB_addPointer.Image")));
            this.toolB_addPointer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_addPointer.Name = "toolB_addPointer";
            this.toolB_addPointer.Size = new System.Drawing.Size(23, 22);
            this.toolB_addPointer.Text = "toolStripButton5";
            this.toolB_addPointer.Click += new System.EventHandler(this.toolB_addPointer_Click);
            // 
            // toolSeperator_ROI
            // 
            this.toolSeperator_ROI.BackColor = System.Drawing.Color.LightGray;
            this.toolSeperator_ROI.ForeColor = System.Drawing.Color.LightGray;
            this.toolSeperator_ROI.Name = "toolSeperator_ROI";
            this.toolSeperator_ROI.Size = new System.Drawing.Size(6, 25);
            // 
            // toolB_showLabel
            // 
            this.toolB_showLabel.BackColor = System.Drawing.Color.LightGray;
            this.toolB_showLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_showLabel.Image = ((System.Drawing.Image)(resources.GetObject("toolB_showLabel.Image")));
            this.toolB_showLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_showLabel.Name = "toolB_showLabel";
            this.toolB_showLabel.Size = new System.Drawing.Size(23, 22);
            this.toolB_showLabel.Text = "toolStripButton6";
            this.toolB_showLabel.Click += new System.EventHandler(this.toolB_showLabel_Click);
            // 
            // toolB_showMaxTemp
            // 
            this.toolB_showMaxTemp.BackColor = System.Drawing.Color.LightGray;
            this.toolB_showMaxTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_showMaxTemp.Image = ((System.Drawing.Image)(resources.GetObject("toolB_showMaxTemp.Image")));
            this.toolB_showMaxTemp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_showMaxTemp.Name = "toolB_showMaxTemp";
            this.toolB_showMaxTemp.Size = new System.Drawing.Size(23, 22);
            this.toolB_showMaxTemp.Text = "toolStripButton7";
            this.toolB_showMaxTemp.Click += new System.EventHandler(this.toolB_showMaxTemp_Click);
            // 
            // toolB_showMinTemp
            // 
            this.toolB_showMinTemp.BackColor = System.Drawing.Color.LightGray;
            this.toolB_showMinTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_showMinTemp.Image = ((System.Drawing.Image)(resources.GetObject("toolB_showMinTemp.Image")));
            this.toolB_showMinTemp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_showMinTemp.Name = "toolB_showMinTemp";
            this.toolB_showMinTemp.Size = new System.Drawing.Size(23, 22);
            this.toolB_showMinTemp.Text = "toolStripButton8";
            this.toolB_showMinTemp.Click += new System.EventHandler(this.toolB_showMinTemp_Click);
            // 
            // ROIListView
            // 
            this.ROIListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ROIListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ROIListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ROIListView.Location = new System.Drawing.Point(0, 28);
            this.ROIListView.Name = "ROIListView";
            this.ROIListView.RowTemplate.Height = 23;
            this.ROIListView.Size = new System.Drawing.Size(1047, 75);
            this.ROIListView.TabIndex = 0;
            // 
            // tools_mainFrm
            // 
            this.tools_mainFrm.BackColor = System.Drawing.SystemColors.Menu;
            this.tools_mainFrm.Dock = System.Windows.Forms.DockStyle.None;
            this.tools_mainFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolB_online,
            this.toolB_open,
            this.toolB_save,
            this.toolB_help});
            this.tools_mainFrm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tools_mainFrm.Location = new System.Drawing.Point(3, 24);
            this.tools_mainFrm.Name = "tools_mainFrm";
            this.tools_mainFrm.Size = new System.Drawing.Size(104, 25);
            this.tools_mainFrm.TabIndex = 5;
            this.tools_mainFrm.Text = "File Toolbar";
            // 
            // toolB_online
            // 
            this.toolB_online.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_online.Image = ((System.Drawing.Image)(resources.GetObject("toolB_online.Image")));
            this.toolB_online.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_online.Name = "toolB_online";
            this.toolB_online.Size = new System.Drawing.Size(23, 22);
            this.toolB_online.Text = "toolStripButton1";
            this.toolB_online.ToolTipText = "Connect Camera";
            // 
            // toolB_open
            // 
            this.toolB_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_open.Image = ((System.Drawing.Image)(resources.GetObject("toolB_open.Image")));
            this.toolB_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_open.Name = "toolB_open";
            this.toolB_open.Size = new System.Drawing.Size(23, 22);
            this.toolB_open.Text = "toolStripButton2";
            this.toolB_open.ToolTipText = "Open IRDX file";
            // 
            // toolB_save
            // 
            this.toolB_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_save.Image = ((System.Drawing.Image)(resources.GetObject("toolB_save.Image")));
            this.toolB_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_save.Name = "toolB_save";
            this.toolB_save.Size = new System.Drawing.Size(23, 22);
            this.toolB_save.Text = "toolStripButton3";
            this.toolB_save.ToolTipText = "Save IRDX file";
            // 
            // toolB_help
            // 
            this.toolB_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_help.Image = ((System.Drawing.Image)(resources.GetObject("toolB_help.Image")));
            this.toolB_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_help.Name = "toolB_help";
            this.toolB_help.Size = new System.Drawing.Size(23, 22);
            this.toolB_help.Text = "toolStripButton4";
            this.toolB_help.ToolTipText = "Program information, Version & Copyright";
            // 
            // toolS_dataAcq
            // 
            this.toolS_dataAcq.Dock = System.Windows.Forms.DockStyle.None;
            this.toolS_dataAcq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolB_Acq,
            this.toolB_stop});
            this.toolS_dataAcq.Location = new System.Drawing.Point(107, 24);
            this.toolS_dataAcq.Name = "toolS_dataAcq";
            this.toolS_dataAcq.Size = new System.Drawing.Size(58, 25);
            this.toolS_dataAcq.TabIndex = 6;
            this.toolS_dataAcq.Text = "Acquisition Toolbar";
            // 
            // toolB_Acq
            // 
            this.toolB_Acq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_Acq.Image = ((System.Drawing.Image)(resources.GetObject("toolB_Acq.Image")));
            this.toolB_Acq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_Acq.Name = "toolB_Acq";
            this.toolB_Acq.Size = new System.Drawing.Size(23, 22);
            this.toolB_Acq.Text = "toolStripButton1";
            this.toolB_Acq.ToolTipText = "Start data acquisition from camera";
            // 
            // toolB_stop
            // 
            this.toolB_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_stop.Image = ((System.Drawing.Image)(resources.GetObject("toolB_stop.Image")));
            this.toolB_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_stop.Name = "toolB_stop";
            this.toolB_stop.Size = new System.Drawing.Size(23, 22);
            this.toolB_stop.Text = "toolStripButton2";
            this.toolB_stop.ToolTipText = "Stop data acquisition from camera";
            // 
            // toolS_DataPlayer
            // 
            this.toolS_DataPlayer.Dock = System.Windows.Forms.DockStyle.None;
            this.toolS_DataPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolB_previous,
            this.toolB_next,
            this.toolB_play});
            this.toolS_DataPlayer.Location = new System.Drawing.Point(165, 24);
            this.toolS_DataPlayer.Name = "toolS_DataPlayer";
            this.toolS_DataPlayer.Size = new System.Drawing.Size(81, 25);
            this.toolS_DataPlayer.TabIndex = 7;
            this.toolS_DataPlayer.Text = "DataPlayer Toolbar";
            // 
            // toolB_previous
            // 
            this.toolB_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_previous.Image = ((System.Drawing.Image)(resources.GetObject("toolB_previous.Image")));
            this.toolB_previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_previous.Name = "toolB_previous";
            this.toolB_previous.Size = new System.Drawing.Size(23, 22);
            this.toolB_previous.Text = "toolStripButton1";
            this.toolB_previous.ToolTipText = "Previous frame";
            // 
            // toolB_next
            // 
            this.toolB_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_next.Image = ((System.Drawing.Image)(resources.GetObject("toolB_next.Image")));
            this.toolB_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_next.Name = "toolB_next";
            this.toolB_next.Size = new System.Drawing.Size(23, 22);
            this.toolB_next.Text = "toolStripButton2";
            this.toolB_next.ToolTipText = "Next frame";
            // 
            // toolB_play
            // 
            this.toolB_play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_play.Image = ((System.Drawing.Image)(resources.GetObject("toolB_play.Image")));
            this.toolB_play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_play.Name = "toolB_play";
            this.toolB_play.Size = new System.Drawing.Size(23, 22);
            this.toolB_play.Text = "toolStripButton3";
            this.toolB_play.ToolTipText = "Play Frame";
            // 
            // toolS_camFocus
            // 
            this.toolS_camFocus.Dock = System.Windows.Forms.DockStyle.None;
            this.toolS_camFocus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolB_zeroFocus,
            this.toolB_prevFocus,
            this.toolB_nextFocus,
            this.toolB_endFocus});
            this.toolS_camFocus.Location = new System.Drawing.Point(246, 24);
            this.toolS_camFocus.Name = "toolS_camFocus";
            this.toolS_camFocus.Size = new System.Drawing.Size(104, 25);
            this.toolS_camFocus.TabIndex = 8;
            this.toolS_camFocus.Text = "Camera Focus Toolbar";
            // 
            // toolB_zeroFocus
            // 
            this.toolB_zeroFocus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_zeroFocus.Image = ((System.Drawing.Image)(resources.GetObject("toolB_zeroFocus.Image")));
            this.toolB_zeroFocus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_zeroFocus.Name = "toolB_zeroFocus";
            this.toolB_zeroFocus.Size = new System.Drawing.Size(23, 22);
            this.toolB_zeroFocus.Text = "toolStripButton1";
            this.toolB_zeroFocus.ToolTipText = "Move focus to near";
            // 
            // toolB_prevFocus
            // 
            this.toolB_prevFocus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_prevFocus.Image = ((System.Drawing.Image)(resources.GetObject("toolB_prevFocus.Image")));
            this.toolB_prevFocus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_prevFocus.Name = "toolB_prevFocus";
            this.toolB_prevFocus.Size = new System.Drawing.Size(23, 22);
            this.toolB_prevFocus.Text = "toolStripButton2";
            this.toolB_prevFocus.ToolTipText = "Move focus one step to near";
            // 
            // toolB_nextFocus
            // 
            this.toolB_nextFocus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_nextFocus.Image = ((System.Drawing.Image)(resources.GetObject("toolB_nextFocus.Image")));
            this.toolB_nextFocus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_nextFocus.Name = "toolB_nextFocus";
            this.toolB_nextFocus.Size = new System.Drawing.Size(23, 22);
            this.toolB_nextFocus.Text = "toolStripButton3";
            this.toolB_nextFocus.ToolTipText = "Move focus one step to far";
            // 
            // toolB_endFocus
            // 
            this.toolB_endFocus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_endFocus.Image = ((System.Drawing.Image)(resources.GetObject("toolB_endFocus.Image")));
            this.toolB_endFocus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_endFocus.Name = "toolB_endFocus";
            this.toolB_endFocus.Size = new System.Drawing.Size(23, 22);
            this.toolB_endFocus.Text = "toolStripButton4";
            this.toolB_endFocus.ToolTipText = "Move focus to far";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolB_ROIDataOpen
            // 
            this.toolB_ROIDataOpen.BackColor = System.Drawing.Color.LightGray;
            this.toolB_ROIDataOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_ROIDataOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolB_ROIDataOpen.Image")));
            this.toolB_ROIDataOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_ROIDataOpen.Name = "toolB_ROIDataOpen";
            this.toolB_ROIDataOpen.Size = new System.Drawing.Size(23, 22);
            this.toolB_ROIDataOpen.Text = "toolStripButton1";
            // 
            // toolB_ROIDataSave
            // 
            this.toolB_ROIDataSave.BackColor = System.Drawing.Color.LightGray;
            this.toolB_ROIDataSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_ROIDataSave.Image = ((System.Drawing.Image)(resources.GetObject("toolB_ROIDataSave.Image")));
            this.toolB_ROIDataSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_ROIDataSave.Name = "toolB_ROIDataSave";
            this.toolB_ROIDataSave.Size = new System.Drawing.Size(23, 22);
            this.toolB_ROIDataSave.Text = "toolStripButton2";
            // 
            // toolB_ROIDataDelete
            // 
            this.toolB_ROIDataDelete.BackColor = System.Drawing.Color.LightGray;
            this.toolB_ROIDataDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolB_ROIDataDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolB_ROIDataDelete.Image")));
            this.toolB_ROIDataDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolB_ROIDataDelete.Name = "toolB_ROIDataDelete";
            this.toolB_ROIDataDelete.Size = new System.Drawing.Size(23, 22);
            this.toolB_ROIDataDelete.Text = "toolStripButton3";
            this.toolB_ROIDataDelete.Click += new System.EventHandler(this.toolB_ROIDataDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 571);
            this.Controls.Add(this.toolS_camFocus);
            this.Controls.Add(this.toolS_DataPlayer);
            this.Controls.Add(this.toolS_dataAcq);
            this.Controls.Add(this.tools_mainFrm);
            this.Controls.Add(this.splitC_generalView);
            this.Controls.Add(this.menu_PyroSoft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_PyroSoft;
            this.Name = "MainForm";
            this.Text = "PyroSoftM";
            this.menu_PyroSoft.ResumeLayout(false);
            this.menu_PyroSoft.PerformLayout();
            this.splitC_generalView.Panel1.ResumeLayout(false);
            this.splitC_generalView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_generalView)).EndInit();
            this.splitC_generalView.ResumeLayout(false);
            this.splitC_display.Panel1.ResumeLayout(false);
            this.splitC_display.Panel2.ResumeLayout(false);
            this.splitC_display.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_display)).EndInit();
            this.splitC_display.ResumeLayout(false);
            this.splitC_view.Panel1.ResumeLayout(false);
            this.splitC_view.Panel1.PerformLayout();
            this.splitC_view.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_view)).EndInit();
            this.splitC_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).EndInit();
            this.toolS_ROI.ResumeLayout(false);
            this.toolS_ROI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ROIListView)).EndInit();
            this.tools_mainFrm.ResumeLayout(false);
            this.tools_mainFrm.PerformLayout();
            this.toolS_dataAcq.ResumeLayout(false);
            this.toolS_dataAcq.PerformLayout();
            this.toolS_DataPlayer.ResumeLayout(false);
            this.toolS_DataPlayer.PerformLayout();
            this.toolS_camFocus.ResumeLayout(false);
            this.toolS_camFocus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chrtCreate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MenuStrip menu_PyroSoft;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOIREFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openIRDXOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator 최근사용파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showMinMaxPointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rOI그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEF그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 이동모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem rOI지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEF지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToNearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveOnStepToNearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveOneStepToFarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToFarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구모음및도킹창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자리선택자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitC_generalView;
        private AxTeeChart.AxTChart axTChart1;
        private System.Windows.Forms.ToolStrip tools_mainFrm;
        private System.Windows.Forms.ToolStripButton toolB_online;
        private System.Windows.Forms.Button btn_camConnect;
        private System.Windows.Forms.Button btn_arrFW;
        private System.Windows.Forms.Button btn_startAcq;
        private System.Windows.Forms.PropertyGrid PyroProperty;
        private System.Windows.Forms.SplitContainer splitC_view;
        private System.Windows.Forms.ToolStripButton toolB_open;
        private System.Windows.Forms.ToolStrip toolS_dataAcq;
        private System.Windows.Forms.ToolStripButton toolB_save;
        private System.Windows.Forms.ToolStripButton toolB_help;
        private System.Windows.Forms.ToolStripButton toolB_Acq;
        private System.Windows.Forms.ToolStripButton toolB_stop;
        private System.Windows.Forms.ToolStrip toolS_DataPlayer;
        private System.Windows.Forms.ToolStripButton toolB_previous;
        private System.Windows.Forms.ToolStripButton toolB_next;
        private System.Windows.Forms.ToolStripButton toolB_play;
        private System.Windows.Forms.ToolStrip toolS_camFocus;
        private System.Windows.Forms.ToolStripButton toolB_zeroFocus;
        private System.Windows.Forms.ToolStripButton toolB_prevFocus;
        private System.Windows.Forms.ToolStripButton toolB_nextFocus;
        private System.Windows.Forms.ToolStripButton toolB_endFocus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitC_display;
        private System.Windows.Forms.DataGridView ROIListView;
        private System.Windows.Forms.ToolStrip toolS_ROI;
        private System.Windows.Forms.ToolStripButton toolB_addRect;
        private System.Windows.Forms.ToolStripButton toolB_addEllipse;
        private System.Windows.Forms.ToolStripButton toolB_addPolygon;
        private System.Windows.Forms.ToolStripButton toolB_addLine;
        private System.Windows.Forms.ToolStripButton toolB_addPointer;
        private System.Windows.Forms.ToolStripSeparator toolSeperator_ROI;
        private System.Windows.Forms.ToolStripButton toolB_showLabel;
        private System.Windows.Forms.ToolStripButton toolB_showMaxTemp;
        private System.Windows.Forms.ToolStripButton toolB_showMinTemp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolB_ROIDataOpen;
        private System.Windows.Forms.ToolStripButton toolB_ROIDataSave;
        private System.Windows.Forms.ToolStripButton toolB_ROIDataDelete;
    }
}

