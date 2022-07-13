using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour {  // Наследование / Абстракция в виде методов ниже

    protected string m_name;
    public string name {              // Инкапсуляция
        get { return m_name; }
        set { m_name = value; }
    }

    protected Rigidbody rb;

    protected virtual void Start() {
        rb = GetComponent<Rigidbody>();
    }

    protected virtual string ShowText () {  // Полиморфизм
        return "This is " + name;
    }

    protected abstract void OnMouseDown();
}
