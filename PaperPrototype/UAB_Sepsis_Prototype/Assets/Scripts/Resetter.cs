using UnityEngine;

public class Resetter : MonoBehaviour
{
    public SOBool[] GameBools;

    void Start()
    {
        for (int i = 0; i < GameBools.Length; i++)
        {
            GameBools[i].Value = false;
        }
    }
}
