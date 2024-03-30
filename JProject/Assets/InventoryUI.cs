using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Vector2 UIPosition;
    bool openInventory = false;

    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.SetActive(openInventory);
        UIPosition = inventoryPanel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openInventory = !openInventory;
            inventoryPanel.SetActive(openInventory);
        }
    }
}
