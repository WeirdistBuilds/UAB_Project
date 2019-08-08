using UnityEngine;
using UnityEngine.UI;

public class AdministerMedsButton : MonoBehaviour
{

    public SOBool Screen2, Screen3, PerformedSepsis, GaveMeds1, GaveMeds2, WantedMeds1;
    public Text InfoText;

    public void Call()
    {
        if (!Screen2.Value && !Screen3.Value)
        {
            if (!GaveMeds1.Value)
            {
                InfoText.text = "You gave the patient 5 mg Amlodipine";
                GaveMeds1.Value = true;
            }
            else
            {
                InfoText.text = "The patient doesn't need any more medication";
            }
        }
        else if (Screen2.Value && !Screen3.Value)
        {
            if (WantedMeds1.Value && !GaveMeds2.Value)
            {
                InfoText.text = "You gave the patient 500mg Tylenol";
                GaveMeds2.Value = true;
            }
            else
            {
                InfoText.text = "The patient doesn't need any more medication";
            }
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            InfoText.text = "The patient is unresponsive";
        }
        else if (Screen3.Value && PerformedSepsis.Value)
        {
            InfoText.text = "The patient doesn't need any more medication";
        }
    }
}
