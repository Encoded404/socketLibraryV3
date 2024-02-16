using System.Net;
using System.Net.Sockets;

namespace socketClientV3
{
    public class socketClient
    {
        public void initialize()
        {

        }
        public void sendBytes(byte[] data, int id)
        {

        }
    }
    // a class that can get the api for the server in the form of a textdocument of values, gets it by calling server with byte = 0;
    class apiHandler
    {
        byte[] sizeBuffer = new byte[] { 0 };
        byte[] buffer;
        Socket APISocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        public string apiReference;
        public void init(IPEndPoint serverIp)
        {
            APISocket.Connect(serverIp);
            APISocket.ReceiveTimeout = 500;

        }
        public void getAPIText()
        {
            try
            {
                sizeBuffer = new byte[] { 0 };
                APISocket.Send(sizeBuffer);
                APISocket.Receive(sizeBuffer);
                APISocket.Receive(buffer = new byte[sizeBuffer[0]]);
            }
            catch (SocketException ex)
            {
                //throw warni
            }
        }
    }
}