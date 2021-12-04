using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject inventoryButton;

    void Start()
    {
        CloseInventory();
    }
    public void OpenInventory()
    {
        inventory.SetActive(true);
        inventoryButton.SetActive(false);
    }

    public void CloseInventory()
    {
        inventory.SetActive(false);
        inventoryButton.SetActive(true);
    }
}
