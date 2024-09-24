using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointageQuilles : MonoBehaviour
{
    public static int nombreQuillesTotal;
    public static int nombreQuilleLive;
    public TextMeshProUGUI TexteQuilles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AfficherScore()
    {
        TexteQuilles.text = "Nombre de quilles tombées : " + nombreQuilleLive;
        if (nombreQuilleLive == 10)
        {
            TexteQuilles.text = "STRIKE!!!";
        }
        GetComponent<Animator>().SetBool("Montrer", true);
        Invoke("ArreterAnim", 15f);
    }

    public void ArreterAnim()
    {
        GetComponent<Animator>().SetBool("Montrer", false);
    }
}
