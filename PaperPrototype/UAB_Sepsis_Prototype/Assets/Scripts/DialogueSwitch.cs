using UnityEngine;

public class DialogueSwitch : MonoBehaviour
{
    public GameObject Dialogue1, Dialogue2Good, Dialogue2Bad, Dialogue3Good, Dialogue3Bad;
    public SOBool Screen2, Screen3, CalledPhysician, PerformedSepsis;
    
    public void Call()
    {
        if (Screen3.Value && PerformedSepsis.Value)
        {
            Dialogue3Good.SetActive(true);
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            Dialogue3Bad.SetActive(true);
        }
        else if (Screen2.Value && !CalledPhysician.Value)
        {
            Dialogue2Good.SetActive(true);
        }
        else if (Screen2.Value && CalledPhysician.Value)
        {
            Dialogue2Bad.SetActive(true);
        }
        else
        {
            Dialogue1.SetActive(true);
        }
    }
}
