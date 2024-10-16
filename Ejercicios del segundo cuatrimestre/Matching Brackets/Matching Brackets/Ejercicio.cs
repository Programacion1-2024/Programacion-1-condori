namespace Matching_Brackets
{
    /*
    Consigna: 
        Se le ofrece la oportunidad de escribir software para Bracketeer™, un mainframe antiguo pero potente. El software que se ejecuta en él está escrito en un lenguaje propietario. 
        Gran parte de su sintaxis le resulta familiar, pero nota muchos corchetes, llaves y paréntesis. A pesar de que Bracketeer™ es potente, carece de flexibilidad.
        Si el código fuente tiene corchetes, llaves o paréntesis desequilibrados, Bracketeer™ se bloquea y debe reiniciarse.
        Para evitar una situación de este tipo, comienza a escribir código que pueda verificar que los corchetes, llaves y paréntesis estén equilibrados antes de intentar ejecutarlo en Bracketeer™.

        Instrucciones
        Dada una cadena que contiene corchetes [], llaves {}, paréntesis () o cualquier combinación de estos, verifique que todos los pares coincidan y estén anidados correctamente.
        Se deben ignorar todos los demás caracteres. Por ejemplo, "{what is (42)}?" está balanceado y "[text}" no.
 */

    public class Ejercicio
    {
        public static bool IsPaired(string input)
        {
            
            var matchingBrackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            
            var stack = new Stack<char>();
            int i = 0;

            while (i < input.Length)
            {
                char c = input[i];

                
                if (matchingBrackets.ContainsKey(c))
                {
                    stack.Push(c);
                }
               
                else if (matchingBrackets.ContainsValue(c))
                {
                    
                    if (stack.Count == 0 || matchingBrackets[stack.Pop()] != c)
                    {
                        return false;
                    }
                }

                i++;
            }

            
            return stack.Count == 0;
        }
    }
}
