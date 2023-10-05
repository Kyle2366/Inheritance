using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orc : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void AttackPlayer()
    {
        print("orc is attacking the player");
    }
}
