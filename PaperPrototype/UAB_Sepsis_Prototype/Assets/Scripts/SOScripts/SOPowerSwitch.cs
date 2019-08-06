using UnityEngine;

[CreateAssetMenu(fileName = "NewPowerSwitch", menuName = "Scriptable Objects/SOPowerSwitch")]
public class SOPowerSwitch : ScriptableObject
{

	public GameObject gameObject;

	public void Call ()
	{
		if (gameObject.activeInHierarchy)
		{
			gameObject.SetActive(false);
		}
		else
		{
			gameObject.SetActive(true);
		}

	}
}
