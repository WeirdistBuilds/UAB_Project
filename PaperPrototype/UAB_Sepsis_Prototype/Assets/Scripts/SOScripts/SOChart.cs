using UnityEngine;

[CreateAssetMenu(fileName = "NewChart", menuName = "Scriptable Objects/SOChart")]
public class SOChart : ScriptableObject
{
    public int Weight;
    public string Allergy;
    public string History;
    public string Meds;
    public int Time;
    public float Temp;
    public int HRate; // heart rate
    public int RRate; // respiration rate
    public int BPS; //first number of BP
    public int BPD;  //second number of BP
    public int OnRA; // no idea
    public int EWS; //early warning score
    public int qSepsis; //qSepsis score
}