using proLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proLibrary.Data
{
	public class DummyData
	{
		public static List<Book> GetBooks()
		{
			List<Book> booklist = new List<Book>()
			{
				new Book(){bookName = "Harry Potter",authorName= "J.K Rowling",serialNumber= "1001",branch= "Stories",publications= "Bloomsbury" },
				new Book(){bookName = "HTML & CSS",authorName= "John",serialNumber= "1002",branch= "Web Development",publications= "John Wiley"  },
				new Book(){bookName = "Introduction to algorithm",authorName= "TCRC",serialNumber= "1003",branch= "Algorithms",publications= "MIT Press"  }
			};

			return booklist;
		}

		public static List<Student> GetStudentDetails()
		{
			List<Student> studentlist = new List<Student>()
			{
				new Student(){ studentName = "Dhivya",studentBranch = "CSE",gender = "Female", phoneNumber = "9988776655",address = "123,new street",city = "chennai",email = "abcdef@gmail.com",password  = "abcdef"},
				new Student(){ studentName = "Mike",studentBranch = "IT",gender = "Male", phoneNumber = "9888765432",address = "456,old street",city = "chennai",email = "ghijkl@gmail.com",password  = "ghijkl"}
			};

			return studentlist;
		}
		public static List<IssuedBooks> GetIssuedBooks()
		{
			List<IssuedBooks> issuedBooklist = new List<IssuedBooks>()
			{
				new IssuedBooks(){ issuedBookName ="Harry Potter", issuedAuthorName ="J.K Rowling", issuedBookBranch ="Stories", issuedBookPublications ="Bloomsbury", issuedStudentName ="Dhivya",issuedStudentEmail  ="abcdef@gmail.com", fromDate="01-11-2020",toDate="15-11-2020"}				
			};

			return issuedBooklist;
		}

	}
}