﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arriver : Kinematic
{
    public Arrive myMoveType;
    LookWhereGoing myRotateType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Arrive();
        myMoveType.character = this;
        myMoveType.target = myTarget;

        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
