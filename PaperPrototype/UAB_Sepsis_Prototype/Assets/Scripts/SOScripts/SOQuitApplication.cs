using UnityEngine;

[CreateAssetMenu(fileName = "NewQuitApplication", menuName = "Scriptable Objects/SOQuitApplication")]
public class SOQuitApplication : ScriptableObject
{
    public void Call()
    {
        Application.Quit();
    }
}
