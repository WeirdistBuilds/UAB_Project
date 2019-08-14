using UnityEngine;

public class ChartSwitch : MonoBehaviour
{
    public GameObject ChartParent;
    public SOBool GameComplete;
    
    public void Call()
    {
        if (!GameComplete.Value)
        {
            ChartParent.SetActive(!ChartParent.activeInHierarchy);
        }
    }
}
