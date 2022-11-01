using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using System.IO;
using System.Diagnostics;

namespace SpellCheckLibrary
{
    public class PythonVikashLibrary
    {

        PyModule scope;
        public string Flagg;
        public string sentence = "HelloWorld";
        public PythonVikashLibrary()
        {
        }

        public void Execute()
        {
            try
            {
                Runtime.PythonDLL = @"C:\Program Files\Python310\python310.dll";
                PythonEngine.PythonHome = @"C:\Program Files\Python310";
                PythonEngine.Initialize();
                scope = Py.CreateScope();
                using (Py.GIL())
                {

                    //scope.Exec("from textblob import Word");
                    //scope.Exec("import re");
                    //string script = ("def check_word_spelling(word):\n"+ "    \n"+
                    //                  "word = Word(word)\n" + "    \n" +
                    //                  "result = word.spellcheck()\n"+ "    \n" +
                    //                  "if word == result[0][0]:\n"+ "    \n" +
                    //                    Flag="True"\n"+ "    " +
                    //                  "else:\n"+ "    \n" +
                    //                   "print(False)\n");
                    //scope.Exec(script);
                    //scope.Exec("def check_sentence_spelling(sentence):");
                    //scope.Exec("words = sentence.split()");
                    //scope.Exec("words = [word.lower() for word in words]");
                    //scope.Exec("words = [re.sub(r'[^A-Za-z0-9]+', '', word) for word in words]");
                    //scope.Exec("for word in words:");
                    //scope.Exec("check_word_spelling(word)");
                    //scope.Exec("check_sentence_spelling('check')");
                    //scope.Exec(File.ReadAllText(@"L:\Spell and lang input check CA\SpellCheckLibrary\PythonScript.py"));
                    string script = File.ReadAllText(@"L:\Spell and lang input check CA\SpellCheckLibrary\PythonScript.py");
                    script = "Flagg='ok'";
                    scope.Exec(script);
                    Console.WriteLine(scope.Exec("Flagg"));
                    //dynamic np = scope.Import("textblob");
                    //np.TextBlob("Word");
                    //scope.Exec(""+Flag+"=hello");
                    //scope.Exec("result = word.spellcheck()");
                    //scope.Exec("check_sentence_spelling('Sentence hello world')");
                }
               
            }
            catch (Exception)
            {

            }

        }

    }
}
