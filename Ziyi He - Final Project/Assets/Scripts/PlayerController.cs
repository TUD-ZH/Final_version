using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float harizontalInput;
    public float xRange;
    public float gravityModifier;
    public bool isGift;
    public bool isGameOver;
    private AudioSource audioSource;

    public AudioClip giftClip, treeClip;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        isGift = false;
    //make player to move left and right
        harizontalInput = Input.GetAxisRaw("Horizontal");//-1 0 1
        transform.Translate(Vector3.right * harizontalInput * speed * Time.deltaTime);
     
    //make sure player cannot go off the screen
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, 0, -97);
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, 0, -97);
    }


    public void OnCollisionEnter(Collision other)
    { 
        if(other.gameObject.CompareTag("gift"))
        {
            isGift = true;
            audioSource.PlayOneShot(giftClip, 1.0f);
        }
        if (other.gameObject.CompareTag("bad"))
        {
            isGameOver = true;
            Debug.Log("Game Over");
            audioSource.PlayOneShot(treeClip, 1.0f);
        }
    }
}