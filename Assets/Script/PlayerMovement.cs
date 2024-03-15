using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    // ----------SALTO----------------
    private Rigidbody2D rb;
    private float horizontalMove;
    public float speed = 5;
    public float jumpSpeed = 10;
    bool isGrounded;
    bool canDoubleJump;
    public float delayBeforeDoubleJump;
    // ----------PATROL----------------
    public float HitCounter = 4;
    public GameObject Patrol;
    // ----------LOST GAME----------------
    [SerializeField]
    private float delayBeforeLoading = 7.5f;
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
 
  
    }
 
    // Update is called once per frame
    void Update()
    {
  
    }
 
 
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            canDoubleJump = false;
            GetComponent<Animator>().SetBool("BoolSalto", false);
        }

    }
    public void jumpButton()
    {
        if(isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * jumpSpeed;
            Invoke("EnableDoubleJump", delayBeforeDoubleJump);
            

        }
        if (canDoubleJump)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            canDoubleJump = false;
        }

        if(isGrounded == false){
            GetComponent<Animator>().SetBool("BoolSalto", true);
        }

    }
 
    void EnableDoubleJump()
        {
            canDoubleJump = true;
        }

        
 
    
    private void OnTriggerEnter2D(Collider2D other)
     {
        // -----------POINTS--------------

        if (other.gameObject.CompareTag("Star")) {
            Debug.Log("Punto");
           Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("StarDust")) {
           Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("StarRetro")) {
           Destroy(other.gameObject);
        }

        // -----------HAZARDS--------------

        if (other.gameObject.CompareTag("Can"))
        {
            Debug.Log("Casua daño! + 1 a Policia");
        }

        if (other.gameObject.CompareTag("Junk"))
        {
            Debug.Log("Casua daño! + 5 a Policia");
        }

        if (other.gameObject.CompareTag("TrafficLigth"))
        {
            Debug.Log("Casua daño! + 10 a Policia");
        }

        // -----------POLICE--------------

        if (other.gameObject.CompareTag("Hazard"))
        {
            HitCounter --;
            Debug.Log("Quedan " + HitCounter + " intentos antes de que Policia avance");
            Debug.Log("Se ha hecho daño!");
        }

        if (other.gameObject.CompareTag("Patrol"))
        {
            Debug.Log("Termina Juego");
            SceneManager.LoadScene(16);
        }

       
        }
    
        
        
        //add the movement force to the player
    private void FixedUpdate()
    {
        if (HitCounter == 0)
        {
            Debug.Log("La policia se mueve!");

            Patrol.SetActive(true);

            timeElapsed += Time.deltaTime;
            if (timeElapsed > delayBeforeLoading)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

}
