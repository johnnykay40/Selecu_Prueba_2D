using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    private Button restartButton;
    private ManagerScene managerScene;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartButton);
        managerScene = FindObjectOfType<ManagerScene>();
    }
    private void RestartButton()
    {
        managerScene.LoadScene(0, false);
    }
}
