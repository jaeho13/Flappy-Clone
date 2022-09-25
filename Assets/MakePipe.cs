using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timediff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(1, Random.Range(-0.7f, 3.8f),0);
            timer = 0;
            Destroy(newpipe, 7.0f);
        }

    }
}
