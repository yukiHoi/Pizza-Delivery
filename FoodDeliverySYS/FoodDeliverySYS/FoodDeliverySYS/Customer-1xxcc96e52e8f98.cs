﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data.SqlTypes;

namespace FoodDeliverySYS
{
    internal class Customer
    {
        private int customer_id;
        private string first_name;
        private string last_name;
        private string email;
        private int phone_no;
        private string address;
        private string county;
        private string town;
        private string eircode;


        public Customer()
        {
            this.customer_id = 0;
            this.first_name = "";
            this.last_name = "";
            this.email = "";
            this.phone_no = 0;
            this.address = "";
            this.county = "";
            this.town = "";
            this.eircode = "";
        }

        public Customer(int customer_id, string first_name, string last_name, string email, int phone_no, string address, string county, string town, string eircode)
        {
            this.customer_id = customer_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.address = address;
            this.county = county;
            this.town = town;
            this.eircode = eircode;
        }
        public int getCustomer_id() { return this.customer_id; }
        public String getFirst_name() { return this.first_name; }
        public String getLast_name() { return this.last_name; }
        public String getEmail() { return this.email; }
        public int getPhone_no() { return this.phone_no; }
        public string getAddress() { return this.address; }
        public String getCounty() { return this.county; }
        public String getTown() { return this.town; }
        public String getEircode() { return this.eircode; }

        public void setCustomer_id(int Customer_id) { customer_id = Customer_id; }
        public void setFirst_name(String First_name) { first_name = First_name; }
        public void setLast_name(String Last_name) { last_name = Last_name; }
        public void setEmail(String Email) { email = Email; }
        public void setPhone_no(int Phone_no) { phone_no = Phone_no; }
        public void setAddress(String Address) { address = Address; }
        public void setCounty(String County) { county = County; }
        public void setTown(String Town) { town = Town; }
        public void setEircode(String Eircode) { eircode = Eircode; }
        public static DataSet getAllCustomer()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Customer_id, first_name, last_name,email, phone_no, address, county, town,eircode " +
                "FROM Customer ORDER BY customer_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllCustomer(String Last_name) //filter search by last name
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT customer_id, first_name,last_name,email,phone_no,address,county,town,eircode " +
                "FROM Customer WHERE last_name = '" +  Last_name + "'ORDER BY first_name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");

            conn.Close();
            return ds;
        }
        public void getCustomer(int Customer_id) //This method will get the customer details from the database
        { 
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM Customer WHERE customer_id = " + Customer_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();  //read data from the reader


                setCustomer_id(dr.GetInt32(0)); //get the customer id from the database
                setFirst_name(dr.GetString(1));     //get the first name from the database
                setLast_name(dr.GetString(2));         //get the last name from the database etc
                setEmail(dr.GetString(3));
                setPhone_no(dr.GetInt32(4));
                setAddress(dr.GetString(5));
                setCounty(dr.GetString(6));
                setTown(dr.GetString(7));
                setEircode(dr.GetString(8));
            

            //close DB
            conn.Close();
        }
        public void addCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Customer VALUES (" +
                 this.customer_id + ",'" +
                 this.first_name + "','" +
                 this.last_name + "','" +
                 this.email + "','" +         
                 this.phone_no + "','" +     
                 this.address + "','" +       
                 this.county + "','" +       
                 this.town + "','" +          
                 this.eircode + "')";         

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void updateCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);


            String sqlQuery = "UPDATE Customer SET " +
                               "customer_id = " + this.customer_id + ", " +
                               "first_name = '" + this.first_name + "', " +
                               "last_name = '" + this.last_name + "', " +
                               "email = '" + this.email + "', " +
                               "phone_no = " + this.phone_no + ", " +
                               "address = '" + this.address + "', " +
                               "county = '" + this.county + "', " +
                               "town = '" + this.town + "', " +
                               "eircode = '" + this.eircode + "' " +
                               "WHERE customer_id = " + this.customer_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
        
            conn.Open();
            cmd.ExecuteNonQuery();
             conn.Close();
        }
        public static DataSet findCustomer(String last_name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
         
                conn.Open();
                string sqlQuery = "SELECT customer_id, first_name, last_name, email, phone_no, address, county, town, eircode " +
                                  "FROM Customer " +
                                  "WHERE last_name LIKE '%" + last_name + "%' ORDER BY last_name";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Customer");

                return ds;            
        }

        public void deRegisterCustomer() //This method to deRegister the customer but not really deRegister, only update to Anonymous
        {
            OracleConnection conn = new OracleConnection( DBConnect.oraDB);

            string sqlQuery = "UPDATE Customer SET " +
                     "first_name = 'Anonymous', " +
                     "last_name = 'User', " +
                     "email = 'anonymous@example.com', " +  
                     "phone_no = '0000000000', " +          
                     "address = 'anonymous', " +            
                     "county = 'anonymous', " +            
                     "town = 'anonymous', " +               
                     "eircode = '0000000' " +            
                     "WHERE customer_id = " + this.customer_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int getNextCustomer_id()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(customer_id) FROM Customer";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Declare a variable to store the next customer id
            int nextCustomerId;
            dr.Read();

            if (dr.IsDBNull(0)) //if the result is null, then the next customer id is 1
                nextCustomerId = 1;
            else
            {
                nextCustomerId = dr.GetInt32(0) + 1; //if the result is not null, then the next customer id is the max customer id + 1
            }

            //Close db connection
            conn.Close();

            return nextCustomerId;
        }
       

    }
}
