using System;
 using System.IO;
 using NLog.Web;
using System.Collections.Generic;

 
namespace Ticket
{
    public class Program
    {
        private const string V = "Tickets.csv";
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

        static void Main(string[] args)
        {

            logger.Info("Program started");

             Tickets ticket1  = new Tickets ("//Tickets.csv");

            string file = "\\Tickets.csv";

            string choice = "";

        do{

            Console.WriteLine("1) Read data from file");
            Console.WriteLine("2) Create file from data");
            Console.WriteLine("3) Press any key to exit program");

            choice = Console.ReadLine();

            logger.Info("User choice:{choice}",choice);
        {
           if (choice == "1"){

                if (File.Exists(file)){
                         
                  StreamReader sr = new StreamReader(file);

                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                    }
                    sr.Close();
                    }

                    }else if(choice == "2"){

               StreamWriter sw = new StreamWriter(file,append:true);

              Console.WriteLine("Enter a Ticket (Y/N)?");

               Console.ReadLine();{

               foreach(char Tickets in "Tickets.csv");

                    {
                        Console.WriteLine("Tickets.csv");
                    }

              try {Console.WriteLine("Enter the name of who submitted the ticket");

               string name = Console.ReadLine().ToUpper();

              Console.WriteLine("Enter the ticket's description");

              string description = Console.ReadLine().ToUpper();
               
               Console.WriteLine("Enter Ticket's Status");

               string status = Console.ReadLine().ToUpper();

               Console.ReadLine().ToUpper();

               sw.WriteLine($"{name},{description},{status}");

                sw.Close();
              }catch (IndexOutOfRangeException){

               Console.WriteLine("Index  was out of Range");        
              
             } 
             
              }
            }
          }
        }while(choice == "1"||choice == "2");

        logger.Info("Program ended");
      }
    }
  }
  
      
          

               
              
  
  

   


  


    


    

       
    
  



       
 
    
