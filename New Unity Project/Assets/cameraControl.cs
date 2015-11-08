using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {
   // private Rigidbody rb;
    [SerializeField]
    private Transform playerController;
    private Transform cameraT;
    // Use this for initialization
    void Start () {
        //rb = this.GetComponent<Rigidbody>();
        cameraT = this.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 v = new Vector3(playerController.position.x, playerController.position.y + 1, playerController.position.z - 5);
        cameraT.position = v;
    }
    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bouncy")
        {
            rb.AddForce(transform.up * 15, ForceMode.Impulse);
        }
    }*/
}
