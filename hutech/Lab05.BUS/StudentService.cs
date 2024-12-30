﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.DAL.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Lab05.BUS
{
    public class StudentService
    {

        public List<Student> GetAll()

        {

            Model1 context = new Model1();

            return context.Students.ToList();

        }

        public List<Student> GetAllHasNoMajor()

        {

            Model1 context = new Model1();

            return context.Students.Where(p => p.MajorID == null).ToList();

        }

        public List<Student> GetAllHasNoMajor(int facultyID)

        {

            Model1 context = new Model1();

            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();

        }

        public Student FindById(string studentId)

        {

            Model1 context = new Model1();

            return context.Students.FirstOrDefault(p => p.StudentID == studentId);

        }

        public void InsertUpdate(Student s)

        {

            Model1 context = new Model1();

            context.Students.AddOrUpdate(s);

            context.SaveChanges();

        }
        private string avatarFilePath = string.Empty;

    }
}
