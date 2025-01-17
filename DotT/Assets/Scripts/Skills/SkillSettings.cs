﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill Settings", menuName = "Skill Settings", order = 3)]
public class SkillSettings : ScriptableObject {
	public enum Buttons {Q,W,E,R,D,one,two,three,four,five};
	public enum Types {Targeted, Area, Instant, Directional, Toggle, Vector, TargetedStructure};
	public enum Target {Enemy, Ally, Both};
	public enum StatusEffect {Slow, Stun};


	public Buttons skillButton = Buttons.Q;//Q,W,E,R,D,1-5

	//see the end for the rest
	public Types skillType = Types.Area;

	public Target skillTarget = Target.Enemy;

	//only one available, will show up on the ground, can be left empty, can have multiple states, triggers for talents, and animations
	public GameObject telegrapgh;	//see the end for more details

	public int damage;
	public float damageOverTime;
	public Health.HpModType damageType;
	//public Health.RatioType damageRatio;
	public int heal;
	public float healOverTime;
	public Health.RatioType healType;

	//multiple values for more complex skills
	public float[] otherValues;
	public Health.RatioType[] otherValueType;

	//any status effects the skill may apply - maybe this should be an array?
	public StatusEffect myEffect = StatusEffect.Slow;
	public float myEffectDuration = 1f;
	public float myEffectAmount = 0.4f;

	//values used in the script itself
	public float[] waitTimes = {0.2f,0.1f,0.3f,0.2f};


	public int manaCost = 50;

	public float cooldown = 5f;
	public float range = 8f;

	//use 0 for insta cast skills
	public float castTime;
	public string castAnimation = "Cast";	//will triggered said animation in the hero
}
