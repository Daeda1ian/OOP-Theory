using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape {

    protected override void Start() {
        base.Start();
        name = "ball";
    }

    protected override void ShowText() {
        GameManager.instance.ChangeShowText("This is " + name);
    }

    protected override void OnMouseDown() {
        GetComponent<Renderer>().material.color = Color.yellow;
        ShowText();
    }

}
