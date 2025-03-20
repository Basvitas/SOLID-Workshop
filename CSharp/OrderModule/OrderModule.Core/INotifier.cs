namespace OrderModule.Core;

public interface INotifier{
    public void send_email(HardwareType type, int number, int price);
}