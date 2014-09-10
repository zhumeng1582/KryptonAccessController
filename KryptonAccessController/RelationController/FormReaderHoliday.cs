using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.ResourcesFile;

namespace KryptonAccessController.RelationController
{
    public partial class FormReaderHoliday : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private OpenMode openMode;
        private AccessDataBase.Model.ReaderInfo modelReaderInfo = new AccessDataBase.Model.ReaderInfo();

        private AccessDataBase.Model.ReaderHoliday modelHoliay = new AccessDataBase.Model.ReaderHoliday();
        private AccessDataBase.BLL.ReaderHoliday bllHoliday = new AccessDataBase.BLL.ReaderHoliday();

        public FormReaderHoliday(OpenMode openMode, AccessDataBase.Model.ReaderInfo modelReaderInfo, AccessDataBase.Model.ReaderHoliday modelHoliay)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = GetResourcesFile.getSystemIco();
            this.CenterToScreen();

            this.openMode = openMode;
            this.modelReaderInfo = modelReaderInfo;
            this.modelHoliay = modelHoliay;
            if (openMode == OpenMode.Update)
            {
                kryptonDateTimePickerStartDate.Value = Convert.ToDateTime(modelHoliay.ReaderHolidayStartDate);
                kryptonDateTimePickerEndDate.Value = Convert.ToDateTime(modelHoliay.ReaderHolidayEndDate);
            }
            else if(openMode == OpenMode.Add)
            { }
        }

        private void kryptonButtonReaderHolidayOk_Click(object sender, EventArgs e)
        {
            modelHoliay.ReaderHolidayStartDate = kryptonDateTimePickerStartDate.Value.ToString().Substring(0, 10).Replace('/','-');
            modelHoliay.ReaderHolidayEndDate = kryptonDateTimePickerEndDate.Value.ToString().Substring(0, 10).Replace('/', '-');

            if (openMode == OpenMode.Add)
            {
                modelHoliay.ReaderID = modelReaderInfo.ReaderID;
                modelHoliay.ReaderHolidayName = "";
                modelHoliay.ReaderHolidayID = bllHoliday.GetMaxId();
                if (bllHoliday.Add(modelHoliay))
                    this.Close();
            }
            else if (openMode == OpenMode.Update)
            {
                if (bllHoliday.Update(modelHoliay))
                    this.Close();
            }

        }

        private void kryptonButtonReaderHolidayCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}