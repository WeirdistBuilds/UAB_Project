using UnityEngine;

[CreateAssetMenu(fileName = "NewBoolChanger", menuName = "Scriptable Objects/SOBoolChanger")]
public class SOBoolChanger : ScriptableObject
{
    public SOBool ToChange;
    public bool Result; 

    public void Call()
    {
        ToChange.Value = Result;
    }    
}
