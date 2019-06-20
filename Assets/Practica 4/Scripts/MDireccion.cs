using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDireccion : MonoBehaviour
{
    //Variables Globales

    float velocidad;
    Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 0.5f;
        target = GameObject.Find("Boris").GetComponent<Transform>();
        Debug.Log(target.name);
        Vector3 dir = target.position - this.transform.position;
        Debug.Log(dir.magnitude);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - this.transform.position;
        if (dir.magnitude > 1)
        {
            this.transform.Translate(dir.normalized * velocidad, Space.World);

        }
    }
}
