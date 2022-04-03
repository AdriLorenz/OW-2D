using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), 
        Mathf.Clamp(transform.position.y, -4.5f, 4.5f), transform.position.z);
    }
}
