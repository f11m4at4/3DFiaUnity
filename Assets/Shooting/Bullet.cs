using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ���� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �ӵ�
public class Bullet : MonoBehaviour
{
    // �ʿ�Ӽ� : �ӵ�
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        // ����
    }

    // Update is called once per frame
    void Update()
    {
        // ��� ���� �̵��ϰ� �ʹ�.
        // 2. �������ʿ�
        Vector3 dir = Vector3.up;
        // 3. �̵��ϰ� �ʹ�.
        // P = P0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
