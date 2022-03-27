using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float destroyPosition = -2f;
    public float gravityScaleRate = 20f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
