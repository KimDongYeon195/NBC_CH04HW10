// .Built.cs -> UBT에게 해당 모듈의 컴파일 방향성을 알려주는 파일, 사용할 모듈을 모아 컴파일
// 모듈 목록 : 특정 기능을 사용하려면, 기능이 속해있는 모듈을 등록함

using UnrealBuildTool;

public class Test : ModuleRules
{
    public Test(ReadOnlyTargetRules Target) : base(Target)
    { 
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] //헤더와 cpp에서 모두 사용하는 모듈
            {
                "Core", //기본 기능(FString, TArray, TMap...)
                "CoreUObject", //프로퍼티, UFUNCTION, UObject...
                "Engine", //AActor, ACharacter, UWorld....
                "InputCore", //키 입력 기능
            }
        );

        PrivateDependencyModuleNames.AddRange(new string[] { }); //cpp(소스파일)에서만 사용하는 모듈

    }
}