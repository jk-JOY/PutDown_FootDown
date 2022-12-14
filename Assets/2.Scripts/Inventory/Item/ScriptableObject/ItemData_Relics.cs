using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 아이템 데이터를 저장하는 데이터 파일을 만들게 해주는 스크립트
/// </summary>
[CreateAssetMenu(fileName = "New Item Data Relics", menuName = "Scriptable Object/Item Data Relics", order = 1)]
public class ItemData_Relics : ItemData
{
    public uint id = 0;                 // 아이템 ID
    public string itemName = "";        // 아이템 이름
    public Sprite itemIcon = null;
    public ItemType itemType;
    public ItemIDCode itemIDCode;
    public GameObject prefab = null;    // 아이템 프리펩
}
