using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public float speed = 5.0f; // �L�����N�^�[�̕������x

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // �ړ��x�N�g�����v�Z
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // �L�����N�^�[���ړ�
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
