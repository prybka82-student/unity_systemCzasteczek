using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour
{
    ParticleSystem _particleSystem;
    bool _play = false;
    bool _includeChildren = true;

    public string InputKeyName;

    // Start is called before the first frame update
    void Start()
    {
        _particleSystem = transform.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(InputKeyName) > 0.5f)
            _play = !_play;
        
        if (_play)
            _particleSystem.Play(_includeChildren);
        else
            _particleSystem.Stop(_includeChildren, ParticleSystemStopBehavior.StopEmitting);
    }
}
