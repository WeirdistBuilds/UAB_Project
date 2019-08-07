using UnityEngine;

public class ChartSwitch : MonoBehaviour
{
    public GameObject ChartParent;
    
    public void Call()
    {
        ChartParent.SetActive(!ChartParent.activeInHierarchy);
    }
    
}
