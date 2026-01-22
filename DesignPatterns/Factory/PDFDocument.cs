using System;

namespace DesignPatternsAssignment.Factory
{
    public class PDFDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }
    }
}
