using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace RapMot
{
    public partial class Form1 : Form
    {
        private int Seconds = 15;
        private int Count = 0;
        List<String> Words = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InsertWords();
            Thread Tr = new Thread(SetSeconds);
            Random ran = new Random();
            LblWords.Text = Words[ran.Next(0, Words.Count)];
            Count++;
            Tr.Start();
        }
        private void SetSeconds() {//Si se puede comienzo con el conteo y las palabras
            while (Count == 1) {
                if (Seconds == 0) {//Si los segundos llegaron a cero cambio la palabra
                    Random ran = new Random();
                    LblSeconds.Invoke((Action)delegate
                    {
                        LblWords.Text = Words[ran.Next(0, Words.Count)];
                    });
                    Seconds = 15;
                }else{
                Thread.Sleep(1000);
                Seconds--;
                LblSeconds.Invoke((Action)delegate
                {
                    LblSeconds.Text = Seconds + " s";
                });
               
            }
            }
            Seconds = 15;
            LblSeconds.Invoke((Action)delegate
            {
                LblSeconds.Text = Seconds + " s";
            });
            LblWords.Invoke((Action)delegate
            {
                LblWords.Text = "PALABRAS";
            });
            Count = 0;
        }
        private void InsertWords()//Inserto las palabras
        {
            Words.Add("Error");
            Words.Add("Mito");
            Words.Add("Leyenda");
            Words.Add("Multiplica");
            Words.Add("Aplica");
            Words.Add("Mastica");
            Words.Add("Dinamita");
            Words.Add("Predica");
            Words.Add("Radica");
            Words.Add("Trafica");
            Words.Add("Fabrica");
            Words.Add("Metas");
            Words.Add("Humo");
            Words.Add("Ciego");
            Words.Add("Infierno");
            Words.Add("Cuaderno");
            Words.Add("Eterno");
            Words.Add("Elegancia");
            Words.Add("Abismo");
            Words.Add("Celular");
            Words.Add("Corona");
            Words.Add("Duelo");
            Words.Add("Ansuelo");
            Words.Add("Dispongo");
            Words.Add("Biblia");
            Words.Add("Fénix");
            Words.Add("Renacer");
            Words.Add("Esfenoides");
            Words.Add("Tu tío");
            Words.Add("Nhilismo");
        }
    }
}
