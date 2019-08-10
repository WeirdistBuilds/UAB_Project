using UnityEngine;
using UnityEngine.UI;

public class CodeSepsisButton : MonoBehaviour
{
    public SOBool Screen2, Screen3, GameComplete, PerformedSepsis;
    public GameObject CodeSepsis, Scene3Critical;
    public GameObject[] UI;
    public Text InfoTab;
    
    public void Call()
    {
        if (Screen2.Value && !Screen3.Value)
        {
            CodeSepsis.SetActive(true);
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
        else if (Screen3.Value && PerformedSepsis.Value)
        {
            InfoTab.text = "The patient seems stable for now.";
        }
    }
}