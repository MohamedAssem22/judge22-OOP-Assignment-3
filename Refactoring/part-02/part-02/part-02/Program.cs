using System;
using part_02.Enrollment;
using part_02.Reports;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Testing EnrollmentManager ===");

        var paymentGateway = new PaymentGateway();
        var seatInventory = new SeatInventory();
        var invoiceGenerator = new InvoiceGenerator();
        var emailService = new EmailService();

        var enrollmentManager = new EnrollmentManager(); 
      

        enrollmentManager.Enroll(
            studentId: "S-105", 
            courseId: "CS-101", 
            subject: "Course Confirmation", 
            body: "You have successfully enrolled in C# Basics.", 
            amount: 150.00m
        );

        Console.WriteLine("\n=== 2. Testing Report Exporters (Template Method) ===");
        
        string csvPath = "report.csv";
        string jsonPath = "report.json";
        string textPath = "report.txt";

    
        MakeReport csvExporter = new CsvReportExporter();
        csvExporter.Export(csvPath);
        Console.WriteLine($"[Success] CSV Report exported to {csvPath}");

      
        MakeReport jsonExporter = new JsonReportExporter();
        jsonExporter.Export(jsonPath);
        Console.WriteLine($"[Success] JSON Report exported to {jsonPath}");

       
        MakeReport textExporter = new TextReportExporter();
        textExporter.Export(textPath);
        Console.WriteLine($"[Success] Text Report exported to {textPath}");

        Console.WriteLine("\nAll Part 02 tests executed successfully!");
    }
}