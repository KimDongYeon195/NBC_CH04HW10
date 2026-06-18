# NBC_CH04HW10
## 필수 구현 기능 - 모듈 & 플러그인 시스템
모듈과 플러그인을 추가하여 코드를 기능단위로 분리, 재사용하는 구조 생성.

### 모듈 생성
Source/Test 폴더 생성후 Test.Build.cs/ Test.h /Test.cpp파일 생성 후, 모듈 목록 추가
-publicDependencyModuleNames'에 Core, CoreUObject, Engine등록.
-`IMPLEMENT_MODULE(FDefaultModuleImpl, Test)`로 모듈 선언(Primary Module과는 다름)

### Test모듈을 컴파일에 추가하기위한 설정
- ModuleAndPlugin.Target.cs/Editor.Target.cs의 ExtraModuleNames에 "Test"추가
- .uproject의 Modules리스트에 Test모듈 등록
- LoadingPhase : PreDefault 설정 (Primary 모듈보다 먼저 로드)

### 모듈간 상호작용
Test 모듈에 AActor클래스인 TestActor클래스를 생성함.
    - UE_LOG를 사용하여 액터클래스가 생성되었음을 알림(TestActor::BeginPlay())
설계 
1. 캐릭터(주 모듈)에 TestActor(Test Module)의 IA을 입력하여 캐릭터300.f앞쪽에 SpawnActor되도록 함.
2. TestActor 클래스 작성 : SceneComponent, StaticMeshComponent를 생성
3. IA을 Playercharacter에 바인딩.
4. SpawnTestActor()함수에 SpawnActor()로직 구현 

### 플러그인 구축
- 프로젝트 활성화: `.uproject` 파일의 `Plugins` 항목에 `Temporary` 플러그인을 `Enabled: true`로 등록.


### 도전 구현 기능 - 플러그인에 새 C++클래스를 생성하여 캐릭터 기능 추가
UCharacterData 클래스를 만들고 속성을 추가해서 해당 속성의 초기값을 마음대로 설정해봅니다.
설계  
1. UCharacterData클래스에 기본적인 캐릭터 데이터작성.
2. CharacterData를 상속받은 각 직업Data클래스를 생성함 (Warrior, Rogue)
4. 속성은 Name, HP, Level.
5. Character클래스의 BeginPlay()에서 UKismetSystemLibrary::PrintString()를 사용하여 출력
    출력예시 : 
            "직업 : 전사"
            "체력 : 300"
            "레벨 : 1"
