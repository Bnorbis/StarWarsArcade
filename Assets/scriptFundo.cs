using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFundo : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float vel;

    void Start()
    {
        vel = 4;   
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10){
            transform.position = new Vector2(0, 10);
        }
    }
}
