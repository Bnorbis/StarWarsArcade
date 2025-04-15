using UnityEngine;

public class scriptSpaceShip : MonoBehaviour
{

    private Rigidbody2D rbd;
    public float vel;
    private float altura;
    private float largura; 
    private float alturaNave; 

    public GameObject tiro;
    private AudioSource shotSong;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        shotSong = this.GetComponent<AudioSource>();
        vel = 10;
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Bounds limites = sr.bounds;
        alturaNave = limites.size.y;
        alturaNave = GetComponent<SpriteRenderer>().bounds.size.y / 2;


    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rbd.velocity = new Vector2(x, y) * vel;

        if(this.transform.position.x > largura){
            this.transform.position =  new Vector2(-largura, this.transform.position.y);
        }else if(this.transform.position.x < -largura) {
            this.transform.position =  new Vector2(largura, this.transform.position.y);
        }

        if(this.transform.position.y > 0){
            this.transform.position =  new Vector2(this.transform.position.x, 0);
        }else if(this.transform.position.y < -altura + alturaNave){
            this.transform.position =  new Vector2(this.transform.position.x, -altura + alturaNave);
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            shotSong.Play();
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + alturaNave);
            Instantiate(tiro, transform.position, Quaternion.identity);
        }
        

    }
}
