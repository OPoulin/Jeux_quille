using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplacerQuilles : MonoBehaviour
{
    Transform positionQuille;
    bool onReplaceUneFois = false;

    // Start is called before the first frame update
    void Start()
    {
        positionQuille = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (positionQuille.position != GetComponent<Transform>().position && positionQuille.rotation != GetComponent<Transform>().rotation && onReplaceUneFois == false)
        {
            Invoke("Replacer", 5f);
            onReplaceUneFois = true;
        }
    }

    public void Replacer()
    {
        GetComponent<Transform>().position = positionQuille.position;
        GetComponent<Transform>().rotation = positionQuille.rotation;
        onReplaceUneFois = false;
        CancelInvoke();
    }
}
