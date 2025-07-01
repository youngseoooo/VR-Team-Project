using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : ScriptableObject
{
    public int id;
    public string name;
    public ItemCategory category;
    public Sprite icon;
    public GameObject prefab;
}

public enum ItemCategory
{
    Equipment,    // 장비
    Fish,   // 물고기
    Consumable  // 소비 아이템 ( 미끼, 스테미나 회복, 이벤트 아이템 등 )
}