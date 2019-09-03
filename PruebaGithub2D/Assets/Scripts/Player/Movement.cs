using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Personal2D.Move
{
    public class Movement : MonoBehaviour
    {
        public float speed;
        public float jumpForce;
        float counter;
        Rigidbody2D rigid;
        public float ratio;
        public LayerMask tipoPiso;
        protected bool inGround;
        public Transform feet;
        protected bool isJumping;
        public float jumpTime;
        public float aceleration;
        private float axisX;
        Animator animator;
        //public Slider health;
        //public Slider stamina;

        AudioSource source;
        AudioClip[] clips;
        // Start is called before the first frame update
        void Awake()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
            source = GetComponent<AudioSource>();
            rigid = GetComponent<Rigidbody2D>();
            clips = GetComponent<ListaSonidos>().clips;
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //Define el valor necesario para ejecutar la animación del sprint al moverse
            animator.SetFloat("Speed", Mathf.Abs(axisX));

            //El movimiento en si (Se utiliza axis)
            axisX = Input.GetAxis("Horizontal");
            float axisY = Input.GetAxis("Vertical");
            Vector2 move = new Vector2(axisX, axisY);
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                
                animator.speed=2f;
                rigid.velocity = new Vector2(axisX * (speed + aceleration), rigid.velocity.y);
            }
            else
            {
                
                animator.speed=1f;
                rigid.velocity = new Vector2(axisX * speed, rigid.velocity.y);
            }

            //rigid.velocity = new Vector2(axisX*speed,rigid.velocity.y);



        }

        void Update()
        {
            //La detección del piso para ver si se puede saltar o no ,
            inGround = Physics2D.OverlapCircle(feet.position, ratio, tipoPiso);
            if (axisX > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (axisX < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }

            if (inGround && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                source.clip = clips[0];
                source.Play();
                counter = jumpTime;
                isJumping = true;
                rigid.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                //rigid.velocity = Vector2.up * jumpForce;
            }
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) && isJumping)
            {

                if (counter > 0)
                {
                    rigid.velocity = Vector2.up * jumpForce;
                    counter -= Time.deltaTime;

                }
                else
                {
                    isJumping = false;
                }
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Space))
            {
                isJumping = false;
            }

            if (!inGround)
            {
                animator.SetBool("IsJumping", true);
                if (rigid.velocity.y > 0)
                {
                    animator.Play("Jump", 0, 0);
                }
                else
                {
                    animator.Play("Jump", 0, 0.5f);
                }

            }
            else
            {
                animator.SetBool("IsJumping", false);
            }
        }

        public bool DetectarPiso(){
            return Physics2D.OverlapCircle(feet.position, ratio, tipoPiso);
        }
    }

}
