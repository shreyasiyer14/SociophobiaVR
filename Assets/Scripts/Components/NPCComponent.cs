﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(EntityComponent))]
abstract public class NPCComponent : AbstractComponent {
	abstract public IEnumerator NPCAction ();
}