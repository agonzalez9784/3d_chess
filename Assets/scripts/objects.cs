using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    public int piece_type = 0; //0 = not a piece 
                               //1 = not a piece
    public Transform ob = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

            Transform ot = this.gameObject.transform;
            game g;
            g = ob.GetComponent<game>();
            g.action = true;
            g.o_t = piece_type;
            g.o = ot;
            Debug.Log(g.o);
            Debug.Log("Test");
    
    }
}
