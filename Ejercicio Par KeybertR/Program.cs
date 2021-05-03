//Ejercicio 3.1
//Nombre: Keybert Rivero
//CI: 28466582
//#Teleprgm2

using System;

namespace EmpleadosPrg2
{
   class Identificacion
    {
       //Declaracion datos de la Clase.
       private string Nombre;
       private string Apellido;
       private int Edad;
       private float Salario;
       private string Departamento;

        //Funciones de Acceso.
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        
        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        //Validacion que no permite que sea 0
        public float salario
        {
            get { return Salario; }
            set {

                if (value <= 0) {
                    Console.WriteLine("El Salario ingresado no puede ser 0");
                    Console.WriteLine("Intentar Nuevamente");
                    Salario = value;   
                }
            }
        }

        public string departamento
        {
            get { return Departamento; }
            set { Departamento = value; }
        }

        //Iniciamos la Subclase.
        class Empleados : Identificacion
        {
            private string envioMerc;
            private string recepcionMerc;
            private int CoCalidadMerc;
            private int InventarioMerc;

            public string EnvioMerc {

                get { return envioMerc; }
                set { envioMerc = value; }
            }

            public string RecepcionMerc
            {
                get { return recepcionMerc; }
                set { recepcionMerc = value; }
            }

            private int coCalidadMerc
            {
                get { return CoCalidadMerc;  }
                set { coCalidadMerc = value; }

            }

            public int inventarioMerc
            {
                get { return InventarioMerc; }
                set { InventarioMerc = value; }
            }
            //Ahora procedemos al Main.

            class InicioEmpleados
            {
                static void Main(string[] args) {

                    //Inicia la Instancia.

                    Empleados K = new Empleados(); 
                    Console.WriteLine("Bienvenidos a la aplicacion de control del");
                    Console.WriteLine("almacen hipertienda bqto......");
                    Console.WriteLine("Ingrese el nombre del empleado: "); 
                    K.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del empleado: ");
                    K.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del empleado: "); 
                    K.Edad = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el salario del empleado: "); 
                    K.Salario = System.Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("¿Podria indicar a que departamente pertenece?: "); 
                    K.Departamento = Console.ReadLine();
                    Console.WriteLine("¿Se realizo el envio del producto en Buen Estado? (si o no) ");
                    K.EnvioMerc = Console.ReadLine();
                    Console.WriteLine("¿Se recibio el producto en Buen Estado? (si o no)"); 
                    K.RecepcionMerc = Console.ReadLine();
                    Console.WriteLine("¿En una Escala del 1 al 10 como califica la calidad del producto?"); 
                    K.CoCalidadMerc = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad restante en almacen: "); 
                    K.InventarioMerc = System.Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Presione una tecla para Continuar....");
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("Los datos cargados al sistema son.....");
                    Console.WriteLine("Nombre: {0}", K.Nombre);
                    Console.WriteLine("Apellido: {0}",K.Apellido);
                    Console.WriteLine("Edad: {0}", K.Edad);
                    Console.WriteLine("Salario: {0}", K.Salario);
                    Console.WriteLine("Departamento: {0}", K.Departamento);
                    Console.WriteLine("¿Producto Enviado?: {0}", K.EnvioMerc);
                    Console.WriteLine("¿Productos Recibido?: {0}", K.RecepcionMerc);
                    Console.WriteLine("¿Calidad Final?: {0}", K.CoCalidadMerc);
                    Console.WriteLine("Cantidad en Inventario: {0}", K.InventarioMerc);
                    Console.WriteLine("Gracias por preferir nuestros Servicios *_* ");
                }
            }
        }
    }  
}