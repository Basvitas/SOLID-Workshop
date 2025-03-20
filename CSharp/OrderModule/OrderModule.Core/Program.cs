using OrderModule.Core;

var orderModule = new OrderModule.Core.OrderModule(new Notifier());

orderModule.Order(HardwareType.Laptop, 3);
orderModule.Order(HardwareType.Monitor, 6);
orderModule.Order(HardwareType.Desk, 2);
