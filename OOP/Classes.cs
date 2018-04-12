namespace OOP
{
    interface Interface1 {
        string I1();

    }


    interface Interface2
    {

        int I1();
        string I2();

    }

    abstract class  AbstractClass {
        public abstract string Abstract();
        public virtual string Concrete() => "Abstract.ConCrete";

    }

    class AClass : AbstractClass, Interface1
    {
        public string I1() => "A.I1";
        public override string Abstract() => "A.Abstract";
        public string Hidden() => "A.Hidden";
        public virtual string Override() => "A.Override";


    }
   sealed  class BClass : AClass, Interface2
    {
        public string I2() => "B.I2";
        public override string Concrete() => "B.Concrete";
        public new string Hidden() => "B.Hidden is not " + base.Hidden();
        public override string Override() => "B.Override";



        



        int Interface2.I1() => 10;
    }


    class CClass : Interface2
    {
        public int I1() =>  11;
        public string I2() => "C.I2";
    }

}
