namespace KryptonAccessController.RelationRealTimeMoni
{
    partial class FormElectronicMap
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
            this.labelElectronicMapName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelElectronicMapDes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelElectronicMapPath = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBoxElectronicMapName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxElectronicMapDes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxElectronicMapPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonElectronicMapPath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonElectronicMapOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelElectronicMapName
            // 
            this.labelElectronicMapName.Location = new System.Drawing.Point(18, 16);
            this.labelElectronicMapName.Name = "labelElectronicMapName";
            this.labelElectronicMapName.Size = new System.Drawing.Size(65, 20);
            this.labelElectronicMapName.TabIndex = 0;
            this.labelElectronicMapName.Values.Text = "地图名：";
            // 
            // labelElectronicMapDes
            // 
            this.labelElectronicMapDes.Location = new System.Drawing.Point(18, 52);
            this.labelElectronicMapDes.Name = "labelElectronicMapDes";
            this.labelElectronicMapDes.Size = new System.Drawing.Size(78, 20);
            this.labelElectronicMapDes.TabIndex = 1;
            this.labelElectronicMapDes.Values.Text = "地图描述：";
            // 
            // labelElectronicMapPath
            // 
            this.labelElectronicMapPath.Location = new System.Drawing.Point(18, 119);
            this.labelElectronicMapPath.Name = "labelElectronicMapPath";
            this.labelElectronicMapPath.Size = new System.Drawing.Size(78, 20);
            this.labelElectronicMapPath.TabIndex = 2;
            this.labelElectronicMapPath.Values.Text = "选择路径：";
            // 
            // textBoxElectronicMapName
            // 
            this.textBoxElectronicMapName.Location = new System.Drawing.Point(113, 14);
            this.textBoxElectronicMapName.Name = "textBoxElectronicMapName";
            this.textBoxElectronicMapName.Size = new System.Drawing.Size(130, 23);
            this.textBoxElectronicMapName.TabIndex = 3;
            // 
            // textBoxElectronicMapDes
            // 
            this.textBoxElectronicMapDes.Location = new System.Drawing.Point(113, 52);
            this.textBoxElectronicMapDes.MaxLength = 100;
            this.textBoxElectronicMapDes.Multiline = true;
            this.textBoxElectronicMapDes.Name = "textBoxElectronicMapDes";
            this.textBoxElectronicMapDes.Size = new System.Drawing.Size(130, 68);
            this.textBoxElectronicMapDes.TabIndex = 4;
            // 
            // textBoxElectronicMapPath
            // 
            this.textBoxElectronicMapPath.Location = new System.Drawing.Point(20, 150);
            this.textBoxElectronicMapPath.Name = "textBoxElectronicMapPath";
            this.textBoxElectronicMapPath.Size = new System.Drawing.Size(171, 23);
            this.textBoxElectronicMapPath.TabIndex = 5;
            // 
            // buttonElectronicMapPath
            // 
            this.buttonElectronicMapPath.Location = new System.Drawing.Point(197, 150);
            this.buttonElectronicMapPath.Name = "buttonElectronicMapPath";
            this.buttonElectronicMapPath.Size = new System.Drawing.Size(46, 25);
            this.buttonElectronicMapPath.TabIndex = 6;
            this.buttonElectronicMapPath.Values.Text = "...";
            this.buttonElectronicMapPath.Click += new System.EventHandler(this.buttonElectronicMapPath_Click);
            // 
            // buttonElectronicMapOK
            // 
            this.buttonElectronicMapOK.Location = new System.Drawing.Point(37, 191);
            this.buttonElectronicMapOK.Name = "buttonElectronicMapOK";
            this.buttonElectronicMapOK.Size = new System.Drawing.Size(75, 30);
            this.buttonElectronicMapOK.TabIndex = 7;
            this.buttonElectronicMapOK.Values.Text = "确定";
            this.buttonElectronicMapOK.Click += new System.EventHandler(this.buttonElectrniocOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(138, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Values.Text = "取消";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.labelElectronicMapName);
            this.kryptonPanel1.Controls.Add(this.buttonCancel);
            this.kryptonPanel1.Controls.Add(this.labelElectronicMapDes);
            this.kryptonPanel1.Controls.Add(this.buttonElectronicMapOK);
            this.kryptonPanel1.Controls.Add(this.labelElectronicMapPath);
            this.kryptonPanel1.Controls.Add(this.buttonElectronicMapPath);
            this.kryptonPanel1.Controls.Add(this.textBoxElectronicMapName);
            this.kryptonPanel1.Controls.Add(this.textBoxElectronicMapPath);
            this.kryptonPanel1.Controls.Add(this.textBoxElectronicMapDes);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(293, 241);
            this.kryptonPanel1.TabIndex = 9;
            // 
            // FormElectronicMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 241);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormElectronicMap";
            this.Text = "电子地图";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelElectronicMapName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelElectronicMapDes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelElectronicMapPath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxElectronicMapName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxElectronicMapDes;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxElectronicMapPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonElectronicMapPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonElectronicMapOK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}