namespace MyComponents
{
    partial class ComponentDoorUnit
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuDelAccessPoint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripSaveMode = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuDelAccessPoint
            // 
            this.contextMenuDelAccessPoint.Name = "contextMenuDelAccessPoint";
            // 
            // contextMenuStripSaveMode
            // 
            this.contextMenuStripSaveMode.Name = "contextMenuStripSaveMode";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuDelAccessPoint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSaveMode;

    }
}
