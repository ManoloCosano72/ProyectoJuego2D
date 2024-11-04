using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public interface Item
{
    public void Collect(){
        Destroy(gameObject);
    }
}
