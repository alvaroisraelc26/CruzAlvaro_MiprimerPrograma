using System;
namespace MisPrimerosPasos1
{
    public class FreeFire
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string correo;
        public string sexo;
        public int diamantes;
        public string nacionalidad;
        public string generoJuego; 
        public string estado;
        public string rango;

        
        public void Datos()
        {
            Console.WriteLine("Bienvenido al Universo BATTLE ROYALE - FreeFire");
            this.Entretenimeinto();
            Console.ReadLine();
            Console.WriteLine("Su nombre es: " + this.nombre + " " + "\n Y su edad es: " + this.edad + " años :3 ");
            Console.ReadLine();
            Console.WriteLine("Información de su cuenta: ");
            Console.ReadLine();
            this.EstadoJugador();
        }
        
        public void Rango()
        {
            Console.Write("¿En qué rango te encuentras en Free Fire ?: ");
            rango= Console.ReadLine();
            var nivel = "Tu Rango es: " + rango;
            Console.WriteLine(nivel);
            Console.WriteLine("Jugador con Rango: " + rango);
            Console.ReadLine();
            
        }

        public void EstadoJugador()
        {
            estado = "En Linea";
            Console.WriteLine(estado);
            Console.ReadLine();
            this.Rango();
        }
        public void Recarga()
        {
            Console.WriteLine("¿Has recargado diamantes en Free Fire?");
            Console.Write("¿Cuantos diamantes recargaste la última vez en FreeFire ?: ");
            diamantes = int.Parse(Console.ReadLine());
            diamantes = diamantes + 0;
            Console.WriteLine("En la actulidad tus diamantes son: " + diamantes + " $ . ");
            Console.ReadLine();
        }    
        
        public void Entretenimeinto()
        {
            generoJuego = "Este juego es Battle Royale y Duelo de Escuadras .";
            Console.WriteLine(generoJuego);

        }
    }

    public class Misiones
    {
        public string misionDiaria;
        public int matarEnemigos;
        public int daño;
        public string recolectarHongos;
        public int consumirBotiquines;// Ep para usar habilidades de personajes
        public string curarEscuadra; 
        public string recolectarTokens; 
        public string revelarEnemigos; 
        public string habilidadesMascota; 
         

        public void MisionDiaria()
        {
            Console.WriteLine("MISIONES DIARIAS");
            Console.Write(" Inglige un daño mayor a 200HP : ");
            Console.WriteLine(" El daño realizado debe ser mayor a 1000HP  " + daño + " de daño ");
            Console.ReadLine();
            Console.WriteLine("*Gracias por completar las misiones diarias*");
            Console.ReadLine();
        }

        public void MisionGrupal()
        {
            Console.Write("¿Que mision has elegido ?: ");
            curaAliados = Console.ReadLine();
            var cura = "La mision eleguida fue : " + curarEscuadra;
            Console.WriteLine(cura);
            Console.WriteLine("Jugador usted eligio: " + curarEscuadra+ "Sus Compañeros le agradecen");
            Console.ReadLine();
            this.Runas();
        }

        public void MisionClan()
        {
            Console.WriteLine("Bienvenido a las misiones del Clan ");
            this.Habilidad();
            Console.ReadLine();
            Console.WriteLine("El nombre de la mision es: " + this.misionDiaria + "\nTienes que comer 4 Hongos: " + this.recolectarHongos + " Nivel 4 " + "\nDebes matar a : " + this.matarEnemigos + " enemigos ");
            Console.ReadLine();
            Console.WriteLine("Las Misiones son: ");
            Console.ReadLine();
            this.MisionIncial();
        }
        public void Tokens()
        {
            recolectarRunas = "Dirigete por todo el mapa recolectando Tokens para reclamar premios";
            Console.WriteLine(recolectarTokens);
            Console.ReadLine();
            this.MisionFinal();
        }

        public void HabilidadMascota()
        {
            espameoHabilidades = "Jugador recuerde que tiene ganar la partida para que las misiones sean cumplidas.";
            Console.WriteLine(habilidadMascota);

        }
    }

    public class Personajes

    {
        public string nombrePersonaje;
        public string generoPersonaje;
        public int habilidadPersonaje; 
        public int partidasPersonaje;
        public int dañoPersonaje;
        public int victoriasPersonaje;
        public int derrotasPersonaje;
        public string habilidadesAdicionales1; 
        public string habilidadesAdicionales2; 
  

        public void TiempoPersonaje()
        {
            Console.WriteLine("Total de Partidas");
            Console.Write("¿Cuantas partidas jugaste con el personaje ?: ");
            partidasPersonaje = int.Parse(Console.ReadLine());
            partidasPersonaje = partidasPersonaje + 0;
            Console.WriteLine("Partidas Jugadas con el personaje son:  " + partidasPersonaje + " partidas");
            Console.ReadLine();
        }

        public void HabilidadPersonaje()
        {
            Console.Write("¿Qué Habilidad tiene tu ersonaje?: ");
            habilidadPersonaje = Console.ReadLine();
            var habilidad = "Tu personaje es de: " + habilidadPersonaje;
            Console.WriteLine(habilidad);
            Console.ReadLine();
            this.Generalidad();
        }

        public void DatosPersonaje()
        {
            Console.WriteLine("Selección de Personajes ");
            Console.ReadLine();
            Console.WriteLine("Su personaje es: " + this.nombrePersonaje + "\nTiene las siguientes hablidades: " + this.habilidadesPersonaje + "\nEl daño del Personajes es: " + this.dañoPersonaje);
            Console.ReadLine();
            Console.WriteLine("Información del personaje: ");
            Console.ReadLine();
            this.HabilidadesAdicionales();
        }
        public void HabilidadesAdicionales()
        {
            Console.WriteLine("Posee el siguiente set: ");
            habilidadesAdicionales1 = "Daño a la cabeza 26%";
            Console.WriteLine(habilidadesAdicionales1);
            Console.ReadLine();
            habilidadesAdicionales2 = "Campode fuerza de 600 HP";
            Console.WriteLine(habilidadesAdicionales2);
            Console.ReadLine();
            this.TiempoPersonaje();
 
        }

        public void Generalidad()
        {
            especialidadPersonaje = "El personaje elegido es un personaje de: " + habilidadesAdicionales1 + " y " + habilidadesAdicionales2;
            Console.WriteLine(habilidadesAdicionales1,habilidadesAdicionales2);
            this.HabilidadesAdicionales();

        }
    }


}