using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_2
{
    internal class ExpertDocumentWorker : DocumentWorker
    {
        
        public string exEditDocument = "Документ відредаговано";
        public string exSaveDocument= "Документ збережено у новому форматі";



        public override string OpenDocument(string open)
        {
            Console.WriteLine(base.openDocument);
            return "";
        }
        public override string EditDocument(string edit)
        {
            Console.WriteLine("Відреагуйте документ ");
            Console.ReadLine();
          
            Console.WriteLine( exEditDocument);
            return "";
        }



        public override string SaveDocument(string save)
        {
            Console.WriteLine("Зберегти документ?\n Так-1\tНі-2");
            int yesNo = int.Parse(Console.ReadLine());
            if (yesNo == 1) { Console.WriteLine(exSaveDocument); }
            else { Console.WriteLine("Документ не збереженно "); }
            return "";
        }
    }
}
    

