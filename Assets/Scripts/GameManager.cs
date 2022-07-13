using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    public static GameManager instance;
    public Text showText;

    private void Awake() {
        instance = this;
    }

    public void ChangeShowText (string text) {
        showText.text = text;
        Debug.Log(text);
    }

}
