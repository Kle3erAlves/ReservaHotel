using System;
using System.Collections.Generic;
using System.Text;

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
