using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape {

    protected override void Start() {
        base.Start();
        name = gameObject.name;
    }

    protected override string ShowText() {
        return "This is the cool " + name;
    }

    protected override void OnMouseDown() {
        GetComponent<Renderer>().material.color = Color.green;
    }

}
