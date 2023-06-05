using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20;

    [SerializeField] float boostedSpeed = 40;
    [SerializeField] float slowedSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var steerAmount = -Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            Debug.Log("Boost");
            moveSpeed = boostedSpeed;
        }

        if (collision.tag == "Bump")
        {
            Debug.Log("Bump");
            moveSpeed = slowedSpeed;
        }
    }
}
