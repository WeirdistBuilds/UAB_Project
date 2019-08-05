using UnityEngine;

[CreateAssetMenu(fileName = "NewBoolChanger", menuName = "Scriptable Objects/SOBoolChanger")]
public class SOBoolChanger : ScriptableObject
{
    public SOBool toChange;

    public void Call()
    {
        toChange.Value = !toChange.Value;
    }    
}
