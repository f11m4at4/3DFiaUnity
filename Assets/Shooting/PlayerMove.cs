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
        // ������� �Է��� �޾Ƽ� �¿�� �̵��ϰ� �ʹ�.
        // 1. ������� �Է¿����� -0.1, -0.2, -0
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // 2. �������ʿ�
        Vector3 dir = Vector3.right * x + Vector3.up * y;        
        // 3. �̵��ϰ� �ʹ�.
        // P = P0 + vt
        transform.position = transform.position + dir * 5 * Time.deltaTime;

        // ��� ���������� �̵��ϰ� �ʹ�. 
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
