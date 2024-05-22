using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juego
{
    public abstract class Bullet : MonoBehaviour
    {
        public float speed = 10f;
        public int damage = 1;

        public abstract void Move();
    }
}