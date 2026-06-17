// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ch04Hw10 : ModuleRules
{
	public Ch04Hw10(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
