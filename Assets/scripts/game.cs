using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{


    // 0 = white, 1 = black
    public int turn = 0;
    public bool running = false;
    public Transform o = null;
    public int o_t = 0;
    private Transform o1 = null;
    public int o1_t = 0;
    private Transform o2 = null;
    public int o2_t = 0;
    public bool action = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Does this work?");
        running = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(action)
        {
             if(o1 == null)
            {
                o1 = o;
                Debug.Log("o1: ");
                Debug.Log(o1);
                o1_t = o_t;
                o = null;
                o_t = 0;
                action = false;

              }else
            {

                if(o != null)
                {
                    o2 = o;
                    o2_t = o_t;
                    Debug.Log("o2: ");
                    Debug.Log(o2);
                    
                        //Transform rb1 = o1.GetComponent<Transform>();
                        //Transform rb2 = o2.GetComponent<Transform>();
                    Vector3 nPos = new Vector3(o2.transform.position.x, o1.transform.position.y, o2.transform.position.z);
                    o1.position = nPos;
                        //rb1.x = rb2.x;
                        //rb1.z = rb2.z;

        
                    Vector3 dObj = new Vector3(1000,1000,1000);

                    if(o2_t == 1)
                    {
                        o2.position = dObj;
                    }else{
                        o_t = 0;
                        o1 = null; 
                        o1_t = 0;
                        o2 = null;
                        o2_t = 0;
                        o = null;  
                        action = false;
                    }

                    o_t = 0;
                    o1 = null; 
                    o1_t = 0;
                    o2 = null;
                    o2_t = 0;
                    o = null;  
                    action = false;
                }
                
            }
            
        
        }else{
            o = null;
        }
    }
              

}

    

