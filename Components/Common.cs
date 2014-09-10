using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyComponents
{
    class Common
    {
        public static Image scaleImage(Image img, double scale)
        {

            System.Drawing.Bitmap objPic, objNewPic;
            try
            {
                objPic = new System.Drawing.Bitmap(img);
                double doubleHeight = objPic.Height * scale;
                double doubleWidth = objPic.Width * scale;

                objNewPic = new System.Drawing.Bitmap(objPic, Convert.ToInt32(doubleWidth), Convert.ToInt32(doubleHeight));
            }
            catch
            {
                objNewPic = null;
            }
            return objNewPic;
        }

        public static void AddButtonItemToContextMenuStrip(ContextMenuStrip contextMenuStrip, string contextMenuName, string contextMenuText, EventHandler clickeven)
        {
            ToolStripMenuItem newToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            newToolStripMenuItem.Name = contextMenuName;
            newToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            newToolStripMenuItem.Text = contextMenuText;
            newToolStripMenuItem.Click += new System.EventHandler(clickeven);

            contextMenuStrip.Items.Add(newToolStripMenuItem);
        }
    }
}
