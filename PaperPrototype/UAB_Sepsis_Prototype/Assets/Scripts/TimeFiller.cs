using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TimeFiller : MonoBehaviour
{
    public SOChart Chart1, Chart2, Chart3Good;
    public SOBool Screen2, Screen3;
    
    public Text Time;

    void Start()
    {
        StringBuilder TimeString = new StringBuilder();
        
        TimeString.Append("0" + Chart1.Time + ":00");
        
        Time.text = TimeString.ToString();
    }

    public void Call()
    {
        StringBuilder NewTimeString = new StringBuilder();
        
        if (Screen2.Value)
        {
            NewTimeString.Clear();
            NewTimeString.Append(Chart3Good.Time + ":00");
            Screen3.Value = true;
            Time.text = NewTimeString.ToString();
        }
        else
        {
            NewTimeString.Clear();
            NewTimeString.Append(Chart2.Time + ":00");
            Screen2.Value = true;
            Time.text = NewTimeString.ToString();
        }
    }
}
