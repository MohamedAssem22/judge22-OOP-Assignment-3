namespace part_02.Enrollment;

public interface IPaymentGateway
{
    void Charge(string studentId, decimal amount);
}

public interface ISeatInventory
{
    void Reserve(string courseId, string studentId);
}

public interface IInvoiceGenerator
{
     string Create(string studentId, decimal amount); 
}

public interface IEmailService
{
     void Send(string studentId, string subject, string body); 
}
public class PaymentGateway : IPaymentGateway
{
    public void Charge(string studentId, decimal amount) =>
        Console.WriteLine($"charge {studentId}: {amount}");
}

public class SeatInventory : ISeatInventory
{
    public void Reserve(string courseId, string studentId) =>
        Console.WriteLine($"reserve seat {courseId} for {studentId}");
}

public class InvoiceGenerator : IInvoiceGenerator
{
    public string Create(string studentId, decimal amount)
    {
        var invoiceId = $"INV-{studentId}-{amount}";
        Console.WriteLine($"invoice {invoiceId}");
        return invoiceId;
    }
}

public class EmailService : IEmailService
{
    public void Send(string studentId, string subject, string body) =>
        Console.WriteLine($"email {studentId}: {subject} / {body}");
}

public  class EnrollmentManager
{
    private readonly IPaymentGateway _paymentGateway;
    private readonly ISeatInventory _seatInventory;
    private readonly IInvoiceGenerator _invoiceGenerator;
    private readonly IEmailService _emailService;
        
    public EnrollmentManager()
    {
        _emailService = new EmailService();
        _seatInventory = new SeatInventory(); 
        _paymentGateway = new PaymentGateway();
        _invoiceGenerator = new InvoiceGenerator(); 
    }



    public void Enroll(string studentId, string courseId, string subject, string body, decimal amount)
    {
        _paymentGateway.Charge(studentId, amount);          
        _seatInventory.Reserve(courseId, studentId);         
        _invoiceGenerator.Create(studentId, amount);         
        _emailService.Send(studentId, subject, body);        

    }
}