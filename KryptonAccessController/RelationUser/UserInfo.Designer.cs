namespace KryptonAccessController.RelationUser
{
    partial class UserInfo
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
            this.dataGridViewWithCheckBox1 = new MyComponents.DataGridViewWithCheckBox();
            this.toolStripUserInfo = new System.Windows.Forms.ToolStrip();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kryptonTreeViewControllerList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dataGridViewWithCheckBox1);
            this.kryptonPanel.Controls.Add(this.toolStripUserInfo);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(408, 246);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dataGridViewWithCheckBox1
            // 
            this.dataGridViewWithCheckBox1.AllowUserToAddRows = false;
            this.dataGridViewWithCheckBox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWithCheckBox1.HaveCheckbox = true;
            this.dataGridViewWithCheckBox1.HaveEditLink = false;
            this.dataGridViewWithCheckBox1.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewWithCheckBox1.Name = "dataGridViewWithCheckBox1";
            this.dataGridViewWithCheckBox1.RowTemplate.Height = 23;
            this.dataGridViewWithCheckBox1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWithCheckBox1.Size = new System.Drawing.Size(408, 221);
            this.dataGridViewWithCheckBox1.TabIndex = 4;
            // 
            // toolStripUserInfo
            // 
            this.toolStripUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripUserInfo.Location = new System.Drawing.Point(0, 0);
            this.toolStripUserInfo.Name = "toolStripUserInfo";
            this.toolStripUserInfo.Size = new System.Drawing.Size(408, 25);
            this.toolStripUserInfo.TabIndex = 3;
            this.toolStripUserInfo.Text = "toolStrip1";
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "Edit";
            this.dataGridViewLinkColumn1.HeaderText = "Edit";
            this.dataGridViewLinkColumn1.LinkColor = System.Drawing.Color.Blue;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Text = "Edit";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.dataGridViewLinkColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // kryptonTreeViewControllerList
            // 
            this.kryptonTreeViewControllerList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.kryptonTreeViewControllerList.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlStandalone;
            this.kryptonTreeViewControllerList.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonTreeViewControllerList.ItemHeight = 21;
            this.kryptonTreeViewControllerList.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonTreeViewControllerList.Location = new System.Drawing.Point(408, 0);
            this.kryptonTreeViewControllerList.Name = "kryptonTreeViewControllerList";
            this.kryptonTreeViewControllerList.Size = new System.Drawing.Size(158, 246);
            this.kryptonTreeViewControllerList.TabIndex = 1;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 246);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonTreeViewControllerList);
            this.Name = "UserInfo";
            this.Text = "用户信息表";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.ToolStrip toolStripUserInfo;
        private MyComponents.DataGridViewWithCheckBox dataGridViewWithCheckBox1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeViewControllerList;
    }
}

