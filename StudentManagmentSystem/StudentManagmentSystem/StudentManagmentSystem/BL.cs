using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    class BL
    {
        public static string[] student_name = new string[100];
        public static string[] program = new string[100];
        public static string[] email = new string[100];
        public static string[] address = new string[100];
        public static int[] student_id = new int[100];
        public static int[] phone_number = new int[100];
        public static int id = 0, index;
        public void set_student_name(string name, int record_number)
        {
            student_name[record_number] = name;
        }
        public void set_program(string prog, int record_number)
        {
            program[record_number] = prog;
        }
        public void set_email(string mail, int record_number)
        {
            email[record_number] = mail;
        }
        public void set_address(string add, int record_number)
        {
            address[record_number] = add;
        }
        public void set_phone_number(int phone, int record_number)
        {
            phone_number[record_number] = phone;
        }
        public void set_student_id(int id, int record_number)
        {
            student_id[record_number] = id;
        }
        public int get_student_id()
        {
            id++;
            return id;
        }
        public string get_student_name(int record_number)
        {
            return student_name[record_number];
        }
        public string get_program(int record_number)
        {
            return program[record_number];
        }
        public string get_email(int record_number)
        {
            return email[record_number];
        }
        public string get_address(int record_number)
        {
            return address[record_number];
        }
        public int get_phone_number(int record_number)
        {
            return phone_number[record_number];
        }
        public int serach(int id, int record_number)
        {
            for (int i = 0; i < record_number; i++)
            {
                if (id == student_id[i])
                {
                    index = i;
                    return i;

                }
            }
            return -1;
        }
        public void deletion(int record_number)
        {
            for (int i = index; i < record_number - 1; i++)
            {
                student_id[i] = student_id[i + 1];
                phone_number[i] = phone_number[i + 1];
                program[i] = program[i + 1];
                student_name[i] = student_name[i + 1];
                email[i] = email[i + 1];
                address[1] = address[i + 1];
            }
        }
    }
}

