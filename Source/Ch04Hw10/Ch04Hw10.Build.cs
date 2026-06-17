// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ch04Hw10 : ModuleRules
{
	public Ch04Hw10(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput",
			"Test", //부 모듈을 메인모듈에 추가
			"Temporary", //플러그인을 Primary모듈에 추가
		
		}
		);
	}
}
