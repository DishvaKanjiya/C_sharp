/*Write a program with following specifications: Class Name: Student Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI Get Students Details using constructor and DisplayStudentDetails() using
member function.*/

using System;

class Student_Demo
{
    public static void Main()
    {
        Student st = new Student();
        st.displayStudentsDetails();
    }
}

class Student
{
    int enrollmentnumber;
    string studentname;
    int semester;
    double cpi;
    double spi;

    public Student()
    {
        Console.WriteLine("Please enter Enrollment Number : ");
        this.enrollmentnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter Student's Name : ");
        this.studentname = Console.ReadLine();
        Console.WriteLine("Please enter Semester : ");
        this.semester = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter CPI : ");
        this.cpi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter SPI : ");
        this.spi = Convert.ToDouble(Console.ReadLine());
    }

    public void displayStudentsDetails()
    {
        Console.WriteLine("Enrollment Number : {0}", enrollmentnumber);
        Console.WriteLine("Student's Name : {0}", studentname);
        Console.WriteLine("Semester : {0}", semester);
        Console.WriteLine("CPI : {0}", cpi);
        Console.WriteLine("SPI : {0}", spi);
    }
}
