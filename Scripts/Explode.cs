using UnityEngine;

public class Explode : MonoBehaviour
{

    public GameObject restartButton, explosion;
    private bool _collisionSet;
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube" && !_collisionSet)
        {
            for(int i = collision.transform.childCount - 1; i >= 0; i--)
            {
                Transform child = collision.transform.GetChild(i);
                child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().AddExplosionForce(400f, Vector3.up, 10f);
                child.SetParent(null);
            }
            restartButton.SetActive(true);          
            Camera.main.gameObject.AddComponent<CameraShake>();
            Destroy(collision.gameObject);
            _collisionSet = true;

            if (PlayerPrefs.GetString("Music") != "No")
                GetComponent<AudioSource>().Play();


            Instantiate(explosion, new Vector3(collision.contacts[0].point.x, collision.contacts[0].point.y, collision.contacts[0].point.z), Quaternion.identity);
        }
    }
 
    }

