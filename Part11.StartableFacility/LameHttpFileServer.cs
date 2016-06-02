using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Castle.Core.Logging;

namespace Part11.StartableFacility
{
    public class LameHttpFileServer : IStartable
    {
        private readonly string _path;
        private readonly HttpListener _listener;
        private Thread _listenerThread;

        public ILogger Logger { get; set; } = NullLogger.Instance;

        public LameHttpFileServer(string prefix, string path)
        {
            _path = path;
            _listener = new HttpListener();
            _listener.Prefixes.Add(prefix);
        }

        
        public void Start()
        {
            Logger.Debug("Starting LameWebService...");
            _listener.Start();
            _listenerThread = new Thread(RequestWorker);
            _listenerThread.Start();
            Logger.Info("LameWebService Started.");
        }

        public void Stop()
        {
            Logger.Debug("Stopping LameWebService...");
            _listenerThread.Abort();
            _listener.Stop();
            Logger.Info("Stopped LameWebService.");
        }

        private void RequestWorker()
        {
            while (true)
            {
                HttpListenerContext context = null;

                try
                {
                    context = _listener.GetContext();
                }
                catch (ObjectDisposedException)
                {
                    return;
                }

                ServeContent(context.Response, _path);
            }
        }

        private void ServeContent(HttpListenerResponse response, string path)
        {
            string content = File.ReadAllText(path);
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            response.ContentLength64 = buffer.Length;

            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}
