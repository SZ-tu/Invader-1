using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPber : MonoBehaviour
{
    int maxHp = 10;
    int Hp;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        Hp = maxHp;
    }

    private void OnTriggerEnter(Collider collider)
    {
      
        if (collider.gameObject.tag == "enemy")
        {
            //HP����1������
            Hp = Hp - 1;

            //HP��Slider�ɔ��f�B
            slider.value = (float)Hp / (float)maxHp; ;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
