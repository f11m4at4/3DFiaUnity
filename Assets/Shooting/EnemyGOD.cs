using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð��� �ѹ��� ���� ����� �ʹ�.
// �ʿ�Ӽ� : �����ð�, �� ����, ����ð�
public class EnemyGOD : MonoBehaviour
{
    // �ʿ�Ӽ� : �����ð�, �� ����, ����ð�
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
        // �����ð��� �ѹ��� ���� ����� �ʹ�.
        // 1. �ð��� �귯���Ѵ�.
        currentTime += Time.deltaTime;
        // 2. �����ð��� �����ϱ�
        // -> ���� ��� �ð��� �����ð��� �ʰ��ߴٸ�
        if (currentTime > createTime)
        {
            // 3. ���� �־�� �Ѵ�.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. ���� ��ġ�ϰ� �ʹ�.
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
