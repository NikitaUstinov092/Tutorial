using Zenject;

public class CompleteObserver_PlayerHold : TutorialCompleteObserver
{
    private PlayerShoot _playerShoot;
    private Move _playerMove;
    
    [Inject]
    private void Construct(PlayerShoot playerShoot, Move playerMove)
    {
        _playerShoot = playerShoot;
        _playerMove = playerMove;
    }
    protected override void OnTutorialComplete()
    {
        _playerShoot.CanShoot = false;
        _playerMove.CanMove = false;
    }
}
