using System;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel.Entities
{
    class Reservation
    {   //SUPERCLASSE
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        //CONSTRUTORES
        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //TRATAMENTO DE EXCEÇÃO TAMBEM PODE SER FEITO NO CONSTRUTOR, QUANDO RECEBER OS PARAMETROS

            if (checkOut <= checkIn)
            { //lançar
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //METODOS DURACAO
        public int Duration()
        {
           TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        //METODO UPDATE -ATUALIZA O OBJETO
        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            //TRATAMENTO DE EXCESSAO, RESPONSABILIDADE DA VERIFICAÇÃO É DO METODO UPDATADATES
            DateTime now = DateTime.Now; //Necessário instanciar todo objeto que sera utilizado, mesmo os do sistema .Net
            if (checkIn < now || checkOut < now)
            { //lançar
                throw new DomainException("Reservation dates for updates must be future dates");
            }

            else if (checkOut <= checkIn)
            { //lançar
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //METODO TO STRING PARA IMPRIMIR O OBJETO NA TELA
        public override string ToString()
        {
            return "Room  "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights ";
        }
    }
}
