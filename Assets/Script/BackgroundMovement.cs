using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
public float scrollSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Child;
       for (int i = 0; i < transform.childCount; i++) {
       Child = transform.GetChild(i).gameObject;
       Scroll(Child);
       }
    }

    void Scroll(GameObject Scrolling) {
        Scrolling.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
    }
}
