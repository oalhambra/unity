using UnityEngine;
using System.Collections;

public class esfera : MonoBehaviour {
    private float movX;
    private float movY;
    [SerializeField]
    private float velocidad;
    [SerializeField]
    private float impulso;
    [SerializeField]
    private float ratio;
    private Rigidbody rb;
    //[SerializeField]
    //private Transform playerController;
    //private Transform cameraT;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        ratio = 1;
        //cameraT = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
       // Vector3 v = new Vector3(playerController.position.x, playerController.position.y + 1, playerController.position.z - 5);
       // cameraT.position = v;
       
    }
    void FixedUpdate()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movX, 0.0F, movY);
        rb.AddForce(movement * velocidad);
        impulso = rb.velocity.y*-1;

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bouncy")
        {
            //rb.AddForce(transform.up*15 / (-2*(impulso)), ForceMode.Impulse);

            rb.AddForce(0.0F, impulso*ratio, 0.0F, ForceMode.Impulse);
            //rb.velocity.y
            
            

        }
    }
}
