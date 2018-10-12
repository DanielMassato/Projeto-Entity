using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace LePaginaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetURL1()
        {
            string sURL;
            sURL = "http://www.microsoft.com";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            WebProxy myProxy = new WebProxy("vitara", 8088);
            myProxy.BypassProxyOnLocal = true;

            wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    tbx.Text +=  sLine + Environment.NewLine;
            }
            
        }

        void getURL2()
        {
            // used to build entire input
            StringBuilder sb = new StringBuilder();

            // used on each read operation
            byte[] buf = new byte[8192];

            // prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create("http://www.mayosoftware.com");
            try
            {
                // execute the request
                HttpWebResponse response = (HttpWebResponse)
                    request.GetResponse();
                // we will read data via the response stream
                Stream resStream = response.GetResponseStream();

                string tempString = null;
                int count = 0;

                do
                {
                    // fill the buffer with data
                    count = resStream.Read(buf, 0, buf.Length);

                    // make sure we read some data
                    if (count != 0)
                    {
                        // translate from bytes to ASCII text
                        tempString = Encoding.Unicode.GetString(buf, 0, count);

                        // continue building the string
                        sb.Append(tempString);
                    }
                }
                while (count > 0); // any more data to read?

                tbx.Text = sb.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BReq req = new BReq();
            string cep = tbxCEP.Text;
            string xml;
            if (!ckbProxy.Checked)
               xml = req.HttpGet("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep + "&formato=xml","","","");
                                        
            else
                xml = req.HttpGet("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep + "&formato=xml", "http://vitara:8088/", "internet", "internet");

            tbx.Text = xml;
            tbx.Text += Environment.NewLine;
            tbx.Text += Environment.NewLine;

            //XmlTextReader textReader = new XmlTextReader("C:\\books.xml");
           // XmlReader reader = XmlReader.Create(new StringReader(tbx.Text)); 
            
            // If the node has value

            //while (reader.Read())
            //{
            //    // Move to fist element
            //    reader.MoveToElement();
            //    tbx.Text += "Name:" + reader.Name + Environment.NewLine;
            //    tbx.Text += "Attribute Count:" + reader.AttributeCount.ToString() + Environment.NewLine;
            //    tbx.Text += "Depth:" + reader.Depth.ToString() + Environment.NewLine;
            //    tbx.Text += "BaseURI:" + reader.BaseURI + Environment.NewLine;
            //    tbx.Text += "Node Type:" + reader.NodeType.ToString() + Environment.NewLine;
            //    tbx.Text += "Value:" + reader.Value.ToString() + Environment.NewLine;
            //    tbx.Text +=  Environment.NewLine;

            //}

            XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(xml);
            tbx.Text += "resultado: " + doc.DocumentElement["resultado"].InnerText+ Environment.NewLine;
            tbx.Text += "uf:" + doc.DocumentElement["uf"].InnerText + Environment.NewLine;
            tbx.Text += "cidade:" + doc.DocumentElement["cidade"].InnerText + Environment.NewLine;
            tbx.Text += "bairro:" + doc.DocumentElement["bairro"].InnerText + Environment.NewLine;
            tbx.Text += "tipo_logradouro:" + doc.DocumentElement["tipo_logradouro"].InnerText + Environment.NewLine;
            tbx.Text += "logradouro:" + doc.DocumentElement["logradouro"].InnerText + Environment.NewLine; 

        }

        private void ckbProxy_CheckedChanged(object sender, EventArgs e)
        {
            gbProxy.Enabled = ckbProxy.Checked;
        }
    }

    /// <summary>
    /// A simple basic class for HTTP Requests.
    /// </summary>
    class BReq
    {
        /// <summary>
        /// UserAgent to be used on the requests
        /// </summary>
        public string UserAgent = @"Mozilla/5.0 (Windows; Windows NT 6.1) AppleWebKit/534.23 (KHTML, like Gecko) Chrome/11.0.686.3 Safari/534.23";

        /// <summary>
        /// Cookie Container that will handle all the cookies.
        /// </summary>
        private CookieContainer cJar;

        /// <summary>
        /// Performs a basic HTTP GET request.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <returns>HTML Content of the response.</returns>
        public string HttpGet(string url, string proxyURI, string proxyUsername, string proxyPasswors)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cJar;
            request.UserAgent = UserAgent;
            request.KeepAlive = false;
            request.Method = "GET";
                        
            WebProxy proxy = new WebProxy();
            if (proxyURI != "")
            {
                proxy.Address = new Uri(proxyURI);
                proxy.Credentials = new NetworkCredential("internet", "internet");
                request.Proxy = proxy;
            }
            
            // FUNCIONA: pega proxy.Address de IE
            //request.Proxy = HttpWebRequest.GetSystemWebProxy();
            //request.Proxy.Credentials = new NetworkCredential("internet", "internet");
           
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(),Encoding.Default);
            
            return sr.ReadToEnd();
        }

        /// <summary>
        /// Performs a basic HTTP POST request
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="post">POST Data to be passed.</param>
        /// <param name="refer">Referrer of the request</param>
        /// <returns>HTML Content of the response.</returns>
        public string HttpPost(string url, string post, string refer = "")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cJar;
            request.UserAgent = UserAgent;
            request.KeepAlive = false;
            request.Method = "POST";
            request.Referer = refer;

        

            byte[] postBytes = Encoding.ASCII.GetBytes(post);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            return sr.ReadToEnd();
        }

        /// <summary>
        /// Creates an HTML file from the string.
        /// </summary>
        /// <param name="html">HTML String.</param>
        public void DebugHtml(string html)
        {
            StreamWriter sw = new StreamWriter("debug.html");
            sw.Write(html);
            sw.Close();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BReq"/> class.
        /// </summary>
        public BReq()
        {
            cJar = new CookieContainer();
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="BReq"/> is reclaimed by garbage collection.
        /// </summary>
        ~BReq()
        {
            // Nothing here
        }
    }
}
