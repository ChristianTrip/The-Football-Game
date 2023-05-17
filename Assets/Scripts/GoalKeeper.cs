using UnityEngine;

public class GoalKeeper : MonoBehaviour
{
    [SerializeField] private float distanceToCover;
    [SerializeField] private float speed;

    private Vector3 startingPosition;
    void Start()
    {
        startingPosition = transform.position;
    }
    
    void Update()
    {
        Vector3 vector3 = startingPosition;
        vector3.x = distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = vector3;

    }
}
