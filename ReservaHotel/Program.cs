using System;
using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check in date (dd/MM/yyyy):");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(room, checkIn, checkOut);//recebe os parametros digitados pelo usuario e enviar para a 
                                                                                   //variavel "reservation" onde os parametros serão alocados nos atributos e o metodo ToString é ativado
                Console.WriteLine("Reservation: " + reservation); //Imprime o objeto reservation na tela

                //Update 
                Console.Write(" ");
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine()); //variavel com o tipo ja declarado, apenas utilizar
                Console.Write("Check out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine()); //variavel com o tipo ja declarado, apenas utilizar

                //ATUALIZANDO A RESERVA
                reservation.UpdateDates(checkIn, checkOut);//chama o metodo UpdateDates
                Console.WriteLine("Reservation:  " + reservation);//Imprime o objeto reservation na tela
            }
            //Captura
            catch (DomainException e) //SE ALGUM ERRO FOR LANÇADO O "CATCH" CAPTURA ESSES ERROS E EXIBI A MENDAGEM ABAIXO
            {
                Console.WriteLine("Error in reservation: " + e.Message);//EXIBE A MENSAGEM DE ERRO
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
