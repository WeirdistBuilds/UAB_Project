using UnityEngine;

public class DialogueStopper : MonoBehaviour
{
    public GameObject[] AllDialogs;
    
    public void Call()
    {
        for (int i = 0; i < AllDialogs.Length; i++)
        {
            AllDialogs[i].SetActive(false);
        }       
    }
}
