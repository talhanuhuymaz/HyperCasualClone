using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;

    [SerializeField] private float leftRightSpeed;


    void Start()
    {


    }



    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * leftRightSpeed * Time.deltaTime;

        this.transform.Translate(yatay, 0, forwardSpeed * Time.deltaTime);

    }
}
