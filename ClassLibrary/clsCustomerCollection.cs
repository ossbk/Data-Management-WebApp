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
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {

                clsCustomer AnCustomer = new clsCustomer();

                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["OnlineStatus"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);

                mCustomerList.Add(AnCustomer);
                Index++;
            
            }
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
             clsDataConnection DB = new clsDataConnection();

            // DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
             DB.AddParameter("@Email", mThisCustomer.Email);
             DB.AddParameter("@Password", mThisCustomer.Password);
             DB.AddParameter("@DateOfBirth", mThisCustomer.DateAdded);
             DB.AddParameter("@Address", mThisCustomer.Address);
             DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
             DB.AddParameter("@OnlineStatus", mThisCustomer.Active);

             return DB.Execute("sproc_tblCustomer_Insert");
           //
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("@OnlineStatus", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}