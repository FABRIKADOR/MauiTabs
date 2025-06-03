using Act4.Models;

namespace Act4.Services
{
    public class CharacterService
    {
        public static List<Character> GetMainCharacters()
        {
            return new List<Character>
            {
                new Character
                {
                    Name = "Walter White",
                    Description = "Un profesor de química de secundaria que se convierte en fabricante de metanfetaminas tras ser diagnosticado con cáncer de pulmón.",
                    ImageSource = "walter_white.png",
                    Category = "Main"
                },
                new Character
                {
                    Name = "Jesse Pinkman",
                    Description = "Ex alumno de Walter White que se convierte en su socio en el negocio de las drogas.",
                    ImageSource = "jesse_pinkman.jpg",
                    Category = "Main"
                }
            };
        }

        public static List<Character> GetAntagonists()
        {
            return new List<Character>
            {
                new Character
                {
                    Name = "Gus Fring",
                    Description = "Propietario de Los Pollos Hermanos y jefe de una red de distribución de drogas.",
                    ImageSource = "gus_fring.webp",
                    Category = "Antagonist"
                },
                new Character
                {
                    Name = "Hank Schrader",
                    Description = "Agente de la DEA y cuñado de Walter White que investiga el caso Heisenberg.",
                    ImageSource = "hank_schrader.png",
                    Category = "Antagonist"
                }
            };
        }

        public static List<Character> GetSupportingCharacters()
        {
            return new List<Character>
            {
                new Character
                {
                    Name = "Skyler White",
                    Description = "Esposa de Walter White que gradualmente descubre las actividades criminales de su marido.",
                    ImageSource = "skyler_white.webp",
                    Category = "Supporting"
                },
                new Character
                {
                    Name = "Saul Goodman",
                    Description = "Abogado criminalista que ayuda a Walter y Jesse en sus operaciones ilegales.",
                    ImageSource = "saul_goodman.webp",
                    Category = "Supporting"
                }
            };
        }
    }
}