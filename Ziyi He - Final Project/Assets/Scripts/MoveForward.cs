using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private PlayerController playerController;
    SpawnManager SpawnManager;
    public float speed = 40f;
    public int point;
    public float forwardBound;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        SpawnManager = FindObjectOfType<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

        //objects will move forward
        if (!playerController.isGameOver)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //objects will destory in this range
        if (transform.position.z < forwardBound && gameObject.CompareTag("bad"))
          {
            Destroy(gameObject);
          }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        SpawnManager.UpdateScore(point);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            SpawnManager.GameIsOver();
        }


    }

}
