using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a nested struct and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana                                                    
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur                                                  
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 */

namespace W3Resources.Structs
{
    class NestedStruct
    {
        struct employeeInfo
        {
            public string Name;
            public dOB Date;    

        }

        struct dOB
        {
            public int Day;
            public int Month;
            public int Year;
        }

        static void Main(string[] args)
        {
            int day = 0;
            int month = 0;
            int year = 0;

            int totalEmps = 0;


            Console.Write("\n\nCreate a nested struct and store data in an array :\n");
            Console.Write("-------------------------------------------------------\n");
            Console.WriteLine("Enter the number of employees you wish to record: ");
            totalEmps = int.Parse(Console.ReadLine());


            employeeInfo[] emp = new employeeInfo[totalEmps];

            for (int i = 0; i < totalEmps; i++)
            {
                Console.Write("Name of the employee : ");
                string nameInput = Console.ReadLine();
                emp[i].Name = nameInput;

                Console.Write("Input day of the birth : ");
                day = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = day;

                Console.Write("Input month of the birth : ");
                month = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = month;

                Console.Write("Input year for the birth : ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = year;
            }
        }
    }

    }

