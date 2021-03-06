using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape {

    protected override void Start() {
        base.Start();
        name = gameObject.name;
    }

    protected override void ShowText() {  
        GameManager.instance.ChangeShowText("This is cool" + name);
    }

    protected override void OnMouseDown() {
        GetComponent<Renderer>().material.color = Color.green;
        ShowText();
    }

}
