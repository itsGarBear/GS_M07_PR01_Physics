﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehavior
{
    public Kinematic character;
    public GameObject target;

    float maxAcceleration = 100f;

    protected virtual Vector3 getTargetPosition()
    {
        return target.transform.position;
    }

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        Vector3 targetPosition = getTargetPosition();
            
        result.linear = targetPosition - character.transform.position;

        result.linear.Normalize();
        result.linear *= maxAcceleration;

        result.angular = 0;
        return result;
    }
}
