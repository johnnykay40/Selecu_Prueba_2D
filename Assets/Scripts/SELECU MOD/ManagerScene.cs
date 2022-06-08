using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    internal void LoadScene(int indexScene, bool isAdditive)
    {
        if (!isAdditive)
        {
            SceneManager.LoadScene(indexScene); 
        }

        else
        {
            SceneManager.LoadScene(indexScene, LoadSceneMode.Additive);
        }
    } 
    internal void RemoveScene(int indexScene)
    {
        SceneManager.UnloadSceneAsync(indexScene);
    }
}