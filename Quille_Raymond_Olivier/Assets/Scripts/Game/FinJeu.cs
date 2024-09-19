using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJeu : MonoBehaviour
{
    public GameObject joueur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == joueur)
        {
            Application.Quit();
        }
    }
}
