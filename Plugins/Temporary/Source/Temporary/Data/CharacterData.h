
#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "CharacterData.generated.h"

UCLASS(BlueprintType)
class TEMPORARY_API UCharacterData : public UObject
{
	GENERATED_BODY()
	
public:

	UCharacterData();

	UPROPERTY(EditAnywhere,BlueprintReadOnly, Category = "CharacterData")
	FString Name;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "CharacterData")
	float HP;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "CharacterData")
	int32 Level;

};
