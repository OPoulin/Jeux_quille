using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JouerMusiqueFin : MonoBehaviour
{
    public AudioClip musiqueFin;
    public AudioClip musiqueAmbiance;
    bool baisse = true;
    bool restart;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = musiqueAmbiance;
        GetComponent<AudioSource>().Play();
        InvokeRepeating("ChangeMusique", 420f, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        print(GetComponent<AudioSource>().volume); 
    }

    public void ChangeMusique()
    {
        if (baisse == true)
        {
            GetComponent<AudioSource>().volume -= 0.05f;

            if (GetComponent<AudioSource>().volume <= 0f)
            {
                GetComponent<AudioSource>().volume = 0f;
            }

            if (GetComponent<AudioSource>().volume == 0f)
            {
                baisse = false;
                GetComponent<AudioSource>().clip = musiqueFin;
                GetComponent<AudioSource>().Play();
            }
            print("On baisse");
        }
        else if (baisse == false)
        {
            GetComponent<AudioSource>().volume += 0.05f;

            if (GetComponent<AudioSource>().volume >= 1f)
            {
                GetComponent<AudioSource>().volume = 1f;
                CancelInvoke("ChangeMusique"); 
            }
            print("On monte");
        }
    }
}
