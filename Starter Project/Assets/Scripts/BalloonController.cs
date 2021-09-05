using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int intClicksToPop = 3;

    void OnMouseDown ()
    {
        //Minus one click
        intClicksToPop--;

        //Make is bigger by .2
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        //if clicks equal 0 then destroy object
        if (intClicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
