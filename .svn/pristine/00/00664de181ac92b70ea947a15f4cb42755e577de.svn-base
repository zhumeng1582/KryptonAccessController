using System;
using KryptonAccessController.ResourcesFile;
using System.Windows.Forms;

namespace KryptonAccessController.Home
{
    public partial class WebServer : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        
        string url;
        static WebServer instance = null;

        public static WebServer getInstance()
        {
            if (instance == null)
            {
                instance = new WebServer();
            }
            return instance;
        }
        private WebServer()
        {
            InitializeComponent();
            url = "http://www.datarfid.com";
        }

        private void WebServer_Load(object sender, EventArgs e)
        {
            this.Icon = GetResourcesFile.getSystemIco();
            webBrowser1.Url = new System.Uri(url, System.UriKind.Absolute);
        }
        public void BringToFrontAndRefresh()
        {
            this.BringToFront();
            webBrowser1.Url = new System.Uri(url, System.UriKind.Absolute);
        }
    }
}
