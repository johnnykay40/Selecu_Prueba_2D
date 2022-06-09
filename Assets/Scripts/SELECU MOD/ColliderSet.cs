using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platformer.Mechanics;

public class ColliderSet : MonoBehaviour
{
    private ManagerScene managerScene;
    private PlayerController playerController;

  

    [Header("Is Canvas")]
    [SerializeField] private bool isCanvas;
    [SerializeField] private Button returnButton;

    [Header("Is Scene")]
    [SerializeField] private bool isLoadScene;
    [SerializeField] private int indexScene;
    [SerializeField] private bool isRemoveScene;
        
    [Header("General")]
    [SerializeField] private GameObject objectOnOff;



    private void Start()
    {
        managerScene = FindObjectOfType<ManagerScene>();
        playerController = FindObjectOfType<PlayerController>();
        if (!isRemoveScene)
        {
            returnButton.onClick.AddListener(() => OnOffObject(false)); 
        }
    }

    private void LoadObject()
    {
        if (isCanvas)
        {
            OnOffObject(true); 
        }

        if (isLoadScene)
        {
            managerScene.LoadScene(indexScene, true);            
        }

        if (isRemoveScene)
        {
            managerScene.RemoveScene(2);            
        }
    }
        
    private void OnOffObject(bool isActive)
    {       
        objectOnOff.SetActive(isActive);       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadObject();
            Destroy(gameObject);
        }
    }
}
