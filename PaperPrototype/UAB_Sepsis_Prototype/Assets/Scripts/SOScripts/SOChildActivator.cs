using UnityEngine;

[CreateAssetMenu(fileName = "NewChildActivator", menuName = "Scriptable Objects/SOChildActivator")]
public class SOChildActivator : ScriptableObject {

	public void Call (GameObject gameObject) {
		gameObject.SetActive(true);		
	}
}
