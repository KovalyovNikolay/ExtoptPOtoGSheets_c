using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtoptPOtoGSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            string testPO_adr = @"D:\Game.po"; // add test info
            string testAPI = "MYgoogleSPREADSHEETapiEXAMPLE"; // add test api string
            // test string needs to check output
            /*
             Example
            start
            SetData() - get strings from user end aply to variables
            GetData() - get data from PO file
            ExportData() - export data to the google spreadsheet
            end...

            SetData(){}
            GetData() {}
            ExportData() {}
             */
            Console.WriteLine("DUser. Please enter data:");
            Console.WriteLine("");
            Console.WriteLine("Your API is: '{0}'", testAPI);
            Console.WriteLine("Your PO file name is: '{0}'", Path.GetFileName(testPO_adr));
            Console.WriteLine("Your PO file path is: '{0}'", Path.GetDirectoryName(testPO_adr));
            Console.ReadKey();
        }
        //private void SetData() { }

    }
}
