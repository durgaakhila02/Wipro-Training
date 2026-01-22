using System;

namespace DesignPatternsAssignment.Factory
{
    // Factory class
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            if (type == "PDF")
                return new PDFDocument();
            else if (type == "WORD")
                return new WordDocument();
            else
                throw new ArgumentException("Invalid document type");
        }
    }
}
