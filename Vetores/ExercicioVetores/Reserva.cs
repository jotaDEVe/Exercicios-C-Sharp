using System;
using System.Globalization;

public class Reserva
{
    //Atributos

    public int room { get; set; }
    public string email { get; set; }
    public string name { get; set; }

    //Construtor

    public Reserva(int room, string email, string name)
    {
        this.room = room;
        this.email = email;
        this.name = name;
    }

   


    public override string ToString()
    {
        return "O quarto " + room + " foi alugado pelo estudante de nome " + name + " e email " + email;
    }
}
