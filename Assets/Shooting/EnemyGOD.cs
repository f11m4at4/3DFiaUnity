using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 만들고 싶다.
// 필요속성 : 생성시간, 적 공장, 경과시간
public class EnemyGOD : MonoBehaviour
{
    // 필요속성 : 생성시간, 적 공장, 경과시간
    public float createTime = 2;
    public GameObject enemyFactory;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 일정시간에 한번씩 적을 만들고 싶다.
        // 1. 시간이 흘러야한다.
        currentTime += Time.deltaTime;
        // 2. 생성시간이 됐으니까
        // -> 만약 경과 시간이 생성시간을 초과했다면
        if (currentTime > createTime)
        {
            // 3. 적이 있어야 한다.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. 적을 배치하고 싶다.
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
