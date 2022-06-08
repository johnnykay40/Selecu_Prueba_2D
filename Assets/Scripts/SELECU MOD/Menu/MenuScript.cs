using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private Button buttonStart;
    private ManagerScene managerScene;

    private void Start()
    {
        buttonStart.onClick.AddListener(ButtonStart);
        managerScene = FindObjectOfType<ManagerScene>();
    }
    private void ButtonStart()
    {
        managerScene.LoadScene(1, false);
    }
   

   
}
