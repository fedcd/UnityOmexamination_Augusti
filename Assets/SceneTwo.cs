using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public void GoToSceneTwo() 
 {   
SceneManager.LoadScene(SceneTwo);
}

}
