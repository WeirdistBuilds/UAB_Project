using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ChartFiller : MonoBehaviour
{
    public SOChart Chart1, Chart2Bad, Chart2Good, Chart3Bad, Chart3Good;
    public bool Screen1, Screen2, Screen3;
    public Text General, Vitals0700, Vitals1400, Vitals1800;

    public SOChart Chart2, Chart3;

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
    }

    private void OnEnable()
    {
        if (Screen1)
        {
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
            Screen1 = false;
        }
        
        
    }

}
