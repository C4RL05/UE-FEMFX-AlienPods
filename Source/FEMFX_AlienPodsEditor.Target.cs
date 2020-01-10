// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FEMFX_AlienPodsEditorTarget : TargetRules
{
	public FEMFX_AlienPodsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FEMFX_AlienPods");
	}
}
