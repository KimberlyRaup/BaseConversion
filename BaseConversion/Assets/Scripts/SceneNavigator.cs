using UnityEngine;
using UnityEngine.SceneManagement;//this must be here to be able to decide which scene to use

public class SceneNavigator : MonoBehaviour
{
    public void LoadTargetScene(int targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }
}
