using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamenerBoules : MonoBehaviour
{
    Transform positionBoule;
    bool unInvoke = false;
    // Start is called before the first frame update
    void Start()
    {
        positionBoule = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().velocity != Vector3.zero && unInvoke == false)
        {
            Invoke("Retour", 15f);
            unInvoke = true;
        }

        if (positionBoule.position.x > 100 || positionBoule.position.x < -120 || positionBoule.position.y > 100 || positionBoule.position.y < -90 || positionBoule.position.z > 130 || positionBoule.position.z < -130)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Transform>().position = positionBoule.position;
            CancelInvoke("Retour");
            unInvoke = false;
        }
    }


    public void Retour()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Transform>().position = positionBoule.position;
        unInvoke = false;
    }
}
