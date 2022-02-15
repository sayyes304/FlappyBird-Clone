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
        timer += Time.deltaTime;    // timer = 1 이면 1초가 흐른 것.
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);      //pipe 생성
            newpipe.transform.position = new Vector3(0, 0, 0);  //새롭게 좌표 설정
            timer = 0;      
        }       // 매 1초 마다 한 번씩 기둥이 생김
    }
}
