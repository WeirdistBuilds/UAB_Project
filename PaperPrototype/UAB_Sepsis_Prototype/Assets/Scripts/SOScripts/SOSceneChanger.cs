using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NewSceneChanger", menuName = "Scriptable Objects/SOSceneChanger")]
public class SOSceneChanger : ScriptableObject
{
    public int ChangeToScene;
    
    public void Call()
    {
        SceneManager.LoadScene(ChangeToScene);
    }

}
