using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using KryptonAccessController.AccessDataBase.BLL;
using KryptonAccessController.AccessDataBase.Model;
using KryptonAccessController.WidgetThread;
using KryptonAccessController.ResourcesFile;


namespace KryptonAccessController.RelationTimePlan
{
    public partial class TimeAccessInfo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        AccessDataBase.BLL.TimeAccess bllTimeAccess = new AccessDataBase.BLL.TimeAccess();
        AccessDataBase.Model.TimeAccess modelTimeAccess = new AccessDataBase.Model.TimeAccess();

        AccessDataBase.BLL.UserGroup bllUserGroup = new AccessDataBase.BLL.UserGroup();
        AccessDataBase.Model.UserGroup modelUserGroup = new AccessDataBase.Model.UserGroup(); 

        private static object obj = new object();
        static TimeAccessInfo _instance = null;
        public static TimeAccessInfo getInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new TimeAccessInfo();
                    }
                }
            }
            return _instance;
        }

        private TimeAccessInfo()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = GetResourcesFile.getSystemIco();

            kryptonContextMenuItem3.Click += new EventHandler(kryptonContextMenuItem3_Click);
            kryptonContextMenuItem2.Click += new EventHandler(kryptonContextMenuItem2_Click);

            initToolStripMenu();
        }

        private void TimeAccessInfo_Load(object sender, EventArgs e)
        {
            initKryptonTreeViewAccessTime();
        }
        public void initToolStripMenu()
        {
            toolStripAccessTimeInfo.Items.Clear();
            ImageOperate.AddButtonItemToToolStrip(toolStripAccessTimeInfo, "add.BMP", "¹ýÂË", toolStripButtonFilter_Click);
        }
        public void toolStripButtonFilter_Click(object sender, EventArgs e) { }
        private void initKryptonTreeViewAccessTime() 
        {
            

            List<KryptonAccessController.AccessDataBase.Model.UserGroup> listUserGroup = bllUserGroup.GetModelList("1=1");
            foreach (AccessDataBase.Model.UserGroup model in listUserGroup)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = model.UserGroupID.ToString();
                treeNode.Text = model.UserGroupName;
                kryptonTreeViewAccessTime.Nodes.Add(treeNode);
                
            }

        }

        private void kryptonTreeViewAccessTime_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;

            TreeNode treeNode = kryptonTreeViewAccessTime.SelectedNode;
            if (treeNode != null) 
            {
                modelUserGroup = bllUserGroup.GetModel(int.Parse(treeNode.Name));
                DataTable dt = bllTimeAccess.GetList("UserGroupID=" + modelUserGroup.UserGroupID).Tables[0];
                kryptonDataGridViewAccessTime.DataSource = dt;
            }
        }
        private void kryptonContextMenuItem2_Click(object sender, EventArgs e) 
        { 

        }
        private void kryptonContextMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}