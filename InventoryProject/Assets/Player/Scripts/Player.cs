using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        ItemObject item = other.GetComponent<Item>()?.item;
        if (item)
        {
            Debug.Log(item);
            inventory.AddItem(item, 1);
            Destroy(other.gameObject);
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
