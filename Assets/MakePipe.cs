using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    // timer = 1 �̸� 1�ʰ� �帥 ��.
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);      //pipe ����
            newpipe.transform.position = new Vector3(0, 0, 0);  //���Ӱ� ��ǥ ����
            timer = 0;      
        }       // �� 1�� ���� �� ���� ����� ����
    }
}
