using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    
    public TMP_Text timerText;
    private float _timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Game time ";
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        int seconds = (int)(_timer % 60);
        timerText.text = "Game time " + seconds;
    }
}
