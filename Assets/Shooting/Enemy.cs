using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ʒ��� ��� �̵��ϰ� �ʹ�.
// Ÿ�������� ��� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : Ÿ��
// �ε����� �� ����ȿ���� �߻���Ű�� �ʹ�.
// �ʿ�Ӽ� : ����ȿ�� ����
public class Enemy : MonoBehaviour
{
    // �ʿ�Ӽ� : �ӵ�
    public float speed = 5;
    // �ʿ�Ӽ� : Ÿ��
    public GameObject target;
    // �ʿ�Ӽ� : ����ȿ�� ����
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 2. �������ʿ� -> Ÿ�������� dir = target - me
        //Vector3 dir = target.transform.position - transform.position;
        Vector3 dir = Vector3.down;
        dir.Normalize();
        // 3. �̵��ϰ� �ʹ�.
        // P = P0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    // �ٸ� ��ü�� �ε����� 
    // �ε����� �� 
    private void OnCollisionEnter(Collision collision)
    {
        // ����ȿ���� �߻���Ű�� �ʹ�.
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        // ���� �װ� 
        Destroy(collision.gameObject);
        // ���� �װ�ʹ�.
        Destroy(gameObject);
    }
}
