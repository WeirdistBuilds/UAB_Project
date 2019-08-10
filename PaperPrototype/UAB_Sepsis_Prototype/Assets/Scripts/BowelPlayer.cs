using UnityEngine;
using UnityEngine.UI;

public class BowelPlayer : MonoBehaviour
{
    public SOBool Screen2, CalledPhysician;
    public GameObject Bowel;
    public Text InfoBox;

    void Start()
    {
        Bowel.SetActive(false);
    }

    public void Call()
    {
        Bowel.SetActive(false);
        
        if (Screen2.Value && CalledPhysician.Value)
        {
            InfoBox.text = "The patient is gone";
        }
        else
        {
            Bowel.SetActive(true);
        }
    }
}
