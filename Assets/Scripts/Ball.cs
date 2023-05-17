using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball: MonoBehaviour
{
    private bool stickToPlayer;
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Transform playerBallPosition;
    private void Start()
    {
        Debug.Log("hello from ball script");
    }

    private void Update()
    {
        if (!stickToPlayer)
        {
            var distanceToPlayer = Vector3.Distance(transformPlayer.position, transform.position);
            if (distanceToPlayer < 1)
            {
                stickToPlayer = true;
            }
        }
        else
        {
            transform.position = playerBallPosition.position;
        }
            
    }
}
