using UnityEngine;
using UnityEngine.UI;

public class BringWaterButton : MonoBehaviour
{

    public SOBool Screen2, Screen3, PerformedSepsis, WantedWater1, WantedWater2, GaveWater1, GaveWater2;
    public Text InfoText;

    public void Call()
    {
        if (!Screen2.Value && !Screen3.Value)
        {
            if (!WantedWater1.Value)
            {
                InfoText.text = "Check to see if they want water first";
            }
            else if (WantedWater1.Value && !GaveWater1.Value)
            {
                InfoText.text = "You gave the patient a glass of water";
                GaveWater1.Value = true;
            }
            else
            {
                InfoText.text = "The patient already has water";
            }
        }
        else if (Screen2.Value && !Screen3.Value)
        {
            InfoText.text = "Check to see if they want water first";
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            InfoText.text = "The patient is unresponsive";
        }
        else if (Screen3.Value && PerformedSepsis.Value)
        {
            if (!WantedWater2.Value)
            {
                InfoText.text = "Check to see if they want water first";
            }
            else if (WantedWater2.Value && !GaveWater2.Value)
            {
                InfoText.text = "You gave the patient a glass of water";
                GaveWater2.Value = true;
            }
            else
            {
                InfoText.text = "The patient already has water";
            }
        }
    }
}
