using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Spaceship _spaceship;

    // Start is called before the first frame update
    void Start()
    {
        ÑommandÑenter ñommandÑenter = new ÑommandÑenter(4, "lala", 100, 100);
        ñommandÑenter.AddBody(new Body(4, "lala", 100, 100), 0);
        ñommandÑenter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 0);
        ñommandÑenter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 1);
        ñommandÑenter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 2);
        ñommandÑenter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 3);
        _spaceship = new Spaceship(0, ñommandÑenter);
        Debug.Log(_spaceship.GetStrength());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
