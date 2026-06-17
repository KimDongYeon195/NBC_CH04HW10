// Copyright Epic Games, Inc. All Rights Reserved.

#include "Ch04Hw10GameMode.h"
#include "Ch04Hw10Character.h"
#include "UObject/ConstructorHelpers.h"

ACh04Hw10GameMode::ACh04Hw10GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
