using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour {  // Наследование / Абстракция в виде методов ниже

    protected string m_name;
    public string name {                    // Инкапсуляция
        get { return m_name; }
        set { m_name = value; }
    }

    protected Rigidbody rb;

    protected virtual void Start() {        // Полиморфизм
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void ShowText() { }   // Полиморфизм

    protected abstract void OnMouseDown();
}
