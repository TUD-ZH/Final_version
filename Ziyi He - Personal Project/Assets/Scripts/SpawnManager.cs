using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    //create array
    public GameObject[] christmasPrefabs;
    public bool gameStarted;
    public int index;
    public float xRange; 
    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameStarted = true;
        score = 0;
        scoreText.text = "Score:" + score;

        //objects will appear in repetedly every second
        InvokeRepeating(nameof(SpawnObject), 2, 1);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObject()
    {

        //random
        float xPos = Random.Range(-xRange, xRange);
        index = Random.Range(0, christmasPrefabs.Length);
        Instantiate(christmasPrefabs[index], new Vector3(xPos, 0f, -75f), christmasPrefabs[index].transform.rotation);

    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;

    }

    public void GameIsOver()
    {
        gameStarted = false;

    }
}