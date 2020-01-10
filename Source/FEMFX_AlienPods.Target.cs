// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FEMFX_AlienPodsTarget : TargetRules
{
	public FEMFX_AlienPodsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FEMFX_AlienPods");
	}
}
