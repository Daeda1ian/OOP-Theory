using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape {
    protected override void Start() {
        base.Start();
        name = gameObject.name + " 3000";
    }

    protected override void ShowText() {
        GameManager.instance.ChangeShowText("This is the " + name);
    }

    protected override void OnMouseDown() {
        GetComponent<Renderer>().material.color = Color.red;
        ShowText();
    }
}
