using UnityEngine;

public class Collision : MonoBehaviour
{
    private Score _score;
    public AudioSource applauseSound;
    public AudioSource whistleSound;
    public GameOver _gameOver;
    private bool _lostGame = false;

    private void Start()
    {
        _score = GameObject.Find("UI").GetComponent<Score>();
        whistleSound.Play();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Keeper"))
        {
            _gameOver.Setup("Game over");
            _lostGame = true;
            Debug.Log("you are dead sir!!");
        }
        if (other.gameObject.CompareTag("GoalLine") && !_lostGame)
        {
            _score.numOfGoals++;
            applauseSound.Play();
            _gameOver.Setup("You won");
            Debug.Log("Goal!!!!!!!!!!!");
        }
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Keeper"))
        {
            Debug.Log("you are dead sir!!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GoalLine"))
            print("EXIT");
    }
}
