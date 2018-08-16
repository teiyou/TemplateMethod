using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Template
{
    public class OmronPLC : AbstractPLC
    {

        private string _localIP;
        private TcpClient _tcpClient;
        private NetworkStream _netStream;



        public OmronPLC(string plcIP,string plcPort,string localIP)
        {
            base._plcIP = plcIP;
            this._localIP = localIP ;
        }



        public override string ReadValue(int address)
        {
            throw new NotImplementedException();
        }

        public override bool WriteValue(int address, string value)
        {
            throw new NotImplementedException();
        }

        public override bool Connection()
        {

            throw new NotImplementedException();
        }
    }
}
