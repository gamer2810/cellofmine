using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject inventory;
    private bool inventoryisShowing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Inventory")){
            inventoryisShowing = !inventoryisShowing;
            inventory.SetActive(inventoryisShowing);
        }
    }
}
