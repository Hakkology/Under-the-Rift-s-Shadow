using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalEffect : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90*Time.deltaTime, 0);
        
    }
}
