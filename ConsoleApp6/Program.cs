// See https://aka.ms/new-console-template for more information
using ConsoleApp6;
List<Jugador> jugadores = new List<Jugador>();
jugadores.Add( new Jugador { Nombre = "Padilla Quiroz, Irina Lineth" , Puntos=0, Posicion=1});
jugadores.Add(new Jugador { Nombre = "Iporre Romero, Kirna Jhocabed", Puntos = 0, Posicion = 2 });
jugadores.Add(new Jugador { Nombre = "Machaca Quispe, Amelie Marjorie", Puntos = 0, Posicion = 3 });
jugadores.Add(new Jugador { Nombre = "Santana Ortiz, Alina Scarlet", Puntos = 0 , Posicion = 4 });
jugadores.Add(new Jugador { Nombre = "De La Cruz Pinedo, Hyemi Elena", Puntos = 0, Posicion = 5 });
jugadores.Add(new Jugador { Nombre = "Ortiz Salcedo, Nayade", Puntos = 0, Posicion = 6 });
jugadores.Add(new Jugador { Nombre = "Tullume Delgado, Littzie Gaela", Puntos = 0, Posicion = 7 });
jugadores.Add(new Jugador { Nombre = "Zegarra Vergaray, Saskia Lucia", Puntos = 0, Posicion = 8 });
jugadores.Add(new Jugador { Nombre = "Laynes Pachas, Alessia Valeria", Puntos = 0, Posicion = 9 });
jugadores.Add(new Jugador { Nombre = "Aquino Principe, Ghia Geraldine", Puntos = 0, Posicion = 10 });
jugadores.Add(new Jugador { Nombre = "Torrico Gamarra, Reyna Victoria", Puntos = 0, Posicion = 11 });
jugadores.Add(new Jugador { Nombre = "Herrera Cordoba, Cala", Puntos = 0, Posicion = 12 });
jugadores.Add(new Jugador { Nombre = "Callupe Matias, Rebeca Victoria", Puntos = 0, Posicion = 13 });
jugadores.Add(new Jugador { Nombre = "Trivenos Quinte, Mia Belen", Puntos = 0, Posicion = 14 });
jugadores.Add(new Jugador { Nombre = "Arana Bello, Meryl Mikaela", Puntos = 0, Posicion = 15 });
jugadores.Add(new Jugador { Nombre = "Cotrina Lopez, Camila Areli", Puntos = 0, Posicion = 16 });
jugadores.Add(new Jugador { Nombre = "Janampa Javier, Sophie Joliet", Puntos = 0, Posicion = 17 });
jugadores.Add(new Jugador { Nombre = "Jauregui Casas, Lhuanna", Puntos = 0, Posicion = 18 });
jugadores.Add(new Jugador { Nombre = "Rojas Raraz, Jarely Katty", Puntos = 0, Posicion = 19 });
jugadores.Add(new Jugador { Nombre = "Libre", Puntos = 0, Posicion = 20 });



Fixture fixture = new Fixture();
fixture.Partidos= new List<List<Partido>> { new List<Partido>() };

for (int i = 1; i < 10; i++)
{
    List<Partido> fecha = new List<Partido>();
    for (int j = 0; j < 20; j++)
	{
		for (int k = 0; k < 20; k++)
		{

        var partidoExiste = fecha.Where(x =>
        (x.Jugador1.Nombre == jugadores[j].Nombre || x.Jugador2.Nombre == jugadores[j].Nombre)
        ||(x.Jugador1.Nombre == jugadores[k].Nombre || x.Jugador2.Nombre == jugadores[k].Nombre)
        );
        
        if (!partidoExiste.Any() ) 
        {
            if ( jugadores[j].Nombre != jugadores[k].Nombre)
            {
                    if (
                        jugadores[j].Puntos == jugadores[k].Puntos
                        || jugadores[j].Puntos + 1 == jugadores[k].Puntos
                        || jugadores[j].Puntos + 2 == jugadores[k].Puntos
                        || jugadores[j].Puntos + 3 == jugadores[k].Puntos
                        || jugadores[j].Puntos + 4 == jugadores[k].Puntos
                        || jugadores[k].Puntos + 1 == jugadores[j].Puntos
                        || jugadores[k].Puntos + 2 == jugadores[j].Puntos
                        || jugadores[k].Puntos + 3 == jugadores[j].Puntos
                        || jugadores[k].Puntos + 4 == jugadores[j].Puntos

                        )
                    {
                        fecha.Add(new Partido { Jugador1 = jugadores[j], Jugador2 = jugadores[k] });

                        if (jugadores[j].Nombre=="Libre")
                        {
                            jugadores[k].Puntos++;
                            
                            break;

                        }


                        if (jugadores[k].Nombre == "Libre")
                        {
                            jugadores[j].Puntos++;
                            break;

                        }

                        jugadores[j].Puntos++;
                        break;
                        
                        

                    }
                  
            }
          
        }		
    }        
    }
    fixture.Partidos.Add( fecha );

}

int contador = 0;
foreach (var fecha in fixture.Partidos)
{

    if (fecha.Count > 0)
    {
        Console.WriteLine("FECHA " + (contador));
        foreach (var partido in fecha)
        {
            Console.WriteLine(string.Concat(partido.Jugador1.Nombre, " VS ", partido.Jugador2.Nombre));

        }
        Console.WriteLine("======================================");
    }
    contador++;
}

var jugadoresOrdenado= jugadores.OrderByDescending(x=>x.Puntos).ToList();
foreach (var item in jugadoresOrdenado)
{
    Console.WriteLine( item.Nombre + " - "+  item.Puntos);

}

Console.ReadLine();







