using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverButton : MonoBehaviour
{

    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterKey()
    {
        Debug.Log("Enter the key");
        ColorBlock colors = button.colors;
        colors.highlightedColor = new Color32(46, 35, 77, 255);
        button.colors = colors;
    }

    public void ExitKey()
    {
        Debug.Log("Exits the key");
        ColorBlock colors = button.colors;
        colors.highlightedColor = colors.normalColor;
        button.colors = colors;

    }
}
