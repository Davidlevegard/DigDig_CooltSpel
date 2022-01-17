using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingSoundfx : MonoBehaviour
{
    public AudioSource GunSound;

    void Start()
    {
        GunSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
