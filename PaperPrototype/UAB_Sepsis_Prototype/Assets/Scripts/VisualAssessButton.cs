using UnityEngine;
using UnityEngine.UI;

public class VisualAssessButton : MonoBehaviour
{
    public SOBool Screen2, Screen3, CalledPhysician, PerformedSepsis, AskedAboutLeg, AssessedLeg;
    public Text InfoBox;
    
    public void Call()
    {
        if (Screen2.Value && !Screen3.Value)
        {
            if (!CalledPhysician.Value)
            {
                InfoBox.text = "He's sweating, lethargic, and difficult to arouse";                
            }
            else
            {
                InfoBox.text = "The doctor ordered an endoscopy, the patient is not here";
            }
        }
        else if (!Screen2.Value && !Screen3.Value)
        {
            if (AskedAboutLeg.Value)
            {
                AssessedLeg.Value = true;
                InfoBox.text = "His recent absess is not healing very well";
            }
            else
            {
                InfoBox.text = "He's awake and alert, skin color normal, lungs clear";                
            }
            
        }
        else
        {
            if (!PerformedSepsis.Value)
            {
                InfoBox.text = "He's unconscious, feverish, and his vitals are dropping rapidly";
            }
            else
            {
                InfoBox.text = "He is improving steadily thanks to you and your team";
            }
        }
    }
}
