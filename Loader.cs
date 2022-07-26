using BepInEx;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ExampleAssembly
{
    [BepInPlugin("Tabg Cheat", "Foxyy#6696", "1.0.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        [DllImport("kernel32")]
        static extern bool AllocConsole(int pid);
        static UnityEngine.GameObject gameObject;


        public void Awake()
        {

            AllocConsole(-1);
            var stdout = Console.OpenStandardOutput();
            var sw = new System.IO.StreamWriter(stdout, Encoding.Default);
            sw.AutoFlush = true;
            Console.SetOut(sw);
            Console.SetError(sw);

            gameObject = new UnityEngine.GameObject();
            gameObject.AddComponent<Cheat>();
            gameObject.AddComponent<ESP>();
            UnityEngine.Object.DontDestroyOnLoad(gameObject);

        }
        public void Start()
        {

        }
        public void Update()
        {

        }
        public void FixedUpdate()
        {

        }
        public void LateUpdate()
        {

        }
        public void OnGUI()
        {
  
        }
        public void OnDisable()
        {

        }
        public void OnEnable()
        {

        }


    }
}
