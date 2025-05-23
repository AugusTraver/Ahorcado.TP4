public static class Juego
{
    public static Dictionary<int, char[]> ModoDificil { get; private set; }
    public static Dictionary<int, char[]> ModoNormal { get; private set; }
    public static Dictionary<int, char[]> ModoFacil { get; private set; }
    public static char[] PalabraElegida { get; private set; }
    public static List<char> IntentosLetras { get; private set; }
    public static int ContadorIntentos;
    public static char[] Adivinanza { get; private set; }
    public static void InicializarJuego(string Nivel)
    {
        ModoDificil = new Dictionary<int, char[]>();
        ModoFacil = new Dictionary<int, char[]>();
        ModoNormal = new Dictionary<int, char[]>();
        IntentosLetras = new List<char>();
        ContadorIntentos = 0;
        char[] palabra1 = { 'd', 'e', 's', 'a', 'p', 'a', 'r', 'e', 'c', 'i', 'd', 'o' }; // desaparecido  
        char[] palabra2 = { 'a', 'd', 'm', 'i', 'n', 'i', 's', 't', 'r', 'a', 'r', 'e' }; // administrare  
        char[] palabra3 = { 'c', 'o', 'n', 'v', 'i', 'v', 'e', 'n', 'c', 'i', 'a', 's' }; // convivencias  
        char[] palabra4 = { 'e', 's', 't', 'u', 'd', 'i', 'a', 'n', 't', 'i', 'l', 'e' }; // estudiantile  
        char[] palabra5 = { 'f', 'u', 'n', 'c', 'i', 'o', 'n', 'a', 'r', 'i', 'a', 's' }; // funcionarias  
        char[] palabra6 = { 'r', 'e', 's', 'p', 'o', 'n', 's', 'a', 'b', 'l', 'e', 's' }; // responsables  
        char[] palabra7 = { 'i', 'n', 'f', 'o', 'r', 'm', 'a', 't', 'i', 'c', 'o', 's' }; // informaticos  
        char[] palabra8 = { 't', 'r', 'a', 'n', 's', 'p', 'o', 'r', 't', 'a', 'r', 'e' }; // transportare  
        char[] palabra9 = { 'r', 'e', 'c', 'u', 'p', 'e', 'r', 'a', 'b', 'l', 'e', 's' }; // recuperables  
        char[] palabra10 = { 'c', 'o', 'n', 't', 'e', 's', 't', 'a', 'r', 'i', 'a', 's' }; // contestarias  
        ModoDificil.Add(1, palabra1);
        ModoDificil.Add(2, palabra2);
        ModoDificil.Add(3, palabra3);
        ModoDificil.Add(4, palabra4);
        ModoDificil.Add(5, palabra5);
        ModoDificil.Add(6, palabra6);
        ModoDificil.Add(7, palabra7);
        ModoDificil.Add(8, palabra8);
        ModoDificil.Add(9, palabra9);
        ModoDificil.Add(10, palabra10);
        char[] palabra11 = { 'e', 's', 't', 'u', 'd', 'i', 'a', 'n', 't' }; // estudiante  
        char[] palabra12 = { 'f', 'u', 'n', 'c', 'i', 'o', 'n', 'a', 'l' }; // funcional  
        char[] palabra13 = { 'v', 'o', 'l', 'u', 'n', 't', 'a', 'r', 'i' }; // voluntari  
        char[] palabra14 = { 'r', 'e', 's', 'p', 'o', 'n', 'd', 'e', 'r' }; // responder  
        char[] palabra15 = { 't', 'r', 'a', 'b', 'a', 'j', 'a', 'n', 'd' }; // trabajando  
        char[] palabra16 = { 'c', 'o', 'n', 'd', 'u', 'c', 't', 'o', 'r' }; // conductor  
        char[] palabra17 = { 'd', 'e', 'c', 'i', 's', 'i', 'o', 'n', 'e' }; // decisiones  
        char[] palabra18 = { 'e', 'j', 'e', 'r', 'c', 'i', 'c', 'i', 'o' }; // ejercicio  
        char[] palabra19 = { 'l', 'i', 'b', 'r', 'e', 'r', 'i', 'a', 's' }; // librerias  
        char[] palabra20 = { 'p', 'a', 'r', 't', 'i', 'd', 'a', 'r', 's' }; // partidars (forma conjugada informal)
        ModoNormal.Add(1, palabra11);
        ModoNormal.Add(2, palabra12);
        ModoNormal.Add(3, palabra13);
        ModoNormal.Add(4, palabra14);
        ModoNormal.Add(5, palabra15);
        ModoNormal.Add(6, palabra16);
        ModoNormal.Add(7, palabra17);
        ModoNormal.Add(8, palabra18);
        ModoNormal.Add(9, palabra19);
        ModoNormal.Add(10, palabra20);
        char[] palabra21 = { 'c', 'a', 's', 'a', 's' }; // casas  
        char[] palabra22 = { 'p', 'e', 'r', 'r', 'o' }; // perro  
        char[] palabra23 = { 's', 'i', 'l', 'l', 'a' }; // silla  
        char[] palabra24 = { 'm', 'e', 's', 'a', 's' }; // mesas  
        char[] palabra25 = { 'p', 'l', 'a', 'y', 'a' }; // playa  
        char[] palabra26 = { 'n', 'i', 'ñ', 'o', 's' }; // niños 
        char[] palabra27 = { 'l', 'u', 'z', 'e', 's' }; // luces  
        char[] palabra28 = { 'h', 'o', 'r', 'a', 's' }; // horas  
        char[] palabra29 = { 't', 'e', 'n', 'i', 's' }; // tenis  
        char[] palabra30 = { 'g', 'a', 't', 'o', 's' }; // gatos  

        ModoFacil.Add(1, palabra21);
        ModoFacil.Add(2, palabra22);
        ModoFacil.Add(3, palabra23);
        ModoFacil.Add(4, palabra24);
        ModoFacil.Add(5, palabra25);
        ModoFacil.Add(6, palabra26);
        ModoFacil.Add(7, palabra27);
        ModoFacil.Add(8, palabra28);
        ModoFacil.Add(9, palabra29);
        ModoFacil.Add(10, palabra30);
        Random rnd = new Random();

        if (Nivel == "Dificil")
        {
            int numeroAleatorio = rnd.Next(1, ModoDificil.Count);
            PalabraElegida = ModoDificil[numeroAleatorio];
        }
        if (Nivel == "Normal")
        {
            int numeroAleatorio = rnd.Next(1, ModoNormal.Count);
            PalabraElegida = ModoNormal[numeroAleatorio];
        }
        if (Nivel == "Facil")
        {
            int numeroAleatorio = rnd.Next(1, ModoFacil.Count);
            PalabraElegida = ModoFacil[numeroAleatorio];
        }

        Adivinanza = new char[PalabraElegida.Length];
        for (int X = 0; X < Adivinanza.Length; X++)
        {
            Adivinanza[X] = '-';
        }
    }
    public static void CompararLetra(char LetraIngresada)
    {
        ContadorIntentos = ContadorIntentos + 1;
        if (!IntentosLetras.Contains(LetraIngresada))
        {
            IntentosLetras.Add(LetraIngresada);
            for (int i = 0; i < IntentosLetras.Count; i++)
            {
                for (int j = 0; j < Adivinanza.Length; j++)
                {
                    if (IntentosLetras[i] == PalabraElegida[j])
                    {
                        Adivinanza[j] = IntentosLetras[i];
                    }
                }
            }
        }
    }
    public static bool CompararPalabra(string AdPalabra)
    {
        bool Gano = false;
        char[] AdChar = AdPalabra.ToCharArray();
        ContadorIntentos++;
            if (AdChar == PalabraElegida)
            {
                Gano = true;
            }
      
        return Gano;
    }
}