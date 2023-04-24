﻿

using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
       
        
        
        public clsCustomerCollection()
        {
             clsCustomer TestItem = new clsCustomer();

             TestItem.Active = true;
             TestItem.Address = "First street";
             TestItem.ContactNumber = "123456789";
             TestItem.DateAdded = DateTime.Now.Date;
             TestItem.Email = "example1@gmail.com";
             TestItem.Password = "password1";

             mCustomerList.Add(TestItem);

             TestItem = new clsCustomer();
             TestItem.Active = true;
             TestItem.Address = "second street";
             TestItem.ContactNumber = "987654321";
             TestItem.DateAdded = DateTime.Now.Date;
             TestItem.Email = "example22@gmail.com";
             TestItem.Password = "password22";
             mCustomerList.Add(TestItem);

          /* Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAddress_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {

                clsCustomer AnCustomer = new clsCustomer();

                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);

                mCustomerList.Add(AnCustomer);
                Index++;
            
            }*/
        }
        

        public List<clsCustomer> CustomerList 
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }


        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //
            }

        }
        public clsCustomer ThisCustomer {
            get
            {
                return mThisCustomer;
            }

            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            mThisCustomer.CustomerID = 1;
            return mThisCustomer.CustomerID;
        }
    }
}