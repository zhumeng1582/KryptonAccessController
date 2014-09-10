namespace KryptonAccessController.RelationManage
{
    partial class FormLogin
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.kryptonPaneLogin = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.buttonCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comboBoxUserName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelFailInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBoxUserPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelUserPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPaneLogin)).BeginInit();
            this.kryptonPaneLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUserName)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(356, 193);
            // 
            // kryptonPaneLogin
            // 
            this.kryptonPaneLogin.Controls.Add(this.buttonCancel);
            this.kryptonPaneLogin.Controls.Add(this.buttonLogin);
            this.kryptonPaneLogin.Controls.Add(this.comboBoxUserName);
            this.kryptonPaneLogin.Controls.Add(this.labelFailInfo);
            this.kryptonPaneLogin.Controls.Add(this.textBoxUserPassword);
            this.kryptonPaneLogin.Controls.Add(this.labelUserPassword);
            this.kryptonPaneLogin.Controls.Add(this.labelUserName);
            this.kryptonPaneLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPaneLogin.Location = new System.Drawing.Point(0, 0);
            this.kryptonPaneLogin.Name = "kryptonPaneLogin";
            this.kryptonPaneLogin.Size = new System.Drawing.Size(323, 223);
            this.kryptonPaneLogin.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Values.Text = "È¡Ïû";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(78, 146);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 25);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Values.Text = "µÇÂ¼";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.DisplayMember = "0";
            this.comboBoxUserName.DropDownWidth = 100;
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Items.AddRange(new object[] {
            "Admin",
            "zhangchao"});
            this.comboBoxUserName.Location = new System.Drawing.Point(145, 16);
            this.comboBoxUserName.MaxLength = 8;
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(100, 23);
            this.comboBoxUserName.TabIndex = 16;
            this.comboBoxUserName.Text = "Admin";
            this.comboBoxUserName.ValueMember = "0";
            // 
            // labelFailInfo
            // 
            this.labelFailInfo.ForeColor = System.Drawing.Color.Red;
            this.labelFailInfo.Location = new System.Drawing.Point(68, 105);
            this.labelFailInfo.Name = "labelFailInfo";
            this.labelFailInfo.Size = new System.Drawing.Size(92, 20);
            this.labelFailInfo.TabIndex = 15;
            this.labelFailInfo.Values.Text = "ÃÜÂëÊäÈë´íÎó";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(145, 51);
            this.textBoxUserPassword.MaxLength = 6;
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxUserPassword.TabIndex = 12;
            this.textBoxUserPassword.Text = "rdm123";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Location = new System.Drawing.Point(70, 54);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(58, 20);
            this.labelUserPassword.TabIndex = 11;
            this.labelUserPassword.Values.Text = "ÃÜ  Âë£º";
            // 
            // labelUserName
            // 
            this.labelUserName.Location = new System.Drawing.Point(68, 24);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 20);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Values.Text = "ÓÃ»§Ãû£º";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kryptonPaneLogin);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(323, 223);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(323, 223);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(323, 223);
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormLogin";
            this.Text = "µÇÂ¼";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Ktypton1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPaneLogin)).EndInit();
            this.kryptonPaneLogin.ResumeLayout(false);
            this.kryptonPaneLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUserName)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPaneLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelFailInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxUserPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelUserPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelUserName;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;

    }
}

