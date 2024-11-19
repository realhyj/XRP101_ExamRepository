# 4번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 1. Player
- 상태 패턴을 사용해 Idle 상태와 Attack 상태를 관리한다.
- Idle상태에서 Q를 누르면 Attack 상태로 진입한다
  - 진입 시 2초 이후 지정된 구형 범위 내에 있는 데미지를 입을 수 있는 적을 탐색해 데미지를 부여하고 Idle상태로 돌아온다
- 상태 머신 : 각 상태들을 관리하는 객체이며, 가장 첫번째로 입력받은 상태를 기본 상태로 설정한다.

### 2. NormalMonster
- 데미지를 입을 수 있는 몬스터

### 3. ShieldeMonster
- 데미지를 입지 않는 몬스터

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
1) Q 입력시, damagable.TakeHit(Controller.AttackValue);에서 문제가 발생한다.
	-> null에 대한 예외처리 문제인 것 같다. 
	-> if (damagable != null)
		{
   			 damagable.TakeHit(Controller.AttackValue);
		} 로 수정하여 예외처리를 한다
2) Q 입력시, 오버플로우가 발생한다.
	-> StateMachine과 StateAttack에서 생기는 것으로 추정된다.
	-> 
