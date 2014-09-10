namespace KryptonAccessController.RelationManage
{
    partial class FormManager
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
            this.kryptonLabelPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelFailInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.labelFailInfo);
            this.kryptonPanel.Controls.Add(this.kryptonButtonCancel);
            this.kryptonPanel.Controls.Add(this.kryptonButtonOK);
            this.kryptonPanel.Controls.Add(this.kryptonLabelPassword);
            this.kryptonPanel.Controls.Add(this.kryptonLabelName);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxPassword);
            this.kryptonPanel.Controls.Add(this.kryptonTextBoxName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 246);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButtonCancel
            // 
            this.kryptonButtonCancel.Location = new System.Drawing.Point(133, 163);
            this.kryptonButtonCancel.Name = "kryptonButtonCancel";
            this.kryptonButtonCancel.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonCancel.TabIndex = 5;
            this.kryptonButtonCancel.Values.Text = "取消";
            this.kryptonButtonCancel.Click += new System.EventHandler(this.kryptonButtonCancel_Click);
            // 
            // kryptonButtonOK
            // 
            this.kryptonButtonOK.Location = new System.Drawing.Point(22, 163);
            this.kryptonButtonOK.Name = "kryptonButtonOK";
            this.kryptonButtonOK.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonOK.TabIndex = 4;
            this.kryptonButtonOK.Values.Text = "确定";
            this.kryptonButtonOK.Click += new System.EventHandler(this.kryptonButtonOK_Click);
            // 
            // kryptonLabelPassword
            // 
            this.kryptonLabelPassword.Location = new System.Drawing.Point(22, 84);
            this.kryptonLabelPassword.Name = "kryptonLabelPassword";
            this.kryptonLabelPassword.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabelPassword.TabIndex = 3;
            this.kryptonLabelPassword.Values.Text = "密码:";
            // 
            // kryptonLabelName
            // 
            this.kryptonLabelName.Location = new System.Drawing.Point(22, 31);
            this.kryptonLabelName.Name = "kryptonLabelName";
            this.kryptonLabelName.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabelName.TabIndex = 2;
            this.kryptonLabelName.Values.Text = "姓名:";
            // 
            // kryptonTextBoxPassword
            // 
            this.kryptonTextBoxPassword.Location = new System.Drawing.Point(68, 81);
            this.kryptonTextBoxPassword.Name = "kryptonTextBoxPassword";
            this.kryptonTextBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBoxPassword.TabIndex = 1;
            // 
            // kryptonTextBoxName
            // 
            this.kryptonTextBoxName.Location = new System.Drawing.Point(68, 28);
            this.kryptonTextBoxName.Name = "kryptonTextBoxName";
            this.kryptonTextBoxName.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBoxName.TabIndex = 0;
            // 
            // labelFailInfo
            // 
            this.labelFailInfo.Location = new System.Drawing.Point(22, 137);
            this.labelFailInfo.Name = "labelFailInfo";
            this.labelFailInfo.Size = new System.Drawing.Size(6, 2);
            this.labelFailInfo.TabIndex = 6;
            this.labelFailInfo.Values.Text = "";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 246);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormManager";
            this.Text = "管理员";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelFailInfo;
    }
}

