using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        transform.position = mousePos3D;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collideWith = collision.gameObject;
        if(collideWith.tag == "Apple")
        {
            Destroy(collideWith);
        }
    }
}
