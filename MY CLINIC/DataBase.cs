﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MY_CLINIC
{
    internal class DataBase
    {
        public static string Con = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=MyClinic; Integrated Security=True";
        public static SqlConnection cn = new(Con);
        public static bool Login(string user, string pass)
        {
            cn.Open();
            SqlDataAdapter d=new("select username, password from accounts where username='" + user + "'and password='" + pass + "'", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public static void Register_Emp(string user, string pass, string name,string phone,float salary)
        {
            string query="Insert Into Accounts (Username,Password,Name,Phone,Salary) Values('"+user+"','"+pass+"','"+name+"','"+phone+"','"+salary+"')";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static bool IsAdmin(string user, string pass)
        {
            cn.Open();
            SqlDataAdapter d = new("Select IsAdmin from Accounts where Username='" + user + "'and Password='" + pass + "'",cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return (bool)dt.Rows[0][0];
        }
        public static void Register_Patient(string name, int age, string phone, string gender, string email, string his)
        {
            string query = "Insert Into Patients (Name,Age,Gender,Phone,E_mail,Chronic_Conditions) Values('"+name+"','"+age+"','"+gender+"','"+phone+"','"+email+"','"+his+"')";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static string Get_Empname(string user, string pass)
        {
            cn.Open();
            SqlDataAdapter d = new("Select Name from Accounts where Username='" + user + "'and Password='" + pass + "'", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close(); 
            return dt.Rows[0][0].ToString();
        }
        public static DataTable Get_AllPatient()
        {
            cn.Open();
            SqlDataAdapter d = new("Select Name from Patients", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return dt;
            //for (int i = 0; i < carsTableAdapter.GetByBrand(brand.Text).Count; i++)

            //{
            //    model.Items.Add(carsTableAdapter.GetByBrand(brand.Text)[i][2]);
            //}
        }
        public static DataTable Get_AllEmp()
        {
            cn.Open();
            SqlDataAdapter d = new("Select Name from Accounts", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return dt;
        }
        public static void Update_Salary(string name,float sal)
        {
            string query = "UPDATE Accounts SET Salary = '"+sal+"' WHERE Name='"+name+"'";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static DataTable Get_AllServices()
        {
            cn.Open();
            SqlDataAdapter d = new("Select Name from Services", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return dt;
        }
        public static float Get_ServPrice(string name)
        {
            cn.Open();
            SqlDataAdapter d = new("Select Price from Services where Name='" + name + "'", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return (float)dt.Rows[0][0];
        }
        public static string Get_ServID(string name)
        {
            cn.Open();
            SqlDataAdapter d = new("Select ID from Services where Name='" + name + "'", cn);
            DataTable dt = new();
            d.Fill(dt);
            cn.Close();
            return dt.Rows[0][0].ToString();
        }
        public static void Update_ServPrice(string name, float price)
        {
            string query = "UPDATE Services SET Price= '" + price + "' WHERE Name='" + name + "'";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static void Add_toSchedule(int id, string Pname, string Ename, string type, float price, string Date, string hour)
        {
            string query = "Insert Into Schedule (ID, Patient_Name, Emp_Name, Type, Price, AppDate, Start_End_Hour)) " +
                "Values('" + id + "','" + Pname + "','" + Ename + "','" + type + "','" + price + "','" + Date + "','"+hour+"')";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static void Delete_Schedule()
        {
            string query = "Delete From Schedule";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
        public static void Register_Appointment(int id, string Pname, string Ename, string type, float price, string Date, string hour)
        {
            string query = "Insert Into Appointments (ID, Patient_Name, Emp_Name, Type, Price, AppDate, Start_End_Hour)) " +
                "Values('" + id + "','" + Pname + "','" + Ename + "','" + type + "','" + price + "','" + Date + "','" + hour + "')";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}

