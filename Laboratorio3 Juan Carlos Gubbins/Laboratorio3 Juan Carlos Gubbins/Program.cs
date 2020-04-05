using System;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Program
    {
        static void Main()
        {
            Supermercado super = new Supermercado();


            Console.WriteLine("Bienvenido al UandesMarket ¿Que deseas hacer? ");
            Console.WriteLine("1.-Ver información del personal");
            Console.WriteLine("2.-Agregar personal y clientes");
            Console.WriteLine("3.-Ver canciones por criterio");
            Console.WriteLine("4.-Crear Playlist");
            Console.WriteLine("5.-Ver Playlists");
            Console.WriteLine("6.-Salir del programa");

            string accion = null;
            while (accion != "6")
            {

                accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Console.WriteLine("a.-Ver información de los empleados");
                        Console.WriteLine("b.-Ver información de los jefes");
                        Console.WriteLine("c.-Ver información de los supervisores ");
                        Console.WriteLine("d.-Ver información de los auxiliares");
                        Console.WriteLine("e.-Salir de esta opción");
                        string opcion = null;
                        while (opcion != "e")
                        {
                            opcion = Console.ReadLine();
                            switch (opcion)
                            {
                                case "a":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Empleados:");
                                    Console.WriteLine("=====================");
                                    super.VerEmpleados(super.listaempleados);
                                    break;
                                case "b":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Jefes:");
                                    Console.WriteLine("=====================");
                                    super.VerJefes(super.listajefes);
                                    break;
                                case "c":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Supervisores:");
                                    Console.WriteLine("=====================");
                                    super.VerSupervisores(super.listasupervisores);
                                    break;
                                case "d":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Auxiliares:");
                                    Console.WriteLine("=====================");
                                    super.VerAuxiliares(super.listauxiliares);
                                    break;
                                case "e":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de información de personal");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar una canción");
                                    Console.WriteLine("3.-Ver canciones por criterio");
                                    Console.WriteLine("4.-Crear Playlist");
                                    Console.WriteLine("5.-Ver Playlists");
                                    Console.WriteLine("6.-Salir del programa");


                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;

                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("a.-Agregar cliente");
                        Console.WriteLine("b.-Agregar empleado");
                        Console.WriteLine("c.-Agregar jefe");
                        Console.WriteLine("d.-Agregar supervisor");
                        Console.WriteLine("e.-Agregar auxiliar");
                        Console.WriteLine("f.-Salir de esta opción");
                        string opcion2 = null;
                        while (opcion2 != "f")
                        {
                            opcion2 = Console.ReadLine();
                            switch (opcion2)
                            {
                                case "a":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Agregar cliente:");
                                    Console.WriteLine("=====================");
                                    string rut = "";
                                    string nombre = "";
                                    string apellido = "";
                                    string nacimiento = "";
                                    string nacionalidad = "";
                                    Console.WriteLine("Ingrese rut del cliente");
                                    rut = Console.ReadLine();
                                    Console.WriteLine("Ingrese nombre del cliente");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellido del cliente");
                                    apellido = Console.ReadLine();
                                    Console.WriteLine("Ingrese fecha de nacimiento del cliente: (DD/MM/AA)");
                                    nacimiento = Console.ReadLine();
                                    Console.WriteLine("Ingrese nacionalidad del cliente");
                                    nacionalidad = Console.ReadLine();
                                    Client c1 = new Client(rut, nombre, apellido, nacimiento, nacionalidad);
                                    super.AgregarCliente(c1);
                                    break;
                                case "b":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Agregar empleado:");
                                    Console.WriteLine("=====================");
                                    string rut2 = "";
                                    string nombre2 = "";
                                    string apellido2 = "";
                                    string nacimiento2 = "";
                                    string nacionalidad2 = "";
                                    int sueldo = 0;
                                    string horario = "";
                                    Console.WriteLine("Ingrese rut del empleado");
                                    rut2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nombre del empleado");
                                    nombre2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellido del empleado");
                                    apellido2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese fecha de nacimiento del empleado: (DD/MM/AA)");
                                    nacimiento2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nacionalidad del empleado");
                                    nacionalidad2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese sueldo de el empleado (Agregar numero sin comas ni puntos)");
                                    sueldo = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese horario de trabajo de el empleado");
                                    horario = Console.ReadLine();

                                    Employees e1 = new Employees(rut2, nombre2, apellido2, nacimiento2, nacionalidad2,sueldo,horario);
                                    super.AgregarEmpleado(e1);
                                    break;
                                case "c":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Agregar jefe:");
                                    Console.WriteLine("=====================");
                                    string rut3 = "";
                                    string nombre3 = "";
                                    string apellido3 = "";
                                    string nacimiento3 = "";
                                    string nacionalidad3 = "";
                                    int sueldo1 = 0;
                                    string horario1 = "";
                                    Console.WriteLine("Ingrese rut del jefe");
                                    rut3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nombre del jefe");
                                    nombre3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellido del jefe");
                                    apellido3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese fecha de nacimiento del jefe: (DD/MM/AA)");
                                    nacimiento3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nacionalidad del jefe");
                                    nacionalidad3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese sueldo de el jefe (Ingresar numero sin puntos ni comas");
                                    sueldo1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese horario de trabajo de el jefe");
                                    horario1 = Console.ReadLine();

                                    Bosses b1 = new Bosses(rut3, nombre3, apellido3, nacimiento3, nacionalidad3, sueldo1, horario1);
                                    super.AgregarJefe(b1);
                                    break;
                                case "d":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Agregar supervisor:");
                                    Console.WriteLine("=====================");
                                    string rut4 = "";
                                    string nombre4 = "";
                                    string apellido4 = "";
                                    string nacimiento4 = "";
                                    string nacionalidad4 = "";
                                    int sueldo2 = 0;
                                    string horario2 = "";
                                    Console.WriteLine("Ingrese rut del supervisor");
                                    rut4 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nombre del supervisor");
                                    nombre4 = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellido del supervisor");
                                    apellido4 = Console.ReadLine();
                                    Console.WriteLine("Ingrese fecha de nacimiento del supervisor: (DD/MM/AA)");
                                    nacimiento4 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nacionalidad del supervisor");
                                    nacionalidad4 = Console.ReadLine();
                                    Console.WriteLine("Ingrese sueldo de el supervisor (Ingresar numero sin puntos ni comas");
                                    sueldo2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese horario de trabajo de el supervisor");
                                    horario2 = Console.ReadLine();

                                    Supervisors s1 = new Supervisors(rut4, nombre4, apellido4, nacimiento4, nacionalidad4, sueldo2, horario2);
                                    super.AgregarSupervisor(s1);
                                    break;
                                case "e":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Agregar Auxiliar:");
                                    Console.WriteLine("=====================");
                                    string rut5 = "";
                                    string nombre5 = "";
                                    string apellido5 = "";
                                    string nacimiento5 = "";
                                    string nacionalidad5 = "";
                                    int sueldo3 = 0;
                                    string horario3 = "";
                                    Console.WriteLine("Ingrese rut del auxiliar");
                                    rut5 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nombre del auxiliar");
                                    nombre5 = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellido del auxiliar");
                                    apellido5 = Console.ReadLine();
                                    Console.WriteLine("Ingrese fecha de nacimiento del auxiliar: (DD/MM/AA)");
                                    nacimiento5 = Console.ReadLine();
                                    Console.WriteLine("Ingrese nacionalidad del auxiliar");
                                    nacionalidad5 = Console.ReadLine();
                                    Console.WriteLine("Ingrese sueldo de el auxiliar (Ingresar numero sin puntos ni comas");
                                    sueldo3 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese horario de trabajo de el auxiliar");
                                    horario3 = Console.ReadLine();

                                    Auxiliaries a1 = new Auxiliaries(rut5, nombre5, apellido5, nacimiento5, nacionalidad5, sueldo3, horario3);
                                    super.AgregarAuxiliar(a1);
                                    break;
                                case "f":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de agregar personal y clientes");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar una canción");
                                    Console.WriteLine("3.-Ver canciones por criterio");
                                    Console.WriteLine("4.-Crear Playlist");
                                    Console.WriteLine("5.-Ver Playlists");
                                    Console.WriteLine("6.-Salir del programa");
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;
                            }
                       
                        }
                        break;
                }
            }
        }
    }
}
