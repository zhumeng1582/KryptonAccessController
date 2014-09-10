namespace KryptonAccessController.RelationController
{
    partial class FormReaderHoliday
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
            this.kryptonLabelEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePickerEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePickerStartDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonButtonReaderHolidayCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonReaderHolidayOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonLabelEndDate);
            this.kryptonPanel.Controls.Add(this.kryptonLabelStartDate);
            this.kryptonPanel.Controls.Add(this.kryptonDateTimePickerEndDate);
            this.kryptonPanel.Controls.Add(this.kryptonDateTimePickerStartDate);
            this.kryptonPanel.Controls.Add(this.kryptonButtonReaderHolidayCancel);
            this.kryptonPanel.Controls.Add(this.kryptonButtonReaderHolidayOk);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(304, 212);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonLabelEndDate
            // 
            this.kryptonLabelEndDate.Location = new System.Drawing.Point(39, 70);
            this.kryptonLabelEndDate.Name = "kryptonLabelEndDate";
            this.kryptonLabelEndDate.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelEndDate.TabIndex = 6;
            this.kryptonLabelEndDate.Values.Text = "结束日期";
            // 
            // kryptonLabelStartDate
            // 
            this.kryptonLabelStartDate.Location = new System.Drawing.Point(39, 30);
            this.kryptonLabelStartDate.Name = "kryptonLabelStartDate";
            this.kryptonLabelStartDate.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabelStartDate.TabIndex = 5;
            this.kryptonLabelStartDate.Values.Text = "开始日期";
            // 
            // kryptonDateTimePickerEndDate
            // 
            this.kryptonDateTimePickerEndDate.CustomFormat = "yyyy-MM-dd";
            this.kryptonDateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePickerEndDate.Location = new System.Drawing.Point(121, 70);
            this.kryptonDateTimePickerEndDate.Name = "kryptonDateTimePickerEndDate";
            this.kryptonDateTimePickerEndDate.Size = new System.Drawing.Size(104, 21);
            this.kryptonDateTimePickerEndDate.TabIndex = 4;
            // 
            // kryptonDateTimePickerStartDate
            // 
            this.kryptonDateTimePickerStartDate.CustomFormat = "yyyy-MM-dd";
            this.kryptonDateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePickerStartDate.Location = new System.Drawing.Point(121, 30);
            this.kryptonDateTimePickerStartDate.Name = "kryptonDateTimePickerStartDate";
            this.kryptonDateTimePickerStartDate.Size = new System.Drawing.Size(104, 21);
            this.kryptonDateTimePickerStartDate.TabIndex = 3;
            // 
            // kryptonButtonReaderHolidayCancel
            // 
            this.kryptonButtonReaderHolidayCancel.Location = new System.Drawing.Point(161, 140);
            this.kryptonButtonReaderHolidayCancel.Name = "kryptonButtonReaderHolidayCancel";
            this.kryptonButtonReaderHolidayCancel.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonReaderHolidayCancel.TabIndex = 2;
            this.kryptonButtonReaderHolidayCancel.Values.Text = "取消";
            this.kryptonButtonReaderHolidayCancel.Click += new System.EventHandler(this.kryptonButtonReaderHolidayCancel_Click);
            // 
            // kryptonButtonReaderHolidayOk
            // 
            this.kryptonButtonReaderHolidayOk.Location = new System.Drawing.Point(20, 140);
            this.kryptonButtonReaderHolidayOk.Name = "kryptonButtonReaderHolidayOk";
            this.kryptonButtonReaderHolidayOk.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonReaderHolidayOk.TabIndex = 1;
            this.kryptonButtonReaderHolidayOk.Values.Text = "确定";
            this.kryptonButtonReaderHolidayOk.Click += new System.EventHandler(this.kryptonButtonReaderHolidayOk_Click);
            // 
            // FormReaderHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 212);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormReaderHoliday";
            this.Text = "读卡器节假日";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonReaderHolidayCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonReaderHolidayOk;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerStartDate;
    }
}

