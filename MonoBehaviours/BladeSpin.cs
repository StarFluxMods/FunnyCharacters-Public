using UnityEngine;

namespace FunnyCharacters.MonoBehaviours
{
    public class BetterSpin : MonoBehaviour
    {
        public bool SpinDuringGameplay;

        public Vector3 SpinAxis;

        public float SpinRate;

        protected float Rotation;

        private void Start()
        {
            Rotation = Random.Range(0, 360);
            transform.localRotation = Quaternion.AngleAxis(Rotation, SpinAxis);
        }

        protected virtual void Update()
        {
            if (SpinDuringGameplay)
            {
                transform.localRotation = Quaternion.AngleAxis(Rotation += SpinRate * Time.deltaTime, SpinAxis);
            }
        }
    }

    public class BetterSpinByWorldPosition : BetterSpin
    {
        public float MaxDistancePerSecond = 0.1f;

        public float GrowRate = 0.1f;

        public float DecayRate = 0.05f;

        private Vector3 LastUpdatePosition;

        private float Speed;

        protected override void Update()
        {
            Vector3 vector = transform.position - LastUpdatePosition;
            LastUpdatePosition = transform.position;
            if (vector.sqrMagnitude > MaxDistancePerSecond * Time.deltaTime)
            {
                Speed += GrowRate * Time.deltaTime;
            }
            else
            {
                Speed -= DecayRate * Time.deltaTime;
            }

            Speed = Mathf.Clamp(Speed, 0f, 2f);
            float spinRate = SpinRate;
            SpinRate *= Speed;
            base.Update();
            SpinRate = spinRate;
        }
    }
}