using System.Net.Mail;
using Microsoft.VisualBasic;
//------------------->Task-3

// public delegate void HospitalNotificationHandler(string message,DateTime time);
//     class HospitalNotifier
// {
//     public event HospitalNotificationHandler PatientAdmitted;
//     public void AdmitPatient(string name)
//     {
//         string msg=$"{name} admitted successfully";
//         DateTime current_time=DateTime.Now;
//         PatientAdmitted?.Invoke(msg,current_time);
//     }
// }
// class AdministrationDepartment
// {
//     public void Notify(string message,DateTime time)
//     {
//         Console.WriteLine($"{message} received at this time {time}");
//     }
// }
class Program
{
    //------------------>Task-1 
    // public delegate string ReportGenerator(string PatientName); 
    // public static string GenerateDischargeSummary (string PatientName)
    // {
        // return $"Discharge summary generated for patient: {PatientName} ";
    // }

    //------------------>Task-2
    // public delegate void HospitalAlert(string message);
    // public static void SendSmsAlert(string message)
    // {
    //     Console.WriteLine($"Sms slert {message}");
    // }
    // public static void SendEmailAlert(string message)
    // {
    //     Console.WriteLine($"Emial alert {message}");
    // }
    // public static void SendDashboardAlert(string message)
    // {
    //     Console.WriteLine($"DashboardAlert {message}");
    // }


    //-------------------Task-3
    public static void Main()
    {
        //task-1
        // ReportGenerator report=GenerateDischargeSummary;
        // string res=report?.Invoke("Rahul");
        // Console.WriteLine(res);

        //Task-2
        // HospitalAlert alert=null;
        // alert+=SendSmsAlert;
        // alert+=SendEmailAlert;
        // alert+=SendDashboardAlert;
        // alert?.Invoke("Emergency patient detected");
        //Task-3
        //  HospitalNotifier notifier = new HospitalNotifier();
        // AdministrationDepartment admin = new AdministrationDepartment();
        // notifier.PatientAdmitted += admin.Notify;
        // notifier.AdmitPatient("Meera");

    }
   

}