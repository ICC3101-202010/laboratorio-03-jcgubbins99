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
            Console.WriteLine("3.-Modificar rol del personal");
            Console.WriteLine("4.-Modificar sueldo personal");
            Console.WriteLine("5.-Modificar horario personal");
            Console.WriteLine("6.-Agregar productos");
            Console.WriteLine("7.-Ver lista productos tienda");
            Console.WriteLine("8.-Comprar productos");
            Console.WriteLine("9.-Ver historial de boletas");
            Console.WriteLine("10.-Salir del programa");

            string accion = null;
            while (accion != "10")
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
                                    Console.WriteLine("a.-Ver información de los empleados");
                                    Console.WriteLine("b.-Ver información de los jefes");
                                    Console.WriteLine("c.-Ver información de los supervisores ");
                                    Console.WriteLine("d.-Ver información de los auxiliares");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "b":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Jefes:");
                                    Console.WriteLine("=====================");
                                    super.VerJefes(super.listajefes);
                                    Console.WriteLine("a.-Ver información de los empleados");
                                    Console.WriteLine("b.-Ver información de los jefes");
                                    Console.WriteLine("c.-Ver información de los supervisores ");
                                    Console.WriteLine("d.-Ver información de los auxiliares");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "c":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Supervisores:");
                                    Console.WriteLine("=====================");
                                    super.VerSupervisores(super.listasupervisores);
                                    Console.WriteLine("a.-Ver información de los empleados");
                                    Console.WriteLine("b.-Ver información de los jefes");
                                    Console.WriteLine("c.-Ver información de los supervisores ");
                                    Console.WriteLine("d.-Ver información de los auxiliares");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "d":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Auxiliares:");
                                    Console.WriteLine("=====================");
                                    super.VerAuxiliares(super.listauxiliares);
                                    Console.WriteLine("a.-Ver información de los empleados");
                                    Console.WriteLine("b.-Ver información de los jefes");
                                    Console.WriteLine("c.-Ver información de los supervisores ");
                                    Console.WriteLine("d.-Ver información de los auxiliares");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "e":
                                    Console.WriteLine("=====================================");
                                    Console.WriteLine("Has salido de información de personal");
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar personal y clientes");
                                    Console.WriteLine("3.-Modificar rol del personal");
                                    Console.WriteLine("4.-Modificar sueldo personal");
                                    Console.WriteLine("5.-Modificar horario personal");
                                    Console.WriteLine("6.-Agregar productos");
                                    Console.WriteLine("7.-Ver lista productos tienda");
                                    Console.WriteLine("8.-Agregar productos al carro");
                                    Console.WriteLine("9.-Ver historial de boletas");
                                    Console.WriteLine("10.-Salir del programa");


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
                                    Console.WriteLine("a.-Agregar cliente");
                                    Console.WriteLine("b.-Agregar empleado");
                                    Console.WriteLine("c.-Agregar jefe");
                                    Console.WriteLine("d.-Agregar supervisor");
                                    Console.WriteLine("e.-Agregar auxiliar");
                                    Console.WriteLine("f.-Salir de esta opción");
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
                                    Console.WriteLine("a.-Agregar cliente");
                                    Console.WriteLine("b.-Agregar empleado");
                                    Console.WriteLine("c.-Agregar jefe");
                                    Console.WriteLine("d.-Agregar supervisor");
                                    Console.WriteLine("e.-Agregar auxiliar");
                                    Console.WriteLine("f.-Salir de esta opción");
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
                                    Console.WriteLine("a.-Agregar cliente");
                                    Console.WriteLine("b.-Agregar empleado");
                                    Console.WriteLine("c.-Agregar jefe");
                                    Console.WriteLine("d.-Agregar supervisor");
                                    Console.WriteLine("e.-Agregar auxiliar");
                                    Console.WriteLine("f.-Salir de esta opción");
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
                                    Console.WriteLine("a.-Agregar cliente");
                                    Console.WriteLine("b.-Agregar empleado");
                                    Console.WriteLine("c.-Agregar jefe");
                                    Console.WriteLine("d.-Agregar supervisor");
                                    Console.WriteLine("e.-Agregar auxiliar");
                                    Console.WriteLine("f.-Salir de esta opción");
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
                                    Console.WriteLine("a.-Agregar cliente");
                                    Console.WriteLine("b.-Agregar empleado");
                                    Console.WriteLine("c.-Agregar jefe");
                                    Console.WriteLine("d.-Agregar supervisor");
                                    Console.WriteLine("e.-Agregar auxiliar");
                                    Console.WriteLine("f.-Salir de esta opción");
                                    break;
                                case "f":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de agregar personal y clientes");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar personal y clientes");
                                    Console.WriteLine("3.-Modificar rol del personal");
                                    Console.WriteLine("4.-Modificar sueldo personal");
                                    Console.WriteLine("5.-Modificar horario personal");
                                    Console.WriteLine("6.-Agregar productos");
                                    Console.WriteLine("7.-Ver lista productos tienda");
                                    Console.WriteLine("8.-Agregar productos al carro");
                                    Console.WriteLine("9.-Ver historial de boletas");
                                    Console.WriteLine("10.-Salir del programa");
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;
                            }
                       
                        }
                        break;
                    case "3":
                        Console.WriteLine("A quien deseas cambiar de rol");
                        Console.WriteLine("a.- De empelado a jefe");
                        Console.WriteLine("b.- De empleado a supervisor");
                        Console.WriteLine("c.- De empleado a auxiliar");
                        Console.WriteLine("d.- De jefe a empleado");
                        Console.WriteLine("e.- De jefe a supervisor");
                        Console.WriteLine("f.- De jefe a auxiliar");
                        Console.WriteLine("g.- De supervisor a empleado");
                        Console.WriteLine("h.- De supervisor a jefe");
                        Console.WriteLine("i.- De supervisor a auxiliar");
                        Console.WriteLine("j.- De auxiliar a empleado");
                        Console.WriteLine("k.- De auxiliar a jefe");
                        Console.WriteLine("l.- De auxiliar a supervisor");
                        Console.WriteLine("m.-Salir de esta opción");
                        string opcion3 = null;
                        while (opcion3 != "m")
                        {
                            opcion3 = Console.ReadLine();
                            switch (opcion3)
                            {
                                case "a":
                                    string rut_ = "";
                                    Console.WriteLine("ingrese el rut de el empleado que desea ascender a jefe");
                                    rut_ = Console.ReadLine();
                                    super.EmpleadoaJefe(rut_);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "b":
                                    string rut_2 = "";
                                    Console.WriteLine("ingrese el rut de el empleado que desea ascender a supervisor");
                                    rut_2 = Console.ReadLine();
                                    super.EmpleadoaSuperivsor(rut_2);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "c":
                                    string rut_3 = "";
                                    Console.WriteLine("ingrese el rut de el empleado que desea cambiar a auxiliar");
                                    rut_3 = Console.ReadLine();
                                    super.EmpleadoaAuxiliar (rut_3);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "d":
                                    string rut_4 = "";
                                    Console.WriteLine("ingrese el rut de el jefe que desea descender a empleado");
                                    rut_4 = Console.ReadLine();
                                    super.JefeaEmpleado(rut_4);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "e":
                                    string rut_5 = "";
                                    Console.WriteLine("ingrese el rut de el jefe que desea cambiar a supervisor");
                                    rut_5 = Console.ReadLine();
                                    super.JefeaSupervisor(rut_5);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "f":
                                    string rut_6 = "";
                                    Console.WriteLine("ingrese el rut de el jefe que desea descender a auxiliar");
                                    rut_6 = Console.ReadLine();
                                    super.JefeaAuxiliar(rut_6);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "g":
                                    string rut_7 = "";
                                    Console.WriteLine("ingrese el rut de el supervisor que desea descender a empleado");
                                    rut_7 = Console.ReadLine();
                                    super.SupervisoraEmpleado(rut_7);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "h":
                                    string rut_8 = "";
                                    Console.WriteLine("ingrese el rut de el supervisor que desea cambiar a jefe");
                                    rut_8 = Console.ReadLine();
                                    super.SupervisoraJefe(rut_8);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "i":
                                    string rut_9 = "";
                                    Console.WriteLine("ingrese el rut de el supervisor que desea descender a auxiliar");
                                    rut_9 = Console.ReadLine();
                                    super.SupervisoraAuxiliar(rut_9);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "j":
                                    string rut_10 = "";
                                    Console.WriteLine("ingrese el rut de el auxiliar que desea cambiar a empleado");
                                    rut_10 = Console.ReadLine();
                                    super.AuxiliaraEmpleado(rut_10);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "k":
                                    string rut_11 = "";
                                    Console.WriteLine("ingrese el rut de el auxiliar que desea ascender a jefe");
                                    rut_11 = Console.ReadLine();
                                    super.AuxiliaraJefe(rut_11);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "l":
                                    string rut_12 = "";
                                    Console.WriteLine("ingrese el rut de el auxiliar que desea ascender a supervispr");
                                    rut_12 = Console.ReadLine();
                                    super.AuxiliaraSupervisor(rut_12);
                                    Console.WriteLine("A quien deseas cambiar de rol");
                                    Console.WriteLine("a.- De empelado a jefe");
                                    Console.WriteLine("b.- De empleado a supervisor");
                                    Console.WriteLine("c.- De empleado a auxiliar");
                                    Console.WriteLine("d.- De jefe a empleado");
                                    Console.WriteLine("e.- De jefe a supervisor");
                                    Console.WriteLine("f.- De jefe a auxiliar");
                                    Console.WriteLine("g.- De supervisor a empleado");
                                    Console.WriteLine("h.- De supervisor a jefe");
                                    Console.WriteLine("i.- De supervisor a auxiliar");
                                    Console.WriteLine("j.- De auxiliar a empleado");
                                    Console.WriteLine("k.- De auxiliar a jefe");
                                    Console.WriteLine("l.- De auxiliar a supervisor");
                                    Console.WriteLine("m.-Salir de esta opción");
                                    break;
                                case "m":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de la opción mover de rol");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar personal y clientes");
                                    Console.WriteLine("3.-Modificar rol del personal");
                                    Console.WriteLine("4.-Modificar sueldo personal");
                                    Console.WriteLine("5.-Modificar horario personal");
                                    Console.WriteLine("6.-Agregar productos");
                                    Console.WriteLine("7.-Ver lista productos tienda");
                                    Console.WriteLine("8.-Agregar productos al carro");
                                    Console.WriteLine("9.-Ver historial de boletas");
                                    Console.WriteLine("10.-Salir del programa");
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;

                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("a.-Modificar sueldo empleado");
                        Console.WriteLine("b.-Modificar sueldo jefe");
                        Console.WriteLine("c.-Modificar sueldo supervisor");
                        Console.WriteLine("d.-Modificar sueldo auxiliar");
                        Console.WriteLine("e.-Salir de esta opción");
                        string opcion4 = null;
                        while (opcion4 != "e")
                        {
                            opcion4 = Console.ReadLine();
                            switch (opcion4)
                            {
                                case "a":
                                    string r = "";
                                    int s = 0;
                                    Console.WriteLine("ingrese el rut del empleado al que desea cambiarle el sueldo");
                                    r = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo sueldo para este empleado");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    super.SueldoEmpleado(r, s);
                                    Console.WriteLine("a.-Modificar sueldo empleado");
                                    Console.WriteLine("b.-Modificar sueldo jefe");
                                    Console.WriteLine("c.-Modificar sueldo supervisor");
                                    Console.WriteLine("d.-Modificar sueldo auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "b":
                                    string r1 = "";
                                    int s1 = 0;
                                    Console.WriteLine("ingrese el rut del jefe al que desea cambiarle el sueldo");
                                    r1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo sueldo para este jefe");
                                    s1 = Convert.ToInt32(Console.ReadLine());
                                    super.SueldoJefe(r1, s1);
                                    Console.WriteLine("a.-Modificar sueldo empleado");
                                    Console.WriteLine("b.-Modificar sueldo jefe");
                                    Console.WriteLine("c.-Modificar sueldo supervisor");
                                    Console.WriteLine("d.-Modificar sueldo auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "c":
                                    string r2 = "";
                                    int s2 = 0;
                                    Console.WriteLine("ingrese el rut del supervisor al que desea cambiarle el sueldo");
                                    r2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo sueldo para este supervisor");
                                    s2 = Convert.ToInt32(Console.ReadLine());
                                    super.SueldoSupervisor(r2, s2);
                                    Console.WriteLine("a.-Modificar sueldo empleado");
                                    Console.WriteLine("b.-Modificar sueldo jefe");
                                    Console.WriteLine("c.-Modificar sueldo supervisor");
                                    Console.WriteLine("d.-Modificar sueldo auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "d":
                                    string r3 = "";
                                    int s3 = 0;
                                    Console.WriteLine("ingrese el rut del auxiliar al que desea cambiarle el sueldo");
                                    r3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo sueldo para este auxiliar");
                                    s3 = Convert.ToInt32(Console.ReadLine());
                                    super.SueldoAuxiliar(r3, s3);
                                    Console.WriteLine("a.-Modificar sueldo empleado");
                                    Console.WriteLine("b.-Modificar sueldo jefe");
                                    Console.WriteLine("c.-Modificar sueldo supervisor");
                                    Console.WriteLine("d.-Modificar sueldo auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "e":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de la opción cambiar sueldo");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar personal y clientes");
                                    Console.WriteLine("3.-Modificar rol del personal");
                                    Console.WriteLine("4.-Modificar sueldo personal");
                                    Console.WriteLine("5.-Modificar horario personal");
                                    Console.WriteLine("6.-Agregar productos");
                                    Console.WriteLine("7.-Ver lista productos tienda");
                                    Console.WriteLine("8.-Agregar productos al carro");
                                    Console.WriteLine("9.-Ver historial de boletas");
                                    Console.WriteLine("10.-Salir del programa");
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;



                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("a.-Modificar horario empleado");
                        Console.WriteLine("b.-Modificar horario jefe");
                        Console.WriteLine("c.-Modificar horario supervisor");
                        Console.WriteLine("d.-Modificar horario auxiliar");
                        Console.WriteLine("e.-Salir de esta opción");
                        string opcion5 = null;
                        while (opcion5 != "e")
                        {
                            opcion5 = Console.ReadLine();
                            switch (opcion5)
                            {
                                case "a":
                                    string rutu = "";
                                    string horari = "";
                                    Console.WriteLine("ingrese el rut del empleado al que desea cambiarle el horario");
                                    rutu = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo horario para este empleado");
                                    horari = Console.ReadLine();
                                    super.HorarioEmpleado(rutu, horari);
                                    Console.WriteLine("a.-Modificar horario empleado");
                                    Console.WriteLine("b.-Modificar horario jefe");
                                    Console.WriteLine("c.-Modificar horario supervisor");
                                    Console.WriteLine("d.-Modificar horario auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "b":
                                    string rutu1 = "";
                                    string horari1 = "";
                                    Console.WriteLine("ingrese el rut del jefe al que desea cambiarle el horario");
                                    rutu1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo horario para este jefe");
                                    horari1 = Console.ReadLine();
                                    super.HorarioJefe(rutu1, horari1);
                                    Console.WriteLine("a.-Modificar horario empleado");
                                    Console.WriteLine("b.-Modificar horario jefe");
                                    Console.WriteLine("c.-Modificar horario supervisor");
                                    Console.WriteLine("d.-Modificar horario auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "c":
                                    string rutu2 = "";
                                    string horari2 = "";
                                    Console.WriteLine("ingrese el rut del supervisor al que desea cambiarle el horario");
                                    rutu2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo horario para este supervisor");
                                    horari2 = Console.ReadLine();
                                    super.HorarioSupervisor(rutu2, horari2);
                                    Console.WriteLine("a.-Modificar horario empleado");
                                    Console.WriteLine("b.-Modificar horario jefe");
                                    Console.WriteLine("c.-Modificar horario supervisor");
                                    Console.WriteLine("d.-Modificar horario auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "d":
                                    string rutu3 = "";
                                    string horari3 = "";
                                    Console.WriteLine("ingrese el rut del auxiliar al que desea cambiarle el horario");
                                    rutu3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo horario para este auxiliar");
                                    horari3 = Console.ReadLine();
                                    super.HorarioAuxiliar(rutu3, horari3);
                                    Console.WriteLine("a.-Modificar horario empleado");
                                    Console.WriteLine("b.-Modificar horario jefe");
                                    Console.WriteLine("c.-Modificar horario supervisor");
                                    Console.WriteLine("d.-Modificar horario auxiliar");
                                    Console.WriteLine("e.-Salir de esta opción");
                                    break;
                                case "e":
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("Has salido de la opción cambiar horario");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("1.-Ver información del personal");
                                    Console.WriteLine("2.-Agregar personal y clientes");
                                    Console.WriteLine("3.-Modificar rol del personal");
                                    Console.WriteLine("4.-Modificar sueldo personal");
                                    Console.WriteLine("5.-Modificar horario personal");
                                    Console.WriteLine("6.-Agregar productos");
                                    Console.WriteLine("7.-Ver lista productos tienda");
                                    Console.WriteLine("8.-Agregar productos al carro");
                                    Console.WriteLine("9.-Ver historial de boletas");
                                    Console.WriteLine("10.-Salir del programa");
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;


                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Agregar producto:");
                        Console.WriteLine("=====================");
                        string nombreproducto = "";
                        string precio = "";
                        string marca = "";
                        int stock = 0;
                        
                        Console.WriteLine("Ingrese nombre porducto");
                        nombreproducto = Console.ReadLine();
                        Console.WriteLine("Ingrese marca del producto");
                        marca = Console.ReadLine();
                        Console.WriteLine("Ingrese precio del producto");
                        precio = Console.ReadLine();
                        Console.WriteLine("Ingrese stock del producto");
                        stock = Convert.ToInt32(Console.ReadLine());

                        Producto p1 = new Producto(nombreproducto, precio, marca, stock);
                        super.AgregarProducto(p1);
                        Console.WriteLine("                              ");
                        Console.WriteLine("                              ");
                        Console.WriteLine("1.-Ver información del personal");
                        Console.WriteLine("2.-Agregar personal y clientes");
                        Console.WriteLine("3.-Modificar rol del personal");
                        Console.WriteLine("4.-Modificar sueldo personal");
                        Console.WriteLine("5.-Modificar horario personal");
                        Console.WriteLine("6.-Agregar productos");
                        Console.WriteLine("7.-Ver lista productos tienda");
                        Console.WriteLine("8.-Comprar productos");
                        Console.WriteLine("9.-Ver historial de boletas");
                        Console.WriteLine("10.-Salir del programa");
                        break;
                    case "7":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Productos:");
                        Console.WriteLine("=====================");
                        super.VerProductos(super.listaproductos);
                        Console.WriteLine("                              ");
                        Console.WriteLine("                              ");
                        Console.WriteLine("1.-Ver información del personal");
                        Console.WriteLine("2.-Agregar personal y clientes");
                        Console.WriteLine("3.-Modificar rol del personal");
                        Console.WriteLine("4.-Modificar sueldo personal");
                        Console.WriteLine("5.-Modificar horario personal");
                        Console.WriteLine("6.-Agregar productos");
                        Console.WriteLine("7.-Ver lista productos tienda");
                        Console.WriteLine("8.-Comprar productos");
                        Console.WriteLine("9.-Ver historial de boletas");
                        Console.WriteLine("10.-Salir del programa");
                        break;

                    case "8":
                        string respuesta = "";
                        while (respuesta != "no")
                        {
                            
                            Console.WriteLine("¿Desea agregar un producto al carro?");
                            respuesta = Console.ReadLine();
                            if (respuesta == "si")
                            {
                                string nombreproduc = "";
                                string marcapro = "";
                                Console.WriteLine("Ingrese el nombre de el producto que desea comprar");
                                nombreproduc = Console.ReadLine();
                                Console.WriteLine("Ingrese la marca de el producto que desea comprar");
                                marcapro = Console.ReadLine();


                                super.RealizarunaCompra(nombreproduc, marcapro);

                            }


                        }
                        string rutcliente = "";
                        Console.WriteLine("Ingrese el rut del cliente al cual le quiere atribuir esta compra");
                        rutcliente = Console.ReadLine();
                        super.ArmaBoletas(rutcliente);
                        Console.WriteLine("                              ");
                        Console.WriteLine("                              ");
                        Console.WriteLine("1.-Ver información del personal");
                        Console.WriteLine("2.-Agregar personal y clientes");
                        Console.WriteLine("3.-Modificar rol del personal");
                        Console.WriteLine("4.-Modificar sueldo personal");
                        Console.WriteLine("5.-Modificar horario personal");
                        Console.WriteLine("6.-Agregar productos");
                        Console.WriteLine("7.-Ver lista productos tienda");
                        Console.WriteLine("8.-Comprar productos");
                        Console.WriteLine("9.-Ver historial de boletas");
                        Console.WriteLine("10.-Salir del programa");
                        break;
                    case "9":
                        Console.WriteLine("===============================================================================");
                        Console.WriteLine("Estas son las boletas que tienes hasta el momento");
                        Console.WriteLine("===============================================================================");
                        super.Verboletas();
                        Console.WriteLine("                              ");
                        Console.WriteLine("                              ");
                        Console.WriteLine("1.-Ver información del personal");
                        Console.WriteLine("2.-Agregar personal y clientes");
                        Console.WriteLine("3.-Modificar rol del personal");
                        Console.WriteLine("4.-Modificar sueldo personal");
                        Console.WriteLine("5.-Modificar horario personal");
                        Console.WriteLine("6.-Agregar productos");
                        Console.WriteLine("7.-Ver lista productos tienda");
                        Console.WriteLine("8.-Comprar productos");
                        Console.WriteLine("9.-Ver historial de boletas");
                        Console.WriteLine("10.-Salir del programa");
                        break;
                    case "10":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Has salido del programa");
                        Console.WriteLine("=====================");

                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción válida");
                        break;





                }
            }
        }
    }
}
