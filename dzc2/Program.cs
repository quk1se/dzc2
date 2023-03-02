using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace dzc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'а', 'е', 'ё', 'и', 'у', 'о', 'ы', 'э', 'ю', 'я' };
            char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] special_symbols = { '~', '<', '>', '#', '$', '@', '%', '^', '*', '(', ')', '_', '+', '=', '/', '\\', '|' };
            char[] sentence_symbols = { ',', '.', ':', ';', '!', '?', '-' };

            Write("Input your string: ");
            string str = ReadLine().ToLower();
            string[] words = str.Split(' ');
            
            int vowels_count = 0;
            int consonants_count = 0;
            int numbers_count = 0;
            int special_symbols_count = 0;
            int sentence_symbols_count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j]) vowels_count++;
                }
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (str[i] == numbers[j]) numbers_count++;
                }
                for (int j = 0; j < special_symbols.Length; j++)
                {
                    if (str[i] == special_symbols[j]) special_symbols_count++;
                }
                for (int j = 0; j < sentence_symbols.Length; j++)
                {
                    if (str[i] == sentence_symbols[j])
                    {
                        sentence_symbols_count++;
                    }
                }
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (str[i] == consonants[j]) consonants_count++;
                }

            }

            WriteLine($"Всего слов: {words.Length}\n Символов: {str.Length} \n Гласных: {vowels_count} \n Согласных: {consonants_count} " +
                $"\n Знаков пунктуации: {sentence_symbols_count} \n Цифр: {numbers_count} \n Др.Символов : {special_symbols_count} \n");


            string str2 = "А роза упала на лапу Азора.".ToLower();
            var str_new = str2.Replace(" ", "");
            bool equel = true;
            for (int i = str_new.Length - 2, j = 0; i >= 0; i--, j++)
            {
                if (str_new[i] != str_new[j]) equel = false;
            }
            WriteLine(str2);
            if (equel) { Write("Is equel!"); }
            else { Write("Not equel"); }
            
            Read();
        }
    }
}
