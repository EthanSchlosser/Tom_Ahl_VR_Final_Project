using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_Button1 : MonoBehaviour
{
    public GameObject platform;
    public float platformSpeed = 2f;
    public XRButton upButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(upButton.isHovered)
        {
            platform.transform.Translate(Vector3.up * Time.deltaTime * platformSpeed, Space.World);
        }
    }

    public void ButtonPushed()
    {
        Debug.Log("You pushed the Button!");
    }
}
