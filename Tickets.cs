using System;
 using System.IO;
 using Nlog.Web;
using System.Collections.Generic;

 
namespace Tickets_with_Classes
{
    public class Tickets
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory()+"\\nlog.confog").GetCurrentClassLogger();
        
        static void Main(string[] args){

            string file ="Tickets.csv";

            string choice = "";

        do{
        logger.Info("Program started");
        
            Console.WriteLine("1)Read data from file");
            Console.WriteLine("2)Create file from data");
            Console.WriteLine("3) Press any key to exit program");

            choice = Console.ReadLine();

            logger.Info("User choice:{choice}",choice);

            if (choice == "1"){
                
                if (File.Exists(file)){
                         
                         StreamReader sr = new StreamReader(file);

                         while (!sr.EndOfStream){

                            string line = sr.ReadLine();

                            string [] arr = line.Split('|');

                            Console.WriteLine("choice: {1},choice {2}", arr [1],arr[2]);

                            if (choice == "2"){

        StreamWriter sw = new StreamWriter(file,append:true);
        for(int i =0; i < 7; i++) {
            
            {
              Console.WriteLine("Enter a Ticket (Y/N)?");

              string resp = Console.ReadLine().ToUpper();

               if (resp != "Y") 
               {
                break; 
               }

               Console.WriteLine("Enter the name of who submitted the ticket");

               string name = Console.ReadLine().ToUpper();


              Console.WriteLine("Enter the ticket's description");

              string description = Console.ReadLine().ToUpper();
               
               Console.WriteLine("Enter Ticket's Status");

               string status = Console.ReadLine().ToUpper();

               sw.WriteLine (name);

               sw.WriteLine ( description);

               sw.WriteLine(status);

            }
            
               sw.Close(); 

            }
        
            while (choice == "1"|choice == "2");
        }else {

           Console.WriteLine("File does not exist");

        }  
            sr.Close();
                    } 

          logger.Info("Program ended");
        } 
    } 


