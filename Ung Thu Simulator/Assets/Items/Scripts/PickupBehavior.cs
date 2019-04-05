﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    private void Start()
    {
         inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Debug.Log(inventory);
            for(int i =0; i < inventory.slots.Length;i++){
                if(inventory.isFull[i] == false){
                    inventory.isFull[i] = true;
                    Instantiate(itemButton,inventory.slots[i].transform,false);
                    Destroy(gameObject);
                    break;
                }
            }
        }   
    }
}
