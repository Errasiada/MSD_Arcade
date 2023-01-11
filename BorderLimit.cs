using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderLimit : MonoBehaviour
{
    private Vector2 screenlimit;
    private float playerlength;
    private float playerheight;
    private Camera camera;
    
    void Start()
    {
        camera = FindObjectOfType<Camera>();
        screenlimit = camera.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,camera.transform.position.z));
        playerlength = transform.GetComponent<SpriteRenderer> ().bounds.size.x;
        playerheight = transform.GetComponent<SpriteRenderer> ().bounds.size.y;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewposition = transform.position;
        viewposition.x = Mathf.Clamp(viewposition.x, screenlimit.x * -1 -playerlength, screenlimit.x + playerlength);
        viewposition.y = Mathf.Clamp(viewposition.y, screenlimit.y * -1 - playerheight, screenlimit.y + playerheight);

        transform.position = viewposition;
        
    }
}
