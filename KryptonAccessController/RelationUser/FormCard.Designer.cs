namespace KryptonAccessController.RelationUser
{
    partial class FormCard
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
            this.kryptonButtonCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabelCardValidDateTime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCardIssueDateTime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePickerCardValidDateTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePickerCardIssueDateTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabelCardType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCardLevel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxCardPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelCardPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxCardVersion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelCardVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxCardID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelCardID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCardStateFlag = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBoxCardStateFalg = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBoxCardLevel = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBoxCardType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardStateFalg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonComboBoxCardType);
            this.kryptonPanel.Controls.Add(this.kryptonComboBoxCardLevel);
            this.kryptonPanel.Controls.Add(this.kryptonComboBoxCardStateFalg);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardStateFlag);
            this.kryptonPanel.Controls.Add(this.kryptonButtonCancel);
            this.kryptonPanel.Controls.Add(this.kryptonButtonOK);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardValidDateTime);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardIssueDateTime);
            this.kryptonPanel.Controls.Add(this.kryptonDateTimePickerCardValidDateTime);
            this.kryptonPanel.Controls.Add(this.kryptonDateTimePickerCardIssueDateTime);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardType);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardLevel);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxCardPassword);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardPassword);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxCardVersion);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardVersion);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxCardID);
            this.kryptonPanel.Controls.Add(this.kryptonLabelCardID);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(289, 321);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButtonCancel
            // 
            this.kryptonButtonCancel.Location = new System.Drawing.Point(134, 253);
            this.kryptonButtonCancel.Name = "kryptonButtonCancel";
            this.kryptonButtonCancel.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonCancel.TabIndex = 29;
            this.kryptonButtonCancel.Values.Text = "取消";
            this.kryptonButtonCancel.Click += new System.EventHandler(this.kryptonButtonCancel_Click);
            // 
            // kryptonButtonOK
            // 
            this.kryptonButtonOK.Location = new System.Drawing.Point(26, 253);
            this.kryptonButtonOK.Name = "kryptonButtonOK";
            this.kryptonButtonOK.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonOK.TabIndex = 28;
            this.kryptonButtonOK.Values.Text = "确定";
            this.kryptonButtonOK.Click += new System.EventHandler(this.kryptonButtonOK_Click);
            // 
            // kryptonLabelCardValidDateTime
            // 
            this.kryptonLabelCardValidDateTime.Location = new System.Drawing.Point(26, 206);
            this.kryptonLabelCardValidDateTime.Name = "kryptonLabelCardValidDateTime";
            this.kryptonLabelCardValidDateTime.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCardValidDateTime.TabIndex = 27;
            this.kryptonLabelCardValidDateTime.Values.Text = "截止日期";
            // 
            // kryptonLabelCardIssueDateTime
            // 
            this.kryptonLabelCardIssueDateTime.Location = new System.Drawing.Point(26, 180);
            this.kryptonLabelCardIssueDateTime.Name = "kryptonLabelCardIssueDateTime";
            this.kryptonLabelCardIssueDateTime.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCardIssueDateTime.TabIndex = 26;
            this.kryptonLabelCardIssueDateTime.Values.Text = "发行日期";
            // 
            // kryptonDateTimePickerCardValidDateTime
            // 
            this.kryptonDateTimePickerCardValidDateTime.CustomFormat = "yyyy-MM-dd";
            this.kryptonDateTimePickerCardValidDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePickerCardValidDateTime.Location = new System.Drawing.Point(95, 207);
            this.kryptonDateTimePickerCardValidDateTime.Name = "kryptonDateTimePickerCardValidDateTime";
            this.kryptonDateTimePickerCardValidDateTime.Size = new System.Drawing.Size(89, 21);
            this.kryptonDateTimePickerCardValidDateTime.TabIndex = 25;
            // 
            // kryptonDateTimePickerCardIssueDateTime
            // 
            this.kryptonDateTimePickerCardIssueDateTime.CustomFormat = "yyyy-MM-dd";
            this.kryptonDateTimePickerCardIssueDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePickerCardIssueDateTime.Location = new System.Drawing.Point(95, 180);
            this.kryptonDateTimePickerCardIssueDateTime.Name = "kryptonDateTimePickerCardIssueDateTime";
            this.kryptonDateTimePickerCardIssueDateTime.Size = new System.Drawing.Size(89, 21);
            this.kryptonDateTimePickerCardIssueDateTime.TabIndex = 24;
            // 
            // kryptonLabelCardType
            // 
            this.kryptonLabelCardType.Location = new System.Drawing.Point(26, 67);
            this.kryptonLabelCardType.Name = "kryptonLabelCardType";
            this.kryptonLabelCardType.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelCardType.TabIndex = 22;
            this.kryptonLabelCardType.Values.Text = "卡类型";
            // 
            // kryptonLabelCardLevel
            // 
            this.kryptonLabelCardLevel.Location = new System.Drawing.Point(26, 96);
            this.kryptonLabelCardLevel.Name = "kryptonLabelCardLevel";
            this.kryptonLabelCardLevel.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCardLevel.TabIndex = 20;
            this.kryptonLabelCardLevel.Values.Text = "卡片级别";
            // 
            // kryptonTextBoxCardPassword
            // 
            this.kryptonTextBoxCardPassword.Location = new System.Drawing.Point(95, 151);
            this.kryptonTextBoxCardPassword.Name = "kryptonTextBoxCardPassword";
            this.kryptonTextBoxCardPassword.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxCardPassword.TabIndex = 19;
            // 
            // kryptonLabelCardPassword
            // 
            this.kryptonLabelCardPassword.Location = new System.Drawing.Point(26, 151);
            this.kryptonLabelCardPassword.Name = "kryptonLabelCardPassword";
            this.kryptonLabelCardPassword.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCardPassword.TabIndex = 18;
            this.kryptonLabelCardPassword.Values.Text = "卡片密码";
            // 
            // kryptonTextBoxCardVersion
            // 
            this.kryptonTextBoxCardVersion.Location = new System.Drawing.Point(95, 41);
            this.kryptonTextBoxCardVersion.Name = "kryptonTextBoxCardVersion";
            this.kryptonTextBoxCardVersion.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxCardVersion.TabIndex = 17;
            // 
            // kryptonLabelCardVersion
            // 
            this.kryptonLabelCardVersion.Location = new System.Drawing.Point(26, 41);
            this.kryptonLabelCardVersion.Name = "kryptonLabelCardVersion";
            this.kryptonLabelCardVersion.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabelCardVersion.TabIndex = 16;
            this.kryptonLabelCardVersion.Values.Text = "卡版本";
            // 
            // kryptonTextBoxCardID
            // 
            this.kryptonTextBoxCardID.Location = new System.Drawing.Point(95, 12);
            this.kryptonTextBoxCardID.Name = "kryptonTextBoxCardID";
            this.kryptonTextBoxCardID.Size = new System.Drawing.Size(100, 20);
            this.kryptonTextBoxCardID.TabIndex = 15;
            // 
            // kryptonLabelCardID
            // 
            this.kryptonLabelCardID.Location = new System.Drawing.Point(26, 12);
            this.kryptonLabelCardID.Name = "kryptonLabelCardID";
            this.kryptonLabelCardID.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabelCardID.TabIndex = 14;
            this.kryptonLabelCardID.Values.Text = "卡号";
            // 
            // kryptonLabelCardStateFlag
            // 
            this.kryptonLabelCardStateFlag.Location = new System.Drawing.Point(26, 123);
            this.kryptonLabelCardStateFlag.Name = "kryptonLabelCardStateFlag";
            this.kryptonLabelCardStateFlag.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelCardStateFlag.TabIndex = 30;
            this.kryptonLabelCardStateFlag.Values.Text = "卡片状态";
            // 
            // kryptonComboBoxCardStateFalg
            // 
            this.kryptonComboBoxCardStateFalg.DropDownWidth = 103;
            this.kryptonComboBoxCardStateFalg.Items.AddRange(new object[] {
            "白名单",
            "冻结卡",
            "跟踪卡",
            "挂失卡",
            "注销卡"});
            this.kryptonComboBoxCardStateFalg.Location = new System.Drawing.Point(95, 124);
            this.kryptonComboBoxCardStateFalg.Name = "kryptonComboBoxCardStateFalg";
            this.kryptonComboBoxCardStateFalg.Size = new System.Drawing.Size(103, 21);
            this.kryptonComboBoxCardStateFalg.TabIndex = 31;
            this.kryptonComboBoxCardStateFalg.Text = "白名单";
            // 
            // kryptonComboBoxCardLevel
            // 
            this.kryptonComboBoxCardLevel.DropDownWidth = 103;
            this.kryptonComboBoxCardLevel.Items.AddRange(new object[] {
            "管理员卡",
            "常开卡",
            "巡更卡",
            "考勤卡",
            "普通卡",
            "临时卡",
            "访客卡"});
            this.kryptonComboBoxCardLevel.Location = new System.Drawing.Point(95, 97);
            this.kryptonComboBoxCardLevel.Name = "kryptonComboBoxCardLevel";
            this.kryptonComboBoxCardLevel.Size = new System.Drawing.Size(103, 21);
            this.kryptonComboBoxCardLevel.TabIndex = 32;
            this.kryptonComboBoxCardLevel.Text = "普通卡";
            // 
            // kryptonComboBoxCardType
            // 
            this.kryptonComboBoxCardType.DropDownWidth = 100;
            this.kryptonComboBoxCardType.Items.AddRange(new object[] {
            "Mifare",
            "HID",
            "EM",
            "Inside",
            "MifareDesfire",
            "MifarePlus",
            "Oberthur"});
            this.kryptonComboBoxCardType.Location = new System.Drawing.Point(95, 70);
            this.kryptonComboBoxCardType.Name = "kryptonComboBoxCardType";
            this.kryptonComboBoxCardType.Size = new System.Drawing.Size(100, 21);
            this.kryptonComboBoxCardType.TabIndex = 33;
            this.kryptonComboBoxCardType.Text = "Mifare";
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 321);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormCard";
            this.Text = "卡片";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardStateFalg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxCardType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardValidDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardIssueDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerCardValidDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerCardIssueDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxCardPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxCardVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxCardID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOK;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxCardType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxCardLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxCardStateFalg;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCardStateFlag;
    }
}

