using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour {  // ������������ / ���������� � ���� ������� ����

    protected string m_name;
    public string name {                    // ������������
        get { return m_name; }
        set { m_name = value; }
    }

    protected Rigidbody rb;

    protected virtual void Start() {        // �����������
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void ShowText() { }   // �����������

    protected abstract void OnMouseDown();
}
