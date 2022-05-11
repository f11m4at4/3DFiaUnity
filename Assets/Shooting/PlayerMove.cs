using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력을 받아서 좌우로 이동하고 싶다.
        // 1. 사용자의 입력에따라 -0.1, -0.2, -0
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // 2. 방향이필요
        Vector3 dir = Vector3.right * x + Vector3.up * y;        
        // 3. 이동하고 싶다.
        // P = P0 + vt
        transform.position = transform.position + dir * 5 * Time.deltaTime;

        // 계속 오른쪽으로 이동하고 싶다. 
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
