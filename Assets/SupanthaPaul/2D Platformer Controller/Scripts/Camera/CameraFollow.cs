using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SupanthaPaul
{
    public class CameraFollow : MonoBehaviour
    {
        private Transform target;
        public Vector3 offset = Vector3.zero;
        public float smoothing = 1.5f;

        // Start is called before the first frame update
        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos + offset, smoothing * Time.deltaTime);
        }
    }
}
