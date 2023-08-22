public interface IReadableDocument
{
    void Read();
}

public interface IProcessableDocument
{
    void Process();
}

public class PDFDocument : IReadableDocument, IProcessableDocument
{
    public void Read()
    {
        Console.WriteLine("Lendo conteúdo de um arquivo PDF...");
    }

    public void Process()
    {
        Console.WriteLine("Processando um arquivo PDF...");
    }
}

public class SpreadsheetDocument : IReadableDocument, IProcessableDocument
{
    public void Read()
    {
        Console.WriteLine("Lendo conteúdo de uma planilha...");
    }

    public void Process()
    {
        Console.WriteLine("Processando uma planilha...");
    }
}

public class DocumentProcessor
{
    public void ProcessDocument(IReadableDocument readableDoc, IProcessableDocument processableDoc)
    {
        readableDoc.Read();
        processableDoc.Process();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var pdfDocument = new PDFDocument();
        var spreadsheetDocument = new SpreadsheetDocument();

        var documentProcessor = new DocumentProcessor();
        documentProcessor.ProcessDocument(pdfDocument, pdfDocument);
        documentProcessor.ProcessDocument(spreadsheetDocument, spreadsheetDocument);
    }
}