using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1GradeManager
{
    static class StudentManagement
    {
        static string userInput;
        static int selection1;
        static int selection2;
        static int selection;
        static bool validInput;
        public static List<int> studentGrades = new List<int>();
        public static List<string> students = new List<string>();        
        public class Student
        {
            public List<string> students = new List<string>();
            public static List<int> studentGrades = new List<int>();
            // public static List<string> studentList = new List<string>();
        }        
        static public void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Class Management Portal");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1: Student Management");
            Console.WriteLine("2: Grade Management");
            Console.WriteLine("3: Exit the Program");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            userInput = Console.ReadLine();
            validInput = int.TryParse(userInput, out selection);

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Student Management Portal");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Please choose from the following options: ");
                    Console.WriteLine();
                    Console.WriteLine("1: Add Student");
                    Console.WriteLine("2: Edit Student");
                    Console.WriteLine("3: Remove Student");
                    Console.WriteLine("4: View all students in class");
                    Console.WriteLine("5: Return to the previous Menu");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                    userInput = Console.ReadLine();
                    validInput = int.TryParse(userInput, out selection);

                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Please enter the name of the student to be added to the system");
                            Console.WriteLine("--------------------------------------------------------------");
                            string userInput = Console.ReadLine();
                            Console.WriteLine($"{userInput} has been added to the class.");
                            students.Add(userInput);
                            studentGrades.Add(0);
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("Press Enter to return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Please select from the following students to Edit");
                            Console.WriteLine("-------------------------------------------------");
                            for (int x = 0; x < students.Count; x++)
                            {
                                Console.WriteLine($"{x}: {students[x]}");
                            }
                            userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection);
                            Console.WriteLine("Please enter updated student name.");
                            string newUser = Console.ReadLine();
                            students.RemoveAt(selection);
                            students.Insert(selection, newUser);
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Student name has been updated in the system.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Please select from the following students to Remove");
                            Console.WriteLine("---------------------------------------------------");
                            for (int x = 0; x < students.Count; x++)
                            {
                                Console.WriteLine($"{x}: {students[x]}");
                            }
                            userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection);
                            students.RemoveAt(selection);
                            // if (studentGrades[selection] <= studentGrades.Count )
                            studentGrades.RemoveAt(selection);
                            Console.WriteLine($"Student has been removed from the class along with grade associated with student");
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Please press enter to return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Students currently enrolled in course: ");
                            Console.WriteLine("---------------------------------------");
                            foreach (string student in students)
                            {
                                Console.WriteLine(student);
                            }
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to return to the Student Management Portal");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                        case 5:
                            Console.Clear();
                            StudentMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid Input, Press Enter to return to the Class Management Portal.");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                    }
                    StudentMenu();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Please choose from the following options: ");
                    Console.WriteLine("----------------------------------------- ");
                    Console.WriteLine("1: Add Grade");
                    Console.WriteLine("2: Edit Grade");
                    Console.WriteLine("3: Remove Grade");
                    Console.WriteLine("4: View all Grades");
                    Console.WriteLine("5: Class GPA");
                    Console.WriteLine("6: Show top Student");
                    Console.WriteLine("7: Show bottom Student");
                    Console.WriteLine("8: Return to the previous Menu");
                    Console.WriteLine("----------------------------------------- ");
                    userInput = Console.ReadLine();
                    validInput = int.TryParse(userInput, out selection);

                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Please enter the name of the student to add a grade for");
                            Console.WriteLine("-------------------------------------------------------");
                            for (int x = 0; x < students.Count; x++)
                            {
                                Console.WriteLine($"{x}: {students[x]}");
                            }
                            string userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection);
                            Console.WriteLine($"Please enter the grade for {students[selection]}:");
                            userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection2);
                            studentGrades.RemoveAt(selection);
                            studentGrades.Insert(selection, selection2);

                            studentGrades.RemoveAt(selection);
                            studentGrades.Insert(selection, selection2);
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to return to the return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;                            
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Please select from the following student grades to Edit");
                            Console.WriteLine("-------------------------------------------------------");
                            for (int x = 0; x < students.Count; x++)
                            {
                                Console.WriteLine($"{x}: {students[x]}");
                            }
                            userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection1);
                            Console.WriteLine("Please enter updated student grade.");
                            string userInput1 = Console.ReadLine();
                            validInput = int.TryParse(userInput1, out selection2);
                            studentGrades.RemoveAt(selection1);
                            studentGrades.Insert(selection1, selection2);
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Grades have been edited, press enter to return to the previous menu");
                            Console.ReadLine();
                            Console.Clear();                            
                            StudentMenu();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Please select from the following student grades to Remove");
                            Console.WriteLine("---------------------------------------------------------");
                            for (int x = 0; x < students.Count; x++)
                            {
                                Console.WriteLine($"{x}: {students[x]}");
                            }
                            userInput = Console.ReadLine();
                            validInput = int.TryParse(userInput, out selection);
                            studentGrades.RemoveAt(selection);
                            studentGrades.Insert(selection, 0);
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Grade has been removed and set to 0%. Ensure to add a current grade for the current student. \nPress enter to return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;                            
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Current Grades for all students in the class");
                            Console.WriteLine("--------------------------------------------");
                            for (int i = 0; i < students.Count; i++)
                            {
                                    Console.Write(students[i] + ": ");
                                    Console.WriteLine(studentGrades[i] + "%");                                                             
                            }
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return to the previous menu");
                            Console.ReadLine();
                            Console.Clear();
                            StudentMenu();
                            break;
                        case 5:
                            Console.Clear();
                            int gpa = 0;
                            for (int i = 0; i < students.Count; i++)
                            {
                                Console.Write(students[i] + ": ");
                                Console.WriteLine(studentGrades[i] + "%");
                                gpa = gpa + studentGrades[i];
                            }
                            int studentsGpa = gpa / students.Count;
                            Console.WriteLine($"The GPA for the class is {studentsGpa}%");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Press enter to return to the previous menu");
                            Console.ReadLine();
                            Console.Clear();
                            StudentMenu();
                            break;
                        case 6:
                            Console.Clear();
                            int maxValue = studentGrades.Max();
                            int maxIndex = studentGrades.IndexOf(maxValue);
                            Console.WriteLine("Top Student");
                            Console.WriteLine("-----------");
                            Console.WriteLine($"{students[maxIndex]}");
                            Console.WriteLine($"{studentGrades[maxIndex]}%");
                            Console.WriteLine("-----------");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return to the previous menu");
                            Console.ReadLine();
                            Console.Clear();
                            StudentMenu();
                            break;
                        case 7:
                            Console.Clear();
                            int minValue = studentGrades.Min();
                            int minIndex = studentGrades.IndexOf(minValue);
                            Console.WriteLine("Lowest Student");
                            Console.WriteLine("--------------");
                            Console.WriteLine($"{students[minIndex]}");
                            Console.WriteLine($"{studentGrades[minIndex]}%");
                            Console.WriteLine("--------------");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return to the previous menu");
                            Console.ReadLine();
                            StudentMenu();
                            break;
                        case 8:
                            Console.Clear();
                            StudentMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid Input, Press Enter to return to the Class Management Portal.");
                            Console.ReadLine();
                            break;

                    }
                    StudentMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Class Manager Portal.");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to exit the system.");
                    Environment.Exit(-1);
                    break;
                default :
                    Console.WriteLine("Invalid Input, Press Enter to return to the Class Management Portal.");
                    Console.ReadLine();
                    StudentMenu();
                    break;

            }

        }
        public static void LoadClass()
        {
            students.Add("Kyle");
            students.Add("Thomas");
            students.Add("Brendan");
            students.Add("Noah");
            studentGrades.Add(90);
            studentGrades.Add(95);
            studentGrades.Add(89);
            studentGrades.Add(70);
        }
    }
}
    

