using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    public class TwinCatPLC : AbstractPLC
    {


       public TwinCatPLC(string plcIP)
        {
            base._plcIP = plcIP;
        }

        public override bool Connection()
        {
            throw new NotImplementedException();
        }

        public override string ReadValue(int address)
        {
            throw new NotImplementedException();
        }

        public override bool WriteValue(int address, string value)
        {
            throw new NotImplementedException();
        }
    }
}
