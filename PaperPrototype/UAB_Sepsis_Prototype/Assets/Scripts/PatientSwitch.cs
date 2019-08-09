using UnityEngine;

public class PatientSwitch : MonoBehaviour
{
    public GameObject[] Scenes;
    public SOBool Screen2, Screen3, CalledPhysician, GameComplete, PerformedSepsis, AssessedLeg;

    private void ResetScenes()
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(false);
        }
    }

    public void Call()
    {
        ResetScenes();
        if (GameComplete.Value && PerformedSepsis.Value)
        {
            Scenes[5].SetActive(true);
        }
        else if (GameComplete.Value && !PerformedSepsis.Value)
        {
            Scenes[4].SetActive(true);
        }
        else if (Screen3.Value && PerformedSepsis.Value)
        {
            Scenes[0].SetActive(true);
        }
        else if (Screen3.Value && !PerformedSepsis.Value)
        {
            Scenes[3].SetActive(true);
        }
        else if (Screen2.Value && !CalledPhysician.Value)
        {
            Scenes[3].SetActive(true);
        }
        else if (Screen2.Value && CalledPhysician.Value)
        {
            Scenes[2].SetActive(true);
        }
        else if (!Screen2.Value && AssessedLeg.Value)
        {
            Scenes[1].SetActive(true);
        }
        else
        {
            Scenes[0].SetActive(true);
        }
    }
}
