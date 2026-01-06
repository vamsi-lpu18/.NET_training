// delegate void PaymentDelegate(decimal amout);
// static class PaymentExtensions
// {
//     public static bool isValidPayment(this decimal amount)
//     {
//         return amount>0 && amount <= 1_000_000;
//     }
// }
// class PaymentService
// {
//     public void ProcessPayment(decimal amount)
//     {
//         Console.WriteLine("Payment of "+ amount+ " processed ");
//     }
// }

using System.Reflection;

delegate void OrderDelegate(string orderId);
class NotificationService
{
    public void SendEmail(string id)
    {
        Console.WriteLine("Email sent for Order "+ id);
    }
    public void SendSMS(string id)
    {
        Console.WriteLine("SMS has been sent");
    }
}

///////////////------------->         Event-Delegation        <---------------------------------
class Button
{
    public delegate void ClickHandler();


    public event ClickHandler Clicked;

    public void click()
    {
        Clicked?.Invoke();
    }
}
                  /////------------------------------->delegate-multicast<-----------------------------------

namespace SmartHomeSecurity
{
    // 1. DEFINITION: The "Contract" for any security response.
    // Any method responding to an alert must be void and take a string location.

    public delegate void SecurityAction(string zone); // definition

    public class MotionSensor
    {
        // The delegate instance (The Panic Button)
        public SecurityAction OnEmergency; // instance creation

        public void DetectIntruder(string zoneName)
        {
            Console.WriteLine($"[SENSOR] Motion detected in {zoneName}!");
            
            // 3. INVOCATION: Triggering the Panic Button
            if (OnEmergency != null)
            {
                OnEmergency(zoneName); // string value = Main Lobby or panicSequence?
            }
        }
    }

    // Diverse classes that don't know about each other
    public class AlarmSystem
    {
        public void SoundSiren(string zone) => Console.WriteLine($"[ALARM] WOO-OOO! High-decibel siren active in {zone}.");
    }

    public class PoliceNotifier
    {
        public void CallDispatch(string zone) => Console.WriteLine($"[POLICE] Notifying local precinct of intrusion in {zone}.");
    }
}

class Program
{
    public static void Main()
    {
        // PaymentService service=new PaymentService();
        // PaymentDelegate payment=service.ProcessPayment;
        // decimal amount=4000;
        // if (amount.isValidPayment())
        // {
        //     payment(amount);
        // }
        // else
        // {
        //     Console.WriteLine("insufficient funds");
        // }
        // amount.isValidPayment;
        // payment(50000000000);


//////////////////////------------------------------------------------------------>Notification delegate<------------------------------------------------------/


        // NotificationService service=new NotificationService();
        // OrderDelegate notify=null;
        // notify+=service.SendEmail;
        // notify+=service.SendSMS;
        // notify("abcd");
        // notify("efghijkl");
        // Console.WriteLine(notify.GetMethodInfo);


        ///--------------------------------------------------------->Action -Delegate<----------------------------------------------------------------
        // Action<string> logActivity=mes=>Console.WriteLine("got this "+mes);
        // logActivity("hi how are you ");



        /////////----------------------------->Function Delegates<---------------------------------
        // Func<decimal,decimal,decimal> calc=(price,discount)=>price-price*discount/100;
        // Console.WriteLine(calc(300,50));

        ////-------------------------------->Predicate delegate<------------------------
        // Predicate<int> isbig=(a) =>a%2==0;
        // // Console.WriteLine(isbig(10));
        // string res=isbig(10)?"true":"false";
        // Console.WriteLine($"it is {res}");


        ////------------------------->event delegation<------------------------------------
        // Button btn=new Button();
        // btn.Clicked+=()=>Console.WriteLine("Buttoni was clicked");
        // btn.Clicked+=()=>Console.WriteLine("Events are begin handled");

        // btn.click();

        ///--------------------------->Delegate -Multicasting<----------------------------------------------------
        /// 
          // Objects Initialization
    //         MotionSensor livingRoomSensor = new MotionSensor();
    //         AlarmSystem siren = new AlarmSystem();
    //         PoliceNotifier police = new PoliceNotifier();

    //         // 2. INSTANTIATION & MULTICASTING
    //         // We "Subscribe" different methods to the sensor's delegate
    //         SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
    //         panicSequence += police.CallDispatch;

    //         // Linking the sequence to the sensor
    //         livingRoomSensor.OnEmergency = panicSequence;
	// // class_object.delegate_instance = delegate_instance_multicast

    //         // Simulation
    //         livingRoomSensor.DetectIntruder("Main Lobby");



            ///----------------------------------->Comparison <---------------------------------------
            Comparison<int> sortdesc=(a,b)=>a.CompareTo(b);
            Console.WriteLine(sortdesc(6,3));
            Console.WriteLine(sortdesc(3,6));
            Console.WriteLine(sortdesc(6,6));


    }
}