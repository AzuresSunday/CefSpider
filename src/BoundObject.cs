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
            var xhttp = new XMLHttpRequest();xhttp.open('GET', '/notifications', false);xhttp.send();console.log(xhttp.responseText);
            bound.onSelected(xhttp.responseText);
          }
        ");
            }
        }

        public void OnSelected(string selected)
        {
            MessageBox.Show("The user selected some text [" + selected + "]");
        }

    }
}
