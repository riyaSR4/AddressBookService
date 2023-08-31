﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookService
{
    public class Operations
    {
        private SqlConnection con;
        private void Connection()
        {
            string connectionStr = "data source = (localdb)\\MSSQLLocalDB; initial catalog = AddressBookService; integrated security = true";
            con = new SqlConnection(connectionStr);
        }
        public void AddContact(AddressBook obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("AddContact", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstName", obj.FirstName);
                com.Parameters.AddWithValue("@lastName", obj.LastName);
                com.Parameters.AddWithValue("@address", obj.Address);
                com.Parameters.AddWithValue("@city", obj.City);
                com.Parameters.AddWithValue("@state", obj.State);
                com.Parameters.AddWithValue("@zip", obj.Zip);
                com.Parameters.AddWithValue("@phoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@email", obj.Email);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Added");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateContact(AddressBook obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("UpdateContact", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstName", obj.FirstName);
                com.Parameters.AddWithValue("@lastName", obj.LastName);
                com.Parameters.AddWithValue("@address", obj.Address);
                com.Parameters.AddWithValue("@city", obj.City);
                com.Parameters.AddWithValue("@state", obj.State);
                com.Parameters.AddWithValue("@zip", obj.Zip);
                com.Parameters.AddWithValue("@phoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@email", obj.Email);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Updated");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteContact(string FirstName)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DeleteContact", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstName", FirstName);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void City(string city)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("City", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@city", city);
                con.Open();
                int i = com.ExecuteNonQuery();
                List<AddressBook> addressBook = new List<AddressBook>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new AddressBook
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            FirstName = Convert.ToString(dr["firstName"]),
                            LastName = Convert.ToString(dr["lastName"]),
                            Address = Convert.ToString(dr["address"]),
                            City = Convert.ToString(dr["city"]),
                            State = Convert.ToString(dr["state"]),
                            Zip = Convert.ToInt32(dr["zip"]),
                            PhoneNumber = Convert.ToString(dr["phoneNumber"]),
                            Email = Convert.ToString(dr["email"]),
                        });
                }
                Console.WriteLine("The persons in city " + city +" are: ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.FirstName + " " + data.LastName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void State(string state)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("State", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@state", state);
                con.Open();
                int i = com.ExecuteNonQuery();
                List<AddressBook> addressBook = new List<AddressBook>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new AddressBook
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            FirstName = Convert.ToString(dr["firstName"]),
                            LastName = Convert.ToString(dr["lastName"]),
                            Address = Convert.ToString(dr["address"]),
                            City = Convert.ToString(dr["city"]),
                            State = Convert.ToString(dr["state"]),
                            Zip = Convert.ToInt32(dr["zip"]),
                            PhoneNumber = Convert.ToString(dr["phoneNumber"]),
                            Email = Convert.ToString(dr["email"]),
                        });
                }
                Console.WriteLine("The persons in the state " + state + " are: ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.FirstName + " " + data.LastName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void SizeByCity()
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("SizeByCity", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                int i = com.ExecuteNonQuery();
                List<AddressBook> addressBook = new List<AddressBook>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new AddressBook
                        {
                            City = Convert.ToString(dr["city"]),
                            Count = Convert.ToInt32(dr["count"])
                        });
                }
                Console.WriteLine("No.of persons in each city are ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.City + "--" + data.Count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void SizeByState()
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("SizeByState", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                int i = com.ExecuteNonQuery();
                List<AddressBook> addressBook = new List<AddressBook>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new AddressBook
                        {
                            State = Convert.ToString(dr["state"]),
                            Count = Convert.ToInt32(dr["count"])
                        });
                }
                Console.WriteLine("No.of persons in each state are ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.State + "--" + data.Count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}