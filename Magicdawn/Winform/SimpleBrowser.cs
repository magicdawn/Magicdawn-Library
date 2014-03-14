using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Winform
{
    public partial class SimpleBrowser : UserControl
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SimpleBrowser()
        {
            InitializeComponent();
            this.IsTxtUrlEnabled = true;//默认启用
            this.txtUrl.Ok += delegate {
                this.btnGo.PerformClick();
            };
            this.Browser.StatusTextChanged += Browser_StatusTextChanged;
        }

        /// <summary>
        /// 输网址的文本框是否可用
        /// </summary>
        [DefaultValue(true),Description("输网址的文本框是否可用")]
        public bool IsTxtUrlEnabled { get; set; }

        #region 工具栏按钮
        private void toolStripBtnBack_Click(object sender,EventArgs e)
        {
            if(this.Browser.CanGoBack)
            {
                this.Browser.GoBack();
            }
        }

        private void toolStripBtnRefesh_Click(object sender,EventArgs e)
        {
            this.Browser.Refresh();
        }

        private void btn_Click(object sender,EventArgs e)
        {
            if(this.Browser.CanGoForward)
            {
                this.Browser.GoForward();
            }
        }

        private void toolStripButton4_Click(object sender,EventArgs e)
        {
            this.Browser.GoHome();
        }
        #endregion

        #region Browser事件
        private void Browser_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            
            foreach(HtmlElement link in this.Browser.Document.Links)
            {
                //链接在本窗体打开
                link.SetAttribute("target","_self");
            }
        }

        private void Browser_Navigating(object sender,WebBrowserNavigatingEventArgs e)
        {
            this.txtUrl.Text = e.Url.ToString();
        }

        private void Browser_Navigated(object sender,WebBrowserNavigatedEventArgs e)
        {
            this.txtUrl.Text = e.Url.ToString();
        }

        private void Browser_StatusTextChanged(object sender,EventArgs e)
        {
            this.lblStatusState.Text = this.Browser.StatusText;
        }
        #endregion

        private void btnGo_Click(object sender,EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.txtUrl.Text))
            {
                this.Browser.Navigate(
                    this.GetCompleteUrl(this.txtUrl.Text)
                );
            }
        }

        private void tmrGetTime_Tick(object sender,EventArgs e)
        {
            this.lblStatusTime.Text = "现在是" + DateTime.Now.ToStringX();
        }

        //如果不存在,添加http://
        string GetCompleteUrl(string url)
        {

            if(!url.StartWithOneOf("http://","https://"))
            {
                url = "http://" + url;
            }
            return url;
        }
    }
}
