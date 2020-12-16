using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float harizontalInput;
    public float xRange;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;  
    }

    // Update is called once per frame
    void Update()
    {

    //make player to move left and right
        harizontalInput = Input.GetAxisRaw("Horizontal");//-1 0 1
        transform.Translate(Vector3.right * harizontalInput * speed * Time.deltaTime);

    //make sure player cannot go off the screen
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, 0, -97);
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, 0, -97);
    }
}
