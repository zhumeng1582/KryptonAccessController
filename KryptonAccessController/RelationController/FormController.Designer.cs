using System.Drawing;
namespace KryptonAccessController.RelationController
{
    partial class FormController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flatTabOtherPara = new MyComponents.FlatTabControl();
            this.tabPageInterFunction = new System.Windows.Forms.TabPage();
            this.kryptonPanelInterFunction = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonComboBoxInputStateType0 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabelInputStateType0 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxFireSensing = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelAuxOutPutPoint = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelPowerOutage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxPowerOutage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelLowVoltage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxAuxOutPutPoint = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxTamperSensing = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelTamperSensing = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelFireSensing = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxLowVoltage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox485 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonComboBoxControllerParityCheck = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBoxControllerAddr485 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelControllerParityCheck = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerFlowControl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerStopBits = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxControllerStopBits = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelControllerDataBits = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxControllerFlowControl = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxControllerBaudrate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelControllerBaudrate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerAddr485 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxControllerDataBits = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBoxTCP = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.textBoxNewDeviceIP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonlabelDNS = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonlabelBackupDNS = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonlabelMAC = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBoxMAC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonlabelGateway = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxBackUpDNS = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxMask = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxDNS = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonlabelMask = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonlabelNewDeviceIP = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBoxGateway = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tabPageDoorUnit1 = new System.Windows.Forms.TabPage();
            this.kryptonPanelDoorUnit1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBoxDoorUnitEnable1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.doorUnit1 = new MyComponents.DoorUnit();
            this.tabPageDoorUnit2 = new System.Windows.Forms.TabPage();
            this.kryptonPanelDoorUnit2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBoxDoorUnitEnable2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.doorUnit2 = new MyComponents.DoorUnit();
            this.tabPageDoorUnit3 = new System.Windows.Forms.TabPage();
            this.kryptonPanelDoorUnit3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBoxDoorUnitEnable3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.doorUnit3 = new MyComponents.DoorUnit();
            this.tabPageDoorUnit4 = new System.Windows.Forms.TabPage();
            this.kryptonPanelDoorUnit4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBoxDoorUnitEnable4 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.doorUnit4 = new MyComponents.DoorUnit();
            this.tabPageIntegrateIO = new System.Windows.Forms.TabPage();
            this.kryptonPanelIntegrateIO = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tabPageExpansionBoard1 = new System.Windows.Forms.TabPage();
            this.kryptonPanelExpansionBoard1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tabPageExpansionBoard2 = new System.Windows.Forms.TabPage();
            this.kryptonPanelExpansionBoard2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tabPageExpansionBoard3 = new System.Windows.Forms.TabPage();
            this.kryptonPanelExpansionBoard3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tabPageExpansionBoard4 = new System.Windows.Forms.TabPage();
            this.kryptonPanelExpansionBoard4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanelControllerBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonControllerCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonControllerOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanelBasicPara = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBoxControllerVersion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelControllerVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBoxCommunicateTypeTCP = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBoxCommunicateType485 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabelCommunicateType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBoxControllerType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBoxControllerLoaction = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxControllerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxControllerID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelControllerLoaction = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelControllerID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.flatTabOtherPara.SuspendLayout();
            this.tabPageInterFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelInterFunction)).BeginInit();
            this.kryptonPanelInterFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxInputStateType0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox485)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox485.Panel)).BeginInit();
            this.kryptonGroupBox485.Panel.SuspendLayout();
            this.kryptonGroupBox485.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxControllerParityCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxTCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxTCP.Panel)).BeginInit();
            this.kryptonGroupBoxTCP.Panel.SuspendLayout();
            this.kryptonGroupBoxTCP.SuspendLayout();
            this.tabPageDoorUnit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit1)).BeginInit();
            this.kryptonPanelDoorUnit1.SuspendLayout();
            this.tabPageDoorUnit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit2)).BeginInit();
            this.kryptonPanelDoorUnit2.SuspendLayout();
            this.tabPageDoorUnit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit3)).BeginInit();
            this.kryptonPanelDoorUnit3.SuspendLayout();
            this.tabPageDoorUnit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit4)).BeginInit();
            this.kryptonPanelDoorUnit4.SuspendLayout();
            this.tabPageIntegrateIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelIntegrateIO)).BeginInit();
            this.tabPageExpansionBoard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard1)).BeginInit();
            this.tabPageExpansionBoard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard2)).BeginInit();
            this.tabPageExpansionBoard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard3)).BeginInit();
            this.tabPageExpansionBoard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelControllerBottom)).BeginInit();
            this.kryptonPanelControllerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelBasicPara)).BeginInit();
            this.kryptonPanelBasicPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxControllerType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.flatTabOtherPara);
            this.kryptonPanel.Controls.Add(this.kryptonPanelControllerBottom);
            this.kryptonPanel.Controls.Add(this.kryptonPanelBasicPara);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(857, 645);
            this.kryptonPanel.TabIndex = 0;
            // 
            // flatTabOtherPara
            // 
            this.flatTabOtherPara.Controls.Add(this.tabPageInterFunction);
            this.flatTabOtherPara.Controls.Add(this.tabPageDoorUnit1);
            this.flatTabOtherPara.Controls.Add(this.tabPageDoorUnit2);
            this.flatTabOtherPara.Controls.Add(this.tabPageDoorUnit3);
            this.flatTabOtherPara.Controls.Add(this.tabPageDoorUnit4);
            this.flatTabOtherPara.Controls.Add(this.tabPageIntegrateIO);
            this.flatTabOtherPara.Controls.Add(this.tabPageExpansionBoard1);
            this.flatTabOtherPara.Controls.Add(this.tabPageExpansionBoard2);
            this.flatTabOtherPara.Controls.Add(this.tabPageExpansionBoard3);
            this.flatTabOtherPara.Controls.Add(this.tabPageExpansionBoard4);
            this.flatTabOtherPara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTabOtherPara.Location = new System.Drawing.Point(0, 133);
            this.flatTabOtherPara.Name = "flatTabOtherPara";
            this.flatTabOtherPara.SelectedIndex = 0;
            this.flatTabOtherPara.Size = new System.Drawing.Size(857, 468);
            this.flatTabOtherPara.TabIndex = 1;
            // 
            // tabPageInterFunction
            // 
            this.tabPageInterFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageInterFunction.Controls.Add(this.kryptonPanelInterFunction);
            this.tabPageInterFunction.Location = new System.Drawing.Point(4, 26);
            this.tabPageInterFunction.Name = "tabPageInterFunction";
            this.tabPageInterFunction.Size = new System.Drawing.Size(849, 438);
            this.tabPageInterFunction.TabIndex = 0;
            this.tabPageInterFunction.Text = "内置功能";
            // 
            // kryptonPanelInterFunction
            // 
            this.kryptonPanelInterFunction.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanelInterFunction.Controls.Add(this.kryptonGroupBox485);
            this.kryptonPanelInterFunction.Controls.Add(this.kryptonGroupBoxTCP);
            this.kryptonPanelInterFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelInterFunction.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelInterFunction.Name = "kryptonPanelInterFunction";
            this.kryptonPanelInterFunction.Size = new System.Drawing.Size(849, 438);
            this.kryptonPanelInterFunction.TabIndex = 122;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(555, 20);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonComboBoxInputStateType0);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelInputStateType0);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonTextBoxFireSensing);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelAuxOutPutPoint);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelPowerOutage);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonTextBoxPowerOutage);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelLowVoltage);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonTextBoxAuxOutPutPoint);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonTextBoxTamperSensing);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelTamperSensing);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabelFireSensing);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonTextBoxLowVoltage);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(256, 219);
            this.kryptonGroupBox2.TabIndex = 121;
            this.kryptonGroupBox2.Text = "辅助单元";
            this.kryptonGroupBox2.Values.Heading = "辅助单元";
            // 
            // kryptonComboBoxInputStateType0
            // 
            this.kryptonComboBoxInputStateType0.DropDownWidth = 93;
            this.kryptonComboBoxInputStateType0.Items.AddRange(new object[] {
            "两态",
            "四态"});
            this.kryptonComboBoxInputStateType0.Location = new System.Drawing.Point(110, 7);
            this.kryptonComboBoxInputStateType0.Name = "kryptonComboBoxInputStateType0";
            this.kryptonComboBoxInputStateType0.Size = new System.Drawing.Size(93, 21);
            this.kryptonComboBoxInputStateType0.TabIndex = 120;
            this.kryptonComboBoxInputStateType0.Text = "两态";
            // 
            // kryptonLabelInputStateType0
            // 
            this.kryptonLabelInputStateType0.Location = new System.Drawing.Point(16, 10);
            this.kryptonLabelInputStateType0.Name = "kryptonLabelInputStateType0";
            this.kryptonLabelInputStateType0.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabelInputStateType0.TabIndex = 119;
            this.kryptonLabelInputStateType0.Values.Text = "输入状态类型";
            // 
            // kryptonTextBoxFireSensing
            // 
            this.kryptonTextBoxFireSensing.Location = new System.Drawing.Point(110, 69);
            this.kryptonTextBoxFireSensing.Name = "kryptonTextBoxFireSensing";
            this.kryptonTextBoxFireSensing.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxFireSensing.TabIndex = 112;
            this.kryptonTextBoxFireSensing.Text = "10";
            // 
            // kryptonLabelAuxOutPutPoint
            // 
            this.kryptonLabelAuxOutPutPoint.Location = new System.Drawing.Point(22, 40);
            this.kryptonLabelAuxOutPutPoint.Name = "kryptonLabelAuxOutPutPoint";
            this.kryptonLabelAuxOutPutPoint.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabelAuxOutPutPoint.TabIndex = 117;
            this.kryptonLabelAuxOutPutPoint.Values.Text = "输出";
            // 
            // kryptonLabelPowerOutage
            // 
            this.kryptonLabelPowerOutage.Location = new System.Drawing.Point(22, 160);
            this.kryptonLabelPowerOutage.Name = "kryptonLabelPowerOutage";
            this.kryptonLabelPowerOutage.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelPowerOutage.TabIndex = 111;
            this.kryptonLabelPowerOutage.Values.Text = "断电报警";
            // 
            // kryptonTextBoxPowerOutage
            // 
            this.kryptonTextBoxPowerOutage.Location = new System.Drawing.Point(110, 156);
            this.kryptonTextBoxPowerOutage.Name = "kryptonTextBoxPowerOutage";
            this.kryptonTextBoxPowerOutage.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxPowerOutage.TabIndex = 116;
            this.kryptonTextBoxPowerOutage.Text = "13";
            // 
            // kryptonLabelLowVoltage
            // 
            this.kryptonLabelLowVoltage.Location = new System.Drawing.Point(22, 131);
            this.kryptonLabelLowVoltage.Name = "kryptonLabelLowVoltage";
            this.kryptonLabelLowVoltage.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabelLowVoltage.TabIndex = 109;
            this.kryptonLabelLowVoltage.Values.Text = "低电量报警";
            // 
            // kryptonTextBoxAuxOutPutPoint
            // 
            this.kryptonTextBoxAuxOutPutPoint.Location = new System.Drawing.Point(110, 36);
            this.kryptonTextBoxAuxOutPutPoint.Name = "kryptonTextBoxAuxOutPutPoint";
            this.kryptonTextBoxAuxOutPutPoint.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxAuxOutPutPoint.TabIndex = 118;
            this.kryptonTextBoxAuxOutPutPoint.Text = "10";
            // 
            // kryptonTextBoxTamperSensing
            // 
            this.kryptonTextBoxTamperSensing.Location = new System.Drawing.Point(110, 98);
            this.kryptonTextBoxTamperSensing.Name = "kryptonTextBoxTamperSensing";
            this.kryptonTextBoxTamperSensing.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxTamperSensing.TabIndex = 113;
            this.kryptonTextBoxTamperSensing.Text = "11";
            // 
            // kryptonLabelTamperSensing
            // 
            this.kryptonLabelTamperSensing.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabelTamperSensing.Name = "kryptonLabelTamperSensing";
            this.kryptonLabelTamperSensing.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelTamperSensing.TabIndex = 108;
            this.kryptonLabelTamperSensing.Values.Text = "防撬开关";
            // 
            // kryptonLabelFireSensing
            // 
            this.kryptonLabelFireSensing.Location = new System.Drawing.Point(22, 73);
            this.kryptonLabelFireSensing.Name = "kryptonLabelFireSensing";
            this.kryptonLabelFireSensing.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelFireSensing.TabIndex = 107;
            this.kryptonLabelFireSensing.Values.Text = "消防报警";
            // 
            // kryptonTextBoxLowVoltage
            // 
            this.kryptonTextBoxLowVoltage.Location = new System.Drawing.Point(110, 127);
            this.kryptonTextBoxLowVoltage.Name = "kryptonTextBoxLowVoltage";
            this.kryptonTextBoxLowVoltage.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxLowVoltage.TabIndex = 114;
            this.kryptonTextBoxLowVoltage.Text = "12";
            // 
            // kryptonGroupBox485
            // 
            this.kryptonGroupBox485.Location = new System.Drawing.Point(300, 20);
            this.kryptonGroupBox485.Name = "kryptonGroupBox485";
            // 
            // kryptonGroupBox485.Panel
            // 
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonComboBoxControllerParityCheck);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonTextBoxControllerAddr485);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerParityCheck);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerFlowControl);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerStopBits);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonTextBoxControllerStopBits);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerDataBits);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonTextBoxControllerFlowControl);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonTextBoxControllerBaudrate);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerBaudrate);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonLabelControllerAddr485);
            this.kryptonGroupBox485.Panel.Controls.Add(this.kryptonTextBoxControllerDataBits);
            this.kryptonGroupBox485.Size = new System.Drawing.Size(227, 226);
            this.kryptonGroupBox485.TabIndex = 120;
            this.kryptonGroupBox485.Text = "RS485通讯参数";
            this.kryptonGroupBox485.Values.Heading = "RS485通讯参数";
            // 
            // kryptonComboBoxControllerParityCheck
            // 
            this.kryptonComboBoxControllerParityCheck.DropDownWidth = 93;
            this.kryptonComboBoxControllerParityCheck.Items.AddRange(new object[] {
            "None",
            "奇校验",
            "偶校验"});
            this.kryptonComboBoxControllerParityCheck.Location = new System.Drawing.Point(91, 132);
            this.kryptonComboBoxControllerParityCheck.Name = "kryptonComboBoxControllerParityCheck";
            this.kryptonComboBoxControllerParityCheck.Size = new System.Drawing.Size(93, 21);
            this.kryptonComboBoxControllerParityCheck.TabIndex = 9;
            this.kryptonComboBoxControllerParityCheck.Text = "None";
            // 
            // kryptonTextBoxControllerAddr485
            // 
            this.kryptonTextBoxControllerAddr485.Location = new System.Drawing.Point(91, 13);
            this.kryptonTextBoxControllerAddr485.Name = "kryptonTextBoxControllerAddr485";
            this.kryptonTextBoxControllerAddr485.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxControllerAddr485.TabIndex = 112;
            this.kryptonTextBoxControllerAddr485.Text = "001";
            // 
            // kryptonLabelControllerParityCheck
            // 
            this.kryptonLabelControllerParityCheck.Location = new System.Drawing.Point(19, 136);
            this.kryptonLabelControllerParityCheck.Name = "kryptonLabelControllerParityCheck";
            this.kryptonLabelControllerParityCheck.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabelControllerParityCheck.TabIndex = 110;
            this.kryptonLabelControllerParityCheck.Values.Text = "校验";
            // 
            // kryptonLabelControllerFlowControl
            // 
            this.kryptonLabelControllerFlowControl.Location = new System.Drawing.Point(19, 165);
            this.kryptonLabelControllerFlowControl.Name = "kryptonLabelControllerFlowControl";
            this.kryptonLabelControllerFlowControl.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelControllerFlowControl.TabIndex = 117;
            this.kryptonLabelControllerFlowControl.Values.Text = "流控制";
            // 
            // kryptonLabelControllerStopBits
            // 
            this.kryptonLabelControllerStopBits.Location = new System.Drawing.Point(19, 107);
            this.kryptonLabelControllerStopBits.Name = "kryptonLabelControllerStopBits";
            this.kryptonLabelControllerStopBits.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelControllerStopBits.TabIndex = 111;
            this.kryptonLabelControllerStopBits.Values.Text = "停止位";
            // 
            // kryptonTextBoxControllerStopBits
            // 
            this.kryptonTextBoxControllerStopBits.Location = new System.Drawing.Point(91, 103);
            this.kryptonTextBoxControllerStopBits.Name = "kryptonTextBoxControllerStopBits";
            this.kryptonTextBoxControllerStopBits.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxControllerStopBits.TabIndex = 116;
            this.kryptonTextBoxControllerStopBits.Text = "1";
            // 
            // kryptonLabelControllerDataBits
            // 
            this.kryptonLabelControllerDataBits.Location = new System.Drawing.Point(19, 78);
            this.kryptonLabelControllerDataBits.Name = "kryptonLabelControllerDataBits";
            this.kryptonLabelControllerDataBits.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelControllerDataBits.TabIndex = 109;
            this.kryptonLabelControllerDataBits.Values.Text = "数据位";
            // 
            // kryptonTextBoxControllerFlowControl
            // 
            this.kryptonTextBoxControllerFlowControl.Location = new System.Drawing.Point(91, 161);
            this.kryptonTextBoxControllerFlowControl.Name = "kryptonTextBoxControllerFlowControl";
            this.kryptonTextBoxControllerFlowControl.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxControllerFlowControl.TabIndex = 118;
            // 
            // kryptonTextBoxControllerBaudrate
            // 
            this.kryptonTextBoxControllerBaudrate.Location = new System.Drawing.Point(91, 45);
            this.kryptonTextBoxControllerBaudrate.Name = "kryptonTextBoxControllerBaudrate";
            this.kryptonTextBoxControllerBaudrate.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxControllerBaudrate.TabIndex = 113;
            this.kryptonTextBoxControllerBaudrate.Text = "115200";
            // 
            // kryptonLabelControllerBaudrate
            // 
            this.kryptonLabelControllerBaudrate.Location = new System.Drawing.Point(18, 48);
            this.kryptonLabelControllerBaudrate.Name = "kryptonLabelControllerBaudrate";
            this.kryptonLabelControllerBaudrate.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelControllerBaudrate.TabIndex = 108;
            this.kryptonLabelControllerBaudrate.Values.Text = "波特率";
            // 
            // kryptonLabelControllerAddr485
            // 
            this.kryptonLabelControllerAddr485.Location = new System.Drawing.Point(18, 16);
            this.kryptonLabelControllerAddr485.Name = "kryptonLabelControllerAddr485";
            this.kryptonLabelControllerAddr485.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabelControllerAddr485.TabIndex = 107;
            this.kryptonLabelControllerAddr485.Values.Text = "地址";
            // 
            // kryptonTextBoxControllerDataBits
            // 
            this.kryptonTextBoxControllerDataBits.Location = new System.Drawing.Point(91, 74);
            this.kryptonTextBoxControllerDataBits.Name = "kryptonTextBoxControllerDataBits";
            this.kryptonTextBoxControllerDataBits.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxControllerDataBits.TabIndex = 114;
            this.kryptonTextBoxControllerDataBits.Text = "8";
            // 
            // kryptonGroupBoxTCP
            // 
            this.kryptonGroupBoxTCP.Location = new System.Drawing.Point(20, 20);
            this.kryptonGroupBoxTCP.Name = "kryptonGroupBoxTCP";
            // 
            // kryptonGroupBoxTCP.Panel
            // 
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.textBoxNewDeviceIP);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelDNS);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelBackupDNS);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelMAC);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.textBoxMAC);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelGateway);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonTextBoxBackUpDNS);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.textBoxMask);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.textBoxDNS);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelMask);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.kryptonlabelNewDeviceIP);
            this.kryptonGroupBoxTCP.Panel.Controls.Add(this.textBoxGateway);
            this.kryptonGroupBoxTCP.Size = new System.Drawing.Size(255, 212);
            this.kryptonGroupBoxTCP.TabIndex = 119;
            this.kryptonGroupBoxTCP.Text = "TCP通讯参数";
            this.kryptonGroupBoxTCP.Values.Heading = "TCP通讯参数";
            // 
            // textBoxNewDeviceIP
            // 
            this.textBoxNewDeviceIP.Location = new System.Drawing.Point(91, 7);
            this.textBoxNewDeviceIP.Name = "textBoxNewDeviceIP";
            this.textBoxNewDeviceIP.Size = new System.Drawing.Size(113, 20);
            this.textBoxNewDeviceIP.TabIndex = 112;
            this.textBoxNewDeviceIP.Text = "192.168.1.230";
            // 
            // kryptonlabelDNS
            // 
            this.kryptonlabelDNS.Location = new System.Drawing.Point(19, 127);
            this.kryptonlabelDNS.Name = "kryptonlabelDNS";
            this.kryptonlabelDNS.Size = new System.Drawing.Size(42, 20);
            this.kryptonlabelDNS.TabIndex = 110;
            this.kryptonlabelDNS.Values.Text = "域名1";
            // 
            // kryptonlabelBackupDNS
            // 
            this.kryptonlabelBackupDNS.Location = new System.Drawing.Point(20, 152);
            this.kryptonlabelBackupDNS.Name = "kryptonlabelBackupDNS";
            this.kryptonlabelBackupDNS.Size = new System.Drawing.Size(42, 20);
            this.kryptonlabelBackupDNS.TabIndex = 117;
            this.kryptonlabelBackupDNS.Values.Text = "域名2";
            // 
            // kryptonlabelMAC
            // 
            this.kryptonlabelMAC.Location = new System.Drawing.Point(19, 98);
            this.kryptonlabelMAC.Name = "kryptonlabelMAC";
            this.kryptonlabelMAC.Size = new System.Drawing.Size(37, 20);
            this.kryptonlabelMAC.TabIndex = 111;
            this.kryptonlabelMAC.Values.Text = "MAC";
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(91, 94);
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(113, 20);
            this.textBoxMAC.TabIndex = 116;
            this.textBoxMAC.Text = "00:17:61:01:88:27";
            // 
            // kryptonlabelGateway
            // 
            this.kryptonlabelGateway.Location = new System.Drawing.Point(19, 69);
            this.kryptonlabelGateway.Name = "kryptonlabelGateway";
            this.kryptonlabelGateway.Size = new System.Drawing.Size(35, 20);
            this.kryptonlabelGateway.TabIndex = 109;
            this.kryptonlabelGateway.Values.Text = "网关";
            // 
            // kryptonTextBoxBackUpDNS
            // 
            this.kryptonTextBoxBackUpDNS.Location = new System.Drawing.Point(91, 152);
            this.kryptonTextBoxBackUpDNS.Name = "kryptonTextBoxBackUpDNS";
            this.kryptonTextBoxBackUpDNS.Size = new System.Drawing.Size(113, 20);
            this.kryptonTextBoxBackUpDNS.TabIndex = 118;
            this.kryptonTextBoxBackUpDNS.Text = "192.168.1.1";
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(91, 36);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(113, 20);
            this.textBoxMask.TabIndex = 113;
            this.textBoxMask.Text = "255.255.255.0";
            // 
            // textBoxDNS
            // 
            this.textBoxDNS.Location = new System.Drawing.Point(91, 123);
            this.textBoxDNS.Name = "textBoxDNS";
            this.textBoxDNS.Size = new System.Drawing.Size(113, 20);
            this.textBoxDNS.TabIndex = 115;
            this.textBoxDNS.Text = "192.168.1.1";
            // 
            // kryptonlabelMask
            // 
            this.kryptonlabelMask.Location = new System.Drawing.Point(20, 39);
            this.kryptonlabelMask.Name = "kryptonlabelMask";
            this.kryptonlabelMask.Size = new System.Drawing.Size(60, 20);
            this.kryptonlabelMask.TabIndex = 108;
            this.kryptonlabelMask.Values.Text = "子网掩码";
            // 
            // kryptonlabelNewDeviceIP
            // 
            this.kryptonlabelNewDeviceIP.Location = new System.Drawing.Point(20, 10);
            this.kryptonlabelNewDeviceIP.Name = "kryptonlabelNewDeviceIP";
            this.kryptonlabelNewDeviceIP.Size = new System.Drawing.Size(46, 20);
            this.kryptonlabelNewDeviceIP.TabIndex = 107;
            this.kryptonlabelNewDeviceIP.Values.Text = "IP地址";
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Location = new System.Drawing.Point(91, 65);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(113, 20);
            this.textBoxGateway.TabIndex = 114;
            this.textBoxGateway.Text = "192.168.1.1";
            // 
            // tabPageDoorUnit1
            // 
            this.tabPageDoorUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageDoorUnit1.Controls.Add(this.kryptonPanelDoorUnit1);
            this.tabPageDoorUnit1.Location = new System.Drawing.Point(4, 26);
            this.tabPageDoorUnit1.Name = "tabPageDoorUnit1";
            this.tabPageDoorUnit1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoorUnit1.Size = new System.Drawing.Size(849, 438);
            this.tabPageDoorUnit1.TabIndex = 1;
            this.tabPageDoorUnit1.Text = "门单元1";
            // 
            // kryptonPanelDoorUnit1
            // 
            this.kryptonPanelDoorUnit1.Controls.Add(this.kryptonCheckBoxDoorUnitEnable1);
            this.kryptonPanelDoorUnit1.Controls.Add(this.doorUnit1);
            this.kryptonPanelDoorUnit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelDoorUnit1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelDoorUnit1.Name = "kryptonPanelDoorUnit1";
            this.kryptonPanelDoorUnit1.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelDoorUnit1.TabIndex = 125;
            // 
            // kryptonCheckBoxDoorUnitEnable1
            // 
            this.kryptonCheckBoxDoorUnitEnable1.Checked = true;
            this.kryptonCheckBoxDoorUnitEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxDoorUnitEnable1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxDoorUnitEnable1.Location = new System.Drawing.Point(20, 23);
            this.kryptonCheckBoxDoorUnitEnable1.Name = "kryptonCheckBoxDoorUnitEnable1";
            this.kryptonCheckBoxDoorUnitEnable1.Size = new System.Drawing.Size(92, 20);
            this.kryptonCheckBoxDoorUnitEnable1.TabIndex = 1;
            this.kryptonCheckBoxDoorUnitEnable1.Text = "使能门单元1";
            this.kryptonCheckBoxDoorUnitEnable1.Values.Text = "使能门单元1";
            this.kryptonCheckBoxDoorUnitEnable1.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxDoorUnitEnable_CheckedChanged);
            // 
            // doorUnit1
            // 
            this.doorUnit1.Location = new System.Drawing.Point(20, 59);
            this.doorUnit1.Name = "doorUnit1";
            this.doorUnit1.Size = new System.Drawing.Size(342, 279);
            this.doorUnit1.TabIndex = 0;
            // 
            // tabPageDoorUnit2
            // 
            this.tabPageDoorUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageDoorUnit2.Controls.Add(this.kryptonPanelDoorUnit2);
            this.tabPageDoorUnit2.Location = new System.Drawing.Point(4, 26);
            this.tabPageDoorUnit2.Name = "tabPageDoorUnit2";
            this.tabPageDoorUnit2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoorUnit2.Size = new System.Drawing.Size(849, 438);
            this.tabPageDoorUnit2.TabIndex = 2;
            this.tabPageDoorUnit2.Text = "门单元2";
            // 
            // kryptonPanelDoorUnit2
            // 
            this.kryptonPanelDoorUnit2.Controls.Add(this.kryptonCheckBoxDoorUnitEnable2);
            this.kryptonPanelDoorUnit2.Controls.Add(this.doorUnit2);
            this.kryptonPanelDoorUnit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelDoorUnit2.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelDoorUnit2.Name = "kryptonPanelDoorUnit2";
            this.kryptonPanelDoorUnit2.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelDoorUnit2.TabIndex = 139;
            // 
            // kryptonCheckBoxDoorUnitEnable2
            // 
            this.kryptonCheckBoxDoorUnitEnable2.Checked = true;
            this.kryptonCheckBoxDoorUnitEnable2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxDoorUnitEnable2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxDoorUnitEnable2.Location = new System.Drawing.Point(20, 23);
            this.kryptonCheckBoxDoorUnitEnable2.Name = "kryptonCheckBoxDoorUnitEnable2";
            this.kryptonCheckBoxDoorUnitEnable2.Size = new System.Drawing.Size(92, 20);
            this.kryptonCheckBoxDoorUnitEnable2.TabIndex = 143;
            this.kryptonCheckBoxDoorUnitEnable2.Text = "使能门单元2";
            this.kryptonCheckBoxDoorUnitEnable2.Values.Text = "使能门单元2";
            this.kryptonCheckBoxDoorUnitEnable2.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxDoorUnitEnable_CheckedChanged);
            // 
            // doorUnit2
            // 
            this.doorUnit2.Location = new System.Drawing.Point(20, 59);
            this.doorUnit2.Name = "doorUnit2";
            this.doorUnit2.Size = new System.Drawing.Size(342, 279);
            this.doorUnit2.TabIndex = 142;
            // 
            // tabPageDoorUnit3
            // 
            this.tabPageDoorUnit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageDoorUnit3.Controls.Add(this.kryptonPanelDoorUnit3);
            this.tabPageDoorUnit3.Location = new System.Drawing.Point(4, 26);
            this.tabPageDoorUnit3.Name = "tabPageDoorUnit3";
            this.tabPageDoorUnit3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoorUnit3.Size = new System.Drawing.Size(849, 438);
            this.tabPageDoorUnit3.TabIndex = 3;
            this.tabPageDoorUnit3.Text = "门单元3";
            // 
            // kryptonPanelDoorUnit3
            // 
            this.kryptonPanelDoorUnit3.Controls.Add(this.kryptonCheckBoxDoorUnitEnable3);
            this.kryptonPanelDoorUnit3.Controls.Add(this.doorUnit3);
            this.kryptonPanelDoorUnit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelDoorUnit3.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelDoorUnit3.Name = "kryptonPanelDoorUnit3";
            this.kryptonPanelDoorUnit3.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelDoorUnit3.TabIndex = 153;
            // 
            // kryptonCheckBoxDoorUnitEnable3
            // 
            this.kryptonCheckBoxDoorUnitEnable3.Checked = true;
            this.kryptonCheckBoxDoorUnitEnable3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxDoorUnitEnable3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxDoorUnitEnable3.Location = new System.Drawing.Point(20, 23);
            this.kryptonCheckBoxDoorUnitEnable3.Name = "kryptonCheckBoxDoorUnitEnable3";
            this.kryptonCheckBoxDoorUnitEnable3.Size = new System.Drawing.Size(92, 20);
            this.kryptonCheckBoxDoorUnitEnable3.TabIndex = 144;
            this.kryptonCheckBoxDoorUnitEnable3.Text = "使能门单元3";
            this.kryptonCheckBoxDoorUnitEnable3.Values.Text = "使能门单元3";
            this.kryptonCheckBoxDoorUnitEnable3.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxDoorUnitEnable_CheckedChanged);
            // 
            // doorUnit3
            // 
            this.doorUnit3.Location = new System.Drawing.Point(20, 59);
            this.doorUnit3.Name = "doorUnit3";
            this.doorUnit3.Size = new System.Drawing.Size(342, 279);
            this.doorUnit3.TabIndex = 143;
            // 
            // tabPageDoorUnit4
            // 
            this.tabPageDoorUnit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageDoorUnit4.Controls.Add(this.kryptonPanelDoorUnit4);
            this.tabPageDoorUnit4.Location = new System.Drawing.Point(4, 26);
            this.tabPageDoorUnit4.Name = "tabPageDoorUnit4";
            this.tabPageDoorUnit4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoorUnit4.Size = new System.Drawing.Size(849, 438);
            this.tabPageDoorUnit4.TabIndex = 4;
            this.tabPageDoorUnit4.Text = "门单元4";
            // 
            // kryptonPanelDoorUnit4
            // 
            this.kryptonPanelDoorUnit4.Controls.Add(this.kryptonCheckBoxDoorUnitEnable4);
            this.kryptonPanelDoorUnit4.Controls.Add(this.doorUnit4);
            this.kryptonPanelDoorUnit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelDoorUnit4.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelDoorUnit4.Name = "kryptonPanelDoorUnit4";
            this.kryptonPanelDoorUnit4.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelDoorUnit4.TabIndex = 153;
            // 
            // kryptonCheckBoxDoorUnitEnable4
            // 
            this.kryptonCheckBoxDoorUnitEnable4.Checked = true;
            this.kryptonCheckBoxDoorUnitEnable4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxDoorUnitEnable4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxDoorUnitEnable4.Location = new System.Drawing.Point(20, 23);
            this.kryptonCheckBoxDoorUnitEnable4.Name = "kryptonCheckBoxDoorUnitEnable4";
            this.kryptonCheckBoxDoorUnitEnable4.Size = new System.Drawing.Size(92, 20);
            this.kryptonCheckBoxDoorUnitEnable4.TabIndex = 144;
            this.kryptonCheckBoxDoorUnitEnable4.Text = "使能门单元4";
            this.kryptonCheckBoxDoorUnitEnable4.Values.Text = "使能门单元4";
            this.kryptonCheckBoxDoorUnitEnable4.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxDoorUnitEnable_CheckedChanged);
            // 
            // doorUnit4
            // 
            this.doorUnit4.Location = new System.Drawing.Point(20, 59);
            this.doorUnit4.Name = "doorUnit4";
            this.doorUnit4.Size = new System.Drawing.Size(342, 279);
            this.doorUnit4.TabIndex = 143;
            // 
            // tabPageIntegrateIO
            // 
            this.tabPageIntegrateIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageIntegrateIO.Controls.Add(this.kryptonPanelIntegrateIO);
            this.tabPageIntegrateIO.Location = new System.Drawing.Point(4, 26);
            this.tabPageIntegrateIO.Name = "tabPageIntegrateIO";
            this.tabPageIntegrateIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntegrateIO.Size = new System.Drawing.Size(849, 438);
            this.tabPageIntegrateIO.TabIndex = 5;
            this.tabPageIntegrateIO.Text = "集成IO";
            // 
            // kryptonPanelIntegrateIO
            // 
            this.kryptonPanelIntegrateIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelIntegrateIO.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelIntegrateIO.Name = "kryptonPanelIntegrateIO";
            this.kryptonPanelIntegrateIO.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelIntegrateIO.TabIndex = 0;
            // 
            // tabPageExpansionBoard1
            // 
            this.tabPageExpansionBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageExpansionBoard1.Controls.Add(this.kryptonPanelExpansionBoard1);
            this.tabPageExpansionBoard1.Location = new System.Drawing.Point(4, 26);
            this.tabPageExpansionBoard1.Name = "tabPageExpansionBoard1";
            this.tabPageExpansionBoard1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpansionBoard1.Size = new System.Drawing.Size(849, 438);
            this.tabPageExpansionBoard1.TabIndex = 6;
            this.tabPageExpansionBoard1.Text = "扩展板1";
            // 
            // kryptonPanelExpansionBoard1
            // 
            this.kryptonPanelExpansionBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExpansionBoard1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelExpansionBoard1.Name = "kryptonPanelExpansionBoard1";
            this.kryptonPanelExpansionBoard1.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelExpansionBoard1.TabIndex = 0;
            // 
            // tabPageExpansionBoard2
            // 
            this.tabPageExpansionBoard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageExpansionBoard2.Controls.Add(this.kryptonPanelExpansionBoard2);
            this.tabPageExpansionBoard2.Location = new System.Drawing.Point(4, 26);
            this.tabPageExpansionBoard2.Name = "tabPageExpansionBoard2";
            this.tabPageExpansionBoard2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpansionBoard2.Size = new System.Drawing.Size(849, 438);
            this.tabPageExpansionBoard2.TabIndex = 7;
            this.tabPageExpansionBoard2.Text = "扩展板2";
            // 
            // kryptonPanelExpansionBoard2
            // 
            this.kryptonPanelExpansionBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExpansionBoard2.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelExpansionBoard2.Name = "kryptonPanelExpansionBoard2";
            this.kryptonPanelExpansionBoard2.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelExpansionBoard2.TabIndex = 0;
            // 
            // tabPageExpansionBoard3
            // 
            this.tabPageExpansionBoard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageExpansionBoard3.Controls.Add(this.kryptonPanelExpansionBoard3);
            this.tabPageExpansionBoard3.Location = new System.Drawing.Point(4, 26);
            this.tabPageExpansionBoard3.Name = "tabPageExpansionBoard3";
            this.tabPageExpansionBoard3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpansionBoard3.Size = new System.Drawing.Size(849, 438);
            this.tabPageExpansionBoard3.TabIndex = 8;
            this.tabPageExpansionBoard3.Text = "扩展板3";
            // 
            // kryptonPanelExpansionBoard3
            // 
            this.kryptonPanelExpansionBoard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExpansionBoard3.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelExpansionBoard3.Name = "kryptonPanelExpansionBoard3";
            this.kryptonPanelExpansionBoard3.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelExpansionBoard3.TabIndex = 0;
            // 
            // tabPageExpansionBoard4
            // 
            this.tabPageExpansionBoard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPageExpansionBoard4.Controls.Add(this.kryptonPanelExpansionBoard4);
            this.tabPageExpansionBoard4.Location = new System.Drawing.Point(4, 26);
            this.tabPageExpansionBoard4.Name = "tabPageExpansionBoard4";
            this.tabPageExpansionBoard4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpansionBoard4.Size = new System.Drawing.Size(849, 438);
            this.tabPageExpansionBoard4.TabIndex = 9;
            this.tabPageExpansionBoard4.Text = "扩展板4";
            // 
            // kryptonPanelExpansionBoard4
            // 
            this.kryptonPanelExpansionBoard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExpansionBoard4.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanelExpansionBoard4.Name = "kryptonPanelExpansionBoard4";
            this.kryptonPanelExpansionBoard4.Size = new System.Drawing.Size(843, 432);
            this.kryptonPanelExpansionBoard4.TabIndex = 0;
            // 
            // kryptonPanelControllerBottom
            // 
            this.kryptonPanelControllerBottom.Controls.Add(this.kryptonButtonControllerCancel);
            this.kryptonPanelControllerBottom.Controls.Add(this.kryptonButtonControllerOK);
            this.kryptonPanelControllerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelControllerBottom.Location = new System.Drawing.Point(0, 601);
            this.kryptonPanelControllerBottom.Name = "kryptonPanelControllerBottom";
            this.kryptonPanelControllerBottom.Size = new System.Drawing.Size(857, 44);
            this.kryptonPanelControllerBottom.TabIndex = 2;
            // 
            // kryptonButtonControllerCancel
            // 
            this.kryptonButtonControllerCancel.Location = new System.Drawing.Point(498, 13);
            this.kryptonButtonControllerCancel.Name = "kryptonButtonControllerCancel";
            this.kryptonButtonControllerCancel.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonControllerCancel.TabIndex = 1;
            this.kryptonButtonControllerCancel.Values.Text = "取消";
            this.kryptonButtonControllerCancel.Click += new System.EventHandler(this.kryptonButtonControllerCancel_Click);
            // 
            // kryptonButtonControllerOK
            // 
            this.kryptonButtonControllerOK.Location = new System.Drawing.Point(177, 13);
            this.kryptonButtonControllerOK.Name = "kryptonButtonControllerOK";
            this.kryptonButtonControllerOK.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonControllerOK.TabIndex = 0;
            this.kryptonButtonControllerOK.Values.Text = "确定";
            this.kryptonButtonControllerOK.Click += new System.EventHandler(this.kryptonButtonControllerOK_Click);
            // 
            // kryptonPanelBasicPara
            // 
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonTextBoxControllerVersion);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelControllerVersion);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonCheckBoxCommunicateTypeTCP);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonCheckBoxCommunicateType485);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelCommunicateType);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonComboBoxControllerType);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonTextBoxControllerLoaction);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonTextBoxControllerName);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonTextBoxControllerID);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelControllerLoaction);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelControllerType);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelControllerName);
            this.kryptonPanelBasicPara.Controls.Add(this.kryptonLabelControllerID);
            this.kryptonPanelBasicPara.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanelBasicPara.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelBasicPara.Name = "kryptonPanelBasicPara";
            this.kryptonPanelBasicPara.Size = new System.Drawing.Size(857, 133);
            this.kryptonPanelBasicPara.TabIndex = 0;
            // 
            // kryptonTextBoxControllerVersion
            // 
            this.kryptonTextBoxControllerVersion.Location = new System.Drawing.Point(480, 55);
            this.kryptonTextBoxControllerVersion.Name = "kryptonTextBoxControllerVersion";
            this.kryptonTextBoxControllerVersion.Size = new System.Drawing.Size(169, 20);
            this.kryptonTextBoxControllerVersion.TabIndex = 13;
            this.kryptonTextBoxControllerVersion.Text = "V2014.03.03";
            // 
            // kryptonLabelControllerVersion
            // 
            this.kryptonLabelControllerVersion.Location = new System.Drawing.Point(387, 58);
            this.kryptonLabelControllerVersion.Name = "kryptonLabelControllerVersion";
            this.kryptonLabelControllerVersion.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabelControllerVersion.TabIndex = 12;
            this.kryptonLabelControllerVersion.Values.Text = "控制器版本";
            // 
            // kryptonCheckBoxCommunicateTypeTCP
            // 
            this.kryptonCheckBoxCommunicateTypeTCP.Checked = true;
            this.kryptonCheckBoxCommunicateTypeTCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxCommunicateTypeTCP.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxCommunicateTypeTCP.Location = new System.Drawing.Point(498, 15);
            this.kryptonCheckBoxCommunicateTypeTCP.Name = "kryptonCheckBoxCommunicateTypeTCP";
            this.kryptonCheckBoxCommunicateTypeTCP.Size = new System.Drawing.Size(45, 20);
            this.kryptonCheckBoxCommunicateTypeTCP.TabIndex = 11;
            this.kryptonCheckBoxCommunicateTypeTCP.Text = "TCP";
            this.kryptonCheckBoxCommunicateTypeTCP.Values.Text = "TCP";
            this.kryptonCheckBoxCommunicateTypeTCP.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxCommunicateTypeTCP_CheckedChanged);
            // 
            // kryptonCheckBoxCommunicateType485
            // 
            this.kryptonCheckBoxCommunicateType485.Checked = true;
            this.kryptonCheckBoxCommunicateType485.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxCommunicateType485.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonCheckBoxCommunicateType485.Location = new System.Drawing.Point(591, 12);
            this.kryptonCheckBoxCommunicateType485.Name = "kryptonCheckBoxCommunicateType485";
            this.kryptonCheckBoxCommunicateType485.Size = new System.Drawing.Size(43, 20);
            this.kryptonCheckBoxCommunicateType485.TabIndex = 10;
            this.kryptonCheckBoxCommunicateType485.Text = "485";
            this.kryptonCheckBoxCommunicateType485.Values.Text = "485";
            this.kryptonCheckBoxCommunicateType485.CheckedChanged += new System.EventHandler(this.kryptonCheckBoxCommunicateType485_CheckedChanged);
            // 
            // kryptonLabelCommunicateType
            // 
            this.kryptonLabelCommunicateType.Location = new System.Drawing.Point(387, 15);
            this.kryptonLabelCommunicateType.Name = "kryptonLabelCommunicateType";
            this.kryptonLabelCommunicateType.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCommunicateType.TabIndex = 9;
            this.kryptonLabelCommunicateType.Values.Text = "通讯类型";
            // 
            // kryptonComboBoxControllerType
            // 
            this.kryptonComboBoxControllerType.DropDownWidth = 93;
            this.kryptonComboBoxControllerType.Items.AddRange(new object[] {
            "C0402",
            "C0402+E02",
            "C0402+S02"});
            this.kryptonComboBoxControllerType.Location = new System.Drawing.Point(120, 67);
            this.kryptonComboBoxControllerType.Name = "kryptonComboBoxControllerType";
            this.kryptonComboBoxControllerType.Size = new System.Drawing.Size(93, 21);
            this.kryptonComboBoxControllerType.TabIndex = 8;
            this.kryptonComboBoxControllerType.Text = "C0402";
            this.kryptonComboBoxControllerType.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBoxControllerType_SelectedIndexChanged);
            // 
            // kryptonTextBoxControllerLoaction
            // 
            this.kryptonTextBoxControllerLoaction.Location = new System.Drawing.Point(120, 93);
            this.kryptonTextBoxControllerLoaction.Name = "kryptonTextBoxControllerLoaction";
            this.kryptonTextBoxControllerLoaction.Size = new System.Drawing.Size(169, 20);
            this.kryptonTextBoxControllerLoaction.TabIndex = 6;
            this.kryptonTextBoxControllerLoaction.Text = "控制器地址";
            // 
            // kryptonTextBoxControllerName
            // 
            this.kryptonTextBoxControllerName.Location = new System.Drawing.Point(120, 41);
            this.kryptonTextBoxControllerName.Name = "kryptonTextBoxControllerName";
            this.kryptonTextBoxControllerName.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxControllerName.TabIndex = 5;
            this.kryptonTextBoxControllerName.Text = "控制器1";
            // 
            // kryptonTextBoxControllerID
            // 
            this.kryptonTextBoxControllerID.Location = new System.Drawing.Point(120, 12);
            this.kryptonTextBoxControllerID.Name = "kryptonTextBoxControllerID";
            this.kryptonTextBoxControllerID.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxControllerID.TabIndex = 4;
            this.kryptonTextBoxControllerID.Text = "241";
            // 
            // kryptonLabelControllerLoaction
            // 
            this.kryptonLabelControllerLoaction.Location = new System.Drawing.Point(27, 96);
            this.kryptonLabelControllerLoaction.Name = "kryptonLabelControllerLoaction";
            this.kryptonLabelControllerLoaction.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabelControllerLoaction.TabIndex = 3;
            this.kryptonLabelControllerLoaction.Values.Text = "控制器地址";
            // 
            // kryptonLabelControllerType
            // 
            this.kryptonLabelControllerType.Location = new System.Drawing.Point(27, 70);
            this.kryptonLabelControllerType.Name = "kryptonLabelControllerType";
            this.kryptonLabelControllerType.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabelControllerType.TabIndex = 2;
            this.kryptonLabelControllerType.Values.Text = "控制器类型";
            // 
            // kryptonLabelControllerName
            // 
            this.kryptonLabelControllerName.Location = new System.Drawing.Point(27, 44);
            this.kryptonLabelControllerName.Name = "kryptonLabelControllerName";
            this.kryptonLabelControllerName.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelControllerName.TabIndex = 1;
            this.kryptonLabelControllerName.Values.Text = "控制器名";
            // 
            // kryptonLabelControllerID
            // 
            this.kryptonLabelControllerID.Location = new System.Drawing.Point(27, 15);
            this.kryptonLabelControllerID.Name = "kryptonLabelControllerID";
            this.kryptonLabelControllerID.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelControllerID.TabIndex = 0;
            this.kryptonLabelControllerID.Values.Text = "控制器ID";
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 645);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormController";
            this.Text = "控制器信息";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.flatTabOtherPara.ResumeLayout(false);
            this.tabPageInterFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelInterFunction)).EndInit();
            this.kryptonPanelInterFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxInputStateType0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox485.Panel)).EndInit();
            this.kryptonGroupBox485.Panel.ResumeLayout(false);
            this.kryptonGroupBox485.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox485)).EndInit();
            this.kryptonGroupBox485.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxControllerParityCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxTCP.Panel)).EndInit();
            this.kryptonGroupBoxTCP.Panel.ResumeLayout(false);
            this.kryptonGroupBoxTCP.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxTCP)).EndInit();
            this.kryptonGroupBoxTCP.ResumeLayout(false);
            this.tabPageDoorUnit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit1)).EndInit();
            this.kryptonPanelDoorUnit1.ResumeLayout(false);
            this.kryptonPanelDoorUnit1.PerformLayout();
            this.tabPageDoorUnit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit2)).EndInit();
            this.kryptonPanelDoorUnit2.ResumeLayout(false);
            this.kryptonPanelDoorUnit2.PerformLayout();
            this.tabPageDoorUnit3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit3)).EndInit();
            this.kryptonPanelDoorUnit3.ResumeLayout(false);
            this.kryptonPanelDoorUnit3.PerformLayout();
            this.tabPageDoorUnit4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelDoorUnit4)).EndInit();
            this.kryptonPanelDoorUnit4.ResumeLayout(false);
            this.kryptonPanelDoorUnit4.PerformLayout();
            this.tabPageIntegrateIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelIntegrateIO)).EndInit();
            this.tabPageExpansionBoard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard1)).EndInit();
            this.tabPageExpansionBoard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard2)).EndInit();
            this.tabPageExpansionBoard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard3)).EndInit();
            this.tabPageExpansionBoard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExpansionBoard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelControllerBottom)).EndInit();
            this.kryptonPanelControllerBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelBasicPara)).EndInit();
            this.kryptonPanelBasicPara.ResumeLayout(false);
            this.kryptonPanelBasicPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxControllerType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelBasicPara;
        private MyComponents.FlatTabControl flatTabOtherPara;
        private System.Windows.Forms.TabPage tabPageInterFunction;
        private System.Windows.Forms.TabPage tabPageDoorUnit1;
        private System.Windows.Forms.TabPage tabPageDoorUnit2;
        private System.Windows.Forms.TabPage tabPageDoorUnit3;
        private System.Windows.Forms.TabPage tabPageDoorUnit4;
        private System.Windows.Forms.TabPage tabPageIntegrateIO;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxControllerType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerLoaction;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerLoaction;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxNewDeviceIP;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelBackupDNS;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxMAC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxBackUpDNS;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxDNS;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelNewDeviceIP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxGateway;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelMask;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxMask;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelGateway;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelMAC;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonlabelDNS;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBoxTCP;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox485;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerAddr485;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerParityCheck;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerFlowControl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerStopBits;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerStopBits;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerDataBits;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerFlowControl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerBaudrate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerBaudrate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerAddr485;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerDataBits;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxControllerParityCheck;
        private System.Windows.Forms.TabPage tabPageExpansionBoard1;
        private System.Windows.Forms.TabPage tabPageExpansionBoard2;
        private System.Windows.Forms.TabPage tabPageExpansionBoard3;
        private System.Windows.Forms.TabPage tabPageExpansionBoard4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxFireSensing;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelAuxOutPutPoint;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelPowerOutage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxPowerOutage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelLowVoltage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxAuxOutPutPoint;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxTamperSensing;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelTamperSensing;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelFireSensing;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxLowVoltage;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelControllerBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonControllerCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonControllerOK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCommunicateType;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxCommunicateTypeTCP;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxCommunicateType485;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelInterFunction;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelDoorUnit1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelDoorUnit2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelDoorUnit3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelDoorUnit4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelIntegrateIO;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelExpansionBoard1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelExpansionBoard2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelExpansionBoard3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelExpansionBoard4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxControllerVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelControllerVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxInputStateType0;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelInputStateType0;
        private MyComponents.DoorUnit doorUnit1;
        private MyComponents.DoorUnit doorUnit2;
        private MyComponents.DoorUnit doorUnit3;
        private MyComponents.DoorUnit doorUnit4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDoorUnitEnable1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDoorUnitEnable2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDoorUnitEnable3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDoorUnitEnable4;
        
    }
}

