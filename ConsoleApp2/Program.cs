using System;

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string proKey = "pro";
        const string expKey = "expert";

        Console.WriteLine("Введите ключ доступа: ");
        string userInput = Console.ReadLine();

        DocumentWorker worker;

        if (userInput == proKey)
        {
            worker = new ProDocumentWorker();
        }
        else if (userInput == expKey)
        {
            worker = new ExpertDocumentWorker();
        }
        else
        {
            worker = new DocumentWorker();
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}
