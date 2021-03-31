namespace RollaBall
{
    public class PlayerBall : Player
    {

        private void Update()
        {
            GetAxis();
        }

        private void FixedUpdate()
        {
            Move();
        }

    }
}

