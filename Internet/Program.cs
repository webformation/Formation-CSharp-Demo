using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Internet
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest req =  WebRequest.Create("http://www.lemonde.fr/");
            WebResponse resp = req.GetResponse();

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://www.lemonde.fr/");
            // Turn off connection keep-alives. 
            httpReq.KeepAlive = false;
            HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();

            //Get the HTTP content length returned by the server.
            String contentLength = httpResp.ContentLength.ToString();

            // Get the response stream.
            Stream respstrm = resp.GetResponseStream();
            // Create a buffer to hold the response data.
            int BufferSize = 512;
            Byte[] Buffer = new Byte[BufferSize];
            // Read the stream to access the data.
            int bytesRead = respstrm.Read(Buffer, 0, BufferSize);
            while (bytesRead > 0)
            {
                Console.Write(
                   Encoding.ASCII.GetString(Buffer, 0, bytesRead));
                bytesRead = respstrm.Read(Buffer, 0, BufferSize);
            }
            respstrm.Close();
        }
    }
}
