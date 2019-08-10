using UnityEngine;
using UnityEngine.UI;

public class CallPhysicianButton : MonoBehaviour
{
    public SOBool Screen2, Screen3, CalledPhysician;
    public GameObject PhysicianVisit;
    public Text InfoBox;

    public void Call()
    {
        if (!Screen2.Value && !Screen3.Value)
        {
            if (!CalledPhysician.Value)
            {
                PhysicianVisit.SetActive(true);
            }
            else
            {
                InfoBox.text = "You've already talked to the doctor about GI bleed concerns";
            }
        }
        else
        {
            InfoBox.text = "The doctor is not answering, they must be busy";
        }
    }
    
}
