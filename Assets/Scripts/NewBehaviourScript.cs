using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Spaceship _spaceship;

    // Start is called before the first frame update
    void Start()
    {
        �ommand�enter �ommand�enter = new �ommand�enter(4, "lala", 100, 100);
        �ommand�enter.AddBody(new Body(4, "lala", 100, 100), 0);
        �ommand�enter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 0);
        �ommand�enter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 1);
        �ommand�enter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 2);
        �ommand�enter.AddModule(new Battery("lala", 100, 100, 1000, 0), 0, 3);
        _spaceship = new Spaceship(0, �ommand�enter);
        Debug.Log(_spaceship.GetStrength());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
