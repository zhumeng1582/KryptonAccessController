using System;
using System.Windows.Forms;
namespace KryptonAccessController.WidgetThread
{
    class WidgetThread
    {
        public static void shakeLable(System.Windows.Forms.Control name)
        {

            ((ComponentFactory.Krypton.Toolkit.KryptonLabel)name).StateNormal.ShortText.Color1 = System.Drawing.Color.Red;

            Random ran = new Random((int)DateTime.Now.Ticks);
            System.Drawing.Point point = name.Location;

            for (int i = 0; i < 20; i++)
            {
                name.Location = new System.Drawing.Point(point.X + ran.Next(8) - 1, point.Y + ran.Next(8) - 1);
                System.Threading.Thread.Sleep(10);
                name.Location = point;
                System.Threading.Thread.Sleep(10);
            }
        }
        public static void displayFormOnPanel(Control.ControlCollection control, Form newForm)
        {
            bool isExist = control.Contains(newForm);
            if (isExist == false)
            {
                newForm.TopLevel = false;    //设置为非顶级窗体
                newForm.FormBorderStyle = FormBorderStyle.None;       //设置窗体为非边框样式
                newForm.Dock = System.Windows.Forms.DockStyle.Fill;   //设置样式是否填充整个PANEL
                control.Add(newForm);      //添加窗体
                newForm.Show();
            }
            newForm.BringToFront();
        }
    }
}
