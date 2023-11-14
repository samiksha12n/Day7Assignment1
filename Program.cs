using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day7Assignment1UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                string path = "D:\\";
                Console.WriteLine("Enter File Name");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (!File.Exists(fpath))
                {
                    File.Create(path);
                    Console.WriteLine($"File {fName} Creation Success");
                }
                else
                {
                    Console.WriteLine($"This file {fName} already exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finish");
                Console.ReadKey();
            }
            
            try
            {
                string path = "D:\\New Folder";
                Console.WriteLine("Enter File Name");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (!File.Exists(fpath))
                {
                    File.Delete(fpath);
                    Console.WriteLine($"File {fName} is Deleted");
                }
                else
                {    
                    
                    Console.WriteLine($"This file {fName} does not exists");
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finish");
                Console.ReadKey();
            }

            // Reading From File
            StreamReader sr;
            try
            {
                string fpath = "D://New Folder/file1.txt";
                sr = new StreamReader(fpath);
                string text = " ";
                while((text= sr.ReadLine())!= null)
                {
                    Console.WriteLine(text);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            //Appending File
            string fappend = "D://New Folder/file.txt";
            using (StreamWriter sw = File.AppendText(fappend))
            {
                sw.WriteLine("Its a Demo");
            }
            string readappend=File.ReadAllText(fappend);
            Console.WriteLine(readappend);
            Console.ReadKey();
        }
    }
}
