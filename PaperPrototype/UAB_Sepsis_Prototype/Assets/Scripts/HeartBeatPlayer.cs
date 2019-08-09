using UnityEngine;

public class HeartBeatPlayer : MonoBehaviour
{
    public SOBool Screen2, Screen3, CalledPhysician, PerformedSepsis;
    public GameObject[] Heartbeats;

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
        
        if (Screen3.Value && PerformedSepsis.Value)
        {
            Heartbeats[0].SetActive(true);
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            Heartbeats[3].SetActive(true);
        }
        else if (Screen2.Value && !CalledPhysician.Value)
        {
            Heartbeats[2].SetActive(true);
        }
        else
        {
            Heartbeats[1].SetActive(true);
        }
    }
}
