using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_2
{
    internal class ProDocumentWorker : DocumentWorker
    {
       
        public string proEditDocument = "Документ відредаговано";
        public string proSaveDocument = "Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт";

       


        public override string OpenDocument(string open)
        {
            Console.WriteLine(base.openDocument);
            return "";
        }
        public override string EditDocument(string edit)
        {
            Console.WriteLine("Відреагуйте документ ");
            Console.ReadLine();
            Console.WriteLine(proEditDocument);
            return "";
        }



        public override string SaveDocument(string save)
        {
            Console.WriteLine("Зберегти документ?\n Так-1\tНі-2");

            int yesNo=int.Parse( Console.ReadLine()); 
            if (yesNo == 1) { Console.WriteLine(proSaveDocument); }
            else { Console.WriteLine("Документ не збереженно ");}
            
            return "";
        }

    }
}

