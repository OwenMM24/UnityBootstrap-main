using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //the only thing this player needs is one key
    public bool hasKey = false;

    public void setKey()
    {
        hasKey = true;
    }
}
