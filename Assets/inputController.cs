using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class inputController : MonoBehaviour
{
    // Start is called before the first frame update
  //naming a variable vfx of type visual effect
  VisualEffect vfx; 
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       Vector3 mousePos = Input.mousePosition;
       float xRatio = mousePos.x/Screen.width - 0.5f; //this will give a value between -0.5 and 0.5 which will be the position of the middle of the screen
       vfx.SetInt("Spawnrate", (int)(xRatio * 1000f +1000f));
    //    Debug.Log((int)mousePos.x);
    //    Debug.Log((int)mousePos.y);

    vfx.SetFloat("StickDistance", xRatio * 0.1f +0.05f);

    }
}
