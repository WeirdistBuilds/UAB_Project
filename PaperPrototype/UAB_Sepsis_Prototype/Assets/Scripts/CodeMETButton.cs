using UnityEngine;
using UnityEngine.UI;

public class CodeMETButton : MonoBehaviour
{
    public SOBool Screen2, Screen3, GameComplete, CalledPhysician, PerformedSepsis;
    public GameObject CodeMET, Stable, Scene3Critical;
    public GameObject[] UI;
    public Text InfoBox;
    
    public void Call()
    {
        if (Screen2.Value && !Screen3.Value)
        {
            if (!CalledPhysician.Value)
            {
                CodeMET.SetActive(true);
            }
            else
            {
                InfoBox.text = "The patient is not here";
            }
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            for (int i = 0; i < UI.Length; i++)
            {
                UI[i].SetActive(false);
            }
            Scene3Critical.SetActive(true);
            GameComplete.Value = true;
        }
        else
        {
            Stable.SetActive(true);
        }
    }
}