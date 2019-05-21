using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns.Prototype
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream,self);
            stream.Seek(0,SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }
    }
    [Serializable]
    class Person
    {
       public string [] Names;
        public Adress Adress;
        public Person(string[] names, Adress address)
        {
            this.Names = names;
            this.Adress = address;
        }

       public Person (Person other)
       {
           Names =  new string[other.Names.Length];
           other.Names.CopyTo(Names,0);
           Adress = new Adress(other.Adress);
       }
        public override string ToString() 
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Adress)}: {nameof(Adress.streetName)}: {Adress.streetName} {nameof(Adress.houseNumber)}: {Adress.houseNumber}";
        }
    }
    [Serializable]
    public class Adress
    {
        public string streetName;
        public int houseNumber;
        
        public Adress(string streetName, int houseNumber)
        {
            this.streetName = streetName;
            this.houseNumber = houseNumber;
        }
        public Adress (Adress other)
        {
            streetName = other.streetName;
            houseNumber = other.houseNumber;
        }
    }
}