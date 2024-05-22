using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juego
{
    public abstract class Ship : MonoBehaviour
    {
        public float speed = 3f;

        public abstract void Move(Vector3 direction);
        public abstract void Shoot(Enums.BulletType bulletType);
    }
}