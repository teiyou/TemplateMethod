using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Template
{
   public   abstract class AbstractPLC
    {

        #region  字段
        protected string _plcIP;
        private bool _isConnected;
        #endregion



        #region 属性
        public string PLCIP
        {
            get { return _plcIP; }
        }


        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                if (PropertyChanged != null)
                    this.PropertyChanged.BeginInvoke(this, new PropertyChangedEventArgs("IsConnnected"), null
                        , null);

            }
        }

        #endregion


        #region  事件
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        #region 方法

        public abstract bool Connection();
        public abstract bool WriteValue(int address, string value);
        // public abstract bool WriteValues(int[] list_Address, string[] list_Values);
        public abstract string ReadValue(int address);
        #endregion




    }
}
