using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string Name;
    public int Health;
    public int Speed;
    public int skill;
    public List<Item> Inventory = new List<Item>();
}

[System.Serializable]
public class Item
{
    public bool IsEquipped;
    public ItemData Data;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UserData User;

    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
            Destroy(gameObject);
    }
}
