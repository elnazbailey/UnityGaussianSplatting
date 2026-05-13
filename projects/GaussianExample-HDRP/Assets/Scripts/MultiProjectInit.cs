using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiProjectInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Display.displays.Length && i <= 6; i++)
        {
            Display.displays[i].Activate();
        }
    }
}
