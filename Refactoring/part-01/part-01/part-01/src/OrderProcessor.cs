namespace part_01;

public interface IEmailSender
{
     void SendEmail(string to, string body); 
}

public interface ISaveRepository
{
    void SaveRepo(int orderId, DateTime processedAt); 
}

public class SqlOrderRepository : ISaveRepository
{
    public void SaveRepo(int orderId, DateTime processedAt)
    {
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}

public class SmtpEmailSender : IEmailSender
{
    public void SendEmail(string to, string body)
    {
        Console.WriteLine($"[SMTP] to={to} body={body}");

    }
}

public class OrderProcessor
{
    private readonly IEmailSender _emailSender;
    private readonly ISaveRepository _repository;

    public OrderProcessor(IEmailSender emailSender, ISaveRepository repository)
    {
        _emailSender = emailSender;
        _repository = repository; 
    }

    public void Process(int orderId, string customerEmail)
    {
        _emailSender.SendEmail(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
        _repository.SaveRepo(orderId, DateTime.Now);
    }
}