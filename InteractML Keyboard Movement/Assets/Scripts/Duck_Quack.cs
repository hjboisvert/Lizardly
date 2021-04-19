using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class Duck_Quack : MonoBehaviour
{
    AudioSource DuckSound;

    [PullFromIMLController, Range(0, 1)]
    public float Volume;

    // Start is called before the first frame update
    void Start()
    {
        DuckSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Volume <= 1)
        {
            DuckSound.volume = Volume;
        }

    }
}
