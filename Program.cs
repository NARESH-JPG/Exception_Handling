using System;

namespace Demo_Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {



            try
            {
                //Console.WriteLine("Enter your Favourate No");
                //string No =  Console.ReadLine();
                //Int32.Parse(No);

                //Console.WriteLine("No You entered {0}. valid Integer 32", No);

                throw new StudentNotFoundException("Student Not Found ", "NARESH");

            }

            catch (StudentNotFoundException s)
            {
                Console.WriteLine("student not found exception caught\n"+s.StudentName );
            }
            catch (FormatException fe)
            {

                Console.WriteLine("Invalid Integar Number", fe.Message);

                throw;


            }

            catch (OverflowException)
            {
                OverflowException a = new OverflowException();

                Console.WriteLine("Value You entered is too big to fit in int32", a.Source);
            }
            //catch(Exception)
            //{
            //    Console.WriteLine("Some Global Exception has occured and we are working on it .....!");
            //}
            finally
            {
                Console.WriteLine("Hope This Object Oriented way of handling Exception is Easy to Understnd and implement.!!!");
            }
            Console.WriteLine("------------------------------------------!");
        }
    }
}
