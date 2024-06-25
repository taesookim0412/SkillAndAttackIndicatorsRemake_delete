﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Assets.DTT.Area_of_Effect_Regions.Demo.Interactive_Demo.Scripts.Observer
{
    public class SkillAndAttackIndicatorInput : MonoBehaviour
    {
        [SerializeField]
        private SkillAndAttackIndicatorSystem SkillAndAttackIndicatorSystem;

        public void OnAbility1(CallbackContext ctx)
        {
            if (ctx.performed)
            {
                SkillAndAttackIndicatorSystem.TriggerSkillAndAttackIndicatorObserver(AbilityProjectorType.Arc, 
                    AbilityProjectorMaterialType.First,
                    AbilityIndicatorCastType.ShowDuringCast);
            }
        }
    }
}
