using UnityEngine;

public class scriptNpc : MonoBehaviour
{

    private Rigidbody2D rbd;
    public float vel = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D col){
        scriptPlacar.addPlacar(5);
        Destroy(col.gameObject);
        Destroy(gameObject);
    }
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -Camera.main.orthographicSize){
            Destroy(gameObject);
        }

    }
}
