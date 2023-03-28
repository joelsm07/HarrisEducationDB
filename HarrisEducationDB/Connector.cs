using HarrisEducationDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB
{
    internal class Connector
    {
        private string connString = "Server=harrisdb.c2nvpkkuc8e1.us-east-1.rds.amazonaws.com; User ID=admin;Password=Bethany777;Database=harrisdb";

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("Call sp_getStudent()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Student.Add(new Student)
                          {
                            studentId = reader.GetInt32(0),
                            firstName = reader.GetString(1),
                            lastName = reader.GetString(2),
                            gender = reader.GetString(3),
                            addressId = reader.GetString(4)
                          });
                    }
            }
            return students;
        }
    }
}                 


            
         

