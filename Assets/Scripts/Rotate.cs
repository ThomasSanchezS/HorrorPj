using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int eje = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(eje == 0){
        transform.Rotate(0f, 0f, 0.2f);
        }
        else if(eje == 1){
            transform.Rotate(0f, 0.2f, 0);           
        }else{
            transform.Rotate(0.2f, 0f, 0f);
        }
    }
}
