using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Score : MonoBehaviour
{

    public Transform ball;

    public TMP_Text scoreText;
    public float numOfGoals;

    void Start()
    { 
        scoreText.text = "Score " + numOfGoals.ToString();
        numOfGoals = 0f;
    }
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score " + numOfGoals.ToString();
    }
}
