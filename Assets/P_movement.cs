using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_movement : MonoBehaviour
{
    Vector3 sharkMoveX;
    Vector3 sharkMoveUp;

    float generalSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sharkMoveX = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += sharkMoveX * Time.deltaTime * generalSpeed;

        sharkMoveUp = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += sharkMoveUp * Time.deltaTime * generalSpeed;
    }

}
