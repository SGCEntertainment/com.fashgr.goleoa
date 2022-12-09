using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jug : MonoBehaviour
{
    public static Jug instance;

    [SerializeField] private Image image;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI text1;

    private string t = "Jugadores de futbol";
        
    private void Start()
    {
        instance = this;
    }
    
    public void SetRes(Sprite sprite, string t) 
    {
        image.sprite = sprite;
        text.text = t;
        text1.text = sprite.name;
    }

    public void Close()
    {
        text1.text = t;
    }
}
