using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicGun : MonoBehaviour
{
    [SerializeField]
    private Transform _firePoint;
    [SerializeField, Range(0.2f, 2f)]
    private float _delay = 2f;
    [SerializeField, Range(0.5f, 100f)]
    private float _velocity = 15f;
    [SerializeField, Min(.1f)]
    private float _mass = 5f;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            var tr = obj.transform;
            tr.localScale = new Vector3(.4f, .4f, .4f);
            tr.SetPositionAndRotation(_firePoint.position, _firePoint.rotation);
            var body = obj.AddComponent<Rigidbody>();
            body.mass = _mass;
            body.velocity = _firePoint.up * _velocity;
            body.interpolation = RigidbodyInterpolation.Interpolate;
            body.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            Destroy(obj, 10f);
        }
    }
    public IEnumerator Gun_Mover(bool side, Vector3 pos, float Target_time)
    {
            if (side)
            {
                var time = 0f;
                while (Target_time > time)
                {
                    transform.localPosition = Vector3.Lerp(pos, new Vector3(pos.x, pos.y, 7f), 1f - (Target_time - time) / Target_time);
                    time += Time.deltaTime;
                    yield return null;
                }
            }

            else
            {
                var time = 0f;
                while (Target_time > time)
                {
                    transform.localPosition = Vector3.Lerp(pos, new Vector3(pos.x, pos.y, -11f), 1f - (Target_time - time) / Target_time);
                    time += Time.deltaTime;
                    yield return null;
                }

            }
    }
}
