# reinforce_game

윈폼으로 만들어본 강화게임입니다.  

강화 버튼 누르면 강화가 됩니다.  

인벤토리 기능을 이용하여  
현재 강화중인 것을 저장해 놓을 수 있습니다.  

인벤토리에 저장해 놓은 것을 다시 불러와  
강화를 시도할 수 있습니다.  

## 강화 확률

강화 확률 공식은 다음과 같습니다.
> 100 * exp(-X / 10)  

원래는 1차 함수를 이용하여 구현을 했었는데  
그렇게하면 강화 단계에 제한이 생기게 되었습니다.  

그걸 해결하고자 극한 값으로 수렴하는  
함수를 이용하여 강화 확률을 설정하였습니다.  

이를 통해 이론상 무한정 강화를 할 수 있게 되었습니다만  
어느정도 강화를 진행하면 확률이 0에 수렴하기 때문에  
그 확률을 뚫고 강화를 진행하기는 힘들 것으로 보입니다.  

## 강화 확률 - 2

강화 확률을 정하는 방법에는 여러가지가 있지만  
저는 함수를 이용하여 각 단계별로 확률을 구하는 방법을  
선택하였습니다.  

하지만 다른 여러 방법들도 있었는데  
그 중 대표적인 것이 `메이플스토리`에서의 강화 확률입니다.  

위 게임에서는 각 단계별로 공식을 설정하여 강화 확률을 구하는 방식을 선택하였습니다.  

예를 들어 0~5강은 5퍼센트씩 감소  
6~10강은 10퍼센트씩 감소  
그 이후는 1퍼센트로 고정과 같은 방식입니다.  

이런 식으로 강화확률을 설정하면  
각 단계별로 강화 난이도를 설정할 수 있게 됩니다.  

하지만 구현에 있어 각각 설정을 해주어야 한다는 점에서  
코드가 길어지게 될 것 이라는 예상이 있었고  
이에 저는 함수를 통한 강화 확률을 선택하였습니다.  

함수를 통하여 강화 확률을 설정해주면  
강화 확률이 깔끔하게 떨어지지는 않지만  
구현하는데 있어서 상당히 간편해진다는 장점이 있었습니다.  
