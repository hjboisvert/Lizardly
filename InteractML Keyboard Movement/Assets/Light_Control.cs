using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class Light_Control : MonoBehaviour
{
    Light Under_light;

    [PullFromIMLController, Range(0, 10)]
    public float LightIntesity;

    // Start is called before the first frame update
    void Start()
    {
        Under_light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Under_light.intensity = LightIntesity;
    }
}
