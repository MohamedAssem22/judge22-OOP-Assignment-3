using System;
using part_01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Testing Shipping Strategy ===");
    
        var shippingCalc = new ShippingCostCalculator(new AramexShipping());
        decimal cost = shippingCalc.Calculate("Aramex", 2.5m);
        Console.WriteLine($"Total Shipping Cost: {cost}\n");


        Console.WriteLine("=== 2. Testing Order Processor (DI) ===");
  
        var emailSender = new SmtpEmailSender();
        var repo = new SqlOrderRepository();
        var orderProcessor = new OrderProcessor(emailSender, repo);
        
        orderProcessor.Process(1001, "customer@example.com");
        Console.WriteLine();


        Console.WriteLine("=== 3. Testing Notifications (Decorators) ===");
        
      
        INotification urgentEmail = new UrgentNotification(new EmailNotification());
        urgentEmail.Send("customer@example.com", "Your account password was changed.");

     
        var sms = new SmsNotification();
        var scheduledSms = new ScheduledNotification(sms, DateTime.Now.AddHours(2));
        scheduledSms.Send("+201000000000", "Your appointment is confirmed.");

        Console.WriteLine("\nAll Part 01 tests executed successfully!");
    }
}