using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace KryptonAccessController.RelationRealTimeMoni
{
    public partial class FormPictureMovable : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private Point pt = Point.Empty; // 记录鼠标按下时的坐标
        private Point def = Point.Empty; // 记录鼠标按下panel横纵滚动条的值

        //IDevicePointGroup iDevicePointGroup = new FactoryDataBase().CreateDevicePointGroup();
        public FormPictureMovable()
        {
            InitializeComponent();
        }

        private void pictureBoxElectronicMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Cursor = Cursors.SizeAll;
            pt = this.PointToClient(pictureBoxElectronicMap.PointToScreen(e.Location)); // 鼠标是按在picturebox上，需要转化成相对于panel的坐标
            def.X = this.panel1.HorizontalScroll.Value; // HScroll值
            def.Y = this.panel1.VerticalScroll.Value; // VScroll值
        }

        private void pictureBoxElectronicMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            if (Cursor != Cursors.SizeAll) return;
            Point cur = this.PointToClient(pictureBoxElectronicMap.PointToScreen(e.Location)); // 当前鼠标坐标，同样需要转化成相对于panel的坐标
            cur = new Point(pt.X - cur.X, pt.Y - cur.Y); // 计算差

            cur.X = def.X + cur.X; // 计算和
            cur.Y = def.Y + cur.Y;

            if (0 > cur.X)
                cur.X = 0;  // 如果超出范围，需要修正
            if (this.panel1.HorizontalScroll.Maximum < cur.X)
                cur.X = this.panel1.HorizontalScroll.Maximum;
            if (0 > cur.Y)
                cur.Y = 0;
            if (this.panel1.VerticalScroll.Maximum < cur.Y)
                cur.Y = this.panel1.VerticalScroll.Maximum;


            if (this.panel1.HorizontalScroll.Visible)
                this.panel1.HorizontalScroll.Value = cur.X;  // 如果存在对应的滚动条，则赋值

            if (this.panel1.VerticalScroll.Visible)
                this.panel1.VerticalScroll.Value = cur.Y;
        }

        private void pictureBoxElectronicMap_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}