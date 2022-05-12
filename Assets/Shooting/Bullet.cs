using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 위로 이동하고 싶다.
// 필요속성 : 속도
public class Bullet : MonoBehaviour
{
    // 필요속성 : 속도
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        // 설정
    }

    // Update is called once per frame
    void Update()
    {
        // 계속 위로 이동하고 싶다.
        // 2. 방향이필요
        Vector3 dir = Vector3.up;
        // 3. 이동하고 싶다.
        // P = P0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
