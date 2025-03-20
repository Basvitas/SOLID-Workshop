using OrderModule.Core.Services;

namespace OrderModule.Core;

public class Notifier: INotifier
{
    public void send_email(HardwareType type, int number, int price)
    {
        // Compose and send email
        var address = "itbusiness@example.com";
        var orderDetails = $"{number} of {type}";
        var invoiceDetails = $"Customer email: {address}\nDetails: {orderDetails}\nPrice: {price}";
        var email = new Email()
        {
            To = address,
            From = "Ordermodule@example.com",
            Header = $"Invoice {type}",
            Body = invoiceDetails,
        };
        Emailer.SendEmail(email);
        
        Console.WriteLine("Order processed");
    }

}