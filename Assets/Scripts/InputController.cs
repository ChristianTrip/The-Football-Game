using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public Vector3 turn;
    public float MySpeed = 0.060f;

    public float sensitivity = 0.5f;
    //private float defaultSpeed = Time.deltaTime;
    private float _speed;

    public float xRange = 25;
    public float zRange = 25;
    // Start is called before the first frame update
    void Start()
    {
        this._rigidbody = GetComponent<Rigidbody>();
        this._speed = MySpeed;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        
        
        if (Input.GetKey((KeyCode.A)))
        {
            transform.Translate(Vector3.left * _speed);
        }
        if (Input.GetKey((KeyCode.W)))
        {
            transform.Translate(Vector3.forward * _speed);
        }
        if (Input.GetKey((KeyCode.D)))
        {
            transform.Translate(Vector3.right * _speed);
        }
        if (Input.GetKey((KeyCode.S)))
        {
            transform.Translate(Vector3.back * _speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * _speed);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.down * _speed);   
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }
}
