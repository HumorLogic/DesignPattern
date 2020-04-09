using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example1
{ 
    class program
    {
        static void Main(string[] args)
        {
            NameRepository nameRepository = new NameRepository();
            for(Iterator iter = nameRepository.CreateIterator(); iter.HasMore();)
            {
                string name = (string)iter.GetNext();
                Console.WriteLine(name);
            }
        }
    }




    public interface Iterator
    {
        object GetNext();
        bool HasMore();
    }

    public interface IterableCollection
    {
        Iterator CreateIterator();
    }

    public class NameRepository : IterableCollection
    {
        public string[] names = { "Humor", "Apple", "Pine","Leon","Jay Chou" };
        public Iterator CreateIterator()
        {
            return new NameIterator(this);
        }
    }


    public class NameIterator : Iterator
    {
        private NameRepository nameRep;
        private int iterationState;

      
        public NameIterator(NameRepository repository)
        {
            iterationState = 0;
            this.nameRep = repository;
        }

        public object GetNext()
        {
            if (this.HasMore())
            {
                return nameRep.names[iterationState++];
            }return null;
        }

        public bool HasMore()
        {
            if (iterationState < nameRep.names.Length)
            {
                return true;
            }
            return false;
        }
    }

}
