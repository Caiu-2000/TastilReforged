
using UnityEngine;

[DefaultExecutionOrder(10)]
public class CameraBrain : MonoBehaviour , IObserver<movementData>
{
    private Rigidbody rb;
    Vector3 velocity;
    public void Notify(movementData t)
    {
        velocity = t.velocity;
      
    }

    void Start()
    {
        rb = GameManager.player.GetComponent<Rigidbody>();

    }
    //        Vector3 TiltDirection = (transform.position - hittdata.AttackFrom).normalized;


}
/*
 * private IEnumerator InclinarObjeto(Quaternion destino)
    {
        PaintMaterial(new Color(42,129,255)); // Cambia el color a rojo al inclinarse
        while (Quaternion.Angle(transform.rotation, destino) > 0.1f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, destino, Time.deltaTime * velocidadRotacion);
            yield return null;
        }
        transform.rotation = destino;


        while (Quaternion.Angle(transform.rotation, rotacionInicial) > 0.1f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionInicial, Time.deltaTime * velocidadRotacion);
            yield return null;
        }

        transform.rotation = rotacionInicial;
        corrutinaInclinacion = null;
        PaintMaterial(Color.white); // Cambia el color de vuelta a blanco al volver a la posición inicial
    }
 * 
 */