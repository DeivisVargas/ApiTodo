using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Entities
{
    //IEquatable<Entity> para poder comparar duas entidades 
    public abstract class Entity : IEquatable<Entity>
    {

        public Entity()
        {
            //para gerar um novo id 
            Id = Guid.NewGuid();
        }


        //para gerar id de auto complemento/chave unica 
        //private ,ninguem de fora pode setar esse id ,somente a propria classe 
        public Guid Id { get; private set; }



        //overhide IEquatable
        public bool Equals(Entity other)
        {
            return Id == other.Id;
            //throw new NotImplementedException();
        }
    }
}
