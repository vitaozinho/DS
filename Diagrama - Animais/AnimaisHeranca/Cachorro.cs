using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{   
    class Cachorro : Mamifero
    {

        private String atitude;
        private int hora, min;
        private String dono;

        public getHora(){
            return hora;
        }
        public setHora(int hora){
            this.hora=hora;
        }

        public getMin(){
            return min;
        }
        public setMin(int min){
            this.min=min;
        }


        public override void locomover()
        {
            Console.WriteLine("Cachorro se locomovendo"); ;
        }
        public override void alimentar()
        {
            Console.WriteLine("Cachorro se Alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("Cachorro latindo!");
        }

        public void enterrarOsso()
        {
            Console.WriteLine("Cachorro enterrando o osso!");
        }

        public void abanarRabo()
        {
            Console.WriteLine("Cachorro abanando o rabo!");
        }

        public override string ToString()
        {
            return "\n\tCachorro\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor do pelo: \t" + getCorPelo() + "\nRaça: \t\t" + getRaca();
        }

        public void reagir() {
            if (atitude == "brincar" || atitude == "acariciar"){
                Console.WriteLine("Abana o rabo");
            }
            }


        public void reagir() { 
        if (hora < 12){
            Console.WriteLine("Abana o rabo e late");
            }
        else (hora>=18){
            Console.WriteLine("Não liga para o dono");  
            }
            else {
            Console.WriteLine ("Abana o rabo")
            }

   

        }
    }
}
