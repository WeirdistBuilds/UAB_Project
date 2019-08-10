using UnityEngine;
using UnityEngine.UI;

public class HeartBeatPlayer : MonoBehaviour
{
    public SOBool Screen2, Screen3, CalledPhysician, PerformedSepsis;
    public GameObject[] Heartbeats;
    public Text InfoBox;

    void Start()
    {
        StopBeats();
    }
    
    private void StopBeats()
    {
        for (int i = 0; i < Heartbeats.Length; i++)
        {
            Heartbeats[i].SetActive(false);
        }
    }
    
    public void Call()
    {
        StopBeats();
        
        if (Screen3.Value)
        {
            if (PerformedSepsis.Value)
            {
                Heartbeats[0].SetActive(true);
            }
            else
            {
                Heartbeats[3].SetActive(true);
            }
        }
        else if (Screen2.Value)
        {
            if(CalledPhysician.Value)
            {
                InfoBox.text = "The patient is gone";
            }
            else
            {
                Heartbeats[2].SetActive(true);                
            }
        }
        else
        {
            Heartbeats[1].SetActive(true);
        }
    }
}
