using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            //Instantiate��bulletPrefab���o�������A�o���������I�u�W�F�N�g��bullet�ɑ��

            rb = bullet.GetComponent<Rigidbody>(); //bullet��rigidbody���擾
            rb.AddForce(transform.forward * bulletSpeed); //�͂�������

            Destroy(bullet, lifeTime); //bullet��lifeTime�b��ɉ�
        }
    }
}
