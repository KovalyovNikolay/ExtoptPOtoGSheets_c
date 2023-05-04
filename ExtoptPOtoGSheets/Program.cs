using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExtoptPOtoGSheets
{
   public class UData
	{
		private string EngPO;// = @"D:\Game.po"; // add test info
		private string RuPO;// = @"D:\Game.po"; // add test info
		private string gspreadsheetAPI;// = "MYgoogleSPREADSHEETapiEXAMPLE"; // add test api string

		// empty construct
        public UData() { }
        // custom cunstruct
        public UData(string aAPI, string engPO, string ruPO) 
        { 
            this.gspreadsheetAPI = aAPI;
            this.EngPO = engPO;
            this.RuPO = ruPO;
        }
        // getters and setters
        public string GetAPIkey() { return this.gspreadsheetAPI;}
        public void SetAPIkey(string aAPI) { this.gspreadsheetAPI = aAPI;}
        public string GetEngPO() { return this.EngPO;}
        public void SetEngPO(string aEngPO) { this.EngPO = aEngPO;}
        public string GetRuPO() { return this.RuPO;}
        public void SetRuPO(string aRuPO) { this.RuPO = aRuPO;}
	}

    class Program
    {
        private void SetUserData(UData userdata)
        {        
            Console.WriteLine("------------------------------------------------")
            Console.WriteLine("-               SET CURRENT DATA               -")
            Console.WriteLine("------------------------------------------------")     
            Console.WriteLine("DUser. Please enter data:");
            Console.WriteLine("");
            Console.WriteLine("Google spreadsheet API: ");
            userdata.SetAPIkey(Console.ReadLine());
            Console.WriteLine("EngPO file path: ");
            userdata.SetEngPO(Console.ReadLine());
            Console.WriteLine("RuPO file path: ");
            userdata.SetRuPO(Console.ReadLine());           
            Console.WriteLine("------------------------------------------------")           
            Console.WriteLine("")
        }
        private void GetPOData(UData userdata)
        { 
            Console.WriteLine("------------------------------------------------")
            Console.WriteLine("-               GET DATA FROM PO               -")
            Console.WriteLine("------------------------------------------------")
        }
        private void ExportData(UData userdata)
        { 
            Console.WriteLine("------------------------------------------------")
            Console.WriteLine("-                  EXPORT DATA                 -")
            Console.WriteLine("------------------------------------------------")
        }
        private void ListData(UData userdata)
        {
            Console.WriteLine("------------------------------------------------")
            Console.WriteLine("-               GET CURRENT DATA               -")
            Console.WriteLine("------------------------------------------------")
            Console.WriteLine("User API key: '{0}'", userdata.GetAPIkey());
            Console.WriteLine("User EngPO: '{0}'", userdata.GetEngPO());
            Console.WriteLine("User RuPO: '{0}'", userdata.GetRuPO());            
            Console.WriteLine("------------------------------------------------")           
            Console.WriteLine("")
        }
        
        static void Main(string[] args)
        {
            //string testPO_adr = @"D:\Game.po"; // add test info
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
            UData udata = new UData(); // create clear object 
        }
    }
}
