using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 100f;
    [SerializeField] float moveSpeed = 5f;
    //string a = "ab";
    //int num = 2;
    //bool loos = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal - rotate
        float steerAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        //Vertical - move
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
