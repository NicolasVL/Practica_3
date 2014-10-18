using System;
using System.Collections;

namespace Practica3
{
	class Program
	{
		   public string nombre,codigo,IDX;
           public int opc;
		public static void Main(string[] args)
		{
        
          Program pra = new Program ();
          Hashtable tabla = new Hashtable ();

          do {
              Console.WriteLine("INGRESE CODIGO:");
              pra.codigo = Console.ReadLine();
              Console.WriteLine("INGRESE NOMBRE:");
              pra.nombre = Console.ReadLine();
              tabla.Add(pra.codigo,pra.nombre);

              Console.WriteLine("1 PARA INGRESAR MAS VALORES:");
              Console.WriteLine("2 PARA EDITAR VALORES:");
              Console.WriteLine("3 PARA VER VALORES:");
              Console.WriteLine("4 PARA BORRAR VALORES:");
              Console.WriteLine("5 PARA SALIR:");
              pra.opc =int.Parse (Console.ReadLine());
                       switch(pra.opc)
                       {
                        case 1:
                         break;
                        case 2:
                               Console.WriteLine("INGRESE CODIGO A EDITAR:");
                               pra.IDX=Console.ReadLine();
                               tabla.Remove(pra.IDX);

                               Console.WriteLine("INGRESE NUEVO CODIGO:");
                               pra.codigo = Console.ReadLine();
                               Console.WriteLine("INGRESE NOMBRE:");
                               pra.nombre = Console.ReadLine();
                               tabla.Add(pra.codigo,pra.nombre);

                         break;
                         case 3:

                                Console.WriteLine("INGRESE CODIGO:");
                                pra.IDX=Console.ReadLine();
                                object valor = tabla [pra.IDX];
                                Console.WriteLine ("EL NOMBRE ES : "+valor);


                          break;
                          case 4:
                                 Console.WriteLine("INGRESE CODIGO A REMOVER:");
                                 pra.IDX=Console.ReadLine();
                                 tabla.Remove(pra.IDX);


                                 break;}
          }while(pra.opc!=5);
          
          
          }
		}
	}

