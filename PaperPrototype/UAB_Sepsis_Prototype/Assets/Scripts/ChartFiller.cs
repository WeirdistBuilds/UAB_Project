using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ChartFiller : MonoBehaviour
{
    public SOChart Chart1, Chart2, Chart3Bad, Chart3Good;
    public SOBool Screen2, Screen3, CalledPhysician, PerformedQSepsis;
    public Text General, Vitals0700, Vitals1400, Vitals1800;

    private void Start()
    {
        StringBuilder GeneralString = new StringBuilder();
        
        GeneralString.Append("Name: ");
        GeneralString.Append(Chart1.Name);
        GeneralString.AppendLine();
        
        GeneralString.Append("Age: ");
        GeneralString.Append(Chart1.Age);
        GeneralString.AppendLine();
        
        GeneralString.Append("Weight: ");
        GeneralString.Append(Chart1.Weight + " kg");
        GeneralString.AppendLine();
        
        GeneralString.Append("Allergies: ");
        GeneralString.Append(Chart1.Allergy);
        GeneralString.AppendLine();
        
        GeneralString.Append("History: ");
        GeneralString.Append(Chart1.History);
        GeneralString.AppendLine();
        
        GeneralString.Append("Medications: ");
        GeneralString.Append(Chart1.Meds);

        General.text = GeneralString.ToString();
        
        
        
        StringBuilder Vitals0700String = new StringBuilder();
            
        Vitals0700String.Append("Time: ");
        Vitals0700String.Append("0" + Chart1.Time + ":00");
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();            
            
        Vitals0700String.Append("Temp: ");
        Vitals0700String.Append(Chart1.Temp + " F");
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();
            
        Vitals0700String.Append("HR: ");
        Vitals0700String.Append(Chart1.HRate);
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();
            
        Vitals0700String.Append("RR: ");
        Vitals0700String.Append(Chart1.RRate);
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();
            
        Vitals0700String.Append("BP: ");
        Vitals0700String.Append(Chart1.BPS + "/" + Chart1.BPD);
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();
            
        Vitals0700String.Append(Chart1.OnRA);
        Vitals0700String.Append("% on RA");
        Vitals0700String.AppendLine();
        Vitals0700String.AppendLine();
            
        Vitals0700String.Append("EWS: ");
        Vitals0700String.Append(Chart1.EWS);

        Vitals0700.text = Vitals0700String.ToString();

        if (Screen2.Value)
        {
            StringBuilder Vitals1400String = new StringBuilder();
            
            if (CalledPhysician.Value)
            {
                Vitals1400String.Append("Time: ");
                Vitals1400String.Append("0" + Chart2.Time + ":00");
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();            
            
                Vitals1400String.Append("Vitals missed");
                Vitals1400String.Append("due to");
                Vitals1400String.Append("endoscopy.");
                
                Vitals1400.text = Vitals1400String.ToString();
            }
            else
            {
                Vitals1400String.Append("Time: ");
                Vitals1400String.Append(Chart2.Time + ":00");
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();            
            
                Vitals1400String.Append("Temp: ");
                Vitals1400String.Append(Chart2.Temp + " F");
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();
            
                Vitals1400String.Append("HR: ");
                Vitals1400String.Append(Chart2.HRate);
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();
            
                Vitals1400String.Append("RR: ");
                Vitals1400String.Append(Chart2.RRate);
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();
            
                Vitals1400String.Append("BP: ");
                Vitals1400String.Append(Chart2.BPS + "/" + Chart2.BPD);
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();
            
                Vitals1400String.Append(Chart2.OnRA);
                Vitals1400String.Append("% on RA");
                Vitals1400String.AppendLine();
                Vitals1400String.AppendLine();
            
                Vitals1400String.Append("EWS: ");
                Vitals1400String.Append(Chart2.EWS);

                Vitals1400.text = Vitals1400String.ToString();
            }
        }
        
        if (Screen3.Value)
        {
            StringBuilder Vitals1800String = new StringBuilder();
            
            if (!PerformedQSepsis)
            {
                Vitals1800String.Append("Time: ");
                Vitals1800String.Append(Chart3Bad.Time + ":00");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();            
            
                Vitals1800String.Append("Temp: ");
                Vitals1800String.Append(Chart3Bad.Temp + " F");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("HR: ");
                Vitals1800String.Append(Chart3Bad.HRate);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("RR: ");
                Vitals1800String.Append(Chart3Bad.RRate);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("BP: ");
                Vitals1800String.Append(Chart3Bad.BPS + "/" + Chart3Bad.BPD);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append(Chart3Bad.OnRA);
                Vitals1800String.Append("% on RA");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("EWS: ");
                Vitals1800String.Append(Chart3Bad.EWS);

                Vitals1400.text = Vitals1800String.ToString();
            }
            else
            {
                Vitals1800String.Append("Time: ");
                Vitals1800String.Append("0" + Chart3Good.Time + ":00");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();            
            
                Vitals1800String.Append("Temp: ");
                Vitals1800String.Append(Chart3Good.Temp + " F");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("HR: ");
                Vitals1800String.Append(Chart3Good.HRate);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("RR: ");
                Vitals1800String.Append(Chart3Good.RRate);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("BP: ");
                Vitals1800String.Append(Chart3Good.BPS + "/" + Chart3Good.BPD);
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append(Chart3Good.OnRA);
                Vitals1800String.Append("% on RA");
                Vitals1800String.AppendLine();
                Vitals1800String.AppendLine();
            
                Vitals1800String.Append("EWS: ");
                Vitals1800String.Append(Chart3Good.EWS);

                Vitals1400.text = Vitals1800String.ToString();
            }
        }
    }

}
