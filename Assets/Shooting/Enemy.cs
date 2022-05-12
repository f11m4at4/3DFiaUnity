using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아래로 계속 이동하고 싶다.
// 타겟쪽으로 계속 이동하고 싶다.
// 필요속성 : 타겟
// 부딪혔을 때 폭발효과를 발생시키고 싶다.
// 필요속성 : 폭발효과 공장
public class Enemy : MonoBehaviour
{
    // 필요속성 : 속도
    public float speed = 5;
    // 필요속성 : 타겟
    public GameObject target;
    // 필요속성 : 폭발효과 공장
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 2. 방향이필요 -> 타겟쪽으로 dir = target - me
        //Vector3 dir = target.transform.position - transform.position;
        Vector3 dir = Vector3.down;
        dir.Normalize();
        // 3. 이동하고 싶다.
        // P = P0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    // 다른 물체와 부딪히면 
    // 부딪혔을 때 
    private void OnCollisionEnter(Collision collision)
    {
        // 폭발효과를 발생시키고 싶다.
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        // 갸도 죽고 
        Destroy(collision.gameObject);
        // 나도 죽고싶다.
        Destroy(gameObject);
    }
}
