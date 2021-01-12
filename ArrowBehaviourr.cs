using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviourr : MonoBehaviour
{
    public GameObject arrowprefab;

    public float arrowspeed = 60.0f;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       
    }
}
