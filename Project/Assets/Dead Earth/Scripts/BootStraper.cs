using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStraper : MonoBehaviour
{
    // Start is called before the first frame update used for inilitlized main menu
    void Start()
    {
        if (ApplicationManager.instance) ApplicationManager.instance.LoadMainMenu(); 
    }

    
}
