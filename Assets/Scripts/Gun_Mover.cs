using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Mover : PhysicGun
{
    private Transform pos;
    private bool side = true;
    public float Target_time = 1f;
    public IEnumerator Start()
    {
        pos = transform;
        while (true)
        {
            yield return Gun_Mover(side, pos.position, Target_time);
            SetActive();
        }

        void SetActive()
        {
            if (side)
                side = false;
            else
                side = true;
        }
    }
}
