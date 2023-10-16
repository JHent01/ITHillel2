using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_2
{
    abstract class DocumentWorker
    {
       


        public string openDocument;
        public string editDocument;
        public string saveDocument;


        public DocumentWorker()
        {
            



            this.openDocument = "Документ відкритий";
            this.editDocument = "Редагування документа доступне у версії Про";
            this.saveDocument = "Збереження документа доступне у версії Про";

          

            openDocument = OpenDocument(openDocument);
            editDocument = EditDocument(editDocument);
            saveDocument = SaveDocument(saveDocument);


        }
        public abstract string OpenDocument(string open);
        public abstract string EditDocument(string edit);
        public abstract string SaveDocument(string save);

    }
}
