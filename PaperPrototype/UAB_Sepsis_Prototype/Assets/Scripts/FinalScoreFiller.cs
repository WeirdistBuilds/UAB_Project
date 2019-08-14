using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreFiller : MonoBehaviour
{
    public SOBool
        AskedAboutLeg,
        GaveMeds1,
        WantedWater1,
        GaveWater1,
        AssessedLeg,
        CalledPhysician,
        WantedMeds1,
        GaveMeds2,
        CalledRightCode,
        CalledCodeOnTime,
        ChoseWrong,
        PerformedSepsis,
        GaveWater2,
        WantedWater2;

    public SOInt FinalScore, TotalScore;

    public Text summary, score;

    private void OnEnable()
    {
        FinalScore.value = 0;
        FillSummary();
        FillScore();
    }

    private void FillScore()
    {
        var poor = TotalScore.Value / 4;
        var fair = TotalScore.Value / 2;
        var good = TotalScore.Value / 1.3;
        var perfect = TotalScore.Value;

        StringBuilder FinalString = new StringBuilder();
        FinalString.Append("Out of " + TotalScore.Value + " possible points,");
        FinalString.AppendLine();
        FinalString.Append("You got " + FinalScore.Value + ".");
        FinalString.AppendLine();
        FinalString.AppendLine();
        
        if (FinalScore.Value < poor)
        {
            FinalString.Append("Oh, don't worry! You'll get the hang of it soon. I hope you try again!");
        }
        else if (FinalScore.Value < fair)
        {
            FinalString.Append("That's not too bad! You've still got a long way to go though, maybe another try will help?");
        }
        else if (FinalScore.Value < good)
        {
            FinalString.Append("Hey that's pretty good! You've still got some room for improvement though, maybe one more try?");
        }
        else if (FinalScore.Value < perfect)
        {
            FinalString.Append("That's great! You really are good at this!");
        }
        else
        {
            FinalString.Append("Amazing! A perfect score! You ought to think about doing this for a living!");
        }
            
        score.text = FinalString.ToString();
    }
    
    
    private void FillSummary()
    {
        StringBuilder ScoreString = new StringBuilder();

        
        //07:00
        
        if (AskedAboutLeg.Value)
        {
            if (!AssessedLeg.Value)
            {
                ScoreString.Append("You asked the patient how his leg was doing, but didn't do a visual assessment.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
            }
            else
            {
                ScoreString.Append("You asked the patient how his leg was doing, and did a visual assessment.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
                FinalScore.value++;
            }
        }

        if (GaveMeds1.Value)
        {
            ScoreString.Append("You gave the patient his home medication.");
            ScoreString.AppendLine();
            ScoreString.AppendLine();
            FinalScore.value++;
        }
        else
        {
            ScoreString.Append("You didn't give the patient his home medication.");
            ScoreString.AppendLine();
            ScoreString.AppendLine();
        }
        
        
        if (!WantedWater1.Value)
        {
            ScoreString.Append("You didn't ask the patient if he needed anything at 07:00.");
            ScoreString.AppendLine();
            ScoreString.AppendLine();
        }
        else
        {
            if (!GaveWater1.Value)
            {
                ScoreString.Append("You asked the patient if he needed anything at 07:00, but forgot to give him water.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
            }
            else
            {
                ScoreString.Append("You asked the patient if he needed anything at 07:00, and gave him water.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
                FinalScore.value++;                    
            }   
        }
        
        
        
        
        if (CalledPhysician.Value)
        {
            ScoreString.Append("You called a physician on the grounds of suspected GI bleeds, causing him to miss his 14:00 vitals");
            ScoreString.AppendLine();
            ScoreString.AppendLine();
        }
        else //14:00
        {
            if (!WantedMeds1.Value)
            {
                ScoreString.Append("You didn't ask the patient if he needed anything at 14:00.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
            }
            else
            {
                if (GaveMeds2.Value)
                {
                    ScoreString.Append("You asked the patient if he needed anything at 14:00, and gave him pain medication.");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();
                    FinalScore.value++; 
                }
                else
                {
                    ScoreString.Append("You asked the patient if he needed anything at 14:00, but forgot to give him pain medication.");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();                  
                }   
            }

            if (CalledCodeOnTime.Value)
            {
                ScoreString.Append("You called a code on time.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
                FinalScore.value++;
                if (CalledRightCode.Value)
                {
                    ScoreString.Append("You called a Code Sepsis! That was just the right thing to do.");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();
                    FinalScore.value += 3;  
                }
                else
                {
                    ScoreString.Append("You called a Code MET! That's good, but if you had realized the patient was septic you could have called Code Sepsis and started on the Sepsis Power Plan right away.");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();
                    FinalScore.value++; 
                }

                if (ChoseWrong.Value)
                {
                    ScoreString.Append("During the Sepsis Power Plan, you didn't remember to start with drawing blood for cultures. That's very important to do first.");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();  
                }
                else
                {
                    ScoreString.Append("You remembered to start with blood cultures! That was very smart, thank you!");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();
                    FinalScore.value++; 
                }

                if (PerformedSepsis.Value)
                {
                    ScoreString.Append("You handled the patient's sepsis and managed to stabilize them. Amazing!");
                    ScoreString.AppendLine();
                    ScoreString.AppendLine();
                    FinalScore.value += 10;
                } 
            }
            else
            {
                ScoreString.Append("You didn't call a code at 14:00. Be sure to check the vitals chart every round!");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
            }
        }
        
        //18:00
        if (!WantedWater2.Value)
        {
            ScoreString.Append("You didn't ask the patient if he needed anything at 18:00.");
            ScoreString.AppendLine();
            ScoreString.AppendLine();
        }
        else
        {
            if (!GaveWater2.Value)
            {
                ScoreString.Append("You asked the patient if he needed anything at 18:00, but forgot to give him water.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
            }
            else
            {
                ScoreString.Append("You asked the patient if he needed anything at 18:00, and gave him water.");
                ScoreString.AppendLine();
                ScoreString.AppendLine();
                FinalScore.value++;                    
            }   
        }
        
        summary.text = ScoreString.ToString();
    }
}
