using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 m_customPosition;

    public Renderer rend;

    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.red;


    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            
        }
        transform.position = m_customPosition;
    }
}

