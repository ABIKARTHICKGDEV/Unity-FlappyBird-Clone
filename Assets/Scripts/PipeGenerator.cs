using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(GeneratePipes()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GeneratePipes()
    {
        while (true)
        {
            float gappipe = Random.RandomRange(2.8f,4f);
            yield return new WaitForSeconds(gappipe);
            float randy = Random.Range(-1.7f, 3f);
            pos = new Vector3(8f, randy, 0f);
            Instantiate(pipe, pos, Quaternion.identity);
        }
        
    }

}
