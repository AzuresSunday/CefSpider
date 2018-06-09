using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefSpider
{
    class BoundObject
    {
        
        public void OnFrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                ChromiumWebBrowser browser = sender as ChromiumWebBrowser;
                browser.ExecuteScriptAsync(@"
          document.body.onmouseup = function()
          {
            //var xhttp = new XMLHttpRequest();xhttp.open('GET', '/notifications', false);xhttp.send();console.log(xhttp.responseText);
            //xhttp.responseText            
            var a='1';
            var b='2';
            boundobj.onSelected(a+b);//区分大小写！,首字母小写才能被c#方法名检测到，C#首字母大小写不受影响。其中boundobj受浏览器注册的名称RegisterJsObject中的方法决定的。
          }
        ");
            }
        }

        public void onSelected(string selected)
        {
            //MessageBox.Show("The user selected some text [" + selected + "]");
        }

    }
}
