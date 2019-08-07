using UnityEngine;

public class DialogueSwitch : MonoBehaviour
{
    public GameObject Dialogue1, Dialogue2Good, Dialogue2Bad, Dialogue3Good, Dialogue3Bad;
    public SOBool Screen2, Screen3, CalledPhysician, PerformedQSepsis;
    
    public void Call()
    {
        if (Screen3 && PerformedQSepsis)
        {
            Dialogue3Good.SetActive(!Dialogue3Good.activeInHierarchy);
        }
        else if (Screen3 && CalledPhysician)
        {
            Dialogue3Bad.SetActive(!Dialogue3Bad.activeInHierarchy);
        }
        else if (Screen2 && !CalledPhysician)
        {
            Dialogue2Good.SetActive(!Dialogue2Good.activeInHierarchy);
        }
        else if (Screen2 && CalledPhysician)
        {
            Dialogue2Bad.SetActive(!Dialogue2Bad.activeInHierarchy);
        }
        else
        {
            Dialogue1.SetActive(!Dialogue1.activeInHierarchy);
        }
    }
    
}
