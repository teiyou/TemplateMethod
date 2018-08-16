using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPLC currentPLC = new OmronPLC("192.168.124.123", "123", "12394");
            AbstractPLC otherPLC = new TwinCatPLC("192.168.100.20");
            currentPLC.PropertyChanged +=Update;
            currentPLC.Connection();
        }
        private  static  void  Update(object sender,PropertyChangedEventArgs e)
        {

        }



    }
}
