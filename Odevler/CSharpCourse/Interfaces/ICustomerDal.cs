﻿using System;
namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();


    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }


        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySQLCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }


        public void Update()
        {
            Console.WriteLine("MySQL Updated");
        }
    }

    public class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {

            customerDal.Add();
        }
    }
}


