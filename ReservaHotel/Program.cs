using System;
using ReservaHotel.Entities;
using System.Globalization;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int room = int.Parse(Console.ReadLine());

            Console.Write("Check in date (dd/MM/yyyy):");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check out date (dd/MM/yyyy):");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(room, checkIn, checkOut);//recebe os parametros digitados pelo usuario e enviar para a 
            //variavel "reservation" onde os parametros serão alocados nos atributos e o metodo ToString é ativado
            Console.WriteLine("Reservation: "+ reservation); //Imprime o objeto reservation na tela

            //TRATAMENTOS DE ERROS if else

            //Update 
            Console.Write(" ");
            Console.Write("Enter data to update the reservation: ");

            Console.Write("Check in date (dd/MM/yyyy):");
            checkIn = DateTime.Parse(Console.ReadLine()); //variavel com o tipo ja declarado, apenas utilizar
            Console.Write("Check out date (dd/MM/yyyy):");
            checkOut = DateTime.Parse(Console.ReadLine()); //variavel com o tipo ja declarado, apenas utilizar

            //TRATAMENTOS DE ERROS if else


            //ATUALIZANDO A RESERVA
            reservation.UpdateDates(checkIn, checkOut);//chama o metodo UpdateDates
            Console.WriteLine("Reservation:  "+ reservation);


        }
    }
}
