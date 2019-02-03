using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject player;

    public float sidewaysForce = 1f;
    // Start is called before the first frame update
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, sidewaysForce * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -sidewaysForce * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0,90,0);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -90, 0);
        }

    }
}
