using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerBridgeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int bYear;
            int evenOdd;
            string roygbiv;
            int bMonth;
        }

        //Method that greets user



        //method: # of years until retirment

        static int RetireYear()
        {
            int age;
        int bYear = 2018 - age; 
                                
        int evenOdd = bYear % 2; 
           
            
            if (evenOdd == 1)
            {
                return 30; 
            }

            if (evenOdd == 0) 
            {
                return  1;
            }
        }

        //method: determines vacation home

     static bool RetireHome()
     {
            int siblings;

            if (siblings <= 0)
            {
                Console.Write("on the island from 'Lost '");

            }

            if (siblings == 0)
            {
                Console.Write("in Rio, Brazil ");
            }
            
            if (siblings == 1)
            {
                Console.Write("in Scranton, PA ");
            }

            if (siblings == 2)
            {
                Console.Write("in Geneva, Switzerland ");
            }

            if (siblings == 3)
            {
                Console.Write("in Los Angeles, CA ");
            }

            if (siblings > 3)
            {
                Console.Write("in Sydney, Australia ");
            }
       }





        //method: mode of transportation

        public string Transport()
        {
            switch (roygbiv)
            {
                case "red":
                    return "pogo stick ";
                    break;

                case "orange":
                    return "submarine ";
                    break;

                case "yellow":
                    return "river boat ";
                    break;

                case "green":
                    return "batmobile ";
                    break;

                case "blue":
                    return "space shuttle ";
                    break;

                case "indigo":
                    return "hang glider ";
                    break;

                case "violet":
                    return "raft ";
                    break;
            }
        }

        //method: retirment money
         

        public double RetireMoney()
        {
            if ((bMonth <= 4) && (bMonth >= 1))
            {
                return: 100.00
            }
            if ((bMonth <= 0) || (bMonth > 12))
            {
                return 0.00;
            }
            if ((bMonth <= 8) && (bMonth >= 5))
            {
                return 1000.00;
            }
            if ((bMonth <= 12) && (bMonth >= 9))
            {
                return 10000.00;
            }
        }
        //method for how good fortune is
       public string
           {
           return "Wow, that is the worst fortune."; 
           }


        //method that allows useer to quit the program



        //method to allow user to restart the program at any point


    }
}
