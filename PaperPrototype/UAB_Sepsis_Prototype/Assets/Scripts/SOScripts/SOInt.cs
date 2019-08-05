using UnityEngine;

[CreateAssetMenu(fileName = "NewInt", menuName = "Scriptable Objects/SOInt")]
public class SOInt : ScriptableObject
{
    public int value;
    public virtual float Value
    {
        get { return value; }
    }
}
