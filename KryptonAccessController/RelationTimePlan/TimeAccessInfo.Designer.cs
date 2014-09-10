namespace KryptonAccessController.RelationTimePlan
{
    partial class TimeAccessInfo
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
            this.kryptonDataGridViewAccessTime = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonTreeViewAccessTime = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonContextMenuAccessTime = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.toolStripAccessTimeInfo = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewAccessTime)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDataGridViewAccessTime);
            this.kryptonPanel.Controls.Add(this.kryptonTreeViewAccessTime);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 25);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(436, 269);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonDataGridViewAccessTime
            // 
            this.kryptonDataGridViewAccessTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewAccessTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewAccessTime.Location = new System.Drawing.Point(143, 0);
            this.kryptonDataGridViewAccessTime.Name = "kryptonDataGridViewAccessTime";
            this.kryptonDataGridViewAccessTime.RowTemplate.Height = 23;
            this.kryptonDataGridViewAccessTime.Size = new System.Drawing.Size(293, 269);
            this.kryptonDataGridViewAccessTime.TabIndex = 1;
            // 
            // kryptonTreeViewAccessTime
            // 
            this.kryptonTreeViewAccessTime.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.kryptonTreeViewAccessTime.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.kryptonTreeViewAccessTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonTreeViewAccessTime.ItemHeight = 21;
            this.kryptonTreeViewAccessTime.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonTreeViewAccessTime.KryptonContextMenu = this.kryptonContextMenuAccessTime;
            this.kryptonTreeViewAccessTime.Location = new System.Drawing.Point(0, 0);
            this.kryptonTreeViewAccessTime.Name = "kryptonTreeViewAccessTime";
            this.kryptonTreeViewAccessTime.Size = new System.Drawing.Size(143, 269);
            this.kryptonTreeViewAccessTime.TabIndex = 0;
            this.kryptonTreeViewAccessTime.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.kryptonTreeViewAccessTime_NodeMouseDoubleClick);
            // 
            // kryptonContextMenuAccessTime
            // 
            this.kryptonContextMenuAccessTime.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuItem3});
            this.kryptonContextMenuItems1.Tag = "访问时间管理";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "添加时间组";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Text = "删除时间组";
            // 
            // toolStripAccessTimeInfo
            // 
            this.toolStripAccessTimeInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripAccessTimeInfo.Location = new System.Drawing.Point(0, 0);
            this.toolStripAccessTimeInfo.Name = "toolStripAccessTimeInfo";
            this.toolStripAccessTimeInfo.Size = new System.Drawing.Size(436, 25);
            this.toolStripAccessTimeInfo.TabIndex = 8;
            this.toolStripAccessTimeInfo.Text = "toolStrip1";
            // 
            // TimeAccessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 294);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.toolStripAccessTimeInfo);
            this.Name = "TimeAccessInfo";
            this.Text = "TimeAccessInfo";
            this.Load += new System.EventHandler(this.TimeAccessInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewAccessTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewAccessTime;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeViewAccessTime;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenuAccessTime;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private System.Windows.Forms.ToolStrip toolStripAccessTimeInfo;
    }
}

