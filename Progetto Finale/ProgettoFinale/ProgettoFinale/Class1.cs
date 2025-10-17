using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProgettoFinale
{
    public class Persona
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }

    public class Studente : Persona
    {
        public string CodiceMatricola { get; set; }


        public string ToString()
        {
            return $"{CodiceMatricola},{Id},{Nome},{Cognome},{Email},{Telefono}";
        }

        public string NomeCompleto => $"{Nome} {Cognome}";
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]//annotazione per Convertire l'enum in string
    public enum Dipartimento
    {
        ECONOMIA, GIURISPRUDENZA, INGEGNERIA_INFORMATICA, INGEGNERIA_ELETRONICA, INGEGNERIA_AEREOSPAZIALE
    }

    public class Docente : Persona
    {
      public Dipartimento materia { get; set; }

        public string NomeCognome => $"{Nome} {Cognome}";


        public string ToString()
        {
            return $"{materia},{Id},{Nome},{Cognome},{Email},{Telefono}";
        }
            
    }

    public class Corso
    {
        public Docente Prof { get; set; }
        public string ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public string ToString()
        {
            return $"{Prof.ToString()},{ID},{Nome},{DataInizio},{DataFine}";
        }

        public string DisplayProf
        {
            get
            {
                return $"{Prof.Nome} {Prof.Cognome}";
            }
        }


    }

    public class Esame
    { 
        public Corso Corso { get; set; }
        public Studente Studente { get; set; }
        public DateTime DataEsame { get; set; }
        public int Voto { get; set; }
    }

}
