using UnityEngine.UI;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    public float fadeTime;
    private Image blackScreen;

	void Start ()
	{
        blackScreen = GetComponent<Image>();
	}
	
	void Update ()
	{
		blackScreen.CrossFadeAlpha(0f, fadeTime, false);
		
		if (blackScreen.color.a <= 0)
		{
			gameObject.SetActive(false);
		}
	}
}
