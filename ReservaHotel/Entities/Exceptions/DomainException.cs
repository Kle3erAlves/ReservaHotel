using System;


namespace ReservaHotel.Entities.Exceptions
{   //CLASSE DA NOSSA EXCEÇÃO PERSONALIZADA
    class DomainException : ApplicationException
    {
        //CONSTRUTOR RECEBENDO UMA "STRING MESSAGE", APENAS REPASSA A MENSAGEM PARA O CONSTRUTOR DA CLASSE APLICATION EXCEPTION
        public DomainException(string message) : base(message)
        {

        }
    }
}
