using CefSpider.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CefSpider.Network
{
    class IpInfo
    {
        public string CurrentIpInfo { get; private set; }

        public string UpdateCurrentIpInfo()
        {
            HttpWebResponse response = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ip.taobao.com/service/getIpInfo2.php");
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";
                request.ServicePoint.Expect100Continue = false;
                request.Timeout = 60000;
                string body = @"ip=myip";
                byte[] postBytes = System.Text.Encoding.UTF8.GetBytes(body);
                request.ContentLength = postBytes.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(postBytes, 0, postBytes.Length);
                stream.Close();

                response = (HttpWebResponse)request.GetResponse();
                string responseText = ReadResponse(response);
                response.Close();

                IpJsonModel ipmodel = JsonConvert.DeserializeObject<IpJsonModel>(responseText);
                CurrentIpInfo = ipmodel.data.ip;
                return ipmodel.data.city + "：" + ipmodel.data.ip;
            }
            catch
            {
                CurrentIpInfo = "0.0.0.0";
                return "-【网络异常】";
            }
        }

        private static string ReadResponse(HttpWebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            {
                Stream streamToRead = responseStream;
                if (response.ContentEncoding.ToLower().Contains("gzip"))
                {
                    streamToRead = new GZipStream(streamToRead, CompressionMode.Decompress);
                }
                else if (response.ContentEncoding.ToLower().Contains("deflate"))
                {
                    streamToRead = new DeflateStream(streamToRead, CompressionMode.Decompress);
                }

                using (StreamReader streamReader = new StreamReader(streamToRead, Encoding.UTF8))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
