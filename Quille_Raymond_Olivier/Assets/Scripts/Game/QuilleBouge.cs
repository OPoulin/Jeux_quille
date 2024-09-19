using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuilleBouge : MonoBehaviour
{
    Transform transformQuille;

    // Start is called before the first frame update
    void Start()
    {
        transformQuille = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != transformQuille.position)
        {
            ManagerQuilles.QuillesTotales += 1;
            ManagerQuilles.QuillesTombees += 1;
        }
    }
}
