﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class CurrentValues
    {
        int _BiletID;
        public int BiletID
        {
            get { return _BiletID; }
            set { _BiletID = value; }
        }
        string _CurrentTC;
        public string CurrentTC
        {
            get { return _CurrentTC; }
            set { _CurrentTC = value; }
        }

        int _SuccesID;
        public int SuccesID
        {
            get { return _SuccesID; }
            set { _SuccesID = value; }
        }
        

        int _UcusID;
        public int UcusID
        {
            get { return _UcusID; }
            set { _UcusID = value; }
        }


        int _MusteriID;
        public int MusteriID
        {
            get { return _MusteriID; }
            set { _MusteriID = value; }
        }
        int _KoltukID;
        public int KoltukID
        {
            get { return _KoltukID; }
            set { _KoltukID = value; }
        }
    }
}