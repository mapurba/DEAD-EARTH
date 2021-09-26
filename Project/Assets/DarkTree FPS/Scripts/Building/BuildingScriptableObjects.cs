﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Building", menuName = "Building Data", order = 0)]
public class BuildingScriptableObjects : ScriptableObject
{
    public string BuildingName;
    public string Description;

    public GameObject BuildingGameObject;

    public Sprite BuildingIcon;
    
    public GameObject[] buildingCostItems;
    [Header("Size must be the same as items")]
    public int[] builingCostItemsAmont;
}
