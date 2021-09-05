using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int intscore = 0;
        // string strname = "Bob";
        // float fltjump = 5.82f;
        // bool blngameover = false;

        float fltmynumber = 5.0f;
        float fltb = 2.0f;
        float fltc = fltb * 2.0f;

        fltmynumber += 15.2f;

        fltmynumber *= 3.0f;

        fltmynumber--;
        fltmynumber++;

        fltmynumber += fltb;

        Debug.Log(fltmynumber);

        int intNumA = 20;
        int intNumB = 15;

        if(intNumA < intNumB)
            {
                Debug.Log("intNumA is less than intNumB");
                
                if(intNumA==5 && intNumB==6)
                {
                    
                }
                if (intNumA > 5 || intNumB > 10)
                {
                    
                }
            }
            else if(intNumA > intNumB)
            {
                Debug.Log("intNumA is greater than intNumB");
            } 
            else
            {
                Debug.Log("intNumA is equal to intNumB");
            }

        Debug.Log(transform.position);

        Vector3 testvector = new Vector3(10, 2, -5);

        transform.position += testvector;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
