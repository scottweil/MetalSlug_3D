using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParamStateBehavior : StateMachineBehaviour
{
    public SetParamStateData[] ParamStateData;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (SetParamStateData data in ParamStateData)
        {
            animator.SetBool(data.paramName, data.setDefaultState);
        }
    }

    [Serializable]
    public struct SetParamStateData
    {
        public string paramName;
        public bool setDefaultState;
    }
}
