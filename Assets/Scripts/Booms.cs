using UnityEngine;

public class Booms: MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private float raduis;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    public void Boom()
    {
        Rigidbody[] targets = FindObjectsOfType<Rigidbody>();

        foreach (var target in targets)
        {
            var distance = Vector3.Distance(_transform.position, target.position);
            if (distance <= raduis)
            {
                Vector3 direction = target.position - _transform.position;
                target.AddForce(direction.normalized * power * (raduis - distance), ForceMode.Impulse);
            }
        }
    }

}
