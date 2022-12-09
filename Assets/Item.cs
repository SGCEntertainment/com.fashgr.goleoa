using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Sprite sprite;

    [SerializeField] private string t;

    public void Click()
    {
        Jug.instance.SetRes(sprite, t);
    }
}
