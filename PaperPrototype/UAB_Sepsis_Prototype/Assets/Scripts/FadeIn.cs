using UnityEngine.UI;
using UnityEngine;

public class FadeIn : MonoBehaviour
{

	public float FadeTime;
	private Image blackScreen;
	private bool fadingIn;

	void Start()
	{
		blackScreen = GetComponent<Image>();
		fadingIn = true;
	}

	private void OnEnable()
	{
		fadingIn = true;
	}

	void Update()
	{
		if (fadingIn)
		{
			blackScreen.CrossFadeAlpha(0f, FadeTime * Time.deltaTime, false);

			if (blackScreen.color.a <= 0)
			{
				fadingIn = false;
				gameObject.SetActive(false);
			}

		}
	}
}
