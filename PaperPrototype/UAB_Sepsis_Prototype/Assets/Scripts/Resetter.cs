using UnityEngine;

public class Resetter : MonoBehaviour
{
    public SOBool[] GameBools;
    public SOInt Score;

    void Start()
    {
        for (int i = 0; i < GameBools.Length; i++)
        {
            GameBools[i].Value = false;
        }

        Score.value = 0;
    }
}
