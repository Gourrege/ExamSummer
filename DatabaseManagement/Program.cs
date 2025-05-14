﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSummer;

namespace DatabaseManagement
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            PatientData db = new PatientData(); //creating the Database

            using (db) 
            {
                Patient p1 = new Patient()
                {
                    FirstName = "John",
                    Surname = "Smith",
                    DOB = new DateTime(2000, 01, 31),
                    ContactNumber = "086 123 4567"
                };


                Patient p2 = new Patient()
                {
                    FirstName = "Mary",
                    Surname = "Jones",
                    DOB = new DateTime(1980, 06, 15),
                    ContactNumber = "087 323 2585"
                };

                Patient p3 = new Patient()
                {
                    FirstName = "Jim",
                    Surname = "Ryan",
                    DOB = new DateTime(2005, 03, 10),
                    ContactNumber = "086 568 7896"
                };

                db.Patients.Add(p1);
                db.Patients.Add(p2);
                db.Patients.Add(p3);

                Console.WriteLine("Patients Added to Database");

                db.SaveChanges(); //Saves the database

                Console.WriteLine("Database Saved");
            }

        }
    }
}
