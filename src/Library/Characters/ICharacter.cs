using System.Collections;
using System;
using System.Collections.Generic;

namespace RoleplayGame
{

//esta interfaz será el molde para todos los diferentes tipos de caracteres del juego, ya que todos ellos 
//tienen atributos y metodos en común, como tambien una lista de IItems
    public interface ICharacter
    {
        int Health {get;}
        String Name {get; set;}

        int AttackValue{get;}
        int DefenseValue{get;}
        void Cure();        
        public void ReceiveAttack(int power); 




                
    }
}
