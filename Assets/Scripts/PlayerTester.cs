using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, 1));
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -1));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(1, 0));
        }
    }
}
