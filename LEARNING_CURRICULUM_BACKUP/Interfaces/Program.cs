using System;

// //Without interfaces:
// VisaPayment visa = new VisaPayment();
// Checkout(visa);

// PaypalPayment paypal = new PaypalPayment();
// CheckoutPaypal(paypal);

// BankTransfer transfer = new BankTransfer();
// CheckoutTransfer(transfer);

// static void Checkout(VisaPayment payment)
// {
//     payment.Pay();
// }

// static void CheckoutPaypal(PaypalPayment payment)
// {
//     payment.Pay();
// }

// static void CheckoutTransfer(BankTransfer payment)
// {
//     payment.Pay();
// }
// class VisaPayment
// {
//     public void Pay()
//     {
//         Console.WriteLine("Paid with Visa");
//     }
// }

// class PaypalPayment
// {
//     public void Pay()
//     {
//         Console.WriteLine("Paid with Paypal");

//     }
// }

// class BankTransfer
// {
//     public void Pay()
//     {
//         Console.WriteLine("Paid through transfer.");

//     }
// }

//with interfaces:

// VisaPayment visa = new VisaPayment();
PaypalPayment paypal = new PaypalPayment();
BankTransfer transfer = new BankTransfer();

static void Checkout(IPayment payment)
{
    payment.Pay();
    payment.Speak();
}

Checkout(new VisaPayment());
Checkout(paypal);
Checkout(transfer);

// Now "Checkout" accepts anything that implements IPayment, whether it's Visa, PayPal, Bank Transfer, or any future payment method.
public interface IPayment
{
    void Pay();
    void Speak();
}

public class VisaPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid with Visa.");
    }
    public void Speak()
    {
        Console.WriteLine("Yaay!!");
    }
}

public class PaypalPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid with Paypal");
    }
    public void Speak()
    {
        Console.WriteLine("Yaay!!");
    }
}

public class BankTransfer : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid through bank transfer");
    }
    public void Speak()
    {
        Console.WriteLine("Yaay!!");
    }
}