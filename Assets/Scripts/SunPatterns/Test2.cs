﻿using UnityEngine;
using System.Collections;
using System;
/*
public class Test2 : MonoBehaviour, IPattern
{
    public float frequency = 0.3f;
    private float counter = 0;

    private readonly SunBehavior sb;

    private float angle = 90;
    private float radius = 0.4f;
    private float speed_multiplier;
    private int count = 1;
    private float bulletspeed = 1.5f;

    private ArrayList bullets;

    public Test2(SunBehavior sb)
    {
        this.sb = sb;
        bullets = new ArrayList();
    }

    public void UpdatePattern()
    {
        counter += Time.deltaTime;
        if (counter >= frequency)
        {
            emitProjectile();
            counter = 0;
        }
    }
    void emitProjectile()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 thispos = new Vector3(count * radius, count * radius, 0);
            thispos = Quaternion.Euler(angle, 0, 0) * thispos;
            speed_multiplier = bulletspeed * sb.force;
            //Debug.Log(thispos);
            GameObject go = (GameObject)Instantiate(sb.typeProjectiles[0], sb.transform.position + thispos, Quaternion.identity);
            go.GetComponent<ProjectileBehavior>().launchedby = "sun";
            //go.GetComponent<Rigidbody2D>().AddForce(thispos * speed_multiplier);
            angle += 90;
        }
        count++;
    }

    public void EndPattern()
    {
        throw new NotImplementedException();
    }
}
*/