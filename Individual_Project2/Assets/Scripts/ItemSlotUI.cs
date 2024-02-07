using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Image icon;
    public GameObject EquipObject;

    private Item item;

    public void Init (Item item)
    {
        this.item = item;

        icon.sprite = item.Data.icon;
        EquipObject.SetActive(item.IsEquipped);
    }

    public void OnClickItem()
    {
        item.IsEquipped = !item.IsEquipped;
        EquipObject.SetActive(item.IsEquipped);
    }

}